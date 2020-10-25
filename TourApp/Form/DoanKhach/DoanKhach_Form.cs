using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TourApp.Entity;
using TourApp.Repository.IRepository;
using TourApp.Const;

namespace TourApp
{
    public partial class DoanKhach_Form : Form
    {
        public int id = 0;
        private ITourRepository _tourRepository;

        public DoanKhach_Form(ITourRepository tourRepository)
        {
            InitializeComponent();
            _tourRepository = tourRepository;
        }

        public Boolean validate()
        {
            if(mad.Text == "")
            {
                mad.ForeColor = Color.Red;
                mad.Focus();
                errormsg0.Text = ErrorMsg.err_blank;
                errormsg0.Visible = true;
                return false;
            }
            else
            {
                errormsg0.Visible = false;
                mad.ForeColor = Color.Black;
            }

            if (tend.Text == "")
            {
                tend.ForeColor = Color.Red;
                tend.Focus();
                errormsg0.Text = ErrorMsg.err_blank;
                errormsg0.Visible = true;
                return false;
            }
            else
            {
                errormsg0.Visible = false;
                tend.ForeColor = Color.Black;
            }

            if (data_hk.Rows.Count <= 1)
            {
                errormsg1.Visible = true;
                return false;
            }
            else
            {
                errormsg1.Visible = false;
            }

            if (data_nv.Rows.Count <= 1)
            {
                errormsg2.Visible = true;
                return false;
            }
            else
            {
                errormsg2.Visible = false;
            }

            if (data_cp.Rows.Count <= 1)
            {
                errormsg3.Visible = true;
                return false;
            }
            else
            {
                errormsg3.Visible = false;
            }

            return true;
        }

        private void init()
        {
            IEnumerable<Tour> Tours = _tourRepository.getAll();

            foreach(Tour tourm in Tours )
            {
                tourd.Items.Add(tourm.Ten);
            }

            tourd.SelectedIndex = 0;
            
        }
        

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(!validate())
            {
                return;
            }


        }

        private void DoanKhach_Form_Load(object sender, EventArgs e)
        {
            init();
        }
    }
}
