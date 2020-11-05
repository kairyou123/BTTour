using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TourApp.Entity;
using TourApp.Repository.IRepository;

namespace TourApp
{
    public partial class TKTinhHinhHoatDong : Form
    {
        private readonly ITourRepository _tourRepo;
        public TKTinhHinhHoatDong(
                                    ITourRepository tourRepo
                                )
        {
            _tourRepo = tourRepo;
            InitializeComponent();
        }

        private void TKTinhHinhHoatDong_Load(object sender, EventArgs e)
        {
            Init();
        }
        private void Init()
        {
            var tours = _tourRepo.getAll();
            foreach(Tour tour in tours)
            {
                string sodoan = tour.DoanKhachs.Count.ToString();
                string doanhso = moneyFormat(tour.DoanKhachs.Sum(i => i.Gia.GiaTri + i.CTChitieus.Sum(ct => int.Parse(ct.TienCT))));
                var item = new ListViewItem(new string[] {tour.MaTour,tour.Ten, doanhso, sodoan});
                listView.Items.Add(item);
            }
        }
        private string moneyFormat(int value)
        {
            CultureInfo cultureInfo = CultureInfo.GetCultureInfo("vi-VN");
            return (value.ToString("#,###.##", cultureInfo).Replace(".", ",") + " VNĐ");
        }
    }
}
