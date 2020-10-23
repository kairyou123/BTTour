using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TourApp.Entity;
using TourApp.Repository;
using TourApp.Repository.IRepository;
using TourApp.UI;

namespace TourApp
{
    public partial class List : Form
    {
        private readonly ITourRepository _tourRepo;
        private readonly IServiceProvider _serviceProvider;
        public List(
                        ITourRepository tourRepo,
                        IServiceProvider serviceProvider
                    )
        {
            InitializeComponent();
            _tourRepo = tourRepo;
            _serviceProvider = serviceProvider;
            tabControl1.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormRefresh();
            ChangeTheme(new DefaultTheme(), this.Controls);
        }
        public void FormRefresh()
        {
            searchBox.Text = "";
            isDeleted_ChB.Checked = false;
            tourGridView.Rows.Clear();
            var data =  _tourRepo.getAll();
            //tourGridView.VirtualMode = true;
            foreach (Tour item in data)
            {

                tourGridView.Rows.Add(item.TourId, item.MaTour, item.Ten, item.LHDL.Ten);
            }
            //tourGridView.Rows.Add();
        }




        private void tourGridView_CellPainting_1(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            //I supposed your button column is at index 0
            if (e.ColumnIndex == 4)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var img = Properties.Resources.view;
                var w = e.CellBounds.Width-2;
                var h = e.CellBounds.Height-2;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(img, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
            if (e.ColumnIndex == 5)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var img = Properties.Resources.edit;
                var w = e.CellBounds.Width - 2;
                var h = e.CellBounds.Height - 2;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(img, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
            if (e.ColumnIndex == 6)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var img = Properties.Resources.delete;
                var w = e.CellBounds.Width - 2;
                var h = e.CellBounds.Height - 2;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(img, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ThemTour form = _serviceProvider.GetRequiredService<ThemTour>();
            var main = this.Location;
            form.Location = new Point((main.X + 10), (main.Y + 10));
            form.Show();
        }

        private void tourGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            var grid = (DataGridView)sender;
            var name = grid.Columns[e.ColumnIndex].Name;
            var value = grid.Rows[e.RowIndex].Cells["TourIdCol"].Value.ToString();
            switch (name)
            {
                case "ViewCol":
                    ThongTinTour form = _serviceProvider.GetRequiredService<ThongTinTour>();
                    form.getId(int.Parse(value));
                    var main = this.Location;
                    form.Location = new Point((main.X + 10), (main.Y + 10));
                    form.Show();
                    break;
                case "EditCol":
                    break;
                case "DeleteCol":
                    var tour = _tourRepo.getById(int.Parse(value));
                    var messageResult = MessageBox.Show("Bạn có chắc muốn xóa "+ tour.Ten, "Warning", MessageBoxButtons.YesNo);
                    if (messageResult != DialogResult.Yes) return;
                    _tourRepo.Delete(tour);
                    Search();
                    break;
            }
            
        }

        private void tourGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            var grid = (DataGridView)sender;
            var name = grid.Columns[e.ColumnIndex].Name;
            if (name == "EditCol" || name == "ViewCol" || name == "DeleteCol") return;
            var value = grid.Rows[e.RowIndex].Cells["TourIdCol"].Value.ToString();

            ThongTinTour form = _serviceProvider.GetRequiredService<ThongTinTour>();
            form.getId(int.Parse(value));
            var main = this.Location;
            form.Location = new Point((main.X + 10), (main.Y + 10));
            form.Show();
        }

        private  void button1_Click(object sender, EventArgs e)
        {
            Search();
        }
        private void Search()
        {
            var searchStr = searchBox.Text;
            tourGridView.Rows.Clear();
            var data = _tourRepo.getWhere(searchStr, isDeleted_ChB.Checked ? 1 : 0);
            foreach (Tour item in data)
            {
                tourGridView.Rows.Add(item.TourId, item.MaTour, item.Ten, item.LHDL.Ten);
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
             FormRefresh();
        }

        private void searchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) Search();
        }

        private void isDeleted_CheckedChanged(object sender, EventArgs e)
        {
            Search();
            if (isDeleted_ChB.Checked)
            {
                tourGridView.Columns["EditCol"].Visible = false;
                tourGridView.Columns["DeleteCol"].Visible = false;
            }
            else
            {
                tourGridView.Columns["EditCol"].Visible = true;
                tourGridView.Columns["DeleteCol"].Visible = true;
            }
        }

        private void toolStripMenuItem2_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //get the parent item
            ToolStripMenuItem ownerItem = e.ClickedItem.OwnerItem as ToolStripMenuItem;
            if (ownerItem != null)
            {
                //uncheck all item
                foreach (ToolStripMenuItem item in ownerItem.DropDownItems)
                {
                    item.Checked = false;
                }
            }
            //it will check the clicked item automatically

            //change theme
            if (e.ClickedItem == DarkStripMenuItem) ChangeTheme(new DarkTheme(),this.Controls);
            else if (e.ClickedItem == LightStripMenuItem) ChangeTheme(new LightTheme(), this.Controls);
            else  ChangeTheme(new DefaultTheme(), this.Controls);
        }
        private void ChangeTheme(Theme theme,Control.ControlCollection container)
        {
            foreach (Control component in container)
            {
                if(component is MenuStrip)
                {
                    (component as MenuStrip).BackColor = theme.MenuStripBG;
                    (component as MenuStrip).ForeColor = theme.MenuStripFG;
                    ChangeTheme(theme, component.Controls);
                }
                else if (component is TabControl)
                {
                    (component as TabControl).BackColor = theme.TabControlBG;
                    (component as TabControl).ForeColor = theme.TabControlFG;
                    ChangeTheme(theme, component.Controls);
                }
                else if(component is TabPage)
                {
                    (component as TabPage).BackColor = theme.TabPageBG;
                    (component as TabPage).ForeColor = theme.TabPageFG;
                    ChangeTheme(theme, component.Controls);
                }
                else if(component is DataGridView)
                {
                    (component as DataGridView).BackgroundColor = theme.DataGridviewBG;
                    (component as DataGridView).ForeColor = theme.DataGridviewFG;
                    (component as DataGridView).GridColor = theme.DataGridviewGridColor;
                    ChangeTheme(theme, component.Controls);
                }
                else if(component is TextBox)
                {
                    (component as TextBox).BackColor = theme.TextBoxBG;
                    (component as TextBox).ForeColor = theme.TextBoxFG;
                    ChangeTheme(theme, component.Controls);
                }
                else if (component is Button)
                {
                    (component as Button).BackColor = theme.ButtonBG;
                    (component as Button).ForeColor = theme.ButtonFG;
                    ChangeTheme(theme, component.Controls);
                }

            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
