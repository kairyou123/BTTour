using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TourApp
{
    public partial class FormTest : Form
    {
        private readonly ThongTinTour _thongTinTour;
        public FormTest(ThongTinTour thongTinTour)
        {
            _thongTinTour = thongTinTour;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
       
            _thongTinTour.getId(1);
            _thongTinTour.Show();
            this.Hide();
        }
    }
}
