using System.Windows.Forms;
namespace TourApp
{
    partial class List
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(List));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabTour = new System.Windows.Forms.TabPage();
            this.tabTour_ToPrice = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabTour_FromPrice = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabTour_ToDate = new System.Windows.Forms.DateTimePicker();
            this.tabTour_FromDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tabTour_SearchOption = new System.Windows.Forms.ComboBox();
            this.isDeleted_ChB = new System.Windows.Forms.CheckBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tourGridView = new System.Windows.Forms.DataGridView();
            this.TourIdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTourCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LHDLCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ViewCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.EditCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.tabStaff = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.tabNV_SearchOption = new System.Windows.Forms.ComboBox();
            this.NVGridView = new System.Windows.Forms.DataGridView();
            this.tabNV_IDCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabNV_MaNVCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabNV_TenCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabNV_SDTCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabNV_BlankCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabNV_ViewCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabNV_EditCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabNV_DeleteCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabNV_SearchBox = new System.Windows.Forms.TextBox();
            this.tabNV_CB = new System.Windows.Forms.CheckBox();
            this.tabNV_AddBtn = new System.Windows.Forms.Button();
            this.tabNV_RefreshBtn = new System.Windows.Forms.Button();
            this.tabNV_SearchBtn = new System.Windows.Forms.Button();
            this.tabPassenger = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.tabHanhKhach_SearchOption = new System.Windows.Forms.ComboBox();
            this.HanhKhachGridView = new System.Windows.Forms.DataGridView();
            this.tabHanhKhach_IDCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabHanhKhach_MaKhachCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabHanhKhach_TenCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabHanhKhach_SDTCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabHanhKhach_EmailCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabHanhKhach_CMNDCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabHanhKhach_DiachiCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabHanhKhach_GioitinhCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabHanhKhach_PassportCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabHanhKhach_ViewCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabHanhKhach_EditCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabHanhKhach_DeleteCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabHanhKhach_CB = new System.Windows.Forms.CheckBox();
            this.tabHanhKhach_SearchBox = new System.Windows.Forms.TextBox();
            this.tabHanhKhach_RefreshBtn = new System.Windows.Forms.Button();
            this.tabHanhKhach_AddBtn = new System.Windows.Forms.Button();
            this.tabHanhKhach_SearchBtn = new System.Windows.Forms.Button();
            this.tabGroup = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.tabDoan_SearchOption = new System.Windows.Forms.ComboBox();
            this.DoanGridView = new System.Windows.Forms.DataGridView();
            this.tabDoan_IDCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabDoan_MaDoanCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabDoan_TenCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabDoan_ChitietCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabDoan_StatusCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabDoan_TourIDCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabDoan_MaTourCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabDoan_ViewCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabDoan_EditCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabDoan_DeleteCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabDoan_SearchBox = new System.Windows.Forms.TextBox();
            this.tabDoan_CB = new System.Windows.Forms.CheckBox();
            this.tabDoan_AddBtn = new System.Windows.Forms.Button();
            this.tabDoan_RefreshBtn = new System.Windows.Forms.Button();
            this.tabDoan_SearchBtn = new System.Windows.Forms.Button();
            this.tabCT = new System.Windows.Forms.TabPage();
            this.tabCT_SearchOption = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ChiTieuGridView = new System.Windows.Forms.DataGridView();
            this.tabCT_IDCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabCT_TenCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabCT_BlankCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabCT_ViewCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabCT_EditCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabCT_DeleteCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabCT_SearchBox = new System.Windows.Forms.TextBox();
            this.tabCT_RefreshBtn = new System.Windows.Forms.Button();
            this.tabCT_AddBtn = new System.Windows.Forms.Button();
            this.tabCT_SearchBtn = new System.Windows.Forms.Button();
            this.tabDestination = new System.Windows.Forms.TabPage();
            this.DiaDiemGridView = new System.Windows.Forms.DataGridView();
            this.tabDD_IDCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabDD_TenCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabDD_BlankCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabDD_ViewCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabDD_EditCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabDD_DeleteCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabDD_AddBtn = new System.Windows.Forms.Button();
            this.tabDD_RefreshBtn = new System.Windows.Forms.Button();
            this.tabDD_SearchBtn = new System.Windows.Forms.Button();
            this.tabDD_SearchBox = new System.Windows.Forms.TextBox();
            this.tabDD_SearchOption = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabLHDL = new System.Windows.Forms.TabPage();
            this.LHDLGridView = new System.Windows.Forms.DataGridView();
            this.tabLHDL_IDCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabLHDL_TenCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabLHDL_MotaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabLHDL_BlankCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabLHDL_ViewCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabLHDL_EditCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabLHDL_DeleteCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabLHDL_SearchBox = new System.Windows.Forms.TextBox();
            this.tabLHDL_AddBtn = new System.Windows.Forms.Button();
            this.tabLHDL_RefreshBtn = new System.Windows.Forms.Button();
            this.tabLHDL_SearchBtn = new System.Windows.Forms.Button();
            this.tabLHDL_SearchOption = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ExportMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeThemeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.DarkStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LightStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DefaultStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.StatisticMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.TKChiPhiMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.TKDoanhThuMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.TKTinhHinhHoatDongMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.TKSoLanDiTourMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.tabControl.SuspendLayout();
            this.tabTour.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabTour_ToPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabTour_FromPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourGridView)).BeginInit();
            this.tabStaff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NVGridView)).BeginInit();
            this.tabPassenger.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HanhKhachGridView)).BeginInit();
            this.tabGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DoanGridView)).BeginInit();
            this.tabCT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChiTieuGridView)).BeginInit();
            this.tabDestination.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiaDiemGridView)).BeginInit();
            this.tabLHDL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LHDLGridView)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabTour);
            this.tabControl.Controls.Add(this.tabStaff);
            this.tabControl.Controls.Add(this.tabPassenger);
            this.tabControl.Controls.Add(this.tabGroup);
            this.tabControl.Controls.Add(this.tabCT);
            this.tabControl.Controls.Add(this.tabDestination);
            this.tabControl.Controls.Add(this.tabLHDL);
            this.tabControl.Location = new System.Drawing.Point(0, 35);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 2;
            this.tabControl.Size = new System.Drawing.Size(792, 601);
            this.tabControl.TabIndex = 1;
            // 
            // tabTour
            // 
            this.tabTour.Controls.Add(this.tabTour_ToPrice);
            this.tabTour.Controls.Add(this.label5);
            this.tabTour.Controls.Add(this.label4);
            this.tabTour.Controls.Add(this.tabTour_FromPrice);
            this.tabTour.Controls.Add(this.label3);
            this.tabTour.Controls.Add(this.label2);
            this.tabTour.Controls.Add(this.tabTour_ToDate);
            this.tabTour.Controls.Add(this.tabTour_FromDate);
            this.tabTour.Controls.Add(this.label1);
            this.tabTour.Controls.Add(this.tabTour_SearchOption);
            this.tabTour.Controls.Add(this.isDeleted_ChB);
            this.tabTour.Controls.Add(this.btnRefresh);
            this.tabTour.Controls.Add(this.button2);
            this.tabTour.Controls.Add(this.tourGridView);
            this.tabTour.Controls.Add(this.button1);
            this.tabTour.Controls.Add(this.searchBox);
            this.tabTour.Location = new System.Drawing.Point(4, 29);
            this.tabTour.Name = "tabTour";
            this.tabTour.Padding = new System.Windows.Forms.Padding(3);
            this.tabTour.Size = new System.Drawing.Size(784, 568);
            this.tabTour.TabIndex = 0;
            this.tabTour.Text = "Tour";
            this.tabTour.UseVisualStyleBackColor = true;
            // 
            // tabTour_ToPrice
            // 
            this.tabTour_ToPrice.Location = new System.Drawing.Point(609, 72);
            this.tabTour_ToPrice.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.tabTour_ToPrice.Name = "tabTour_ToPrice";
            this.tabTour_ToPrice.Size = new System.Drawing.Size(150, 27);
            this.tabTour_ToPrice.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(567, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 28);
            this.label5.TabIndex = 13;
            this.label5.Text = "->";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(370, 75);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(31, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Giá";
            // 
            // tabTour_FromPrice
            // 
            this.tabTour_FromPrice.Location = new System.Drawing.Point(407, 72);
            this.tabTour_FromPrice.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.tabTour_FromPrice.Name = "tabTour_FromPrice";
            this.tabTour_FromPrice.Size = new System.Drawing.Size(150, 27);
            this.tabTour_FromPrice.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Đến";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Từ ";
            // 
            // tabTour_ToDate
            // 
            this.tabTour_ToDate.Location = new System.Drawing.Point(45, 75);
            this.tabTour_ToDate.Name = "tabTour_ToDate";
            this.tabTour_ToDate.Size = new System.Drawing.Size(250, 27);
            this.tabTour_ToDate.TabIndex = 8;
            // 
            // tabTour_FromDate
            // 
            this.tabTour_FromDate.Location = new System.Drawing.Point(45, 20);
            this.tabTour_FromDate.Name = "tabTour_FromDate";
            this.tabTour_FromDate.Size = new System.Drawing.Size(247, 27);
            this.tabTour_FromDate.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(333, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tìm theo";
            // 
            // tabTour_SearchOption
            // 
            this.tabTour_SearchOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tabTour_SearchOption.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabTour_SearchOption.FormattingEnabled = true;
            this.tabTour_SearchOption.Items.AddRange(new object[] {
            "Tên tour",
            "Mã tour",
            "ID tour",
            "Loại hình du lịch"});
            this.tabTour_SearchOption.Location = new System.Drawing.Point(407, 13);
            this.tabTour_SearchOption.Name = "tabTour_SearchOption";
            this.tabTour_SearchOption.Size = new System.Drawing.Size(151, 33);
            this.tabTour_SearchOption.TabIndex = 5;
            // 
            // isDeleted_ChB
            // 
            this.isDeleted_ChB.AutoSize = true;
            this.isDeleted_ChB.Location = new System.Drawing.Point(6, 141);
            this.isDeleted_ChB.Name = "isDeleted_ChB";
            this.isDeleted_ChB.Size = new System.Drawing.Size(78, 24);
            this.isDeleted_ChB.TabIndex = 4;
            this.isDeleted_ChB.Text = "Đã xóa";
            this.isDeleted_ChB.UseVisualStyleBackColor = true;
            this.isDeleted_ChB.CheckedChanged += new System.EventHandler(this.isDeleted_CheckedChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.BackgroundImage")));
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.Location = new System.Drawing.Point(685, 131);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(46, 36);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(735, 131);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 36);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tourGridView
            // 
            this.tourGridView.AllowUserToAddRows = false;
            this.tourGridView.AllowUserToDeleteRows = false;
            this.tourGridView.AllowUserToOrderColumns = true;
            this.tourGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tourGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TourIdCol,
            this.MaTourCol,
            this.TenCol,
            this.LHDLCol,
            this.ViewCol,
            this.EditCol,
            this.DeleteCol});
            this.tourGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.tourGridView.Location = new System.Drawing.Point(3, 175);
            this.tourGridView.Name = "tourGridView";
            this.tourGridView.ReadOnly = true;
            this.tourGridView.RowHeadersVisible = false;
            this.tourGridView.RowHeadersWidth = 51;
            this.tourGridView.Size = new System.Drawing.Size(778, 387);
            this.tourGridView.TabIndex = 0;
            this.tourGridView.Text = "dataGridView1";
            this.tourGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tourGridView_CellClick);
            this.tourGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tourGridView_CellDoubleClick);
            this.tourGridView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.tourGridView_CellPainting_1);
            // 
            // TourIdCol
            // 
            this.TourIdCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TourIdCol.HeaderText = "TourID";
            this.TourIdCol.MinimumWidth = 6;
            this.TourIdCol.Name = "TourIdCol";
            this.TourIdCol.ReadOnly = true;
            this.TourIdCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TourIdCol.Width = 82;
            // 
            // MaTourCol
            // 
            this.MaTourCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MaTourCol.HeaderText = "Mã tour";
            this.MaTourCol.MinimumWidth = 6;
            this.MaTourCol.Name = "MaTourCol";
            this.MaTourCol.ReadOnly = true;
            this.MaTourCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaTourCol.Width = 83;
            // 
            // TenCol
            // 
            this.TenCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TenCol.HeaderText = "Tên";
            this.TenCol.MinimumWidth = 6;
            this.TenCol.Name = "TenCol";
            this.TenCol.ReadOnly = true;
            this.TenCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TenCol.Width = 61;
            // 
            // LHDLCol
            // 
            this.LHDLCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LHDLCol.HeaderText = "Loại hình du lịch";
            this.LHDLCol.MinimumWidth = 6;
            this.LHDLCol.Name = "LHDLCol";
            this.LHDLCol.ReadOnly = true;
            this.LHDLCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ViewCol
            // 
            this.ViewCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ViewCol.HeaderText = "Xem";
            this.ViewCol.MinimumWidth = 6;
            this.ViewCol.Name = "ViewCol";
            this.ViewCol.ReadOnly = true;
            this.ViewCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ViewCol.Width = 45;
            // 
            // EditCol
            // 
            this.EditCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.EditCol.HeaderText = "Sửa";
            this.EditCol.MinimumWidth = 6;
            this.EditCol.Name = "EditCol";
            this.EditCol.ReadOnly = true;
            this.EditCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EditCol.Width = 40;
            // 
            // DeleteCol
            // 
            this.DeleteCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.DeleteCol.HeaderText = "Xóa";
            this.DeleteCol.MinimumWidth = 6;
            this.DeleteCol.Name = "DeleteCol";
            this.DeleteCol.ReadOnly = true;
            this.DeleteCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DeleteCol.Width = 41;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(635, 131);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(46, 36);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchBox.Location = new System.Drawing.Point(566, 15);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(215, 32);
            this.searchBox.TabIndex = 0;
            this.searchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchBox_KeyPress);
            // 
            // tabStaff
            // 
            this.tabStaff.Controls.Add(this.label6);
            this.tabStaff.Controls.Add(this.tabNV_SearchOption);
            this.tabStaff.Controls.Add(this.NVGridView);
            this.tabStaff.Controls.Add(this.tabNV_SearchBox);
            this.tabStaff.Controls.Add(this.tabNV_CB);
            this.tabStaff.Controls.Add(this.tabNV_AddBtn);
            this.tabStaff.Controls.Add(this.tabNV_RefreshBtn);
            this.tabStaff.Controls.Add(this.tabNV_SearchBtn);
            this.tabStaff.Location = new System.Drawing.Point(4, 29);
            this.tabStaff.Name = "tabStaff";
            this.tabStaff.Padding = new System.Windows.Forms.Padding(3);
            this.tabStaff.Size = new System.Drawing.Size(784, 568);
            this.tabStaff.TabIndex = 1;
            this.tabStaff.Text = "Nhân viên";
            this.tabStaff.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(333, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Tìm theo";
            // 
            // tabNV_SearchOption
            // 
            this.tabNV_SearchOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tabNV_SearchOption.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabNV_SearchOption.FormattingEnabled = true;
            this.tabNV_SearchOption.Items.AddRange(new object[] {
            "ID",
            "Mã nhân viên",
            "Tên ",
            "SĐT"});
            this.tabNV_SearchOption.Location = new System.Drawing.Point(407, 24);
            this.tabNV_SearchOption.Name = "tabNV_SearchOption";
            this.tabNV_SearchOption.Size = new System.Drawing.Size(151, 33);
            this.tabNV_SearchOption.TabIndex = 6;
            // 
            // NVGridView
            // 
            this.NVGridView.AllowUserToAddRows = false;
            this.NVGridView.AllowUserToDeleteRows = false;
            this.NVGridView.AllowUserToOrderColumns = true;
            this.NVGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NVGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tabNV_IDCol,
            this.tabNV_MaNVCol,
            this.tabNV_TenCol,
            this.tabNV_SDTCol,
            this.tabNV_BlankCol,
            this.tabNV_ViewCol,
            this.tabNV_EditCol,
            this.tabNV_DeleteCol});
            this.NVGridView.Location = new System.Drawing.Point(3, 142);
            this.NVGridView.Name = "NVGridView";
            this.NVGridView.RowHeadersVisible = false;
            this.NVGridView.RowHeadersWidth = 51;
            this.NVGridView.Size = new System.Drawing.Size(778, 421);
            this.NVGridView.TabIndex = 5;
            this.NVGridView.Text = "dataGridView1";
            this.NVGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.NVGridView_CellClick);
            this.NVGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.NVGridView_CellDoubleClick);
            this.NVGridView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.NVGridView_CellPainting);
            // 
            // tabNV_IDCol
            // 
            this.tabNV_IDCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tabNV_IDCol.HeaderText = "ID";
            this.tabNV_IDCol.MinimumWidth = 6;
            this.tabNV_IDCol.Name = "tabNV_IDCol";
            this.tabNV_IDCol.ReadOnly = true;
            this.tabNV_IDCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tabNV_IDCol.Width = 53;
            // 
            // tabNV_MaNVCol
            // 
            this.tabNV_MaNVCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tabNV_MaNVCol.HeaderText = "Mã NV";
            this.tabNV_MaNVCol.MinimumWidth = 6;
            this.tabNV_MaNVCol.Name = "tabNV_MaNVCol";
            this.tabNV_MaNVCol.ReadOnly = true;
            this.tabNV_MaNVCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tabNV_MaNVCol.Width = 83;
            // 
            // tabNV_TenCol
            // 
            this.tabNV_TenCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tabNV_TenCol.HeaderText = "Tên";
            this.tabNV_TenCol.MinimumWidth = 6;
            this.tabNV_TenCol.Name = "tabNV_TenCol";
            this.tabNV_TenCol.ReadOnly = true;
            this.tabNV_TenCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tabNV_TenCol.Width = 61;
            // 
            // tabNV_SDTCol
            // 
            this.tabNV_SDTCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tabNV_SDTCol.HeaderText = "SĐT";
            this.tabNV_SDTCol.MinimumWidth = 6;
            this.tabNV_SDTCol.Name = "tabNV_SDTCol";
            this.tabNV_SDTCol.ReadOnly = true;
            this.tabNV_SDTCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tabNV_SDTCol.Width = 65;
            // 
            // tabNV_BlankCol
            // 
            this.tabNV_BlankCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tabNV_BlankCol.HeaderText = "";
            this.tabNV_BlankCol.MinimumWidth = 6;
            this.tabNV_BlankCol.Name = "tabNV_BlankCol";
            this.tabNV_BlankCol.ReadOnly = true;
            this.tabNV_BlankCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // tabNV_ViewCol
            // 
            this.tabNV_ViewCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tabNV_ViewCol.HeaderText = "Xem";
            this.tabNV_ViewCol.MinimumWidth = 6;
            this.tabNV_ViewCol.Name = "tabNV_ViewCol";
            this.tabNV_ViewCol.ReadOnly = true;
            this.tabNV_ViewCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tabNV_ViewCol.Width = 45;
            // 
            // tabNV_EditCol
            // 
            this.tabNV_EditCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tabNV_EditCol.HeaderText = "Sửa";
            this.tabNV_EditCol.MinimumWidth = 6;
            this.tabNV_EditCol.Name = "tabNV_EditCol";
            this.tabNV_EditCol.ReadOnly = true;
            this.tabNV_EditCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tabNV_EditCol.Width = 40;
            // 
            // tabNV_DeleteCol
            // 
            this.tabNV_DeleteCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tabNV_DeleteCol.HeaderText = "Xóa";
            this.tabNV_DeleteCol.MinimumWidth = 6;
            this.tabNV_DeleteCol.Name = "tabNV_DeleteCol";
            this.tabNV_DeleteCol.ReadOnly = true;
            this.tabNV_DeleteCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tabNV_DeleteCol.Width = 41;
            // 
            // tabNV_SearchBox
            // 
            this.tabNV_SearchBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabNV_SearchBox.Location = new System.Drawing.Point(566, 24);
            this.tabNV_SearchBox.Name = "tabNV_SearchBox";
            this.tabNV_SearchBox.Size = new System.Drawing.Size(215, 32);
            this.tabNV_SearchBox.TabIndex = 4;
            this.tabNV_SearchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tabNV_SearchBox_KeyPress);
            // 
            // tabNV_CB
            // 
            this.tabNV_CB.AutoSize = true;
            this.tabNV_CB.Location = new System.Drawing.Point(5, 108);
            this.tabNV_CB.Name = "tabNV_CB";
            this.tabNV_CB.Size = new System.Drawing.Size(78, 24);
            this.tabNV_CB.TabIndex = 3;
            this.tabNV_CB.Text = "Đã xóa";
            this.tabNV_CB.UseVisualStyleBackColor = true;
            this.tabNV_CB.CheckedChanged += new System.EventHandler(this.tabNV_CB_CheckedChanged);
            // 
            // tabNV_AddBtn
            // 
            this.tabNV_AddBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabNV_AddBtn.BackgroundImage")));
            this.tabNV_AddBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabNV_AddBtn.Location = new System.Drawing.Point(735, 99);
            this.tabNV_AddBtn.Name = "tabNV_AddBtn";
            this.tabNV_AddBtn.Size = new System.Drawing.Size(46, 36);
            this.tabNV_AddBtn.TabIndex = 2;
            this.tabNV_AddBtn.UseVisualStyleBackColor = true;
            this.tabNV_AddBtn.Click += new System.EventHandler(this.tabNV_AddBtn_Click);
            // 
            // tabNV_RefreshBtn
            // 
            this.tabNV_RefreshBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabNV_RefreshBtn.BackgroundImage")));
            this.tabNV_RefreshBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabNV_RefreshBtn.Location = new System.Drawing.Point(685, 99);
            this.tabNV_RefreshBtn.Name = "tabNV_RefreshBtn";
            this.tabNV_RefreshBtn.Size = new System.Drawing.Size(46, 36);
            this.tabNV_RefreshBtn.TabIndex = 1;
            this.tabNV_RefreshBtn.UseVisualStyleBackColor = true;
            this.tabNV_RefreshBtn.Click += new System.EventHandler(this.tabNV_RefreshBtn_Click);
            // 
            // tabNV_SearchBtn
            // 
            this.tabNV_SearchBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabNV_SearchBtn.BackgroundImage")));
            this.tabNV_SearchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabNV_SearchBtn.Location = new System.Drawing.Point(635, 99);
            this.tabNV_SearchBtn.Name = "tabNV_SearchBtn";
            this.tabNV_SearchBtn.Size = new System.Drawing.Size(46, 36);
            this.tabNV_SearchBtn.TabIndex = 0;
            this.tabNV_SearchBtn.UseVisualStyleBackColor = true;
            this.tabNV_SearchBtn.Click += new System.EventHandler(this.tabNV_SearchBtn_Click);
            // 
            // tabPassenger
            // 
            this.tabPassenger.Controls.Add(this.label7);
            this.tabPassenger.Controls.Add(this.tabHanhKhach_SearchOption);
            this.tabPassenger.Controls.Add(this.HanhKhachGridView);
            this.tabPassenger.Controls.Add(this.tabHanhKhach_CB);
            this.tabPassenger.Controls.Add(this.tabHanhKhach_SearchBox);
            this.tabPassenger.Controls.Add(this.tabHanhKhach_RefreshBtn);
            this.tabPassenger.Controls.Add(this.tabHanhKhach_AddBtn);
            this.tabPassenger.Controls.Add(this.tabHanhKhach_SearchBtn);
            this.tabPassenger.Location = new System.Drawing.Point(4, 29);
            this.tabPassenger.Name = "tabPassenger";
            this.tabPassenger.Size = new System.Drawing.Size(784, 568);
            this.tabPassenger.TabIndex = 6;
            this.tabPassenger.Text = "Hành khách";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(333, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Tìm theo";
            // 
            // tabHanhKhach_SearchOption
            // 
            this.tabHanhKhach_SearchOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tabHanhKhach_SearchOption.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabHanhKhach_SearchOption.FormattingEnabled = true;
            this.tabHanhKhach_SearchOption.Items.AddRange(new object[] {
            "ID",
            "Mã khách",
            "Tên",
            "SĐT",
            "Email",
            "CMND",
            "Địa chỉ ",
            "Giới tính",
            "Passport"});
            this.tabHanhKhach_SearchOption.Location = new System.Drawing.Point(407, 24);
            this.tabHanhKhach_SearchOption.Name = "tabHanhKhach_SearchOption";
            this.tabHanhKhach_SearchOption.Size = new System.Drawing.Size(151, 33);
            this.tabHanhKhach_SearchOption.TabIndex = 6;
            // 
            // HanhKhachGridView
            // 
            this.HanhKhachGridView.AllowUserToAddRows = false;
            this.HanhKhachGridView.AllowUserToDeleteRows = false;
            this.HanhKhachGridView.AllowUserToOrderColumns = true;
            this.HanhKhachGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HanhKhachGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tabHanhKhach_IDCol,
            this.tabHanhKhach_MaKhachCol,
            this.tabHanhKhach_TenCol,
            this.tabHanhKhach_SDTCol,
            this.tabHanhKhach_EmailCol,
            this.tabHanhKhach_CMNDCol,
            this.tabHanhKhach_DiachiCol,
            this.tabHanhKhach_GioitinhCol,
            this.tabHanhKhach_PassportCol,
            this.tabHanhKhach_ViewCol,
            this.tabHanhKhach_EditCol,
            this.tabHanhKhach_DeleteCol});
            this.HanhKhachGridView.Location = new System.Drawing.Point(3, 142);
            this.HanhKhachGridView.Name = "HanhKhachGridView";
            this.HanhKhachGridView.RowHeadersVisible = false;
            this.HanhKhachGridView.RowHeadersWidth = 51;
            this.HanhKhachGridView.Size = new System.Drawing.Size(778, 421);
            this.HanhKhachGridView.TabIndex = 5;
            this.HanhKhachGridView.Text = "dataGridView1";
            this.HanhKhachGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.HanhKhachGridView_CellClick);
            this.HanhKhachGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.HanhKhachGridView_CellDoubleClick);
            this.HanhKhachGridView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.HanhKhachGridView_CellPainting);
            // 
            // tabHanhKhach_IDCol
            // 
            this.tabHanhKhach_IDCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tabHanhKhach_IDCol.HeaderText = "ID";
            this.tabHanhKhach_IDCol.MinimumWidth = 6;
            this.tabHanhKhach_IDCol.Name = "tabHanhKhach_IDCol";
            this.tabHanhKhach_IDCol.ReadOnly = true;
            this.tabHanhKhach_IDCol.Width = 53;
            // 
            // tabHanhKhach_MaKhachCol
            // 
            this.tabHanhKhach_MaKhachCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tabHanhKhach_MaKhachCol.HeaderText = "Mã khách";
            this.tabHanhKhach_MaKhachCol.MinimumWidth = 6;
            this.tabHanhKhach_MaKhachCol.Name = "tabHanhKhach_MaKhachCol";
            this.tabHanhKhach_MaKhachCol.ReadOnly = true;
            this.tabHanhKhach_MaKhachCol.Width = 101;
            // 
            // tabHanhKhach_TenCol
            // 
            this.tabHanhKhach_TenCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tabHanhKhach_TenCol.HeaderText = "Tên";
            this.tabHanhKhach_TenCol.MinimumWidth = 6;
            this.tabHanhKhach_TenCol.Name = "tabHanhKhach_TenCol";
            this.tabHanhKhach_TenCol.ReadOnly = true;
            this.tabHanhKhach_TenCol.Width = 61;
            // 
            // tabHanhKhach_SDTCol
            // 
            this.tabHanhKhach_SDTCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tabHanhKhach_SDTCol.HeaderText = "SĐT";
            this.tabHanhKhach_SDTCol.MinimumWidth = 6;
            this.tabHanhKhach_SDTCol.Name = "tabHanhKhach_SDTCol";
            this.tabHanhKhach_SDTCol.ReadOnly = true;
            this.tabHanhKhach_SDTCol.Width = 65;
            // 
            // tabHanhKhach_EmailCol
            // 
            this.tabHanhKhach_EmailCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tabHanhKhach_EmailCol.HeaderText = "Email";
            this.tabHanhKhach_EmailCol.MinimumWidth = 6;
            this.tabHanhKhach_EmailCol.Name = "tabHanhKhach_EmailCol";
            this.tabHanhKhach_EmailCol.ReadOnly = true;
            this.tabHanhKhach_EmailCol.Width = 75;
            // 
            // tabHanhKhach_CMNDCol
            // 
            this.tabHanhKhach_CMNDCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tabHanhKhach_CMNDCol.HeaderText = "CMND";
            this.tabHanhKhach_CMNDCol.MinimumWidth = 6;
            this.tabHanhKhach_CMNDCol.Name = "tabHanhKhach_CMNDCol";
            this.tabHanhKhach_CMNDCol.ReadOnly = true;
            this.tabHanhKhach_CMNDCol.Width = 82;
            // 
            // tabHanhKhach_DiachiCol
            // 
            this.tabHanhKhach_DiachiCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tabHanhKhach_DiachiCol.HeaderText = "Địa chỉ";
            this.tabHanhKhach_DiachiCol.MinimumWidth = 6;
            this.tabHanhKhach_DiachiCol.Name = "tabHanhKhach_DiachiCol";
            this.tabHanhKhach_DiachiCol.ReadOnly = true;
            this.tabHanhKhach_DiachiCol.Width = 84;
            // 
            // tabHanhKhach_GioitinhCol
            // 
            this.tabHanhKhach_GioitinhCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tabHanhKhach_GioitinhCol.HeaderText = "Giới tính";
            this.tabHanhKhach_GioitinhCol.MinimumWidth = 6;
            this.tabHanhKhach_GioitinhCol.Name = "tabHanhKhach_GioitinhCol";
            this.tabHanhKhach_GioitinhCol.ReadOnly = true;
            this.tabHanhKhach_GioitinhCol.Width = 94;
            // 
            // tabHanhKhach_PassportCol
            // 
            this.tabHanhKhach_PassportCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tabHanhKhach_PassportCol.HeaderText = "Passport";
            this.tabHanhKhach_PassportCol.MinimumWidth = 6;
            this.tabHanhKhach_PassportCol.Name = "tabHanhKhach_PassportCol";
            this.tabHanhKhach_PassportCol.ReadOnly = true;
            this.tabHanhKhach_PassportCol.Width = 93;
            // 
            // tabHanhKhach_ViewCol
            // 
            this.tabHanhKhach_ViewCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tabHanhKhach_ViewCol.HeaderText = "Xem";
            this.tabHanhKhach_ViewCol.MinimumWidth = 6;
            this.tabHanhKhach_ViewCol.Name = "tabHanhKhach_ViewCol";
            this.tabHanhKhach_ViewCol.ReadOnly = true;
            this.tabHanhKhach_ViewCol.Width = 45;
            // 
            // tabHanhKhach_EditCol
            // 
            this.tabHanhKhach_EditCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tabHanhKhach_EditCol.HeaderText = "Sửa";
            this.tabHanhKhach_EditCol.MinimumWidth = 6;
            this.tabHanhKhach_EditCol.Name = "tabHanhKhach_EditCol";
            this.tabHanhKhach_EditCol.ReadOnly = true;
            this.tabHanhKhach_EditCol.Width = 40;
            // 
            // tabHanhKhach_DeleteCol
            // 
            this.tabHanhKhach_DeleteCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tabHanhKhach_DeleteCol.HeaderText = "Xóa";
            this.tabHanhKhach_DeleteCol.MinimumWidth = 6;
            this.tabHanhKhach_DeleteCol.Name = "tabHanhKhach_DeleteCol";
            this.tabHanhKhach_DeleteCol.ReadOnly = true;
            this.tabHanhKhach_DeleteCol.Width = 41;
            // 
            // tabHanhKhach_CB
            // 
            this.tabHanhKhach_CB.AutoSize = true;
            this.tabHanhKhach_CB.Location = new System.Drawing.Point(5, 108);
            this.tabHanhKhach_CB.Name = "tabHanhKhach_CB";
            this.tabHanhKhach_CB.Size = new System.Drawing.Size(78, 24);
            this.tabHanhKhach_CB.TabIndex = 4;
            this.tabHanhKhach_CB.Text = "Đã xóa";
            this.tabHanhKhach_CB.UseVisualStyleBackColor = true;
            this.tabHanhKhach_CB.CheckedChanged += new System.EventHandler(this.tabHanhKhach_CB_CheckedChanged);
            // 
            // tabHanhKhach_SearchBox
            // 
            this.tabHanhKhach_SearchBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabHanhKhach_SearchBox.Location = new System.Drawing.Point(566, 24);
            this.tabHanhKhach_SearchBox.Name = "tabHanhKhach_SearchBox";
            this.tabHanhKhach_SearchBox.Size = new System.Drawing.Size(215, 32);
            this.tabHanhKhach_SearchBox.TabIndex = 3;
            this.tabHanhKhach_SearchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tabHanhKhach_SearchBox_KeyPress);
            // 
            // tabHanhKhach_RefreshBtn
            // 
            this.tabHanhKhach_RefreshBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabHanhKhach_RefreshBtn.BackgroundImage")));
            this.tabHanhKhach_RefreshBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabHanhKhach_RefreshBtn.Location = new System.Drawing.Point(685, 99);
            this.tabHanhKhach_RefreshBtn.Name = "tabHanhKhach_RefreshBtn";
            this.tabHanhKhach_RefreshBtn.Size = new System.Drawing.Size(46, 36);
            this.tabHanhKhach_RefreshBtn.TabIndex = 2;
            this.tabHanhKhach_RefreshBtn.UseVisualStyleBackColor = true;
            this.tabHanhKhach_RefreshBtn.Click += new System.EventHandler(this.tabHanhKhach_RefreshBtn_Click);
            // 
            // tabHanhKhach_AddBtn
            // 
            this.tabHanhKhach_AddBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabHanhKhach_AddBtn.BackgroundImage")));
            this.tabHanhKhach_AddBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabHanhKhach_AddBtn.Location = new System.Drawing.Point(735, 99);
            this.tabHanhKhach_AddBtn.Name = "tabHanhKhach_AddBtn";
            this.tabHanhKhach_AddBtn.Size = new System.Drawing.Size(46, 36);
            this.tabHanhKhach_AddBtn.TabIndex = 1;
            this.tabHanhKhach_AddBtn.UseVisualStyleBackColor = true;
            this.tabHanhKhach_AddBtn.Click += new System.EventHandler(this.tabHanhKhach_AddBtn_Click);
            // 
            // tabHanhKhach_SearchBtn
            // 
            this.tabHanhKhach_SearchBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabHanhKhach_SearchBtn.BackgroundImage")));
            this.tabHanhKhach_SearchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabHanhKhach_SearchBtn.Location = new System.Drawing.Point(635, 99);
            this.tabHanhKhach_SearchBtn.Name = "tabHanhKhach_SearchBtn";
            this.tabHanhKhach_SearchBtn.Size = new System.Drawing.Size(46, 36);
            this.tabHanhKhach_SearchBtn.TabIndex = 0;
            this.tabHanhKhach_SearchBtn.UseVisualStyleBackColor = true;
            this.tabHanhKhach_SearchBtn.Click += new System.EventHandler(this.tabHanhKhach_SearchBtn_Click);
            // 
            // tabGroup
            // 
            this.tabGroup.Controls.Add(this.label8);
            this.tabGroup.Controls.Add(this.tabDoan_SearchOption);
            this.tabGroup.Controls.Add(this.DoanGridView);
            this.tabGroup.Controls.Add(this.tabDoan_SearchBox);
            this.tabGroup.Controls.Add(this.tabDoan_CB);
            this.tabGroup.Controls.Add(this.tabDoan_AddBtn);
            this.tabGroup.Controls.Add(this.tabDoan_RefreshBtn);
            this.tabGroup.Controls.Add(this.tabDoan_SearchBtn);
            this.tabGroup.Location = new System.Drawing.Point(4, 29);
            this.tabGroup.Name = "tabGroup";
            this.tabGroup.Size = new System.Drawing.Size(784, 568);
            this.tabGroup.TabIndex = 3;
            this.tabGroup.Text = "Đoàn";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(333, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Tìm theo";
            // 
            // tabDoan_SearchOption
            // 
            this.tabDoan_SearchOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tabDoan_SearchOption.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabDoan_SearchOption.FormattingEnabled = true;
            this.tabDoan_SearchOption.Items.AddRange(new object[] {
            "ID",
            "Mã Đoàn",
            "Tên Đoàn",
            "Chi tiết",
            "Tình trạng",
            "Tour ID",
            "Mã Tour"});
            this.tabDoan_SearchOption.Location = new System.Drawing.Point(407, 24);
            this.tabDoan_SearchOption.Name = "tabDoan_SearchOption";
            this.tabDoan_SearchOption.Size = new System.Drawing.Size(151, 33);
            this.tabDoan_SearchOption.TabIndex = 6;
            // 
            // DoanGridView
            // 
            this.DoanGridView.AllowUserToAddRows = false;
            this.DoanGridView.AllowUserToDeleteRows = false;
            this.DoanGridView.AllowUserToOrderColumns = true;
            this.DoanGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DoanGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tabDoan_IDCol,
            this.tabDoan_MaDoanCol,
            this.tabDoan_TenCol,
            this.tabDoan_ChitietCol,
            this.tabDoan_StatusCol,
            this.tabDoan_TourIDCol,
            this.tabDoan_MaTourCol,
            this.tabDoan_ViewCol,
            this.tabDoan_EditCol,
            this.tabDoan_DeleteCol});
            this.DoanGridView.Location = new System.Drawing.Point(3, 142);
            this.DoanGridView.Name = "DoanGridView";
            this.DoanGridView.RowHeadersVisible = false;
            this.DoanGridView.RowHeadersWidth = 51;
            this.DoanGridView.Size = new System.Drawing.Size(778, 421);
            this.DoanGridView.TabIndex = 5;
            this.DoanGridView.Text = "dataGridView1";
            this.DoanGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.doanGridview_CellClick);
            this.DoanGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.doanGridview_CellDoubleClick);
            this.DoanGridView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.doanGridview_CellPainting);
            // 
            // tabDoan_IDCol
            // 
            this.tabDoan_IDCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tabDoan_IDCol.HeaderText = "ID";
            this.tabDoan_IDCol.MinimumWidth = 6;
            this.tabDoan_IDCol.Name = "tabDoan_IDCol";
            this.tabDoan_IDCol.ReadOnly = true;
            this.tabDoan_IDCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tabDoan_IDCol.Width = 53;
            // 
            // tabDoan_MaDoanCol
            // 
            this.tabDoan_MaDoanCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tabDoan_MaDoanCol.HeaderText = "Mã Đoàn";
            this.tabDoan_MaDoanCol.MinimumWidth = 6;
            this.tabDoan_MaDoanCol.Name = "tabDoan_MaDoanCol";
            this.tabDoan_MaDoanCol.ReadOnly = true;
            this.tabDoan_MaDoanCol.Width = 99;
            // 
            // tabDoan_TenCol
            // 
            this.tabDoan_TenCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tabDoan_TenCol.HeaderText = "Tên Đoàn";
            this.tabDoan_TenCol.MinimumWidth = 6;
            this.tabDoan_TenCol.Name = "tabDoan_TenCol";
            this.tabDoan_TenCol.ReadOnly = true;
            this.tabDoan_TenCol.Width = 101;
            // 
            // tabDoan_ChitietCol
            // 
            this.tabDoan_ChitietCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.tabDoan_ChitietCol.HeaderText = "Chi tiết";
            this.tabDoan_ChitietCol.MinimumWidth = 6;
            this.tabDoan_ChitietCol.Name = "tabDoan_ChitietCol";
            this.tabDoan_ChitietCol.ReadOnly = true;
            this.tabDoan_ChitietCol.Width = 125;
            // 
            // tabDoan_StatusCol
            // 
            this.tabDoan_StatusCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tabDoan_StatusCol.HeaderText = "Tình trạng";
            this.tabDoan_StatusCol.MinimumWidth = 6;
            this.tabDoan_StatusCol.Name = "tabDoan_StatusCol";
            this.tabDoan_StatusCol.ReadOnly = true;
            this.tabDoan_StatusCol.Width = 105;
            // 
            // tabDoan_TourIDCol
            // 
            this.tabDoan_TourIDCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tabDoan_TourIDCol.HeaderText = "Tour ID";
            this.tabDoan_TourIDCol.MinimumWidth = 6;
            this.tabDoan_TourIDCol.Name = "tabDoan_TourIDCol";
            this.tabDoan_TourIDCol.ReadOnly = true;
            this.tabDoan_TourIDCol.Width = 86;
            // 
            // tabDoan_MaTourCol
            // 
            this.tabDoan_MaTourCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tabDoan_MaTourCol.HeaderText = "Mã Tour";
            this.tabDoan_MaTourCol.MinimumWidth = 6;
            this.tabDoan_MaTourCol.Name = "tabDoan_MaTourCol";
            this.tabDoan_MaTourCol.ReadOnly = true;
            this.tabDoan_MaTourCol.Width = 92;
            // 
            // tabDoan_ViewCol
            // 
            this.tabDoan_ViewCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tabDoan_ViewCol.HeaderText = "Xem";
            this.tabDoan_ViewCol.MinimumWidth = 6;
            this.tabDoan_ViewCol.Name = "tabDoan_ViewCol";
            this.tabDoan_ViewCol.ReadOnly = true;
            this.tabDoan_ViewCol.Width = 45;
            // 
            // tabDoan_EditCol
            // 
            this.tabDoan_EditCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tabDoan_EditCol.HeaderText = "Sửa";
            this.tabDoan_EditCol.MinimumWidth = 6;
            this.tabDoan_EditCol.Name = "tabDoan_EditCol";
            this.tabDoan_EditCol.ReadOnly = true;
            this.tabDoan_EditCol.Width = 40;
            // 
            // tabDoan_DeleteCol
            // 
            this.tabDoan_DeleteCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tabDoan_DeleteCol.HeaderText = "Xóa";
            this.tabDoan_DeleteCol.MinimumWidth = 6;
            this.tabDoan_DeleteCol.Name = "tabDoan_DeleteCol";
            this.tabDoan_DeleteCol.ReadOnly = true;
            this.tabDoan_DeleteCol.Width = 41;
            // 
            // tabDoan_SearchBox
            // 
            this.tabDoan_SearchBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabDoan_SearchBox.Location = new System.Drawing.Point(566, 24);
            this.tabDoan_SearchBox.Name = "tabDoan_SearchBox";
            this.tabDoan_SearchBox.Size = new System.Drawing.Size(215, 32);
            this.tabDoan_SearchBox.TabIndex = 4;
            this.tabDoan_SearchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tabDoan_SearchBox_KeyPress);
            // 
            // tabDoan_CB
            // 
            this.tabDoan_CB.AutoSize = true;
            this.tabDoan_CB.Location = new System.Drawing.Point(5, 108);
            this.tabDoan_CB.Name = "tabDoan_CB";
            this.tabDoan_CB.Size = new System.Drawing.Size(78, 24);
            this.tabDoan_CB.TabIndex = 3;
            this.tabDoan_CB.Text = "Đã xóa";
            this.tabDoan_CB.UseVisualStyleBackColor = true;
            this.tabDoan_CB.CheckedChanged += new System.EventHandler(this.tabDoan_CB_CheckedChanged);
            // 
            // tabDoan_AddBtn
            // 
            this.tabDoan_AddBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabDoan_AddBtn.BackgroundImage")));
            this.tabDoan_AddBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabDoan_AddBtn.Location = new System.Drawing.Point(735, 99);
            this.tabDoan_AddBtn.Name = "tabDoan_AddBtn";
            this.tabDoan_AddBtn.Size = new System.Drawing.Size(46, 36);
            this.tabDoan_AddBtn.TabIndex = 2;
            this.tabDoan_AddBtn.UseVisualStyleBackColor = true;
            this.tabDoan_AddBtn.Click += new System.EventHandler(this.tabDoan_AddBtn_Click);
            // 
            // tabDoan_RefreshBtn
            // 
            this.tabDoan_RefreshBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabDoan_RefreshBtn.BackgroundImage")));
            this.tabDoan_RefreshBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabDoan_RefreshBtn.Location = new System.Drawing.Point(685, 99);
            this.tabDoan_RefreshBtn.Name = "tabDoan_RefreshBtn";
            this.tabDoan_RefreshBtn.Size = new System.Drawing.Size(46, 36);
            this.tabDoan_RefreshBtn.TabIndex = 1;
            this.tabDoan_RefreshBtn.UseVisualStyleBackColor = true;
            this.tabDoan_RefreshBtn.Click += new System.EventHandler(this.tabDoan_RefreshBtn_Click);
            // 
            // tabDoan_SearchBtn
            // 
            this.tabDoan_SearchBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabDoan_SearchBtn.BackgroundImage")));
            this.tabDoan_SearchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabDoan_SearchBtn.Location = new System.Drawing.Point(635, 99);
            this.tabDoan_SearchBtn.Name = "tabDoan_SearchBtn";
            this.tabDoan_SearchBtn.Size = new System.Drawing.Size(46, 36);
            this.tabDoan_SearchBtn.TabIndex = 0;
            this.tabDoan_SearchBtn.UseVisualStyleBackColor = true;
            this.tabDoan_SearchBtn.Click += new System.EventHandler(this.tabDoan_SearchBtn_Click);
            // 
            // tabCT
            // 
            this.tabCT.Controls.Add(this.tabCT_SearchOption);
            this.tabCT.Controls.Add(this.label9);
            this.tabCT.Controls.Add(this.ChiTieuGridView);
            this.tabCT.Controls.Add(this.tabCT_SearchBox);
            this.tabCT.Controls.Add(this.tabCT_RefreshBtn);
            this.tabCT.Controls.Add(this.tabCT_AddBtn);
            this.tabCT.Controls.Add(this.tabCT_SearchBtn);
            this.tabCT.Location = new System.Drawing.Point(4, 29);
            this.tabCT.Name = "tabCT";
            this.tabCT.Size = new System.Drawing.Size(784, 568);
            this.tabCT.TabIndex = 4;
            this.tabCT.Text = "Chi tiêu";
            // 
            // tabCT_SearchOption
            // 
            this.tabCT_SearchOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tabCT_SearchOption.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabCT_SearchOption.FormattingEnabled = true;
            this.tabCT_SearchOption.Items.AddRange(new object[] {
            "ID",
            "Tên chỉ tiêu"});
            this.tabCT_SearchOption.Location = new System.Drawing.Point(407, 24);
            this.tabCT_SearchOption.Name = "tabCT_SearchOption";
            this.tabCT_SearchOption.Size = new System.Drawing.Size(151, 33);
            this.tabCT_SearchOption.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(333, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "Tìm theo";
            // 
            // ChiTieuGridView
            // 
            this.ChiTieuGridView.AllowUserToAddRows = false;
            this.ChiTieuGridView.AllowUserToDeleteRows = false;
            this.ChiTieuGridView.AllowUserToOrderColumns = true;
            this.ChiTieuGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ChiTieuGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tabCT_IDCol,
            this.tabCT_TenCol,
            this.tabCT_BlankCol,
            this.tabCT_ViewCol,
            this.tabCT_EditCol,
            this.tabCT_DeleteCol});
            this.ChiTieuGridView.Location = new System.Drawing.Point(3, 142);
            this.ChiTieuGridView.Name = "ChiTieuGridView";
            this.ChiTieuGridView.RowHeadersVisible = false;
            this.ChiTieuGridView.RowHeadersWidth = 51;
            this.ChiTieuGridView.Size = new System.Drawing.Size(778, 421);
            this.ChiTieuGridView.TabIndex = 5;
            this.ChiTieuGridView.Text = "dataGridView1";
            this.ChiTieuGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ChiTieuGridView_CellClick);
            this.ChiTieuGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ChiTieuGridView_CellDoubleClick);
            this.ChiTieuGridView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.ChiTieuGridView_CellPainting);
            // 
            // tabCT_IDCol
            // 
            this.tabCT_IDCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tabCT_IDCol.HeaderText = "ID";
            this.tabCT_IDCol.MinimumWidth = 6;
            this.tabCT_IDCol.Name = "tabCT_IDCol";
            this.tabCT_IDCol.ReadOnly = true;
            this.tabCT_IDCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tabCT_IDCol.Width = 53;
            // 
            // tabCT_TenCol
            // 
            this.tabCT_TenCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tabCT_TenCol.HeaderText = "Tên chỉ tiêu";
            this.tabCT_TenCol.MinimumWidth = 6;
            this.tabCT_TenCol.Name = "tabCT_TenCol";
            this.tabCT_TenCol.ReadOnly = true;
            this.tabCT_TenCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tabCT_TenCol.Width = 113;
            // 
            // tabCT_BlankCol
            // 
            this.tabCT_BlankCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tabCT_BlankCol.HeaderText = "";
            this.tabCT_BlankCol.MinimumWidth = 6;
            this.tabCT_BlankCol.Name = "tabCT_BlankCol";
            this.tabCT_BlankCol.ReadOnly = true;
            this.tabCT_BlankCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // tabCT_ViewCol
            // 
            this.tabCT_ViewCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tabCT_ViewCol.HeaderText = "Xem";
            this.tabCT_ViewCol.MinimumWidth = 6;
            this.tabCT_ViewCol.Name = "tabCT_ViewCol";
            this.tabCT_ViewCol.ReadOnly = true;
            this.tabCT_ViewCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tabCT_ViewCol.Width = 45;
            // 
            // tabCT_EditCol
            // 
            this.tabCT_EditCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tabCT_EditCol.HeaderText = "Sửa";
            this.tabCT_EditCol.MinimumWidth = 6;
            this.tabCT_EditCol.Name = "tabCT_EditCol";
            this.tabCT_EditCol.ReadOnly = true;
            this.tabCT_EditCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tabCT_EditCol.Width = 40;
            // 
            // tabCT_DeleteCol
            // 
            this.tabCT_DeleteCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tabCT_DeleteCol.HeaderText = "Xóa";
            this.tabCT_DeleteCol.MinimumWidth = 6;
            this.tabCT_DeleteCol.Name = "tabCT_DeleteCol";
            this.tabCT_DeleteCol.ReadOnly = true;
            this.tabCT_DeleteCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tabCT_DeleteCol.Width = 41;
            // 
            // tabCT_SearchBox
            // 
            this.tabCT_SearchBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabCT_SearchBox.Location = new System.Drawing.Point(566, 24);
            this.tabCT_SearchBox.Name = "tabCT_SearchBox";
            this.tabCT_SearchBox.Size = new System.Drawing.Size(215, 32);
            this.tabCT_SearchBox.TabIndex = 3;
            this.tabCT_SearchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tabCT_SearchBox_KeyPress);
            // 
            // tabCT_RefreshBtn
            // 
            this.tabCT_RefreshBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabCT_RefreshBtn.BackgroundImage")));
            this.tabCT_RefreshBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabCT_RefreshBtn.Location = new System.Drawing.Point(685, 99);
            this.tabCT_RefreshBtn.Name = "tabCT_RefreshBtn";
            this.tabCT_RefreshBtn.Size = new System.Drawing.Size(46, 36);
            this.tabCT_RefreshBtn.TabIndex = 2;
            this.tabCT_RefreshBtn.UseVisualStyleBackColor = true;
            this.tabCT_RefreshBtn.Click += new System.EventHandler(this.tabCT_RefreshBtn_Click);
            // 
            // tabCT_AddBtn
            // 
            this.tabCT_AddBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabCT_AddBtn.BackgroundImage")));
            this.tabCT_AddBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabCT_AddBtn.Location = new System.Drawing.Point(735, 99);
            this.tabCT_AddBtn.Name = "tabCT_AddBtn";
            this.tabCT_AddBtn.Size = new System.Drawing.Size(46, 36);
            this.tabCT_AddBtn.TabIndex = 1;
            this.tabCT_AddBtn.UseVisualStyleBackColor = true;
            this.tabCT_AddBtn.Click += new System.EventHandler(this.tabCT_AddBtn_Click);
            // 
            // tabCT_SearchBtn
            // 
            this.tabCT_SearchBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabCT_SearchBtn.BackgroundImage")));
            this.tabCT_SearchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabCT_SearchBtn.Location = new System.Drawing.Point(635, 99);
            this.tabCT_SearchBtn.Name = "tabCT_SearchBtn";
            this.tabCT_SearchBtn.Size = new System.Drawing.Size(46, 36);
            this.tabCT_SearchBtn.TabIndex = 0;
            this.tabCT_SearchBtn.UseVisualStyleBackColor = true;
            this.tabCT_SearchBtn.Click += new System.EventHandler(this.tabCT_SearchBtn_Click);
            // 
            // tabDestination
            // 
            this.tabDestination.Controls.Add(this.DiaDiemGridView);
            this.tabDestination.Controls.Add(this.tabDD_AddBtn);
            this.tabDestination.Controls.Add(this.tabDD_RefreshBtn);
            this.tabDestination.Controls.Add(this.tabDD_SearchBtn);
            this.tabDestination.Controls.Add(this.tabDD_SearchBox);
            this.tabDestination.Controls.Add(this.tabDD_SearchOption);
            this.tabDestination.Controls.Add(this.label10);
            this.tabDestination.Location = new System.Drawing.Point(4, 29);
            this.tabDestination.Name = "tabDestination";
            this.tabDestination.Padding = new System.Windows.Forms.Padding(3);
            this.tabDestination.Size = new System.Drawing.Size(784, 568);
            this.tabDestination.TabIndex = 2;
            this.tabDestination.Text = "Địa điểm";
            this.tabDestination.UseVisualStyleBackColor = true;
            // 
            // DiaDiemGridView
            // 
            this.DiaDiemGridView.AllowUserToAddRows = false;
            this.DiaDiemGridView.AllowUserToDeleteRows = false;
            this.DiaDiemGridView.AllowUserToOrderColumns = true;
            this.DiaDiemGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DiaDiemGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tabDD_IDCol,
            this.tabDD_TenCol,
            this.tabDD_BlankCol,
            this.tabDD_ViewCol,
            this.tabDD_EditCol,
            this.tabDD_DeleteCol});
            this.DiaDiemGridView.Location = new System.Drawing.Point(3, 142);
            this.DiaDiemGridView.Name = "DiaDiemGridView";
            this.DiaDiemGridView.RowHeadersVisible = false;
            this.DiaDiemGridView.RowHeadersWidth = 51;
            this.DiaDiemGridView.Size = new System.Drawing.Size(778, 421);
            this.DiaDiemGridView.TabIndex = 6;
            this.DiaDiemGridView.Text = "dataGridView1";
            this.DiaDiemGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DiaDiemGridView_CellClick);
            this.DiaDiemGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DiaDiemGridView_CellDoubleClick);
            this.DiaDiemGridView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.DiaDiemGridView_CellPainting);
            // 
            // tabDD_IDCol
            // 
            this.tabDD_IDCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tabDD_IDCol.HeaderText = "ID";
            this.tabDD_IDCol.MinimumWidth = 6;
            this.tabDD_IDCol.Name = "tabDD_IDCol";
            this.tabDD_IDCol.ReadOnly = true;
            this.tabDD_IDCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tabDD_IDCol.Width = 53;
            // 
            // tabDD_TenCol
            // 
            this.tabDD_TenCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tabDD_TenCol.HeaderText = "Tên địa điểm";
            this.tabDD_TenCol.MinimumWidth = 6;
            this.tabDD_TenCol.Name = "tabDD_TenCol";
            this.tabDD_TenCol.ReadOnly = true;
            this.tabDD_TenCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tabDD_TenCol.Width = 124;
            // 
            // tabDD_BlankCol
            // 
            this.tabDD_BlankCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tabDD_BlankCol.HeaderText = "";
            this.tabDD_BlankCol.MinimumWidth = 6;
            this.tabDD_BlankCol.Name = "tabDD_BlankCol";
            this.tabDD_BlankCol.ReadOnly = true;
            this.tabDD_BlankCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // tabDD_ViewCol
            // 
            this.tabDD_ViewCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tabDD_ViewCol.HeaderText = "Xem";
            this.tabDD_ViewCol.MinimumWidth = 6;
            this.tabDD_ViewCol.Name = "tabDD_ViewCol";
            this.tabDD_ViewCol.ReadOnly = true;
            this.tabDD_ViewCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tabDD_ViewCol.Width = 45;
            // 
            // tabDD_EditCol
            // 
            this.tabDD_EditCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tabDD_EditCol.HeaderText = "Sửa";
            this.tabDD_EditCol.MinimumWidth = 6;
            this.tabDD_EditCol.Name = "tabDD_EditCol";
            this.tabDD_EditCol.ReadOnly = true;
            this.tabDD_EditCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tabDD_EditCol.Width = 40;
            // 
            // tabDD_DeleteCol
            // 
            this.tabDD_DeleteCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tabDD_DeleteCol.HeaderText = "Xóa";
            this.tabDD_DeleteCol.MinimumWidth = 6;
            this.tabDD_DeleteCol.Name = "tabDD_DeleteCol";
            this.tabDD_DeleteCol.ReadOnly = true;
            this.tabDD_DeleteCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tabDD_DeleteCol.Width = 41;
            // 
            // tabDD_AddBtn
            // 
            this.tabDD_AddBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabDD_AddBtn.BackgroundImage")));
            this.tabDD_AddBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabDD_AddBtn.Location = new System.Drawing.Point(735, 99);
            this.tabDD_AddBtn.Name = "tabDD_AddBtn";
            this.tabDD_AddBtn.Size = new System.Drawing.Size(46, 36);
            this.tabDD_AddBtn.TabIndex = 5;
            this.tabDD_AddBtn.UseVisualStyleBackColor = true;
            this.tabDD_AddBtn.Click += new System.EventHandler(this.tabDD_AddBtn_Click);
            // 
            // tabDD_RefreshBtn
            // 
            this.tabDD_RefreshBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabDD_RefreshBtn.BackgroundImage")));
            this.tabDD_RefreshBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabDD_RefreshBtn.Location = new System.Drawing.Point(685, 99);
            this.tabDD_RefreshBtn.Name = "tabDD_RefreshBtn";
            this.tabDD_RefreshBtn.Size = new System.Drawing.Size(46, 36);
            this.tabDD_RefreshBtn.TabIndex = 4;
            this.tabDD_RefreshBtn.UseVisualStyleBackColor = true;
            this.tabDD_RefreshBtn.Click += new System.EventHandler(this.tabDD_RefreshBtn_Click);
            // 
            // tabDD_SearchBtn
            // 
            this.tabDD_SearchBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabDD_SearchBtn.BackgroundImage")));
            this.tabDD_SearchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabDD_SearchBtn.Location = new System.Drawing.Point(635, 99);
            this.tabDD_SearchBtn.Name = "tabDD_SearchBtn";
            this.tabDD_SearchBtn.Size = new System.Drawing.Size(46, 36);
            this.tabDD_SearchBtn.TabIndex = 3;
            this.tabDD_SearchBtn.UseVisualStyleBackColor = true;
            this.tabDD_SearchBtn.Click += new System.EventHandler(this.tabDD_SearchBtn_Click);
            // 
            // tabDD_SearchBox
            // 
            this.tabDD_SearchBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabDD_SearchBox.Location = new System.Drawing.Point(566, 24);
            this.tabDD_SearchBox.Name = "tabDD_SearchBox";
            this.tabDD_SearchBox.Size = new System.Drawing.Size(215, 32);
            this.tabDD_SearchBox.TabIndex = 2;
            this.tabDD_SearchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tabDD_SearchBox_KeyPress);
            // 
            // tabDD_SearchOption
            // 
            this.tabDD_SearchOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tabDD_SearchOption.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabDD_SearchOption.FormattingEnabled = true;
            this.tabDD_SearchOption.Items.AddRange(new object[] {
            "ID",
            "Tên địa điểm"});
            this.tabDD_SearchOption.Location = new System.Drawing.Point(407, 24);
            this.tabDD_SearchOption.Name = "tabDD_SearchOption";
            this.tabDD_SearchOption.Size = new System.Drawing.Size(151, 33);
            this.tabDD_SearchOption.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(333, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Tìm theo";
            // 
            // tabLHDL
            // 
            this.tabLHDL.Controls.Add(this.LHDLGridView);
            this.tabLHDL.Controls.Add(this.tabLHDL_SearchBox);
            this.tabLHDL.Controls.Add(this.tabLHDL_AddBtn);
            this.tabLHDL.Controls.Add(this.tabLHDL_RefreshBtn);
            this.tabLHDL.Controls.Add(this.tabLHDL_SearchBtn);
            this.tabLHDL.Controls.Add(this.tabLHDL_SearchOption);
            this.tabLHDL.Controls.Add(this.label11);
            this.tabLHDL.Location = new System.Drawing.Point(4, 29);
            this.tabLHDL.Name = "tabLHDL";
            this.tabLHDL.Size = new System.Drawing.Size(784, 568);
            this.tabLHDL.TabIndex = 5;
            this.tabLHDL.Text = "Loại hình du lịch";
            // 
            // LHDLGridView
            // 
            this.LHDLGridView.AllowUserToAddRows = false;
            this.LHDLGridView.AllowUserToDeleteRows = false;
            this.LHDLGridView.AllowUserToOrderColumns = true;
            this.LHDLGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LHDLGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tabLHDL_IDCol,
            this.tabLHDL_TenCol,
            this.tabLHDL_MotaCol,
            this.tabLHDL_BlankCol,
            this.tabLHDL_ViewCol,
            this.tabLHDL_EditCol,
            this.tabLHDL_DeleteCol});
            this.LHDLGridView.Location = new System.Drawing.Point(3, 142);
            this.LHDLGridView.Name = "LHDLGridView";
            this.LHDLGridView.RowHeadersVisible = false;
            this.LHDLGridView.RowHeadersWidth = 51;
            this.LHDLGridView.Size = new System.Drawing.Size(778, 421);
            this.LHDLGridView.TabIndex = 6;
            this.LHDLGridView.Text = "dataGridView1";
            this.LHDLGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LHDLGridView_CellClick);
            this.LHDLGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LHDLGridView_CellDoubleClick);
            this.LHDLGridView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.LHDLGridView_CellPainting);
            // 
            // tabLHDL_IDCol
            // 
            this.tabLHDL_IDCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tabLHDL_IDCol.HeaderText = "ID";
            this.tabLHDL_IDCol.MinimumWidth = 6;
            this.tabLHDL_IDCol.Name = "tabLHDL_IDCol";
            this.tabLHDL_IDCol.ReadOnly = true;
            this.tabLHDL_IDCol.Width = 53;
            // 
            // tabLHDL_TenCol
            // 
            this.tabLHDL_TenCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tabLHDL_TenCol.HeaderText = "Tên";
            this.tabLHDL_TenCol.MinimumWidth = 6;
            this.tabLHDL_TenCol.Name = "tabLHDL_TenCol";
            this.tabLHDL_TenCol.ReadOnly = true;
            this.tabLHDL_TenCol.Width = 61;
            // 
            // tabLHDL_MotaCol
            // 
            this.tabLHDL_MotaCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tabLHDL_MotaCol.HeaderText = "Mô tả";
            this.tabLHDL_MotaCol.MinimumWidth = 6;
            this.tabLHDL_MotaCol.Name = "tabLHDL_MotaCol";
            this.tabLHDL_MotaCol.ReadOnly = true;
            // 
            // tabLHDL_BlankCol
            // 
            this.tabLHDL_BlankCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tabLHDL_BlankCol.HeaderText = "";
            this.tabLHDL_BlankCol.MinimumWidth = 6;
            this.tabLHDL_BlankCol.Name = "tabLHDL_BlankCol";
            this.tabLHDL_BlankCol.ReadOnly = true;
            // 
            // tabLHDL_ViewCol
            // 
            this.tabLHDL_ViewCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tabLHDL_ViewCol.HeaderText = "Xem";
            this.tabLHDL_ViewCol.MinimumWidth = 6;
            this.tabLHDL_ViewCol.Name = "tabLHDL_ViewCol";
            this.tabLHDL_ViewCol.ReadOnly = true;
            this.tabLHDL_ViewCol.Width = 45;
            // 
            // tabLHDL_EditCol
            // 
            this.tabLHDL_EditCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tabLHDL_EditCol.HeaderText = "Sửa";
            this.tabLHDL_EditCol.MinimumWidth = 6;
            this.tabLHDL_EditCol.Name = "tabLHDL_EditCol";
            this.tabLHDL_EditCol.ReadOnly = true;
            this.tabLHDL_EditCol.Width = 40;
            // 
            // tabLHDL_DeleteCol
            // 
            this.tabLHDL_DeleteCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tabLHDL_DeleteCol.HeaderText = "Xóa";
            this.tabLHDL_DeleteCol.MinimumWidth = 6;
            this.tabLHDL_DeleteCol.Name = "tabLHDL_DeleteCol";
            this.tabLHDL_DeleteCol.ReadOnly = true;
            this.tabLHDL_DeleteCol.Width = 41;
            // 
            // tabLHDL_SearchBox
            // 
            this.tabLHDL_SearchBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabLHDL_SearchBox.Location = new System.Drawing.Point(566, 24);
            this.tabLHDL_SearchBox.Name = "tabLHDL_SearchBox";
            this.tabLHDL_SearchBox.Size = new System.Drawing.Size(215, 32);
            this.tabLHDL_SearchBox.TabIndex = 5;
            this.tabLHDL_SearchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tabLHDL_SearchBox_KeyPress);
            // 
            // tabLHDL_AddBtn
            // 
            this.tabLHDL_AddBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabLHDL_AddBtn.BackgroundImage")));
            this.tabLHDL_AddBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabLHDL_AddBtn.Location = new System.Drawing.Point(735, 99);
            this.tabLHDL_AddBtn.Name = "tabLHDL_AddBtn";
            this.tabLHDL_AddBtn.Size = new System.Drawing.Size(46, 36);
            this.tabLHDL_AddBtn.TabIndex = 4;
            this.tabLHDL_AddBtn.UseVisualStyleBackColor = true;
            this.tabLHDL_AddBtn.Click += new System.EventHandler(this.tabLHDL_AddBtn_Click);
            // 
            // tabLHDL_RefreshBtn
            // 
            this.tabLHDL_RefreshBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabLHDL_RefreshBtn.BackgroundImage")));
            this.tabLHDL_RefreshBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabLHDL_RefreshBtn.Location = new System.Drawing.Point(685, 99);
            this.tabLHDL_RefreshBtn.Name = "tabLHDL_RefreshBtn";
            this.tabLHDL_RefreshBtn.Size = new System.Drawing.Size(46, 36);
            this.tabLHDL_RefreshBtn.TabIndex = 3;
            this.tabLHDL_RefreshBtn.UseVisualStyleBackColor = true;
            this.tabLHDL_RefreshBtn.Click += new System.EventHandler(this.tabLHDL_RefreshBtn_Click);
            // 
            // tabLHDL_SearchBtn
            // 
            this.tabLHDL_SearchBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabLHDL_SearchBtn.BackgroundImage")));
            this.tabLHDL_SearchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabLHDL_SearchBtn.Location = new System.Drawing.Point(635, 99);
            this.tabLHDL_SearchBtn.Name = "tabLHDL_SearchBtn";
            this.tabLHDL_SearchBtn.Size = new System.Drawing.Size(46, 36);
            this.tabLHDL_SearchBtn.TabIndex = 2;
            this.tabLHDL_SearchBtn.UseVisualStyleBackColor = true;
            this.tabLHDL_SearchBtn.Click += new System.EventHandler(this.tabLHDL_SearchBtn_Click);
            // 
            // tabLHDL_SearchOption
            // 
            this.tabLHDL_SearchOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tabLHDL_SearchOption.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabLHDL_SearchOption.FormattingEnabled = true;
            this.tabLHDL_SearchOption.Items.AddRange(new object[] {
            "ID",
            "Tên",
            "Mô tả"});
            this.tabLHDL_SearchOption.Location = new System.Drawing.Point(407, 24);
            this.tabLHDL_SearchOption.Name = "tabLHDL_SearchOption";
            this.tabLHDL_SearchOption.Size = new System.Drawing.Size(151, 33);
            this.tabLHDL_SearchOption.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(333, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Tìm theo";
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu,
            this.SettingMenu,
            this.ToolsMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.menuStrip.Size = new System.Drawing.Size(792, 30);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menu";
            // 
            // FileMenu
            // 
            this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExportMenuBtn});
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(46, 24);
            this.FileMenu.Text = "File";
            this.FileMenu.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.FileMenu_DropDownItemClicked);
            // 
            // ExportMenuBtn
            // 
            this.ExportMenuBtn.Name = "ExportMenuBtn";
            this.ExportMenuBtn.Size = new System.Drawing.Size(191, 26);
            this.ExportMenuBtn.Text = "Export to excel";
            // 
            // SettingMenu
            // 
            this.SettingMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChangeThemeMenu});
            this.SettingMenu.Name = "SettingMenu";
            this.SettingMenu.Size = new System.Drawing.Size(70, 24);
            this.SettingMenu.Text = "Setting";
            // 
            // ChangeThemeMenu
            // 
            this.ChangeThemeMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DarkStripMenuItem,
            this.LightStripMenuItem,
            this.DefaultStripMenuItem});
            this.ChangeThemeMenu.Name = "ChangeThemeMenu";
            this.ChangeThemeMenu.Size = new System.Drawing.Size(188, 26);
            this.ChangeThemeMenu.Text = "Change theme";
            this.ChangeThemeMenu.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ChangeThemeMenu_DropDownItemClicked);
            // 
            // DarkStripMenuItem
            // 
            this.DarkStripMenuItem.CheckOnClick = true;
            this.DarkStripMenuItem.Name = "DarkStripMenuItem";
            this.DarkStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.DarkStripMenuItem.Text = "Dark ";
            // 
            // LightStripMenuItem
            // 
            this.LightStripMenuItem.CheckOnClick = true;
            this.LightStripMenuItem.Name = "LightStripMenuItem";
            this.LightStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.LightStripMenuItem.Text = "Light";
            // 
            // DefaultStripMenuItem
            // 
            this.DefaultStripMenuItem.Checked = true;
            this.DefaultStripMenuItem.CheckOnClick = true;
            this.DefaultStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DefaultStripMenuItem.Name = "DefaultStripMenuItem";
            this.DefaultStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.DefaultStripMenuItem.Text = "Default";
            // 
            // ToolsMenu
            // 
            this.ToolsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatisticMenu});
            this.ToolsMenu.Name = "ToolsMenu";
            this.ToolsMenu.Size = new System.Drawing.Size(58, 24);
            this.ToolsMenu.Text = "Tools";
            // 
            // StatisticMenu
            // 
            this.StatisticMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TKChiPhiMenu,
            this.TKDoanhThuMenu,
            this.TKTinhHinhHoatDongMenu,
            this.TKSoLanDiTourMenu});
            this.StatisticMenu.Name = "StatisticMenu";
            this.StatisticMenu.Size = new System.Drawing.Size(153, 26);
            this.StatisticMenu.Text = "Thống kê";
            // 
            // TKChiPhiMenu
            // 
            this.TKChiPhiMenu.Name = "TKChiPhiMenu";
            this.TKChiPhiMenu.Size = new System.Drawing.Size(275, 26);
            this.TKChiPhiMenu.Text = "Thống kê chi phí";
            this.TKChiPhiMenu.Click += new System.EventHandler(this.TKChiPhiMenu_Clicked);
            // 
            // TKDoanhThuMenu
            // 
            this.TKDoanhThuMenu.Name = "TKDoanhThuMenu";
            this.TKDoanhThuMenu.Size = new System.Drawing.Size(275, 26);
            this.TKDoanhThuMenu.Text = "Doanh thu";
            this.TKDoanhThuMenu.Click += new System.EventHandler(this.TKDoanhThuMenu_Clicked);
            // 
            // TKTinhHinhHoatDongMenu
            // 
            this.TKTinhHinhHoatDongMenu.Name = "TKTinhHinhHoatDongMenu";
            this.TKTinhHinhHoatDongMenu.Size = new System.Drawing.Size(275, 26);
            this.TKTinhHinhHoatDongMenu.Text = "Tình hình hoạt động";
            // 
            // TKSoLanDiTourMenu
            // 
            this.TKSoLanDiTourMenu.Name = "TKSoLanDiTourMenu";
            this.TKSoLanDiTourMenu.Size = new System.Drawing.Size(275, 26);
            this.TKSoLanDiTourMenu.Text = "Số lần đi tour của nhân viên";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "Dark",
            "Light"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 28);
            // 
            // List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(792, 637);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "List";
            this.Text = "Danh sách";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabTour.ResumeLayout(false);
            this.tabTour.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabTour_ToPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabTour_FromPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourGridView)).EndInit();
            this.tabStaff.ResumeLayout(false);
            this.tabStaff.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NVGridView)).EndInit();
            this.tabPassenger.ResumeLayout(false);
            this.tabPassenger.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HanhKhachGridView)).EndInit();
            this.tabGroup.ResumeLayout(false);
            this.tabGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DoanGridView)).EndInit();
            this.tabCT.ResumeLayout(false);
            this.tabCT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChiTieuGridView)).EndInit();
            this.tabDestination.ResumeLayout(false);
            this.tabDestination.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiaDiemGridView)).EndInit();
            this.tabLHDL.ResumeLayout(false);
            this.tabLHDL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LHDLGridView)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabTour;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.TabPage tabStaff;
        private System.Windows.Forms.TabPage tabDestination;
        private System.Windows.Forms.TabPage tabGroup;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView tourGridView;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TourIdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTourCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn LHDLCol;
        private System.Windows.Forms.DataGridViewButtonColumn ViewCol;
        private System.Windows.Forms.DataGridViewButtonColumn EditCol;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteCol;
        private System.Windows.Forms.CheckBox isDeleted_ChB;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem SettingMenu;
        private System.Windows.Forms.ToolStripMenuItem ChangeThemeMenu;
        private System.Windows.Forms.ToolStripMenuItem DarkStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LightStripMenuItem;
        private ToolStripComboBox toolStripComboBox1;
        private ToolStripMenuItem DefaultStripMenuItem;
        private TextBox tabNV_SearchBox;
        private CheckBox tabNV_CB;
        private Button tabNV_AddBtn;
        private Button tabNV_RefreshBtn;
        private Button tabNV_SearchBtn;
        private DataGridView NVGridView;
        private TabPage tabCT;
        private DataGridView ChiTieuGridView;
        private TextBox tabCT_SearchBox;
        private Button tabCT_RefreshBtn;
        private Button tabCT_AddBtn;
        private Button tabCT_SearchBtn;
        private ToolStripMenuItem FileMenu;
        private ToolStripMenuItem ExportMenuBtn;
        private TabPage tabLHDL;
        private TextBox tabDoan_SearchBox;
        private CheckBox tabDoan_CB;
        private Button tabDoan_AddBtn;
        private Button tabDoan_RefreshBtn;
        private Button tabDoan_SearchBtn;
        private TabPage tabPassenger;
        private DataGridView DoanGridView;
        private DataGridViewTextBoxColumn tabDoan_IDCol;
        private DataGridViewTextBoxColumn tabDoan_MaDoanCol;
        private DataGridViewTextBoxColumn tabDoan_TenCol;
        private DataGridViewTextBoxColumn tabDoan_ChitietCol;
        private DataGridViewTextBoxColumn tabDoan_StatusCol;
        private DataGridViewTextBoxColumn tabDoan_TourIDCol;
        private DataGridViewTextBoxColumn tabDoan_MaTourCol;
        private DataGridViewButtonColumn tabDoan_ViewCol;
        private DataGridViewButtonColumn tabDoan_EditCol;
        private DataGridViewButtonColumn tabDoan_DeleteCol;
        private DataGridViewTextBoxColumn tabNV_IDCol;
        private DataGridViewTextBoxColumn tabNV_MaNVCol;
        private DataGridViewTextBoxColumn tabNV_TenCol;
        private DataGridViewTextBoxColumn tabNV_SDTCol;
        private DataGridViewTextBoxColumn tabNV_BlankCol;
        private DataGridViewButtonColumn tabNV_ViewCol;
        private DataGridViewButtonColumn tabNV_EditCol;
        private DataGridViewButtonColumn tabNV_DeleteCol;
        private DataGridViewTextBoxColumn tabCT_IDCol;
        private DataGridViewTextBoxColumn tabCT_TenCol;
        private DataGridViewTextBoxColumn tabCT_BlankCol;
        private DataGridViewButtonColumn tabCT_ViewCol;
        private DataGridViewButtonColumn tabCT_EditCol;
        private DataGridViewButtonColumn tabCT_DeleteCol;
        private Button tabHanhKhach_SearchBtn;
        private DataGridView HanhKhachGridView;
        private CheckBox tabHanhKhach_CB;
        private TextBox tabHanhKhach_SearchBox;
        private Button tabHanhKhach_RefreshBtn;
        private Button tabHanhKhach_AddBtn;
        private DataGridViewTextBoxColumn tabHanhKhach_IDCol;
        private DataGridViewTextBoxColumn tabHanhKhach_MaKhachCol;
        private DataGridViewTextBoxColumn tabHanhKhach_TenCol;
        private DataGridViewTextBoxColumn tabHanhKhach_SDTCol;
        private DataGridViewTextBoxColumn tabHanhKhach_EmailCol;
        private DataGridViewTextBoxColumn tabHanhKhach_CMNDCol;
        private DataGridViewTextBoxColumn tabHanhKhach_DiachiCol;
        private DataGridViewTextBoxColumn tabHanhKhach_GioitinhCol;
        private DataGridViewTextBoxColumn tabHanhKhach_PassportCol;
        private DataGridViewButtonColumn tabHanhKhach_ViewCol;
        private DataGridViewButtonColumn tabHanhKhach_EditCol;
        private DataGridViewButtonColumn tabHanhKhach_DeleteCol;
        private Label label1;
        private ComboBox tabTour_SearchOption;
        private Label label3;
        private Label label2;
        private DateTimePicker tabTour_ToDate;
        private DateTimePicker tabTour_FromDate;
        private Label label4;
        private NumericUpDown tabTour_FromPrice;
        private NumericUpDown tabTour_ToPrice;
        private Label label5;
        private Label label6;
        private ComboBox tabNV_SearchOption;
        private Label label7;
        private ComboBox tabHanhKhach_SearchOption;
        private Label label8;
        private ComboBox tabDoan_SearchOption;
        private ComboBox tabCT_SearchOption;
        private Label label9;
        private TextBox tabDD_SearchBox;
        private ComboBox tabDD_SearchOption;
        private Label label10;
        private DataGridView DiaDiemGridView;
        private Button tabDD_AddBtn;
        private Button tabDD_RefreshBtn;
        private Button tabDD_SearchBtn;
        private DataGridViewTextBoxColumn tabDD_IDCol;
        private DataGridViewTextBoxColumn tabDD_TenCol;
        private DataGridViewTextBoxColumn tabDD_BlankCol;
        private DataGridViewButtonColumn tabDD_ViewCol;
        private DataGridViewButtonColumn tabDD_EditCol;
        private DataGridViewButtonColumn tabDD_DeleteCol;
        private DataGridView LHDLGridView;
        private TextBox tabLHDL_SearchBox;
        private Button tabLHDL_AddBtn;
        private Button tabLHDL_RefreshBtn;
        private Button tabLHDL_SearchBtn;
        private ComboBox tabLHDL_SearchOption;
        private Label label11;
        private DataGridViewTextBoxColumn tabLHDL_IDCol;
        private DataGridViewTextBoxColumn tabLHDL_TenCol;
        private DataGridViewTextBoxColumn tabLHDL_MotaCol;
        private DataGridViewTextBoxColumn tabLHDL_BlankCol;
        private DataGridViewButtonColumn tabLHDL_ViewCol;
        private DataGridViewButtonColumn tabLHDL_EditCol;
        private DataGridViewButtonColumn tabLHDL_DeleteCol;
        private ToolStripMenuItem ToolsMenu;
        private ToolStripMenuItem StatisticMenu;
        private ToolStripMenuItem TKChiPhiMenu;
        private ToolStripMenuItem TKDoanhThuMenu;
        private ToolStripMenuItem TKTinhHinhHoatDongMenu;
        private ToolStripMenuItem TKSoLanDiTourMenu;
    }
}

