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
using System.Runtime.Serialization.Formatters;
using System.Linq;

namespace TourApp
{
    public partial class DoanKhach_Form : Form
    {
        public int id = 0;
        private readonly ITourRepository _tourRepository;
        private readonly IDoanKhachRepository _doanRepo;
        private readonly IServiceProvider _service;
        private readonly INhanVienRepository _nvRepo;
        private readonly IHanhKhachRepository _hkRepo;
        private readonly IChiTieuRepository _ctRepo;
        public EditState formType;

        public DoanKhach_Form(ITourRepository tourRepository, IServiceProvider service, IDoanKhachRepository doanRepo,
                                                     INhanVienRepository nvRepo, IHanhKhachRepository hkRepo, IChiTieuRepository ctRepo)
        {
            InitializeComponent();
            _tourRepository = tourRepository;
            _service = service;
            _doanRepo = doanRepo;
            _nvRepo = nvRepo;
            _hkRepo = hkRepo;
            _ctRepo = ctRepo;
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

            if (DateTime.Compare(datestart.Value, dateend.Value) > 0)
            {
                errormsg0.Text = ErrorMsg.err_minMaxDate;
                errormsg0.Visible = true;
                return false;
            }
            else
            {
                errormsg0.Visible = false;
            }

            if (data_hk.Rows.Count <1)
            {
                errormsg1.Visible = true;
                return false;
            }
            else
            {
                errormsg1.Visible = false;
            }

            if (data_nv.Rows.Count < 1)
            {
                errormsg2.Visible = true;
                return false;
            }
            else
            {
                errormsg2.Visible = false;
            }

            if (data_cp.Rows.Count < 1)
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
            if (formType != EditState.View)
            {
                IEnumerable<Tour> Tours = _tourRepository.getAll();
                foreach (Tour tourm in Tours)
                {
                    tourd.Items.Add(tourm.Ten);
                }
            }
            datestart.Value = DateTime.Now.Date;
            dateend.Value = DateTime.Now.Date;

            switch (formType)
           {
                case EditState.Create:
                    tourd.SelectedIndex = 0;
                    break;
                case EditState.Edit:
                    //Init Data to DoanForm
                    DoanKhach dk_init = _doanRepo.getById(id);
                    mad.Text = dk_init.MaDoan;
                    tend.Text = dk_init.TenDoan;
                    tourd.SelectedItem = dk_init.Tour.Ten;
                    statusd.Text = dk_init.Chitiet;
                    datestart.Value =  dk_init.DateStart;
                    dateend.Value = dk_init.DateEnd;

                    if (dk_init.DateStart <= DateTime.Now.Date)
                    {
                        mad.ReadOnly = true;
                        tend.ReadOnly = true;
                        statusd.ReadOnly = true;
                        datestart.Enabled = false;
                        dateend.Enabled = false;
                        Save.Enabled = false;
                        cp_btn.Enabled = false;
                        nv_btn.Enabled = false;
                        hk_btn.Enabled = false;
                        tourd.Enabled = false;
                    }

                    //HanhKhach
                    foreach (var hk in dk_init.CTDoans)
                    {
                        data_hk.Rows.Add(hk.HanhKhach.MaKhach, hk.HanhKhach.Ten, hk.HanhKhach.SDT);
                    }
                    //NhanVien
                    foreach (var nv in dk_init.NV_VTs)
                    {
                        data_nv.Rows.Add(nv.NhanVien.MaNV, nv.NhanVien.Ten,nv.ViTri);
                    }
                    //ChiTieu
                    foreach (var ct in dk_init.CTChitieus)
                    {
                        data_cp.Rows.Add(ct.ChiTieu.Ten, ct.TienCT);
                    }
                    break;
                case EditState.View:
                    DoanKhach dk_init1 = _doanRepo.getById(id);
                    mad.Text = dk_init1.MaDoan;
                    tend.Text = dk_init1.TenDoan;
                    tourd.Items.Add(dk_init1.Tour.Ten);
                    tourd.SelectedIndex = 0;
                    statusd.Text = dk_init1.Chitiet;
                    datestart.Value = dk_init1.DateStart;
                    dateend.Value = dk_init1.DateEnd;

                    //HanhKhach
                    foreach (var hk in dk_init1.CTDoans)
                    {
                        data_hk.Rows.Add(hk.HanhKhach.MaKhach, hk.HanhKhach.Ten, hk.HanhKhach.SDT);
                    }
                    //NhanVien
                    foreach (var nv in dk_init1.NV_VTs)
                    {
                        data_nv.Rows.Add(nv.NhanVien.MaNV, nv.NhanVien.Ten, nv.ViTri);
                    }
                    //ChiTieu
                    foreach (var ct in dk_init1.CTChitieus)
                    {
                        data_cp.Rows.Add(ct.ChiTieu.Ten, ct.TienCT);
                    }
                    mad.ReadOnly = true;
                    tend.ReadOnly = true;
                    statusd.ReadOnly = true;
                    datestart.Enabled = false;
                    dateend.Enabled = false;
                    Save.Enabled = false;
                    break;
            }

        }

        
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (formType == EditState.View)
            {
                return;
            }

