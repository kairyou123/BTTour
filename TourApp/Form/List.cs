using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TourApp.Repository.IRepository;

namespace TourApp
{
    public partial class List : Form
    {
        private readonly ITourRepository _tourRepo;
        public List(
                        ITourRepository tourRepo
                    )
        {
            _tourRepo = tourRepo;
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Tour_Click(object sender, EventArgs e)
        {

        }
    }
}
