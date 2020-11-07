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
    public partial class ThemDiadiem : Form
    {
        private readonly IDiaDiemRepository _diaDiemRepository;
        public int _id = -1;
        public EditState editState { get; set; }

        public ThemDiadiem(IDiaDiemRepository diaDiemRepository)
        {
            _diaDiemRepository = diaDiemRepository;
            InitializeComponent();
        }

        public void setId(int id)
        {
            _id = id;
        }

        private bool check()
        {
            bool error = false;
            if (diadiemname.Text == "")
            {
                errorlabel.Text = ErrorMsg.err_blank;
                errorlabel.Visible = true;
                diadiemname.Focus();
                error = true;
            }
            else
            {
                errorlabel.Visible = false;
            }
            return error;
        }

        private void init()
        {
            switch (editState)
            {
                case EditState.View:
                    {
                        DiaDiem dd = _diaDiemRepository.getById(_id);
                        diadiemname.Text = dd.TenDD;
                        diadiemname.Enabled = false;
                        savebtt.Enabled = false;
                        break;
                    }
                case EditState.Edit:
                    {
                        DiaDiem dd = _diaDiemRepository.getById(_id);
                        diadiemname.Text = dd.TenDD;
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


        private void savebtt_Click(object sender, EventArgs e)
        {
            if (check())
            {
                return;
            }
            if (_id != -1)
            {
                DiaDiem dd = _diaDiemRepository.getById(_id);
                dd.TenDD = diadiemname.Text;
                _diaDiemRepository.Update(dd);
                MessageBox.Show("Sửa thành công địa điểm");
                Program.Form.TabRefresh(ListTab.Diadiem);
            }
            else
            {
                DiaDiem dd = new DiaDiem();
                dd.TenDD = diadiemname.Text;
                _diaDiemRepository.Add(dd);
                MessageBox.Show("Thêm thành công địa điểm");
                Program.Form.TabRefresh(ListTab.Diadiem);
                this.Close();
            }
        }
    }
}
