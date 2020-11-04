

using Microsoft.Extensions.DependencyInjection;
using System;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
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
        private readonly IDoanKhachRepository _doankhachRepo;
        private readonly IHanhKhachRepository _hanhkhachRepo;

        private readonly IServiceProvider _serviceProvider;
        public List(
                        ITourRepository tourRepo,
                        INhanVienRepository nhanvienRepo,
                        IChiTieuRepository chitieuRepo,
                        IDoanKhachRepository doankhachRepo,
                        IHanhKhachRepository hanhkhachRepo,
                        IServiceProvider serviceProvider
                    )
        {
            InitializeComponent();
            _tourRepo = tourRepo;
            _nhanvienRepo = nhanvienRepo;
            _chitieuRepo = chitieuRepo;
            _doankhachRepo = doankhachRepo;
            _hanhkhachRepo = hanhkhachRepo;

            _serviceProvider = serviceProvider;
            tabControl.SelectedTab = tabTour;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TabRefresh(ListTab.Tour);
            TabRefresh(ListTab.Nhanvien);
            TabRefresh(ListTab.Chitieu);
            TabRefresh(ListTab.Doan);
            TabRefresh(ListTab.HanhKhach);
            ChangeTheme(new DefaultTheme(), this.Controls);
        }
        public void TabRefresh(ListTab tab)
        {

            switch (tab)
            {
                case ListTab.Tour:
                    {
                        tabTour_FromDate.Value = tabTour_FromDate.MinDate;
                        tabTour_ToDate.Value = tabTour_ToDate.MaxDate;
                        tabTour_ToPrice.Value = tabTour_ToPrice.Maximum;
                        tabTour_SearchOption.SelectedIndex = 0;
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
                case ListTab.Doan:
                    {
                        tabDoan_SearchBox.Text = "";
                        DoanGridView.Rows.Clear();
                        var data = _doankhachRepo.getAll();
                        foreach (DoanKhach item in data)
                        {
                            DoanGridView.Rows.Add(item.DoanId, item.MaDoan,item.TenDoan,item.Chitiet,item.Status,item.TourId,item.Tour.MaTour);
                        }
                        break;
                    }
                case ListTab.HanhKhach:
                    {
                        tabHanhKhach_SearchBox.Text = "";
                        HanhKhachGridView.Rows.Clear();
                        var data = _hanhkhachRepo.getAll();
                        foreach (HanhKhach item in data)
                        {
                            HanhKhachGridView.Rows.Add(item.KhachId, item.MaKhach, item.Ten, item.SDT, item.Email);
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
                switch (component)
                {
                    case MenuStrip _:
                        (component as MenuStrip).BackColor = theme.MenuStripBG;
                        (component as MenuStrip).ForeColor = theme.MenuStripFG;
                        ChangeTheme(theme, component.Controls);
                        break;
                    case TabControl _:
                        (component as TabControl).BackColor = theme.TabControlBG;
                        (component as TabControl).ForeColor = theme.TabControlFG;
                        ChangeTheme(theme, component.Controls);
                        break;
                    case TabPage _:
                        (component as TabPage).BackColor = theme.TabPageBG;
                        (component as TabPage).ForeColor = theme.TabPageFG;
                        ChangeTheme(theme, component.Controls);
                        break;
                    case DataGridView _:
                        (component as DataGridView).BackgroundColor = theme.DataGridviewBG;
                        (component as DataGridView).ForeColor = theme.DataGridviewFG;
                        (component as DataGridView).GridColor = theme.DataGridviewGridColor;
                        ChangeTheme(theme, component.Controls);
                        break;
                    case TextBox _:
                        (component as TextBox).BackColor = theme.TextBoxBG;
                        (component as TextBox).ForeColor = theme.TextBoxFG;
                        ChangeTheme(theme, component.Controls);
                        break;
                    case Button _:
                        (component as Button).BackColor = theme.ButtonBG;
                        (component as Button).ForeColor = theme.ButtonFG;
                        ChangeTheme(theme, component.Controls);
                        break;
                }

            }
        }
        //export button pressed
        private void FileMenu_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            var saveDialog = new SaveFileDialog
            {
                Filter = "Excel file (*.xlsx)|*.xlsx",
                FileName = "export.xlsx",
                Title = "Export data to excel",
                CheckFileExists = false
            };
            if (saveDialog.ShowDialog() != DialogResult.OK) return;
            
            DataGridView data =  tabControl.SelectedTab.Controls.OfType<DataGridView>().First();
            exportExcel(data, saveDialog.FileName);
            saveDialog.Dispose();
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

            var row_header = new DocumentFormat.OpenXml.Spreadsheet.Row() { RowIndex = 1 };
            for(var j=0;j<grid.ColumnCount;j++)
                {
                if (!(grid.Columns[j] is DataGridViewTextBoxColumn)) continue;
                    var cell = new DocumentFormat.OpenXml.Spreadsheet.Cell() 
                    { 
                        CellValue = new DocumentFormat.OpenXml.Spreadsheet.CellValue(grid.Columns[j].HeaderText), 
                        DataType = DocumentFormat.OpenXml.Spreadsheet.CellValues.String 
                    };
                    row_header.Append(cell);
                }
            sheetData.Append(row_header);
            for (var i = 0; i < grid.RowCount; i++)
            {
                var row = new DocumentFormat.OpenXml.Spreadsheet.Row();
                for (var j = 0; j < grid.ColumnCount; j++)
                {
                    var grid_cell = grid.Rows[i].Cells[j];
                    if (grid_cell.Value == null) continue;
                    var cell = new DocumentFormat.OpenXml.Spreadsheet.Cell()
                    {
                        CellValue = new DocumentFormat.OpenXml.Spreadsheet.CellValue(grid_cell.Value.ToString()),
                        DataType = DocumentFormat.OpenXml.Spreadsheet.CellValues.String
                    };

                    row.Append(cell);
                }
                sheetData.Append(row);
            }
             
            
            workbookpart.Workbook.Save();

            // Close the document.
            spreadsheetDocument.Close();
            spreadsheetDocument.Dispose();
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
                    SuaTour form2 = _serviceProvider.GetRequiredService<SuaTour>();
                    form2.getId(int.Parse(value));
                    var main2 = this.Location;
                    form2.Location = new Point((main2.X + 10), (main2.Y + 10));
                    form2.Show();
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
            string searchTen, searchLHDL, searchID, searchMaTour;
             searchTen = searchLHDL = searchID = searchMaTour = "";

            switch (tabTour_SearchOption.SelectedIndex)
            {
                case 0:
                    searchTen = searchBox.Text;
                    break;
                case 1:
                    searchMaTour = searchBox.Text;
                    break;
                case 2:
                    searchID = searchBox.Text; 
                    break;
                case 3:
                    searchLHDL = searchBox.Text;
                    break;

            }
            tourGridView.Rows.Clear();
            var data = _tourRepo.getWhere(searchTen,searchLHDL,searchID,searchMaTour,
                                          tabTour_FromDate.Value,tabTour_ToDate.Value,
                                          (int)tabTour_FromPrice.Value,(int) tabTour_ToPrice.Value, 
                                          isDeleted_ChB.Checked ? 1 : 0);
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
                if (e.ColumnIndex == 5)
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
                if (e.ColumnIndex == 6)
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
                if (e.ColumnIndex == 7)
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
            if (e.ColumnIndex == 3)
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
            if (e.ColumnIndex == 4)
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
            if (e.ColumnIndex == 5)
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
            ThemChiTieu form = _serviceProvider.GetRequiredService<ThemChiTieu>();
            var main = this.Location;
            form.Location = new Point((main.X + 10), (main.Y + 10));
            form.Show();
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
                ThemChiTieu form = _serviceProvider.GetRequiredService<ThemChiTieu>();
                form.setId(int.Parse(value));
                    form.editState = EditState.View;
                var main = this.Location;
                form.Location = new Point((main.X + 10), (main.Y + 10));
                form.Show();
                break;
                case "tabCT_EditCol":
                    ThemChiTieu form1 = _serviceProvider.GetRequiredService<ThemChiTieu>();
                    form1.setId(int.Parse(value));
                    form1.editState = EditState.Edit;
                    var main1 = this.Location;
                    form1.Location = new Point((main1.X + 10), (main1.Y + 10));
                    form1.Show();
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

        #region Đoàn

        private void tabDoan_Search()
        {
            var searchStr = tabDoan_SearchBox.Text;
            DoanGridView.Rows.Clear();
            var data = _doankhachRepo.getWhere(searchStr, tabDoan_CB.Checked ? 1 : 0);
            foreach (DoanKhach item in data)
            {
                DoanGridView.Rows.Add(item.DoanId, item.MaDoan, item.TenDoan, item.Chitiet, item.Status, item.TourId, item.Tour.MaTour);
            }
        }
        private void tabDoan_SearchBtn_Click(object sender, EventArgs e)
        {
            tabDoan_Search();
        }

        private void tabDoan_SearchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) tabDoan_Search();
        }

        private void tabDoan_CB_CheckedChanged(object sender, EventArgs e)
        {
            tabDoan_Search();
            if (tabDoan_CB.Checked)
            {
                DoanGridView.Columns["tabDoan_EditCol"].Visible = false;
                DoanGridView.Columns["tabDoan_DeleteCol"].Visible = false;
            }
            else
            {
                DoanGridView.Columns["tabDoan_EditCol"].Visible = true;
                DoanGridView.Columns["tabDoan_DeleteCol"].Visible = true;
            }
        }

        private void tabDoan_RefreshBtn_Click(object sender, EventArgs e)
        {
            TabRefresh(ListTab.Doan);
        }

        private void tabDoan_AddBtn_Click(object sender, EventArgs e)
        {
            DoanKhach_Form form = _serviceProvider.GetRequiredService<DoanKhach_Form>();
            var main = this.Location;
            form.Location = new Point((main.X + 10), (main.Y + 10));
            form.Show();
        }

        private void doanGridview_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            //I supposed your button column is at index 0
            if (e.ColumnIndex == 7)
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
            if (e.ColumnIndex == 8)
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
            if (e.ColumnIndex == 9)
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

        private void doanGridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            var grid = (DataGridView)sender;
            var name = grid.Columns[e.ColumnIndex].Name;
            var value = grid.Rows[e.RowIndex].Cells["tabDoan_IDCol"].Value.ToString();
            switch (name)
            {
                case "tabDoan_ViewCol":
                    DoanKhach_Form form1 = _serviceProvider.GetRequiredService<DoanKhach_Form>();
                    form1.formType = EditState.View;
                    form1.id = int.Parse(value);
                    var main1 = this.Location;
                    form1.Location = new Point((main1.X + 10), (main1.Y + 10));
                    form1.Show();
                    break;
                case "tabDoan_EditCol":
                    DoanKhach_Form form = _serviceProvider.GetRequiredService<DoanKhach_Form>();
                    form.id = int.Parse(value);
                    form.formType = EditState.Edit;
                    var main = this.Location;
                    form.Location = new Point((main.X + 10), (main.Y + 10));
                    form.Show();
                    break;
                case "tabDoan_DeleteCol":
                    var doan = _doankhachRepo.getById(int.Parse(value));
                    var messageResult = MessageBox.Show("Bạn có chắc muốn xóa " + doan.TenDoan, "Warning", MessageBoxButtons.YesNo);
                    if (messageResult != DialogResult.Yes) return;
                    _doankhachRepo.Delete(doan);
                    tabDoan_Search();
                    break;
            }
        }

        private void doanGridview_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            var grid = (DataGridView)sender;
            var name = grid.Columns[e.ColumnIndex].Name;
            if (name == "tabDoan_EditCol" || name == "tabDoan_ViewCol" || name == "tabDoan_DeleteCol") return;
            var value = grid.Rows[e.RowIndex].Cells["tabDoan_IDCol"].Value.ToString();

            //ThongTinTour form = _serviceProvider.GetRequiredService<ThongTinTour>();
            //form.getId(int.Parse(value));
            //var main = this.Location;
            //form.Location = new Point((main.X + 10), (main.Y + 10));
            //form.Show();
        }


        #endregion

        #region Hành khách
       
        private void tabHanhKhach_Search()
        {
            var searchStr = tabHanhKhach_SearchBox.Text;
            HanhKhachGridView.Rows.Clear();
            var data = _hanhkhachRepo.getWhere(searchStr, tabHanhKhach_CB.Checked ? 1 : 0);
            foreach (HanhKhach item in data)
            {
                HanhKhachGridView.Rows.Add(item.KhachId, item.MaKhach, item.Ten, item.SDT, item.Email);
            }
        }
        private void tabHanhKhach_SearchBtn_Click(object sender, EventArgs e)
        {
            tabHanhKhach_Search();
        }

        private void tabHanhKhach_SearchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) tabHanhKhach_Search();
        }

        private void tabHanhKhach_RefreshBtn_Click(object sender, EventArgs e)
        {
            TabRefresh(ListTab.HanhKhach);
        }

        private void tabHanhKhach_AddBtn_Click(object sender, EventArgs e)
        {
            HanhKhach_Form form = _serviceProvider.GetRequiredService<HanhKhach_Form>();
            form.editState = EditState.Create;
            var main = this.Location;
            form.Location = new Point((main.X + 10), (main.Y + 10));
            form.Show();
        }

        private void tabHanhKhach_CB_CheckedChanged(object sender, EventArgs e)
        {
            tabHanhKhach_Search();
            if (tabHanhKhach_CB.Checked)
            {
                HanhKhachGridView.Columns["tabHanhKhach_EditCol"].Visible = false;
                HanhKhachGridView.Columns["tabHanhKhach_DeleteCol"].Visible = false;
            }
            else
            {
                HanhKhachGridView.Columns["tabHanhKhach_EditCol"].Visible = true;
                HanhKhachGridView.Columns["tabHanhKhach_DeleteCol"].Visible = true;
            }
        }

        private void HanhKhachGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            //I supposed your button column is at index 0
            if (e.ColumnIndex == 5)
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
            if (e.ColumnIndex == 6)
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
            if (e.ColumnIndex == 7)
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

        private void HanhKhachGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            var grid = (DataGridView)sender;
            var name = grid.Columns[e.ColumnIndex].Name;
            var value = grid.Rows[e.RowIndex].Cells["tabHanhKhach_IDCol"].Value.ToString();
            switch (name)
            {
                case "tabHanhKhach_ViewCol":
                    {
                        HanhKhach_Form form = _serviceProvider.GetRequiredService<HanhKhach_Form>();
                        form.editState = EditState.View;
                        form.setId(int.Parse(value));
                        var main = this.Location;
                        form.Location = new Point((main.X + 10), (main.Y + 10));
                        form.Show();
                        break;
                    }
                case "tabHanhKhach_EditCol":
                    {
                        HanhKhach_Form form = _serviceProvider.GetRequiredService<HanhKhach_Form>();
                        form.editState = EditState.Edit;
                        form.setId(int.Parse(value));
                        var main = this.Location;
                        form.Location = new Point((main.X + 10), (main.Y + 10));
                        form.Show();
                        break;
                    }
                case "tabHanhKhach_DeleteCol":
                    {
                        var khach = _hanhkhachRepo.getById(int.Parse(value));
                        var messageResult = MessageBox.Show("Bạn có chắc muốn xóa " + khach.Ten, "Warning", MessageBoxButtons.YesNo);
                        if (messageResult != DialogResult.Yes) return;
                        _hanhkhachRepo.Delete(khach);
                        tabHanhKhach_Search();
                        break;
                    }
            }
        }

        private void HanhKhachGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            var grid = (DataGridView)sender;
            var name = grid.Columns[e.ColumnIndex].Name;
            if (name == "tabHanhKhach_EditCol" || name == "tabHanhKhach_ViewCol" || name == "tabHanhKhach_DeleteCol") return;
            var value = grid.Rows[e.RowIndex].Cells["tabHanhKhach_IDCol"].Value.ToString();

            HanhKhach_Form form = _serviceProvider.GetRequiredService<HanhKhach_Form>();
            form.editState = EditState.View;
            form.setId(int.Parse(value));
            var main = this.Location;
            form.Location = new Point((main.X + 10), (main.Y + 10));
            form.Show();
            
        }
        #endregion
    }
}
