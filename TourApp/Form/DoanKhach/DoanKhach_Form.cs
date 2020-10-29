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
using Microsoft.Extensions.DependencyInjection;

namespace TourApp
{
    public partial class DoanKhach_Form : Form
    {
        public int id = 0;
        private ITourRepository _tourRepository;
        private IServiceProvider _service;

        public DoanKhach_Form(ITourRepository tourRepository, IServiceProvider service)
        {
            InitializeComponent();
            _tourRepository = tourRepository;
            _service = service;
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

        private void select(string btn_click)
        {
            var name = btn_click;
            SearchForm s_form;
            switch (name)
            {
                case "hk_btn":
                    s_form = _service.GetRequiredService<SearchForm>();
                    s_form.setForm(FormName.HKFORMNAME);
                    s_form.ShowDialog();
                    var hkList = s_form.listHKRT;
                    data_hk.Rows.Clear();
                    if(hkList != null )
                    {
                        foreach (var hk in hkList)
                        {
                            data_hk.Rows.Add(hk.MaKhach, hk.Ten, hk.SDT);
                        }
                    }
                    break;
                case "nv_btn":
                    break;
                case "ct_btn":
                    s_form = _service.GetRequiredService<SearchForm>();
                    s_form.setForm(FormName.CTFORMNAME);
                    s_form.ShowDialog();
                    var ctList = s_form.listCTRT;
                    var flg = false;
                    if (ctList != null && ctList.Count>0)
                    {
                        foreach (DataGridViewRow row in data_cp.Rows)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                if(cell.GetType() == typeof(DataGridViewButtonCell))
                                {
                                    continue;
                                }

                                string value = cell.Value.ToString();
                                if (value == ctList[0])
                                {
                                    flg = true;
                                    break;
                                }
                            }
                            if (flg) break;
                        }
                        if(!flg)
                        {
                            data_cp.Rows.Add(ctList[0], ctList[1]);
                        }
                        
                    }
                    break;
            }
                
        }

        private void cp_btn_Click(object sender, EventArgs e)
        {
            select("ct_btn");
        }

        private void hk_btn_Click(object sender, EventArgs e)
        {
            select("hk_btn");
        }

        private void data_hk_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == data_hk.Columns["DeleteHK"].Index && e.RowIndex >= 0)
            {
                data_hk.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void data_cp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == data_cp.Columns["DeleteCP"].Index && e.RowIndex >= 0)
            {
                data_cp.Rows.RemoveAt(e.RowIndex);
            }
        }


    }
}
