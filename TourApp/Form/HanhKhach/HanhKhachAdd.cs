using SQLitePCL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using TourApp.Const;
using TourApp.Entity;
using TourApp.Repository.IRepository;

namespace TourApp
{
    public partial class HanhKhach_Form:Form
    {

        public int id = 0;
        public IHanhKhachRepository _hanhKhach;

        public HanhKhach_Form(IHanhKhachRepository hanhKhach)
        {
            InitializeComponent();
            _hanhKhach = hanhKhach;
        }

        public void setId(int id)
        {
            this.id = id;
        }

       private Boolean validate()
        {
            if(txt_id.Text == "")
            {
                txt_id.ForeColor = Color.Red;
                txt_id.Focus();
                err_msg1.Text = ErrorMsg.err_blank;
                err_msg1.Visible = true;
                return false;
            }
            else
            {
                txt_id.ForeColor = Color.Black;
                err_msg1.Visible = false;
            }


            if (txt_name.Text == "")
            {
                txt_name.ForeColor = Color.Red;
                txt_name.Focus();
                err_msg2.Text = ErrorMsg.err_blank;
                err_msg2.Visible = true;
                return false;
            }
            else
            {
                txt_name.ForeColor = Color.Black;
                err_msg2.Visible = false;
            }


            if (txt_email.Text == "")
            {
                txt_email.ForeColor = Color.Red;
                txt_email.Focus();
                err_msg3.Text = ErrorMsg.err_blank;
                err_msg3.Visible = true;
                return false;
            }
            else if (!Regex.IsMatch(txt_email.Text, "^\\w+@+[a-z]+.+[a-z]+$"))
            {
                txt_email.ForeColor = Color.Red;
                txt_email.Focus();
                err_msg3.Text = ErrorMsg.err_email;
                err_msg3.Visible = true;
                return false;
            }
            else
            {
                err_msg3.Visible = false;
                txt_email.ForeColor = Color.Black;
            }

            if (txt_phone.Text == "")
            {
                txt_phone.ForeColor = Color.Red;
                txt_phone.Focus();
                err_msg4.Text = ErrorMsg.err_blank;
                err_msg4.Visible = true;
                return false;
            }
            else if (!Regex.IsMatch(txt_phone.Text, "^[0-9]+$"))
            {
                txt_phone.ForeColor = Color.Red;
                txt_phone.Focus();
                err_msg4.Text = ErrorMsg.err_onlyNumber;
                err_msg4.Visible = true;
                return false;
            }
            else
            {
                err_msg4.Visible = false;
                txt_phone.ForeColor = Color.Black;
            }

            return true;
        }

        private void HanhKhachAdd_Load(object sender, EventArgs e)
        {
            init();
        }

        private void init()
        {

            if(this.id == 0)
            {
                return;
            }

            HanhKhach hk = _hanhKhach.getById(id);
            txt_id.Text = hk.MaKhach;
            txt_email.Text = hk.Email;
            txt_phone.Text = hk.SDT.ToString();
            txt_name.Text = hk.Ten;
            title.Text = "SỬA HÀNH KHÁCH";
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if(!validate())
            {
                return;
            }

            if(id != 0)
            {
                HanhKhach hk = _hanhKhach.getById(id);
                hk.MaKhach = txt_id.Text;
                hk.Ten = txt_name.Text;
                hk.Email = txt_email.Text;
                hk.SDT = int.Parse(txt_phone.Text);
                _hanhKhach.Update(hk);

                MessageBox.Show("Sửa thành công Hành Khách có ID: " + hk.KhachId, "Hành Khách");

                txt_id.Focus();
            }
            else
            {
                HanhKhach hk = new HanhKhach();
                hk.MaKhach = txt_id.Text;
                hk.Ten = txt_name.Text;
                hk.Email = txt_email.Text;
                hk.SDT = int.Parse(txt_phone.Text);
                _hanhKhach.Add(hk);

                MessageBox.Show("Đã thêm thành công", "Hành Khách");

                txt_id.Text = "";
                txt_email.Text = "";
                txt_phone.Text = "";
                txt_name.Text = "";
                txt_id.Focus();
            }



        }


        private void Control_KeyUp(object sender, PreviewKeyDownEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void Lost_Focus(object sender, EventArgs e)
        {
            if (validate())
            {
                return;
            }
        }
    }
}
