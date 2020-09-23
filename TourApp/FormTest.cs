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
        private readonly ThemTour _themTour;
        public FormTest(ThongTinTour thongTinTour,ThemTour themTour)
        {
            _thongTinTour = thongTinTour;
            _themTour = themTour;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _themTour.Show();
            this.Hide();
        }
    }
}
