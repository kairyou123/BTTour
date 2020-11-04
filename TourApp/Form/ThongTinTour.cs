using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TourApp.Entity;
using TourApp.Repository.IRepository;

namespace TourApp
{
    public partial class ThongTinTour : Form
    {
        private readonly ITourRepository _tourRepository;
        private readonly IServiceProvider _serviceProvider;
        private Tour Tour;
        private int _id;
        public ThongTinTour(ITourRepository tourRepository,IServiceProvider serviceProvider)
        {
            _tourRepository = tourRepository;
            _serviceProvider = serviceProvider;
            InitializeComponent();
            
        }

        public void getId(int id)
        {
            _id = id;
        }

        /*Hiển thị thông tin khi vào form thông tin tour*/
        private void showThongtin()
        {
            Tour =  _tourRepository.getById(_id, "");

            /*Thong tin Tour*/
            mtour_txt.Text = Tour.MaTour;
            tentour_txt.Text = Tour.Ten;
            loaihinhtour_txt.Text = Tour.LHDL.Ten;

            /*Dia Diem Tour*/
            foreach(var DD in Tour.CTTours)
            {
                ListViewItem diaDiem = new ListViewItem(new[] { DD.DiaDiem.DDId.ToString(), DD.DiaDiem.TenDD });
                listDD.Items.Add(diaDiem);
          
            }

            /*Gia Tour*/

            var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");

            foreach (var Gia in Tour.Gias)
            {
                var giaTien = String.Format(info, "{0:n}", Gia.GiaTri.ToString());
                ListViewItem gia = new ListViewItem(new[] { giaTien, Gia.TGBD.ToString("dd/MM/yyyy HH:mm:ss"), Gia.TGKT.ToString("dd/MM/yyyy HH:mm:ss") });
                listGia.Items.Insert(0, gia);
            }
            listGia.Items[0].ForeColor = Color.DarkGreen;


        }

        private void ThongTinTour_Load(object sender, EventArgs e)
        {
             showThongtin();
        }

        private void listGia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dsdoankhach_Click(object sender, EventArgs e)
        {
            if (Tour.DoanKhachs == null)
                MessageBox.Show("Không có đoàn khách nào");
            else
            {
                DanhSachDoanKhach form = _serviceProvider.GetRequiredService<DanhSachDoanKhach>();
                form.getId(_id);
                var main = this.Location;
                form.Location = new Point((main.X + 10), (main.Y + 10));
                form.Show();
            }
        }
    }
}
