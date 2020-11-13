using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TourApp.Entity;
using TourApp.Repository.IRepository;

namespace TourApp
{
    public partial class DanhSachDoanKhach : Form
    {
        private readonly ITourRepository _tourRepository;
        private Tour tour;
        private int _id;

        public DanhSachDoanKhach(ITourRepository tourRepository)
        {
            _tourRepository = tourRepository;
            InitializeComponent();
        }

        public void getId(int id)
        {
            _id = id;
        }
        
        private void showthongtin()
        {
            tour = _tourRepository.getById(_id);
            foreach (var doan in tour.DoanKhachs)
            {
                if (doan.isDeleted == 0)
                {
                    ListViewItem item = new ListViewItem(new[] { doan.MaDoan, doan.TenDoan, doan.Chitiet });
                    doankhachlist.Items.Add(item);
                }
            }    
        }

        protected override void OnLoad(EventArgs e)
        {
            showthongtin();
        }



    }
}
