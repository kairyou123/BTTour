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
        private DateTime preDate;

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
            lv_doanhthu1.Items.Clear();
            if (radio_tour.Checked == true)
            {
                tour_fill();
                search_panel.Visible = true;
            }
            else
            {
                doan_fill();
                search_panel.Visible = false;
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

        //validate
        private Boolean validate()
        {
            var dateStart = datestart.Value.Date;
            var dateEnd = dateend.Value.Date;
            var flg = true;

            if (dateEnd < dateStart)
            {
                flg = false;
            }

            if(!flg)
            {
                MessageBox.Show("Ngày tìm kiếm không hợp lệ", "Thông báo");
            }
            return flg;
        }

        //Khi click vào các item sẽ hiển thị ra list các loại doanh thu và tổng doanh thu
        private void ReadData()
        {
            lv_doanhthu1.Items.Clear();

            if (lv.SelectedItems.Count == 0)
                return;

            var id = lv.SelectedItems[0].Text;
            var dateStart = datestart.Value.Date;
            var dateEnd = dateend.Value.Date;
            var total = 0;
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
            
            if (radio_tour.Checked == true)
            {
                var tour = _tourRepo.getById(0, id);

                //DoanKhach filter
                var doans = tour.DoanKhachs.Where(d => d.DateCreated.Date >= dateStart && d.DateCreated.Date <= dateEnd).ToList();
                //In du lieu chi phi cua Doan

                int income = 0;
                if (doans != null && doans.Count > 0)
                {
                    var count = 0;
                    foreach (var doan in doans)
                    {
                        var total_doan = 0;
                        var hanhkhach_count = (doan.CTDoans != null && doan.CTDoans.Count() > 0) ? doan.CTDoans.Count : 0 ;
                        var group1 = new ListViewGroup("doan" + count);
                        count++;
                        group1.Header = doan.TenDoan + " (" + doan.DateStart.Date.ToString("yyyy/MM/dd") + " - " + doan.DateEnd.Date.ToString("yyyy/MM/dd") + ") (" + hanhkhach_count + " hành khách )";
                        lv_doanhthu1.Groups.Add(group1);
                        ListViewItem item1 = new ListViewItem { Text = "Giá Tour (" + doan.Gia.TGBD.Date.ToString("yyyy/MM/dd") + " - " + doan.Gia.TGKT.Date.ToString("yyyy/MM/dd") + ")", Group = group1 };
                        var giaFormat1 = doan.Gia.GiaTri.ToString("#,###.##",cul).Replace(".", ",");
                        total_doan = total_doan + doan.Gia.GiaTri;
                        item1.SubItems.Add(giaFormat1 + " đ");
                        lv_doanhthu1.Items.Add(item1);
                        int income_item = 0;
                        int chiphi_item = 0;
                        foreach (var chitieu in doan.CTChitieus)
                        {
                           
                            int chiphi = int.Parse(chitieu.TienCT);
                            chiphi_item +=  chiphi;
                            
                        }
                        chiphi_item *= hanhkhach_count;
                         
                        
                        //Tổng tiền của đoàn * số lượng hành khách
                        total_doan = total_doan * hanhkhach_count;
                        total = total + total_doan;
                        ListViewItem item_doan = new ListViewItem { Text = "Tổng tiền thu được của đoàn", Group = group1 };
                        var giaFormat2 = total_doan.ToString("#,###.##", cul).Replace(".", ",");
                        item_doan.SubItems.Add(giaFormat2 + " đ");
                        lv_doanhthu1.Items.Add(item_doan);
                        // lợi nhuận 1 đoàn
                        income_item = total_doan - chiphi_item;
                        ListViewItem item = new ListViewItem { Text = "Lợi nhuận", Group = group1 };
                        var giaFormat = income_item.ToString("#,###.##", cul).Replace(".", ",");
                        item.SubItems.Add(giaFormat + " đ");
                        lv_doanhthu1.Items.Add(item);
                        income += income_item;
                    }

                }

                //In tong tien
                ListViewGroup g1 = new ListViewGroup("tong");
                g1.Header = "Tổng doanh thu - Lợi nhuận";
                lv_doanhthu1.Groups.Add(g1);
                ListViewItem totalItem = new ListViewItem { Text = "Tổng Tiền" , Group = g1 };
                var giaTotalFormat = total.ToString("#,###.##", cul).Replace(".", ",");
                totalItem.SubItems.Add(giaTotalFormat + " đ");
                lv_doanhthu1.Items.Add(totalItem);

                ListViewItem totalIncome = new ListViewItem { Text = "Tổng lợi nhuận", Group = g1 };
                var incomeFormat = income.ToString("#,###.##", cul).Replace(".", ",");
                totalIncome.SubItems.Add(incomeFormat + " đ");
                lv_doanhthu1.Items.Add(totalIncome);

            }
            else
            {
                var doan = _doanRepo.getById(0, id);
                var group1 = new ListViewGroup("doan");
                group1.Header = doan.TenDoan + " (" + doan.DateStart.Date.ToString("yyyy/MM/dd") + " - " + doan.DateEnd.Date.ToString("yyyy/MM/dd") + ") (" + doan.CTDoans.Count() + " hành khách )";
                lv_doanhthu1.Groups.Add(group1);
                ListViewItem item1 = new ListViewItem { Text = "Giá Tour (" + doan.Gia.TGBD.Date.ToString("yyyy/MM/dd") + " - " + doan.Gia.TGKT.Date.ToString("yyyy/MM/dd") + ")", Group = group1 };
                var giaFormat1 = doan.Gia.GiaTri.ToString("#,###.##", cul).Replace(".", ",");
                total = total + doan.Gia.GiaTri;
                item1.SubItems.Add(giaFormat1 + " đ");
                lv_doanhthu1.Items.Add(item1);
                //foreach (CTChitieu chitieu in doan.CTChitieus)
                //{
                //    ListViewItem item = new ListViewItem { Text = chitieu.ChiTieu.Ten, Group = group1 };
                //    int chiphi = int.Parse(chitieu.TienCT);
                //    total = total + chiphi;
                //    var giaFormat = chiphi.ToString("#,###.##", cul).Replace(".", ",");
                //    item.SubItems.Add(giaFormat + " đ");
                //    lv_doanhthu1.Items.Add(item);
                //}

                //Tổng tiền của đoàn * số lượng hành khách
                total = total * doan.CTDoans.Count();
                ListViewItem item_doan = new ListViewItem { Text = "Tổng tiền thu được của đoàn", Group = group1 };
                var giaFormat2 = total.ToString("#,###.##", cul).Replace(".", ",");
                item_doan.SubItems.Add(giaFormat2 + " đ");
                lv_doanhthu1.Items.Add(item_doan);
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

        private void date_ValueChanged(object sender, EventArgs e)
        {
            var oldValue = preDate;
            preDate = ((DateTimePicker)sender).Value;
            lv.SelectedItems.Clear();
            if(!validate())
            {
                ((DateTimePicker)sender).Value = oldValue;
            }
        }
    }
}
