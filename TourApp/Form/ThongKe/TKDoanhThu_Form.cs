using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TourApp.Entity;
using TourApp.Repository.IRepository;

namespace TourApp
{
    public partial class TKDoanhThu_Form : Form
    {
        private readonly ITourRepository _tourRepo;
        private readonly IDoanKhachRepository _doanRepo;

        public TKDoanhThu_Form(ITourRepository tourRepo, IDoanKhachRepository doanRepo)
        {
            InitializeComponent();
            _tourRepo = tourRepo;
            _doanRepo = doanRepo;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void init()
        {
            select_radio();
            datestart.Value = DateTime.Now.Date;
            dateend.Value = DateTime.Now.Date;

            //Xóa nền xám khi bị disable của listview
            Bitmap bm = new Bitmap(lv_doanhthu1.ClientSize.Width, lv_doanhthu1.ClientSize.Height);
            Graphics.FromImage(bm).Clear(lv_doanhthu1.BackColor);
            lv_doanhthu1.BackgroundImage = bm;
        }

        // Select các dữ liệu của tour
        private void tour_fill()
        {
            lv.Items.Clear();
            IEnumerable<Tour> tours =   _tourRepo.getAll();
            foreach(Tour tour in tours)
            {
                ListViewItem item = new ListViewItem(tour.MaTour);
                item.SubItems.Add(tour.Ten);
                item.SubItems.Add(tour.LHDL.Ten);
                lv.Items.Add(item);
            }
        }

        // Select các dữ liệu của doan
        private void doan_fill()
        {
            lv.Items.Clear();
            IEnumerable<DoanKhach> doans = _doanRepo.getAll();
            foreach (DoanKhach doan in doans)
            {
                ListViewItem item = new ListViewItem(doan.MaDoan);
                item.SubItems.Add(doan.TenDoan);
                lv.Items.Add(item);
            }
        }

        //Chọn radio thay đổi dữ liệu
        private void select_radio()
        {
            select_init_lv();

            if (radio_tour.Checked == true)
            {
                tour_fill();
            }
            else
            {
                doan_fill();
            }
        }

        //Tạo các tên cột cho listview
        private void select_init_lv()
        {
            lv.Columns.Clear();
            if (radio_tour.Checked == true)
            {
                lv.Columns.Add("ma", "Mã Tour").Width = 70;
                lv.Columns.Add("ten", "Tên Tour").Width = 100; 
                lv.Columns.Add("loaihinh", "Loại").Width = 100; 
            }
            else
            {
                lv.Columns.Add("ma", "Mã Đoàn").Width = 130; 
                lv.Columns.Add("ten", "Tên Đoàn").Width = 130; 
            }
        }

        //Khi click vào các item sẽ hiển thị ra list các loại doanh thu và tổng doanh thu
        private void ReadData()
        {
            if (lv.SelectedItems.Count == 0)
                return;

            var id = lv.SelectedItems[0].Text;
            var dateStart = datestart.Value.Date;
            var dateEnd = dateend.Value.Date;
            var total = 0;
            lv_doanhthu1.Items.Clear();
            
            if (radio_tour.Checked == true)
            {
                var tour = _tourRepo.getById(0, id);

                //DoanKhach filter
                var doans = tour.DoanKhachs.Where(d => d.DateCreated.Date >= dateStart && d.DateCreated.Date <= dateEnd).ToList();
                CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");

                //In du lieu chi phi cua Doan
                if (doans != null && doans.Count > 0)
                {
                    var count = 0;
                    foreach (var doan in doans)
                    { 
                        var group1 = new ListViewGroup("doan" + count);
                        count++;
                        group1.Header = doan.TenDoan + " (" + doan.DateStart.Date + " - " + doan.DateEnd.Date + ")";
                        lv_doanhthu1.Groups.Add(group1);
                        ListViewItem item1 = new ListViewItem { Text = "Giá Tour (" + doan.Gia.TGBD.Date + " - " + doan.Gia.TGKT.Date + ")" , Group = group1 };
                        var giaFormat1 = doan.Gia.GiaTri.ToString("#,###.##",cul).Replace(".", ",");
                        total = total + doan.Gia.GiaTri;
                        item1.SubItems.Add(giaFormat1 + " đ");
                        lv_doanhthu1.Items.Add(item1);
                        foreach (var chitieu in doan.CTChitieus)
                        {
                            ListViewItem item = new ListViewItem { Text = chitieu.ChiTieu.Ten, Group = group1};
                            int chiphi = int.Parse(chitieu.TienCT);
                            total = total + chiphi;
                            var giaFormat = chiphi.ToString("#,###.##", cul).Replace(".", ",");
                            item.SubItems.Add(giaFormat + " đ");
                            lv_doanhthu1.Items.Add(item);
                        }
                        
                    }

                }

                //In tong tien
                ListViewGroup g1 = new ListViewGroup("tong");
                g1.Header = "Tổng doanh thu";
                lv_doanhthu1.Groups.Add(g1);
                ListViewItem totalItem = new ListViewItem { Text = "Tổng Tiền" , Group = g1 };
                var giaFormat2 = total.ToString("#,###.##", cul).Replace(".", ",");
                totalItem.SubItems.Add(giaFormat2 + " đ");
                lv_doanhthu1.Items.Add(totalItem);

            }
        }

        private void TKDoanhThu_Form_Load(object sender, EventArgs e)
        {
            init();
        }

        private void radio_CheckedChanged(object sender, EventArgs e)
        {
            select_radio();
        }


        private void lv_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReadData();
        }


    }
}
