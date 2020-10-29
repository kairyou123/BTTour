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
    public partial class ThemGia : Form
    {
        private readonly ITourRepository _tourRepository;
        private Tour Tour;
        private int _id;


        public ThemGia(ITourRepository tourRepository)
        {
            _tourRepository = tourRepository;
            InitializeComponent();
        }

        private bool check()
        {
            if (mucgia.Value <= 0)
                return false;
            if (tungay.Value > denngay.Value)
                return false;
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!check())
            {
                MessageBox.Show("Thông tin thiếu hoặc không hợp lệ !");
            }
            else
            {
                Tour = _tourRepository.getById(_id, "");
                Gia newgia = new Gia();
                newgia.GiaTri = (int)mucgia.Value;
                newgia.TGBD = tungay.Value;
                newgia.TGKT = denngay.Value;
                Tour.Gias.Add(newgia);
                MessageBox.Show("Thêm thành công!");
                this.Close();
            }
        }

        public void getId(int id)
        {
            _id = id;
        }
    }
}
