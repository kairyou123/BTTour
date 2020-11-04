using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TourApp.Const;
using TourApp.Entity;
using TourApp.Repository.IRepository;

namespace TourApp
{
    public partial class ThemChiTieu : Form
    {
        private readonly IChiTieuRepository _chiTieuRepository;
        public int _id = -1;
        public EditState editState {get; set;}

        public ThemChiTieu(IChiTieuRepository chiTieuRepository)
        {
            _chiTieuRepository = chiTieuRepository;
            InitializeComponent();
        }

        public void setId(int id)
        {
            _id = id;
        }

        private bool check()
        {
            bool error = false;
            if (CTname.Text == "")
            {
                CTnameer.Text = ErrorMsg.err_blank;
                CTnameer.Visible = true;
                CTname.Focus();
                error = true;
            }
            else
            {
                CTnameer.Visible = false;
            }
            return error;
        }

        private void Submitbt_Click(object sender, EventArgs e)
        {
            
        }

        private void init ()
        {
            switch(editState)
            {
                case EditState.View:
                    {
                        ChiTieu ct = _chiTieuRepository.getById(_id);
                        CTname.Text = ct.Ten;
                        CTname.Enabled = false;
                        Submitbt.Enabled = false;
                        break;
                    }
                case EditState.Edit:
                    {
                        ChiTieu ct = _chiTieuRepository.getById(_id);
                        CTname.Text = ct.Ten;          
                        break;
                    }
                case EditState.Create:
                    {
                        break;
                    }
            }    
                
        }

        protected override void OnLoad(EventArgs e)
        {
            init();
        }

        private void Submitbt_Click_1(object sender, EventArgs e)
        {
            if (check())
            {
                return;
            }
            if (_id != -1)
            {
                ChiTieu ct = _chiTieuRepository.getById(_id);
                ct.Ten = CTname.Text;
                _chiTieuRepository.Update(ct);
                MessageBox.Show("Sửa thành công Chi tiêu");
                Program.Form.TabRefresh(ListTab.Chitieu);
            }
            else
            {
                ChiTieu ct = new ChiTieu();
                ct.Ten = CTname.Text;
                _chiTieuRepository.Add(ct);
                MessageBox.Show("Thêm thành công Chi tiêu");
                Program.Form.TabRefresh(ListTab.Chitieu);
                this.Close();
            }
        }
    }
}
