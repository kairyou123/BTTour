using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TourApp.Const;
using TourApp.Entity;
using TourApp.Repository.IRepository;

namespace TourApp
{
    public partial class SuaTour : Form
    {
        private readonly ITourRepository _tourRepository;
        private readonly IDiaDiemRepository _diadiemRepository;
        private readonly IServiceProvider _serviceProvider;
        private Tour Tour;
        private int _id;

        public SuaTour(ITourRepository tourRepository, IDiaDiemRepository diaDiemRepository, IServiceProvider serviceProvider)
        {
            _tourRepository = tourRepository;
            _diadiemRepository = diaDiemRepository;
            _serviceProvider = serviceProvider;
            InitializeComponent();
        }

        public void getId(int id)
        {
            _id = id;
        }

        private void showThongtin()
        {
            IEnumerable<DiaDiem> listdd = _diadiemRepository.getAll();

            /*Dia Diem Tour*/
            foreach (var DD in listdd)
            {
                ListViewItem diaDiem = new ListViewItem(new[] { DD.DDId.ToString(), DD.TenDD });
                diadiemlist.Items.Add(diaDiem);
            }
            /* Loại hình */
            LoaiHinhDL item1 = new LoaiHinhDL();
            item1.LHDLId = 1;
            item1.Ten = "Loại 1";
            loaicbb.Items.Add(item1);
            loaicbb.DisplayMember = "Ten";
            loaicbb.ValueMember = "LHDLId";

            Tour = _tourRepository.getById(_id, "");

            /*Thong tin Tour*/
            matourtb.Text = Tour.MaTour;
            tentourtb.Text = Tour.Ten;
            foreach (LoaiHinhDL loai in loaicbb.Items)
            {
                if (loai.LHDLId == Tour.LHDL.LHDLId)
                {
                    loaicbb.SelectedItem = loai;
                }
            } 

            /*Dia Diem Tour*/
            foreach (var DD in Tour.CTTours)
            {
                ListViewItem diaDiem = new ListViewItem(new[] { DD.DiaDiem.DDId.ToString(), DD.DiaDiem.TenDD });
                foreach (ListViewItem dd in diadiemlist.Items)
                {
                    if (dd.Text == diaDiem.Text)
                    {
                        dd.Checked = true;
                    }
                }
            }

            /*Gia Tour*/

            var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");

            foreach (var Gia in Tour.Gias)
            {
                var giaTien = String.Format(info, "{0:n}", Gia.GiaTri.ToString());
                ListViewItem gia = new ListViewItem(new[] { giaTien, Gia.TGBD.ToString("dd/MM/yyyy HH:mm:ss"), Gia.TGKT.ToString("dd/MM/yyyy HH:mm:ss") });
                gialist.Items.Add(gia);
            }
            
        }

        public void RefreshGia()
        {
            gialist.Items.Clear();
            Tour = _tourRepository.getById(_id, "");
            var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");

            foreach (var Gia in Tour.Gias)
            {
                var giaTien = String.Format(info, "{0:n}", Gia.GiaTri.ToString());
                ListViewItem gia = new ListViewItem(new[] { giaTien, Gia.TGBD.ToString("dd/MM/yyyy HH:mm:ss"), Gia.TGKT.ToString("dd/MM/yyyy HH:mm:ss") });
                gialist.Items.Add(gia);
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            showThongtin();
        }

        

        private bool check()
        {
            if (matourtb.Text == null)
                return false;
            if (tentourtb.Text == null)
                return false;
            if (diadiemlist.CheckedItems == null)
                return false;
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!check())
            {
                MessageBox.Show("Thông tin thiếu hoặc không hợp lệ !");
            }
            else
            {
                Tour = _tourRepository.getById(_id, "");
                Tour.MaTour = matourtb.Text;
                Tour.Ten = tentourtb.Text;
                LoaiHinhDL item = new LoaiHinhDL();
                item = (LoaiHinhDL)loaicbb.SelectedItem;
                Tour.LHDLId = item.LHDLId;
                Tour.CTTours.Clear();
                foreach (ListViewItem dd in diadiemlist.CheckedItems)
                {
                    CTTour newcttour = new CTTour();
                    newcttour.DDId = Convert.ToInt32(dd.SubItems[0].Text);
                    newcttour.TourId = Tour.TourId;
                    //_cTTourRepository.Add(newcttour);
                    Tour.CTTours.Add(newcttour);
                }
                _tourRepository.Update(Tour);
                MessageBox.Show("Cập nhật thành công!");
                Program.Form.TabRefresh(ListTab.Tour);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThemGia form = _serviceProvider.GetRequiredService<ThemGia>();
            form.getId(_id);
            var main = this.Location;
            form.Location = new Point((main.X + 10), (main.Y + 10));
            form.ShowDialog();  
            this.RefreshGia();
        }
    }
}
