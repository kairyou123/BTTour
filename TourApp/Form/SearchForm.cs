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
using System.CodeDom;
using DocumentFormat.OpenXml.Office2010.PowerPoint;
using DocumentFormat.OpenXml.Wordprocessing;
using System.Text.RegularExpressions;

namespace TourApp
{
    public partial class SearchForm : Form
    {
        private string txt_search;
        private string Form_Search;
        private readonly IHanhKhachRepository _hkRepo;
        private readonly IChiTieuRepository _ctRepo;
        public List<HanhKhach> listHKRT;
        public List<String> listCTRT;
        public SearchForm(IHanhKhachRepository hkRepo, IChiTieuRepository ctRepo)
        {
            InitializeComponent();
            _hkRepo = hkRepo;
            _ctRepo = ctRepo;
        }

        public void setForm(string FSearch)
        {
            Form_Search = FSearch;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void init()
        {
            lv_radio.Location = new Point(12, 16);
            lv_radio.Size = new Size(300,260);
            var id = lv_radio.Columns.Add("ID");
            id.Text = "ID";
            var maso = lv_radio.Columns.Add("Maso");
            maso.Text = "Mã Số";
            maso.Width = 70;
            var ten = lv_radio.Columns.Add("Ten");
            ten.Text = "Tên";
            ten.Width = 110;

            switch (Form_Search)
            {
                case FormName.NVFORMNAME:
                    title.Text = "CHỌN NHÂN VIÊN";
                    lv_radio.Visible = true;
                    lv_search.Visible = false;
                    break;
                case FormName.HKFORMNAME:
                    title.Text = "CHỌN HÀNH KHÁCH";
                    lv_search.Visible = true;
                    lv_radio.Visible = false;
                    break;
                case FormName.CTFORMNAME:
                    title.Text = "CHỌN CHI TIÊU";
                    lv_radio.Visible = true;
                    lbl.Text = "Giá";
                    lbl.Visible = true;
                    txt_option.Visible = true;
                    lv_search.Visible = false;
                    lv_radio.Columns.RemoveAt(1);
                    break;
            }
        }

        private bool validate()
        {

            if(Form_Search == FormName.CTFORMNAME)
            {
                if (Regex.IsMatch(txt_option.Text, "^[0-9]{1,}$") == false)
                {
                    errorlbl.Text = "Xin nhập số và không để trống";
                    errorlbl.Visible = true;
                    return false;
                }
                else errorlbl.Visible = false;
            }

            return true;
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            init();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            lv_search.Items.Clear();
            txt_search = text_search.Text;

            switch(Form_Search)
            {
                case "NhanVien_Form":
                    break;
                case "HanhKhach_Form":
                    IEnumerable<HanhKhach> list1 = _hkRepo.getWhere(txt_search);
                    foreach(HanhKhach hk in list1)
                    {
                        ListViewItem newList = new ListViewItem(new[] { hk.KhachId.ToString(), hk.MaKhach,hk.Ten });
                        lv_search.Items.Add(newList);
                    }
                    break;
                case "ChiTieu_Form":
                    
                    IEnumerable<ChiTieu> list2 = _ctRepo.getWhere(txt_search);
                    foreach (ChiTieu ct in list2)
                    {
                        ListViewItem newList = new ListViewItem(new[] { ct.CTId.ToString(), ct.Ten });
                        lv_radio.Items.Add(newList);
                    }
                    break;
            }
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            if(!validate())
            {
                return;
            }

            switch (Form_Search)
            {
                case "NhanVien_Form":
                    break;
                case "HanhKhach_Form":
                    listHKRT = listHK();
                    break;
                case "ChiTieu_Form":
                    listCTRT = listCT();
                    break;
            }
            Close();
        }

        private List<HanhKhach> listHK()
        {
            List<HanhKhach> listRT = new List<HanhKhach>();
            for (int i = 0; i < lv_search.Items.Count; i++)
            {
              if (lv_search.Items[i].Checked == true)
              {
                  HanhKhach hk = _hkRepo.getById(int.Parse(lv_search.Items[i].Text));
                  listRT.Add(hk);
              }
            }

            return listRT;
        }

        private List<String> listCT()
        {
            List<String> listRT = new List<String>();
            var count = 0;
            for (int i = 0; i < lv_radio.Items.Count; i++)
            {
                if (lv_radio.Items[i].Checked == true)
                {
                    count++;
                    ChiTieu ct = _ctRepo.getById(int.Parse(lv_radio.Items[i].Text));
                    listRT.Add(ct.Ten);
                    listRT.Add(txt_option.Text);
                }
            }

            if (count <= 0)
            {
                listRT.Clear();
            }

            return listRT;
        }


        private void lv_radio_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            var listView = sender as ListView;
            if(listView != null && e.NewValue == CheckState.Checked)
            { 
                foreach (ListViewItem checkedItem in listView.CheckedItems)
                {
                    checkedItem.Checked = false;
                }
            }
        }

    }
}
