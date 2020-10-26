

using Microsoft.Extensions.DependencyInjection;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TourApp.Const;
using TourApp.Entity;
using TourApp.Repository.IRepository;
using TourApp.UI;


namespace TourApp
{
    public partial class List : Form
    {
        private readonly ITourRepository _tourRepo;
        private readonly INhanVienRepository _nhanvienRepo;
        private readonly IChiTieuRepository _chitieuRepo;
        private readonly IServiceProvider _serviceProvider;
        public List(
                        ITourRepository tourRepo,
                        INhanVienRepository nhanvienRepo,
                        IChiTieuRepository chitieuRepo,
                        IServiceProvider serviceProvider
                    )
        {
            InitializeComponent();
            _tourRepo = tourRepo;
            _nhanvienRepo = nhanvienRepo;
            _chitieuRepo = chitieuRepo;

            _serviceProvider = serviceProvider;
            tabControl.SelectedTab = tabTour;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TabRefresh(ListTab.Tour);
            TabRefresh(ListTab.Nhanvien);
            TabRefresh(ListTab.Chitieu);
            ChangeTheme(new DefaultTheme(), this.Controls);
        }
        public void TabRefresh(ListTab tab)
        {

            switch (tab)
            {
                case ListTab.Tour:
                    {
                        searchBox.Text = "";
                        isDeleted_ChB.Checked = false;
                        tourGridView.Rows.Clear();
                        var data = _tourRepo.getAll();
                        foreach (Tour item in data)
                        {

                            tourGridView.Rows.Add(item.TourId, item.MaTour, item.Ten, item.LHDL.Ten);
                        }
                        break;
                    }

                case ListTab.Nhanvien:
                    {
                        tabNV_SearchBox.Text = "";
                        tabNV_CB.Checked = false;
                        NVGridView.Rows.Clear();
                        var data = _nhanvienRepo.getAll();
                        foreach (NhanVien item in data)
                        {

                            NVGridView.Rows.Add(item.NVId,item.MaNV, item.Ten, item.SDT);
                        }
                        break;
                    }
                case ListTab.Chitieu:
                    {
                        tabCT_SearchBox.Text = "";
                        ChiTieuGridView.Rows.Clear();
                        var data = _chitieuRepo.getAll();
                        foreach (ChiTieu item in data)
                        {
                            ChiTieuGridView.Rows.Add(item.CTId, item.Ten);
                        }
                        break;
                    }

            }



        }

