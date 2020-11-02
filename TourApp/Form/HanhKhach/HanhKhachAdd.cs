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

        public EditState editState { get; set; }

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


             if (txt_email.Text !="" && !Regex.IsMatch(txt_email.Text, "^\\w+@+[a-z]+\\.+[a-z]+$"))
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
            else if (!Regex.IsMatch(txt_phone.Text, "^[0-9]{9,11}$"))
            {
                txt_phone.ForeColor = Color.Red;
                txt_phone.Focus();
                err_msg4.Text = ErrorMsg.err_phone;
                err_msg4.Visible = true;
                return false;
            }
            else
            {
                err_msg4.Visible = false;
                txt_phone.ForeColor = Color.Black;
            }

            if (txt_cmnd.Text != "" && !Regex.IsMatch(txt_cmnd.Text, "^[0-9]{1,}$"))
            {
                txt_cmnd.ForeColor = Color.Red;
                txt_cmnd.Focus();
                err_msg5.Text = ErrorMsg.err_number;
                err_msg5.Visible = true;
                return false;
            }
            else
            {
                err_msg5.Visible = false;
                txt_cmnd.ForeColor = Color.Black;
            }

            if (txt_diachi.Text == "" )
            {
                txt_diachi.ForeColor = Color.Red;
                txt_diachi.Focus();
                err_msg6.Text = ErrorMsg.err_blank;
                err_msg6.Visible = true;
                return false;
            }
            else
            {
                err_msg6.Visible = false;
                txt_diachi.ForeColor = Color.Black;
            }

            return true;
        }

        private void HanhKhachAdd_Load(object sender, EventArgs e)
        {
            init();
        }

        private void init()
        {

            switch (editState)
            {
                case EditState.View:
                    {
                        HanhKhach hk = _hanhKhach.getById(id);
                        txt_id.Text = hk.MaKhach;
                        txt_email.Text = hk.Email;
                        txt_phone.Text = hk.SDT.ToString();
                        txt_name.Text = hk.Ten;
                        txt_cmnd.Text = hk.CMND;
                        txt_diachi.Text = hk.DiaChi;
                        if (hk.GioiTinh == "Nam")
                        {
                            Radio_GT.Checked = true;
                        }
                        else Radio_GT1.Checked = true;
                        txt_passport.Text = hk.Passport;
                        title.Text = "CHI TIẾT HÀNH KHÁCH";

                        txt_name.ReadOnly = true;
                        txt_email.ReadOnly = true;
                        txt_id.ReadOnly = true;
                        txt_phone.ReadOnly = true;
                        txt_diachi.ReadOnly = true;
                        txt_cmnd.ReadOnly = true;
                        txt_passport.ReadOnly = true;
                        Radio_GT.Enabled = false;
                        Radio_GT1.Enabled = false;
                        btn.Enabled = false;
                        break;
                    }
                case EditState.Create:
                    {
                        break;
                    }
                
                case EditState.Edit:
                    {
                        HanhKhach hk = _hanhKhach.getById(id);
                        txt_id.Text = hk.MaKhach;
                        txt_email.Text = hk.Email;
                        txt_phone.Text = hk.SDT.ToString();
                        txt_name.Text = hk.Ten;
                        txt_cmnd.Text = hk.CMND;
                        txt_diachi.Text = hk.DiaChi;
                        if (hk.GioiTinh == "Nam")
                        {
                            Radio_GT.Checked = true;
                        }
                        else Radio_GT1.Checked = true;
                        txt_passport.Text = hk.Passport;
                        title.Text = "SỬA HÀNH KHÁCH";
                        break;
                    }
            }

            
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
                hk.SDT = txt_phone.Text;
                hk.CMND = txt_cmnd.Text;
                hk.DiaChi = txt_diachi.Text;
                hk.Passport = txt_passport.Text;
                if (Radio_GT.Checked == true)
                {
                    hk.GioiTinh = Radio_GT.Text;
                }
                else hk.GioiTinh = Radio_GT1.Text;
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
                hk.SDT = txt_phone.Text;
                hk.CMND = txt_cmnd.Text;
                hk.DiaChi = txt_diachi.Text;
                hk.Passport = txt_passport.Text;
                if (Radio_GT.Checked == true)
                {
                    hk.GioiTinh = Radio_GT.Text;
                }
                else hk.GioiTinh = Radio_GT1.Text;
                _hanhKhach.Add(hk);

                MessageBox.Show("Đã thêm thành công", "Hành Khách");

                txt_id.Text = "";
                txt_email.Text = "";
                txt_phone.Text = "";
                txt_name.Text = "";
                txt_cmnd.Text = "";
                txt_diachi.Text = "";
                txt_passport.Text = "";
                Radio_GT.Checked = true;
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


        private void txt_Validating(object sender, CancelEventArgs e)
        {
            if (this.ActiveControl.Equals(sender))
                return;

            string name = ((TextBox)sender).Name;
            switch (name)
            {
                case "txt_id":
                    if (txt_id.Text == "")
                    {
                        txt_id.ForeColor = Color.Red;
                        txt_id.Focus();
                        err_msg1.Text = ErrorMsg.err_blank;
                        err_msg1.Visible = true;
                        e.Cancel = true;
                    }
                    else
                    {
                        txt_id.ForeColor = Color.Black;
                        err_msg1.Visible = false;
                    }
                    break;
                case "txt_name":
                    if (txt_name.Text == "")
                    {
                        txt_name.ForeColor = Color.Red;
                        txt_name.Focus();
                        err_msg2.Text = ErrorMsg.err_blank;
                        err_msg2.Visible = true;
                        e.Cancel = true;
                    }
                    else
                    {
                        txt_name.ForeColor = Color.Black;
                        err_msg2.Visible = false;
                    }
                    break;
                case "txt_email":
                    if (txt_email.Text != ""  &&  !Regex.IsMatch(txt_email.Text, "^\\w+@+[a-z]+\\.+[a-z]+$"))
                    {
                        txt_email.ForeColor = Color.Red;
                        txt_email.Focus();
                        err_msg3.Text = ErrorMsg.err_email;
                        err_msg3.Visible = true;
                        e.Cancel = true;
                    }
                    else
                    {
                        err_msg3.Visible = false;
                        txt_email.ForeColor = Color.Black;
                    }
                    break;
                case "txt_phone":
                    if (txt_phone.Text == "")
                    {
                        txt_phone.ForeColor = Color.Red;
                        txt_phone.Focus();
                        err_msg4.Text = ErrorMsg.err_blank;
                        err_msg4.Visible = true;
                        e.Cancel = true;
                    }
                    else if (!Regex.IsMatch(txt_phone.Text, "^[0-9]{9,11}$"))
                    {
                        txt_phone.ForeColor = Color.Red;
                        txt_phone.Focus();
                        err_msg4.Text = ErrorMsg.err_phone ;
                        err_msg4.Visible = true;
                        e.Cancel = true;
                    }
                    else
                    {
                        err_msg4.Visible = false;
                        txt_phone.ForeColor = Color.Black;
                    }
                    break;
                case "txt_cmnd":
                    if (txt_cmnd.Text != "" && !Regex.IsMatch(txt_cmnd.Text, "^[0-9]{1,}$"))
                    {
                        txt_cmnd.ForeColor = Color.Red;
                        txt_cmnd.Focus();
                        err_msg5.Text = ErrorMsg.err_number;
                        err_msg5.Visible = true;
                        e.Cancel = true;
                    }
                    else
                    {
                        err_msg5.Visible = false;
                        txt_cmnd.ForeColor = Color.Black;
                    }
                    break;
                case "txt_diachi":
                    if (txt_diachi.Text == "")
                    {
                        txt_diachi.ForeColor = Color.Red;
                        txt_diachi.Focus();
                        err_msg6.Text = ErrorMsg.err_blank;
                        err_msg6.Visible = true;
                        e.Cancel = true;
                    }
                    else
                    {
                        err_msg6.Visible = false;
                        txt_diachi.ForeColor = Color.Black;
                    }
                    break;
            }

                    
        }

    }
}