            if (!validate())
            {
                return;
            }

            save();
            MessageBox.Show("Lưu thành công", "Thông báo");

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
                    s_form = _service.GetRequiredService<SearchForm>();
                    s_form.setForm(FormName.NVFORMNAME);
                    s_form.ShowDialog();
                    var nvList = s_form.listNVRT;
                    var flg1 = false;
                    if ( nvList != null &&  nvList.Count>0 )
                    {
                        foreach (DataGridViewRow row in data_nv.Rows)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                if (cell.GetType() == typeof(DataGridViewButtonCell))
                                {
                                    continue;
                                }

                                string value = cell.Value.ToString();
                                if (value == nvList[0])
                                {
                                    flg1 = true;
                                    break;
                                }
                                if (flg1) break;
                            }
                        }
                        if (!flg1)
                        {
                            data_nv.Rows.Add(nvList[0], nvList[1], nvList[2]);
                        }
                    }
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
                                if (flg) break;
                            }
                        }
                        if (!flg)
                        {
                            data_cp.Rows.Add(ctList[0], ctList[1]);
                        }

                    }
                    break;
            }
                
        }

        private void cp_btn_Click(object sender, EventArgs e)
        {
            if(formType == EditState.View)
            {
                return;
            }
            select("ct_btn");
        }

        private void hk_btn_Click(object sender, EventArgs e)
        {
            if (formType == EditState.View)
            {
                return;
            }
            select("hk_btn");
        }
        private void nv_btn_Click(object sender, EventArgs e)
        {
            if (formType == EditState.View)
            {
                return;
            }
            select("nv_btn");
        }

        private void save()
        {
            //init Create Type
            DoanKhach doan = new DoanKhach();
            Tour tour1 = _tourRepository.getByName(tourd.SelectedItem.ToString());

            //init Edit Type
            if (formType == EditState.Edit)
            {
                doan = _doanRepo.getById(id);
                if(tour1.TourId != doan.TourId)
                {
                    doan.Gia = tour1.Gias.LastOrDefault();
                }
            }


            
            //Add value to each of column doan
            
            doan.MaDoan = mad.Text;
            doan.TenDoan = tend.Text;
            doan.Tour = tour1;
            doan.Chitiet = statusd.Text;
            doan.DateStart = datestart.Value.Date;
            doan.DateEnd = dateend.Value.Date;

            //NhanVien
            List<NV_VT> doan_nvs = new List<NV_VT>();
            foreach (DataGridViewRow row in data_nv.Rows)
            {
                NV_VT doan_nv = new NV_VT();
               NhanVien nhanvien = _nvRepo.getById(0,row.Cells[0].Value.ToString());
                doan_nv.NhanVien = nhanvien;
                doan_nv.DoanKhach = doan;
                doan_nv.ViTri = row.Cells[2].Value.ToString();
                doan_nvs.Add(doan_nv);
            }
            doan.NV_VTs = doan_nvs;

            //HanhKhach
            List<CTDoan> cTDoans = new List<CTDoan>();
            foreach (DataGridViewRow row in data_hk.Rows)
            {
                CTDoan cTDoan = new CTDoan();
                HanhKhach hk = _hkRepo.getById(0, row.Cells[0].Value.ToString());
                cTDoan.HanhKhach = hk;
                cTDoan.DoanKhach = doan;
                cTDoans.Add(cTDoan);
            }
            doan.CTDoans = cTDoans;

            //ChiTieu
            List<CTChitieu> cTChiTieus = new List<CTChitieu>();
            foreach (DataGridViewRow row in data_cp.Rows)
            {
                CTChitieu cTChiTieu = new CTChitieu();
                ChiTieu ct = _ctRepo.getByName(row.Cells[0].Value.ToString());
                cTChiTieu.ChiTieu = ct;
                cTChiTieu.TienCT = row.Cells[1].Value.ToString();
                cTChiTieu.DoanKhach = doan;
                cTChiTieus.Add(cTChiTieu);

            }
            doan.CTChitieus = cTChiTieus;
            if (formType == EditState.Edit)
            {
                _doanRepo.Update(doan);

            }
            else
            {
                doan.Gia = doan.Tour.Gias.LastOrDefault();
                doan.DateCreated = DateTime.Now;
                _doanRepo.Add(doan);
            }
            
        }

        private void data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (formType == EditState.View)
            {
                return;
            }
            DataGridView datagrid = (DataGridView)sender;
            if(datagrid.Name == "data_hk" && e.ColumnIndex == data_hk.Columns["DeleteHK"].Index && e.RowIndex >= 0)
            {
                data_hk.Rows.RemoveAt(e.RowIndex);
                return;
            }

            if (datagrid.Name == "data_cp" && e.ColumnIndex == data_cp.Columns["DeleteCP"].Index && e.RowIndex >= 0)
            {
                data_cp.Rows.RemoveAt(e.RowIndex);
                return;
            }

            if (datagrid.Name == "data_nv" && e.ColumnIndex == data_nv.Columns["DeleteNV"].Index && e.RowIndex >= 0)
            {
                data_nv.Rows.RemoveAt(e.RowIndex);
                return;
            }
        }


    }
}
