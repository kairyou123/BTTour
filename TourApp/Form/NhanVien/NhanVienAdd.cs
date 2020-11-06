
using System;
using System.ComponentModel;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using TourApp.Const;
using TourApp.Entity;
using TourApp.Repository.IRepository;

namespace TourApp
{
    public partial class NhanVienAdd : Form
    {
        public int id = 0;
        public INhanVienRepository _nhanvien;

        public NhanVienAdd(INhanVienRepository nhanvien)
        {
            InitializeComponent();
            _nhanvien = nhanvien;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public EditState editState { get; set; }

        //TO FILL:validate
        private Boolean validate()
        {
            //Nhap ID
            if (txt_id.Text == "")
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

            //Ten
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


            //SDT
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

            return true;
        }


        private void NhanVienAdd_Load(object sender, EventArgs e)
        {
            init();
        }

        //TO FILL:init

        private void init()
        {

            switch (editState)
            {
                case EditState.View:
                    {
                        NhanVien nv = _nhanvien.getById(id);
                        txt_id.Text = nv.MaNV;
                        txt_phone.Text = nv.SDT.ToString();
                        txt_name.Text = nv.Ten;
                        title.Text = "CHI TIẾT NHÂN VIÊN";

                        txt_name.ReadOnly = true;
                        txt_id.ReadOnly = true;
                        txt_phone.ReadOnly = true;
                        btn.Enabled = false;
                        break;
                    }
                case EditState.Create:
                    {
                        break;
                    }

                case EditState.Edit:
                    {
                        NhanVien nv = _nhanvien.getById(id);
                        txt_id.Text = nv.MaNV;
                        txt_phone.Text = nv.SDT.ToString();
                        txt_name.Text = nv.Ten;
                        title.Text = "SỬA NHÂN VIÊN";
                        break;
                    }
            }


        }

        //TO FILL:button click

        private void btn_Click(object sender, EventArgs e)
        {
            if (!validate())
            {
                return;
            }

            if (id != 0)
            {
                NhanVien nv = _nhanvien.getById(id);
                nv.MaNV = txt_id.Text;
                nv.Ten = txt_name.Text;
                nv.SDT = txt_phone.Text;
                _nhanvien.Update(nv);

                MessageBox.Show("Sửa thành công nhân viên có ID: " + nv.NVId, "Nhân viên");

                txt_id.Focus();
            }
            else
            {
                NhanVien nv = new NhanVien();
                nv.MaNV = txt_id.Text;
                nv.Ten = txt_name.Text;
                nv.SDT = txt_phone.Text;
                _nhanvien.Add(nv);

                MessageBox.Show("Đã thêm thành công", "Nhân Viên");

                txt_id.Text = "";
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

        //text validating
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
                        err_msg4.Text = ErrorMsg.err_phone;
                        err_msg4.Visible = true;
                        e.Cancel = true;
                    }
                    else
                    {
                        err_msg4.Visible = false;
                        txt_phone.ForeColor = Color.Black;
                    }
                    break;
            }


        }

    }
}
