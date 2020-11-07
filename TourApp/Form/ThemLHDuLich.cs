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
    public partial class ThemLHDuLich : Form
    {
        private readonly ILoaiHinhDuLichRepository _loaiHinhDuLichRepository;
        public int _id = -1;
        public EditState editState { get; set; }

        public ThemLHDuLich(ILoaiHinhDuLichRepository loaiHinhDuLichRepository)
        {
            _loaiHinhDuLichRepository = loaiHinhDuLichRepository;
            InitializeComponent();
        }

        public void setId(int id)
        {
            _id = id;
        }

        private bool check()
        {
            bool error = false;
            if (LHname.Text == "")
            {
                errorlabel.Text = ErrorMsg.err_blank;
                errorlabel.Visible = true;
                LHname.Focus();
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
                        LoaiHinhDL lh = _loaiHinhDuLichRepository.getById(_id);
                        LHname.Text = lh.Ten;
                        Mota.Text = lh.moTa;
                        LHname.Enabled = false;
                        Mota.Enabled = false;
                        Savebtt.Enabled = false;
                        break;
                    }
                case EditState.Edit:
                    {
                        LoaiHinhDL lh = _loaiHinhDuLichRepository.getById(_id);
                        LHname.Text = lh.Ten;
                        Mota.Text = lh.moTa;
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (check())
            {
                return;
            }
            if (_id != -1)
            {
                LoaiHinhDL lh = _loaiHinhDuLichRepository.getById(_id);
                lh.Ten = LHname.Text;
                lh.moTa = Mota.Text;
                _loaiHinhDuLichRepository.Update(lh);
                MessageBox.Show("Sửa thành công Loại hình du lịch");
                Program.Form.TabRefresh(ListTab.LoaiHinhDuLich);
            }
            else
            {
                LoaiHinhDL lh = new LoaiHinhDL();
                lh.Ten = LHname.Text;
                lh.moTa = Mota.Text;
                _loaiHinhDuLichRepository.Add(lh);
                MessageBox.Show("Thêm thành công Loại hình du lịch");
                Program.Form.TabRefresh(ListTab.LoaiHinhDuLich);
                this.Close();
            }
        }
    }
}
