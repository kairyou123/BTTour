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
        private IServiceProvider _service;
        public FormTest(IServiceProvider services)
        {
            _service = services;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HanhKhach_Form HK = _service.GetRequiredService<HanhKhach_Form>();
            HK.Show();

        }
    }
}
