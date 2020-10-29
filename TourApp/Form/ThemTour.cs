using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TourApp.Const;
using TourApp.Entity;
using TourApp.Repository.IRepository;

namespace TourApp
{
    public partial class ThemTour : Form
    {
        private readonly ITourRepository _tourRepository;
        private readonly IDiaDiemRepository _diadiemRepository;
        private readonly ICTTourRepository _cTTourRepository;
        private readonly IGiaRepository _giaRepository;

        public ThemTour(ITourRepository tourRepository,IDiaDiemRepository diaDiemRepository,ICTTourRepository cTTourRepository,IGiaRepository giaRepository)
        {
            _tourRepository = tourRepository;
            _diadiemRepository = diaDiemRepository;
            _cTTourRepository = cTTourRepository;
            _giaRepository = giaRepository;
            InitializeComponent();
        }

        private void showThongtin()
        {
            IEnumerable<DiaDiem> listdd =  _diadiemRepository.getAll();

            /*Dia Diem Tour*/
            foreach (var DD in listdd)
            {
                ListViewItem diaDiem = new ListViewItem(new[] { DD.DDId.ToString(), DD.TenDD });
                diadiem.Items.Add(diaDiem);
            }
            /* Loại hình */
            LoaiHinhDL item1 = new LoaiHinhDL();
            item1.LHDLId = 1;
            item1.Ten = "Loại 1";
            loaihinhcbb.Items.Add(item1);
            loaihinhcbb.DisplayMember = "Ten";
            loaihinhcbb.ValueMember = "LHDLId";
            loaihinhcbb.SelectedItem = item1;
            
        }

        private bool check()
        {
            if (matourtb.Text == null)
                return false;
            if (tentourtb.Text == null)
                return false;
            if (diadiem.CheckedItems == null)
                return false;
            if (mucgia.Value <= 0)
                return false;
            if (tungay.Value > denngay.Value)
                return false;
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!check())
            {
                MessageBox.Show("Thông tin thiếu hoặc không hợp lệ !");
            }
            else
            {
                Tour newtour = new Tour();
                newtour.CTTours = new List<CTTour>();
                newtour.Gias = new List<Gia>();
                Gia newgia = new Gia();
                newtour.MaTour = matourtb.Text;
                newtour.Ten = tentourtb.Text;

                LoaiHinhDL item = new LoaiHinhDL();
                item = (LoaiHinhDL)loaihinhcbb.SelectedItem;
                newtour.LHDL = item;

                foreach (ListViewItem dd in diadiem.CheckedItems)
                {
                    CTTour newcttour = new CTTour();
                    newcttour.DDId = Convert.ToInt32(dd.SubItems[0].Text);
                    newcttour.TourId = newtour.TourId;
                    //_cTTourRepository.Add(newcttour);
                    newtour.CTTours.Add(newcttour);
                }
                newgia.GiaTri = (int)mucgia.Value;
                newgia.TGBD = tungay.Value;
                newgia.TGKT = denngay.Value;
                newgia.TourId = newtour.TourId;
                newtour.Gias.Add(newgia);
                _tourRepository.Add(newtour);
                // _giaRepository.Add(newgia);
                MessageBox.Show("Thêm thành công!");
                Program.Form.TabRefresh(ListTab.Tour);
            }
        }

        protected override  void OnLoad(EventArgs e)
        {
             showThongtin();
        }

    }
}
