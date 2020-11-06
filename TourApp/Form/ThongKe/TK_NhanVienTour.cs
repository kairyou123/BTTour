using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TourApp.Entity;
using TourApp.Repository;
using TourApp.Repository.IRepository;

namespace TourApp
{
    public partial class TK_NhanVienTour : Form
    {
        private readonly INhanVienRepository _nvRepo;
        public TK_NhanVienTour(INhanVienRepository nvRepo)
        {
            InitializeComponent();
            _nvRepo = nvRepo;
        }

        public void init()
        {
            //Xóa nền xám khi bị disable của listview
            Bitmap bm = new Bitmap(lv.ClientSize.Width, lv.ClientSize.Height);
            Graphics.FromImage(bm).Clear(lv.BackColor);
            lv.BackgroundImage = bm;

            readData();
        }
        
        //Lấy dữ liệu từ NhanVien và Đếm số lần đi tour của Nhân Viên
        public void readData(string ID="", string MaNv="", string Ten="", string SDT="", int isDeleted=0)
        {
            lv.Items.Clear();
            IEnumerable<NhanVien> nvs = _nvRepo.getWhere(ID,MaNv,Ten,SDT,isDeleted);
            var dateStart = dateStartPicker.Value.Date;
            var dateEnd = dateEndPicker.Value.Date;

            foreach (NhanVien nv in nvs)
            {
                ListViewItem item = new ListViewItem(nv.MaNV);
                item.SubItems.Add(nv.Ten);
                //Đếm số lần đi tour
                int count = nv.NV_VTs.Where(nv => (nv.DoanKhach.DateEnd.Date >= dateStart && nv.DoanKhach.DateEnd.Date <= dateEnd)).Count();
                item.SubItems.Add(count.ToString()) ;
                lv.Items.Add(item);
            }
        }

        public void search()
        {
            var TenNV = txt_search.Text.ToLower();
            readData("","",TenNV);
        }

        private Boolean validate()
        {
            var dateStart = dateStartPicker.Value.Date;
            var dateEnd = dateEndPicker.Value.Date;
            var flg = true;

            if (dateEnd < dateStart)
            {
                flg = false;
            }

            if (!flg)
            {
                MessageBox.Show("Ngày tìm kiếm không hợp lệ", "Thông báo");
            }
            return flg;
        }

        private void TK_NhanVienTour_Load(object sender, EventArgs e)
        {
            init();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (!validate()) return;

            search();
        }
    }
}