        #region Setting menu
        //change theme
        private void ChangeThemeMenu_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
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
            if (e.ClickedItem == DarkStripMenuItem) ChangeTheme(new DarkTheme(), this.Controls);
            else if (e.ClickedItem == LightStripMenuItem) ChangeTheme(new LightTheme(), this.Controls);
            else ChangeTheme(new DefaultTheme(), this.Controls);
        }
        private void ChangeTheme(Theme theme, Control.ControlCollection container)
        {
            foreach (Control component in container)
            {
                if (component is MenuStrip)
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
                else if (component is TabPage)
                {
                    (component as TabPage).BackColor = theme.TabPageBG;
                    (component as TabPage).ForeColor = theme.TabPageFG;
                    ChangeTheme(theme, component.Controls);
                }
                else if (component is DataGridView)
                {
                    (component as DataGridView).BackgroundColor = theme.DataGridviewBG;
                    (component as DataGridView).ForeColor = theme.DataGridviewFG;
                    (component as DataGridView).GridColor = theme.DataGridviewGridColor;
                    ChangeTheme(theme, component.Controls);
                }
                else if (component is TextBox)
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
        //export button pressed
        private void FileMenu_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            DataGridView data =  tabControl.SelectedTab.Controls.OfType<DataGridView>().First();
            exportExcel(data, "D:\\mytest.xlsx");
        }
        //export excel
        private void exportExcel(DataGridView grid, string filepath)
        {
            // Create a spreadsheet document by supplying the filepath.
            // By default, AutoSave = true, Editable = true, and Type = xlsx.
            var spreadsheetDocument = DocumentFormat.OpenXml.Packaging.SpreadsheetDocument.
                Create(filepath, DocumentFormat.OpenXml.SpreadsheetDocumentType.Workbook);

            // Add a WorkbookPart to the document.
            var workbookpart = spreadsheetDocument.AddWorkbookPart();
            workbookpart.Workbook = new DocumentFormat.OpenXml.Spreadsheet.Workbook();

            // Add a WorksheetPart to the WorkbookPart.
            var worksheetPart = workbookpart.AddNewPart<DocumentFormat.OpenXml.Packaging.WorksheetPart>();
            var sheetData = new DocumentFormat.OpenXml.Spreadsheet.SheetData();
            worksheetPart.Worksheet = new DocumentFormat.OpenXml.Spreadsheet.Worksheet(sheetData);

            // Add Sheets to the Workbook.
            var sheets = spreadsheetDocument.WorkbookPart.Workbook.
                AppendChild(new DocumentFormat.OpenXml.Spreadsheet.Sheets());

            // Append a new worksheet and associate it with the workbook.
            var sheet = new DocumentFormat.OpenXml.Spreadsheet.Sheet()
            {
                Id = spreadsheetDocument.WorkbookPart.
                GetIdOfPart(worksheetPart),
                SheetId = 1,
                Name = "mySheet"
            };
            sheets.Append(sheet);
            var row = new DocumentFormat.OpenXml.Spreadsheet.Row() { RowIndex = 1 };
            var header1 = new DocumentFormat.OpenXml.Spreadsheet.Cell() {  CellValue = new DocumentFormat.OpenXml.Spreadsheet.CellValue("Interval Period Timestamp"), DataType = DocumentFormat.OpenXml.Spreadsheet.CellValues.String };
            row.Append(header1);
            var header2 = new DocumentFormat.OpenXml.Spreadsheet.Cell() {  CellValue = new DocumentFormat.OpenXml.Spreadsheet.CellValue("Settlement Interval"), DataType = DocumentFormat.OpenXml.Spreadsheet.CellValues.String };
            row.Append(header2);
            var header3 = new DocumentFormat.OpenXml.Spreadsheet.Cell() {  CellValue = new DocumentFormat.OpenXml.Spreadsheet.CellValue("Aggregated Consumption Factor"), DataType = DocumentFormat.OpenXml.Spreadsheet.CellValues.String };
            row.Append(header3);
            var header4 = new DocumentFormat.OpenXml.Spreadsheet.Cell() {  CellValue = new DocumentFormat.OpenXml.Spreadsheet.CellValue("Loss Adjusted Aggregated Consumption"), DataType = DocumentFormat.OpenXml.Spreadsheet.CellValues.String };
            row.Append(header4);

            sheetData.Append(row);
            

            workbookpart.Workbook.Save();

            // Close the document.
            spreadsheetDocument.Close();

        }
        #endregion

        #region Tour
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
             TabRefresh(ListTab.Tour);
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

        #endregion

        #region Nhan vien

        

        private void NVGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
                if (e.RowIndex < 0)
                    return;

                //I supposed your button column is at index 0
                if (e.ColumnIndex == 4)
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                    var img = Properties.Resources.view;
                    var w = e.CellBounds.Width - 2;
                    var h = e.CellBounds.Height - 2;
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

        private void NVGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            var grid = (DataGridView)sender;
            var name = grid.Columns[e.ColumnIndex].Name;
            var value = grid.Rows[e.RowIndex].Cells["tabNV_IDCol"].Value.ToString();
            switch (name)
            {
                case "tabNV_ViewCol":
                    //ThongTinTour form = _serviceProvider.GetRequiredService<ThongTinTour>();
                    //form.getId(int.Parse(value));
                    //var main = this.Location;
                    //form.Location = new Point((main.X + 10), (main.Y + 10));
                    //form.Show();
                    //break;
                case "tabNV_EditCol":
                    break;
                case "tabNV_DeleteCol":
                    var nhanvien = _nhanvienRepo.getById(int.Parse(value));
                    var messageResult = MessageBox.Show("Bạn có chắc muốn xóa " + nhanvien.Ten, "Warning", MessageBoxButtons.YesNo);
                    if (messageResult != DialogResult.Yes) return;
                    _nhanvienRepo.Delete(nhanvien);
                    tabNV_Search();
                    break;
            }

        }
        //add
        

        private void tabNV_SearchBtn_Click(object sender, EventArgs e)
        {
            tabNV_Search();
        }

        private void tabNV_AddBtn_Click(object sender, EventArgs e)
        {
            //ThemTour form = _serviceProvider.GetRequiredService<ThemTour>();
            //var main = this.Location;
            //form.Location = new Point((main.X + 10), (main.Y + 10));
            //form.Show();
        }

        private void tabNV_RefreshBtn_Click(object sender, EventArgs e)
        {
            TabRefresh(ListTab.Nhanvien);
        }

