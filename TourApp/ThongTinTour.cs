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
        private Tour Tour;
        private int _id;
        public ThongTinTour(ITourRepository tourRepository)
        {
            _tourRepository = tourRepository;
            InitializeComponent();
            
        }

        public void getId(int id)
        {
            _id = id;
        }

        /*Hiển thị thông tin khi vào form thông tin tour*/
        private async Task showThongtin()
        {
            Tour = await _tourRepository.getById(_id, "");

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
                listGia.Items.Add(gia);
            }


        }

        private async void ThongTinTour_Load(object sender, EventArgs e)
        {
            await showThongtin();
        }

    }
}
