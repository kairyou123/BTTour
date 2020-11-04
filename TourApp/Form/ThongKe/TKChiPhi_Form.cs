using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TourApp.Entity;
using TourApp.Repository.IRepository;

namespace TourApp
{
    public partial class TKChiPhi_Form : Form
    {
        private enum pageOption
        {
            Tour,
            Chitieu
        }
        private pageOption current;
        private readonly ITourRepository _tourRepo;
        private readonly IChiTieuRepository _chitieuRepo;

        private CultureInfo cultureInfo = CultureInfo.GetCultureInfo("vi-VN");
        public TKChiPhi_Form(ITourRepository tourRepo,
                             IChiTieuRepository chitieuRepo
                            )
        {
            _tourRepo = tourRepo;
            _chitieuRepo = chitieuRepo;
            InitializeComponent();

        }
        private void TKChiPhi_Form_Load(object sender, EventArgs e)
        {
            Init();
        }
        private void Init()
        {
            tourRadioBtn.Tag = pageOption.Tour;
            ChitieuRadioBtn.Tag = pageOption.Chitieu;
            fromDate.Value = fromDate.MinDate;
            toDate.Value = toDate.MaxDate;
            ChangePageOption(pageOption.Tour);
        }
        private void ChangePageOption(pageOption option)
        {
            current = option;
            switch (option)
            {
                case pageOption.Tour:
                    {
                        SelectLabel.Text = "Chọn Tour";
                        var list = _tourRepo.getAll();
                        selectCbb.DataSource = list;
                        selectCbb.DisplayMember = "Ten";
                        selectCbb.ValueMember = "TourId";
                        break;
                    }
                case pageOption.Chitieu:
                    {
                        SelectLabel.Text = "Chọn loại chi tiêu";
                        var list = _chitieuRepo.getAll();
                        selectCbb.DataSource = list;
                        selectCbb.DisplayMember = "Ten";
                        selectCbb.ValueMember = "CTId";
                        break;
                    }
            }
        }

        private void selectCbb_Format(object sender, ListControlConvertEventArgs e)
        {

            switch (current)
            {
                case pageOption.Tour:
                    {
                        var item = (Tour)e.ListItem;
                        e.Value = item.MaTour + " - " + item.Ten;
                        break;

                    }
                case pageOption.Chitieu:
                    {
                        var item = (ChiTieu)e.ListItem;
                        e.Value = item.Ten;
                        break;
                    }
            }
        }
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            var radioBtn = groupRadio.Controls.OfType<RadioButton>().FirstOrDefault(i => i.Checked);
            ChangePageOption((pageOption)radioBtn.Tag);
        }
        private void clearListView(ListView lv)
        {
            while (lv.Items.Count > 0)
                lv.Items.RemoveAt(0);
        }
        private string moneyFormat(int value)
        {
            return  (value.ToString("#,###.##", cultureInfo).Replace(".", ",")+" VNĐ");
        }
        private string dateTimeFormat(DateTime date)
        {
            return date.Date.ToString("dd/MM/yyyy");
        }
        private void thongkeBtn_Click(object sender, EventArgs e)
        {
            if (selectCbb.SelectedValue == null) return;
            clearListView(listView);
            
            switch (current)
            {
                case pageOption.Tour:
                    ThongKeTour();
                    break;
                    
                case pageOption.Chitieu:
                    ThongKeChiTieu();
                    break;
                    
            }
        }
        private void ThongKeTour()
        {
            var tour = _tourRepo.getById((int)selectCbb.SelectedValue);
            var doans = tour.DoanKhachs.Where(i => DateTime.Compare(i.DateCreated, fromDate.Value) >= 0
                                    && DateTime.Compare(i.DateCreated, toDate.Value) <= 0);
            int total = 0;
            foreach (DoanKhach doan in doans)
            {
                ListViewGroup group = new ListViewGroup();
                group.Header = doan.MaDoan + " - " + doan.TenDoan
              + " (" + dateTimeFormat(doan.DateStart) + " - " + dateTimeFormat(doan.DateEnd) + ")";
                listView.Groups.Add(group);
                //giá tour
                ListViewItem item = new ListViewItem
                {
                    Text = "Giá tour",
                    Group = group,
                    ForeColor = Color.DarkGreen
                };
                item.SubItems.Add(moneyFormat(doan.Gia.GiaTri));
                int itemTotal = doan.Gia.GiaTri;
                listView.Items.Add(item);

                foreach (CTChitieu ctchitieu in doan.CTChitieus)
                {
                    item = new ListViewItem
                    {
                        Text = ctchitieu.ChiTieu.Ten,
                        Group = group
                    };
                    var tienCT = int.Parse(ctchitieu.TienCT);
                    item.SubItems.Add(moneyFormat(tienCT));
                    listView.Items.Add(item);
                    itemTotal += tienCT;
                }

                item = new ListViewItem
                {
                    Text = "Tổng cộng",
                    Group = group,
                    Font = new Font(listView.Font, FontStyle.Bold)
                };
                item.Position = new Point(item.Position.X, item.Position.Y + 5);
                item.SubItems.Add(moneyFormat(itemTotal));
                listView.Items.Add(item);
                total += itemTotal;

            }
            ListViewGroup groupTotal = new ListViewGroup();
            groupTotal.Header = "";
            listView.Groups.Insert(0, groupTotal);
            var totalFinal = new ListViewItem
            {
                Text = "Tổng cộng",
                Group = groupTotal,
                Font = new Font(listView.Font, FontStyle.Bold)
            };
            totalFinal.SubItems.Add(moneyFormat(total));
            listView.Items.Add(totalFinal);
        }
        private void ThongKeChiTieu()
        {
            var chitieu = _chitieuRepo.getById((int)selectCbb.SelectedValue);
            var ctchitieus = chitieu.CTChitieus.Where(i => DateTime.Compare(i.DoanKhach.DateCreated, fromDate.Value) >= 0
                                    && DateTime.Compare(i.DoanKhach.DateCreated, toDate.Value) <= 0);
            ListViewGroup group = new ListViewGroup();
            group.Header = chitieu.Ten;
            listView.Groups.Add(group);
            int itemTotal = 0;
            foreach (CTChitieu ctchitieu in ctchitieus)
            {
                var doan = ctchitieu.DoanKhach;
                var item = new ListViewItem
                {
                    Text = "Ngày tạo: " + dateTimeFormat(doan.DateCreated),
                    Group = group,
                    ForeColor = Color.DarkGreen
                };
                listView.Items.Add(item);
                item = new ListViewItem
                {
                    Text = " (" + dateTimeFormat(doan.DateStart) + " - " + dateTimeFormat(doan.DateEnd) + ")",
                    Group = group,
                    ForeColor = Color.DarkGray
                };
                listView.Items.Add(item);
                
                item = new ListViewItem
                {
                    Text = doan.MaDoan + " - " + doan.TenDoan,
                    Group = group
                };
                var tienCT = int.Parse(ctchitieu.TienCT);
                item.SubItems.Add(moneyFormat(tienCT));
                listView.Items.Add(item);
                itemTotal += tienCT;

            }
            ListViewGroup groupTotal = new ListViewGroup();
            groupTotal.Header = "";
            listView.Groups.Insert(0,groupTotal);
            var total = new ListViewItem
            {
                Text = "Tổng cộng",
                Font = new Font(listView.Font, FontStyle.Bold),
                Group = groupTotal
            };
            total.SubItems.Add(moneyFormat(itemTotal));
            listView.Items.Add(total);
        }
    }
}