        private void NVGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            var grid = (DataGridView)sender;
            var name = grid.Columns[e.ColumnIndex].Name;
            if (name == "tabNV_EditCol" || name == "tabNV_ViewCol" || name == "tabNV_DeleteCol") return;
            var value = grid.Rows[e.RowIndex].Cells["tabNV_IDCol"].Value.ToString();

            //ThongTinTour form = _serviceProvider.GetRequiredService<ThongTinTour>();
            //form.getId(int.Parse(value));
            //var main = this.Location;
            //form.Location = new Point((main.X + 10), (main.Y + 10));
            //form.Show();
        }
        private void tabNV_Search()
        {
            var searchStr = tabNV_SearchBox.Text;
            NVGridView.Rows.Clear();
            var data = _nhanvienRepo.getWhere(searchStr, tabNV_CB.Checked ? 1 : 0);
            foreach (NhanVien item in data)
            {
                NVGridView.Rows.Add(item.NVId, item.MaNV, item.Ten, item.SDT);
            }
        }

        private void tabNV_SearchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) tabNV_Search();
        }

        private void tabNV_CB_CheckedChanged(object sender, EventArgs e)
        {
            tabNV_Search();
            if (tabNV_CB.Checked)
            {
                NVGridView.Columns["tabNV_EditCol"].Visible = false;
                NVGridView.Columns["tabNV_DeleteCol"].Visible = false;
            }
            else
            {
                NVGridView.Columns["tabNV_EditCol"].Visible = true;
                NVGridView.Columns["tabNV_DeleteCol"].Visible = true;
            }
        }
        #endregion

        #region Chỉ tiêu
        private void ChiTieuGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            //I supposed your button column is at index 0
            if (e.ColumnIndex == 2)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var img = Properties.Resources.view;
                var w = e.CellBounds.Width - 2;
                var h = e.CellBounds.Height - 2;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(img, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
            if (e.ColumnIndex == 3)
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
            if (e.ColumnIndex == 4)
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
        private void tabCT_Search()
        {
            var searchStr = tabCT_SearchBox.Text;
            ChiTieuGridView.Rows.Clear();
            var data = _chitieuRepo.getWhere(searchStr);
            foreach (ChiTieu item in data)
            {
                ChiTieuGridView.Rows.Add(item.CTId, item.Ten);
            }
        }

        private void tabCT_SearchBtn_Click(object sender, EventArgs e)
        {
            tabCT_Search();
        }
        private void tabCT_SearchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) tabCT_Search();
        }
        private void tabCT_RefreshBtn_Click(object sender, EventArgs e)
        {
            TabRefresh(ListTab.Chitieu);
        }

        private void tabCT_AddBtn_Click(object sender, EventArgs e)
        {
            //ThemTour form = _serviceProvider.GetRequiredService<ThemTour>();
            //var main = this.Location;
            //form.Location = new Point((main.X + 10), (main.Y + 10));
            //form.Show();
        }


        private void ChiTieuGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            var grid = (DataGridView)sender;
            var name = grid.Columns[e.ColumnIndex].Name;
            var value = grid.Rows[e.RowIndex].Cells["tabCT_IDCol"].Value.ToString();
            switch (name)
            {
                case "tabCT_ViewCol":
                //ThongTinTour form = _serviceProvider.GetRequiredService<ThongTinTour>();
                //form.getId(int.Parse(value));
                //var main = this.Location;
                //form.Location = new Point((main.X + 10), (main.Y + 10));
                //form.Show();
                //break;
                case "tabCT_EditCol":
                    break;
                case "tabCT_DeleteCol":
                    var chitieu = _chitieuRepo.getById(int.Parse(value));
                    var messageResult = MessageBox.Show("Bạn có chắc muốn xóa " + chitieu.Ten, "Warning", MessageBoxButtons.YesNo);
                    if (messageResult != DialogResult.Yes) return;
                    _chitieuRepo.Delete(chitieu);
                    tabCT_Search();
                    break;
            }
        }

        private void ChiTieuGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            var grid = (DataGridView)sender;
            var name = grid.Columns[e.ColumnIndex].Name;
            if (name == "tabCT_EditCol" || name == "tabCT_ViewCol" || name == "tabCT_DeleteCol") return;
            var value = grid.Rows[e.RowIndex].Cells["tabCT_IDCol"].Value.ToString();

            //ThongTinTour form = _serviceProvider.GetRequiredService<ThongTinTour>();
            //form.getId(int.Parse(value));
            //var main = this.Location;
            //form.Location = new Point((main.X + 10), (main.Y + 10));
            //form.Show();
        }


        #endregion

        
    }
}
