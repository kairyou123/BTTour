﻿using System.Windows.Forms;

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
            this.HanhKhachGridView = new System.Windows.Forms.DataGridView();
            this.tabHanhKhach_IDCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabHanhKhach_MaKhachCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabHanhKhach_TenCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabHanhKhach_SDTCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabHanhKhach_EmailCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabHanhKhach_ViewCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabHanhKhach_EditCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabHanhKhach_DeleteCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabHanhKhach_CB = new System.Windows.Forms.CheckBox();
            this.tabHanhKhach_SearchBox = new System.Windows.Forms.TextBox();
            this.tabHanhKhach_RefreshBtn = new System.Windows.Forms.Button();
            this.tabHanhKhach_AddBtn = new System.Windows.Forms.Button();
            this.tabHanhKhach_SearchBtn = new System.Windows.Forms.Button();
            this.tabGroup = new System.Windows.Forms.TabPage();
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
            this.tabLHDL = new System.Windows.Forms.TabPage();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ExportMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeThemeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.DarkStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LightStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DefaultStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.tabControl.Location = new System.Drawing.Point(0, 26);
            this.tabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 2;
            this.tabControl.Size = new System.Drawing.Size(693, 451);
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
            this.tabTour.Location = new System.Drawing.Point(4, 24);
            this.tabTour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabTour.Name = "tabTour";
            this.tabTour.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabTour.Size = new System.Drawing.Size(685, 423);
            this.tabTour.TabIndex = 0;
            this.tabTour.Text = "Tour";
            this.tabTour.UseVisualStyleBackColor = true;
            // 
            // tabTour_ToPrice
            // 
            this.tabTour_ToPrice.Location = new System.Drawing.Point(533, 54);
            this.tabTour_ToPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabTour_ToPrice.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.tabTour_ToPrice.Name = "tabTour_ToPrice";
            this.tabTour_ToPrice.Size = new System.Drawing.Size(131, 23);
            this.tabTour_ToPrice.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(496, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "->";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(324, 56);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(24, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Giá";
            // 
            // tabTour_FromPrice
            // 
            this.tabTour_FromPrice.Location = new System.Drawing.Point(356, 54);
            this.tabTour_FromPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabTour_FromPrice.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.tabTour_FromPrice.Name = "tabTour_FromPrice";
            this.tabTour_FromPrice.Size = new System.Drawing.Size(131, 23);
            this.tabTour_FromPrice.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Đến";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Từ ";
            // 
            // tabTour_ToDate
            // 
            this.tabTour_ToDate.Location = new System.Drawing.Point(39, 56);
            this.tabTour_ToDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabTour_ToDate.Name = "tabTour_ToDate";
            this.tabTour_ToDate.Size = new System.Drawing.Size(219, 23);
            this.tabTour_ToDate.TabIndex = 8;
            // 
            // tabTour_FromDate
            // 
            this.tabTour_FromDate.Location = new System.Drawing.Point(39, 15);
            this.tabTour_FromDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabTour_FromDate.Name = "tabTour_FromDate";
            this.tabTour_FromDate.Size = new System.Drawing.Size(217, 23);
            this.tabTour_FromDate.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(291, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
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
            this.tabTour_SearchOption.Location = new System.Drawing.Point(356, 10);
            this.tabTour_SearchOption.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabTour_SearchOption.Name = "tabTour_SearchOption";
            this.tabTour_SearchOption.Size = new System.Drawing.Size(133, 28);
            this.tabTour_SearchOption.TabIndex = 5;
            // 
            // isDeleted_ChB
            // 
            this.isDeleted_ChB.AutoSize = true;
            this.isDeleted_ChB.Location = new System.Drawing.Point(5, 106);
            this.isDeleted_ChB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.isDeleted_ChB.Name = "isDeleted_ChB";
            this.isDeleted_ChB.Size = new System.Drawing.Size(62, 19);
            this.isDeleted_ChB.TabIndex = 4;
            this.isDeleted_ChB.Text = "Đã xóa";
            this.isDeleted_ChB.UseVisualStyleBackColor = true;
            this.isDeleted_ChB.CheckedChanged += new System.EventHandler(this.isDeleted_CheckedChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.BackgroundImage")));
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.Location = new System.Drawing.Point(599, 98);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(40, 27);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(643, 98);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 27);
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
            this.tourGridView.Location = new System.Drawing.Point(3, 131);
            this.tourGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tourGridView.Name = "tourGridView";
            this.tourGridView.ReadOnly = true;
            this.tourGridView.RowHeadersVisible = false;
            this.tourGridView.RowHeadersWidth = 51;
            this.tourGridView.Size = new System.Drawing.Size(681, 290);
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
            this.TourIdCol.Width = 66;
            // 
            // MaTourCol
            // 
            this.MaTourCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MaTourCol.HeaderText = "Mã tour";
            this.MaTourCol.MinimumWidth = 6;
            this.MaTourCol.Name = "MaTourCol";
            this.MaTourCol.ReadOnly = true;
            this.MaTourCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaTourCol.Width = 69;
            // 
            // TenCol
            // 
            this.TenCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TenCol.HeaderText = "Tên";
            this.TenCol.MinimumWidth = 6;
            this.TenCol.Name = "TenCol";
            this.TenCol.ReadOnly = true;
            this.TenCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TenCol.Width = 50;
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
            this.ViewCol.Width = 37;
            // 
            // EditCol
            // 
            this.EditCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.EditCol.HeaderText = "Sửa";
            this.EditCol.MinimumWidth = 6;
            this.EditCol.Name = "EditCol";
            this.EditCol.ReadOnly = true;
            this.EditCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EditCol.Width = 32;
            // 
            // DeleteCol
            // 
            this.DeleteCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.DeleteCol.HeaderText = "Xóa";
            this.DeleteCol.MinimumWidth = 6;
            this.DeleteCol.Name = "DeleteCol";
            this.DeleteCol.ReadOnly = true;
            this.DeleteCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DeleteCol.Width = 33;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(556, 98);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(40, 27);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchBox.Location = new System.Drawing.Point(495, 11);
            this.searchBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(189, 27);
            this.searchBox.TabIndex = 0;
            this.searchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchBox_KeyPress);
            // 
            // tabStaff
            // 
            this.tabStaff.Controls.Add(this.NVGridView);
            this.tabStaff.Controls.Add(this.tabNV_SearchBox);
            this.tabStaff.Controls.Add(this.tabNV_CB);
            this.tabStaff.Controls.Add(this.tabNV_AddBtn);
            this.tabStaff.Controls.Add(this.tabNV_RefreshBtn);
            this.tabStaff.Controls.Add(this.tabNV_SearchBtn);
            this.tabStaff.Location = new System.Drawing.Point(4, 24);
            this.tabStaff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabStaff.Name = "tabStaff";
            this.tabStaff.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabStaff.Size = new System.Drawing.Size(685, 423);
            this.tabStaff.TabIndex = 1;
            this.tabStaff.Text = "Nhân viên";
            this.tabStaff.UseVisualStyleBackColor = true;
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
            this.NVGridView.Location = new System.Drawing.Point(3, 105);
            this.NVGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NVGridView.Name = "NVGridView";
            this.NVGridView.RowHeadersVisible = false;
            this.NVGridView.RowHeadersWidth = 51;
            this.NVGridView.Size = new System.Drawing.Size(668, 550);
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
            this.tabNV_IDCol.Width = 43;
            // 
            // tabNV_MaNVCol
            // 
            this.tabNV_MaNVCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tabNV_MaNVCol.HeaderText = "Mã NV";
            this.tabNV_MaNVCol.MinimumWidth = 6;
            this.tabNV_MaNVCol.Name = "tabNV_MaNVCol";
            this.tabNV_MaNVCol.ReadOnly = true;
            this.tabNV_MaNVCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tabNV_MaNVCol.Width = 68;
            // 
            // tabNV_TenCol
            // 
            this.tabNV_TenCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tabNV_TenCol.HeaderText = "Tên";
            this.tabNV_TenCol.MinimumWidth = 6;
            this.tabNV_TenCol.Name = "tabNV_TenCol";
            this.tabNV_TenCol.ReadOnly = true;
            this.tabNV_TenCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tabNV_TenCol.Width = 50;
            // 
            // tabNV_SDTCol
            // 
            this.tabNV_SDTCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tabNV_SDTCol.HeaderText = "SĐT";
            this.tabNV_SDTCol.MinimumWidth = 6;
            this.tabNV_SDTCol.Name = "tabNV_SDTCol";
            this.tabNV_SDTCol.ReadOnly = true;
            this.tabNV_SDTCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tabNV_SDTCol.Width = 52;
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
            this.tabNV_ViewCol.Width = 37;
            // 
            // tabNV_EditCol
            // 
            this.tabNV_EditCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tabNV_EditCol.HeaderText = "Sửa";
            this.tabNV_EditCol.MinimumWidth = 6;
            this.tabNV_EditCol.Name = "tabNV_EditCol";
            this.tabNV_EditCol.ReadOnly = true;
            this.tabNV_EditCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tabNV_EditCol.Width = 32;
            // 
            // tabNV_DeleteCol
            // 
            this.tabNV_DeleteCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tabNV_DeleteCol.HeaderText = "Xóa";
            this.tabNV_DeleteCol.MinimumWidth = 6;
            this.tabNV_DeleteCol.Name = "tabNV_DeleteCol";
            this.tabNV_DeleteCol.ReadOnly = true;
            this.tabNV_DeleteCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tabNV_DeleteCol.Width = 33;
            // 
            // tabNV_SearchBox
            // 
            this.tabNV_SearchBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabNV_SearchBox.Location = new System.Drawing.Point(482, 11);
            this.tabNV_SearchBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabNV_SearchBox.Name = "tabNV_SearchBox";
            this.tabNV_SearchBox.Size = new System.Drawing.Size(189, 32);
            this.tabNV_SearchBox.TabIndex = 4;
            this.tabNV_SearchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tabNV_SearchBox_KeyPress);
            // 
            // tabNV_CB
            // 
            this.tabNV_CB.AutoSize = true;
            this.tabNV_CB.Location = new System.Drawing.Point(4, 74);
            this.tabNV_CB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabNV_CB.Name = "tabNV_CB";
            this.tabNV_CB.Size = new System.Drawing.Size(62, 19);
            this.tabNV_CB.TabIndex = 3;
            this.tabNV_CB.Text = "Đã xóa";
            this.tabNV_CB.UseVisualStyleBackColor = true;
            this.tabNV_CB.CheckedChanged += new System.EventHandler(this.tabNV_CB_CheckedChanged);
            // 
            // tabNV_AddBtn
            // 
            this.tabNV_AddBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabNV_AddBtn.BackgroundImage")));
            this.tabNV_AddBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabNV_AddBtn.Location = new System.Drawing.Point(628, 74);
            this.tabNV_AddBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabNV_AddBtn.Name = "tabNV_AddBtn";
            this.tabNV_AddBtn.Size = new System.Drawing.Size(42, 27);
            this.tabNV_AddBtn.TabIndex = 2;
            this.tabNV_AddBtn.UseVisualStyleBackColor = true;
            this.tabNV_AddBtn.Click += new System.EventHandler(this.tabNV_AddBtn_Click);
            // 
            // tabNV_RefreshBtn
            // 
            this.tabNV_RefreshBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabNV_RefreshBtn.BackgroundImage")));
            this.tabNV_RefreshBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabNV_RefreshBtn.Location = new System.Drawing.Point(584, 74);
            this.tabNV_RefreshBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabNV_RefreshBtn.Name = "tabNV_RefreshBtn";
            this.tabNV_RefreshBtn.Size = new System.Drawing.Size(36, 27);
            this.tabNV_RefreshBtn.TabIndex = 1;
            this.tabNV_RefreshBtn.UseVisualStyleBackColor = true;
            this.tabNV_RefreshBtn.Click += new System.EventHandler(this.tabNV_RefreshBtn_Click);
            // 
            // tabNV_SearchBtn
            // 
            this.tabNV_SearchBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabNV_SearchBtn.BackgroundImage")));
            this.tabNV_SearchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabNV_SearchBtn.Location = new System.Drawing.Point(435, 9);
            this.tabNV_SearchBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabNV_SearchBtn.Name = "tabNV_SearchBtn";
            this.tabNV_SearchBtn.Size = new System.Drawing.Size(37, 33);
            this.tabNV_SearchBtn.TabIndex = 0;
            this.tabNV_SearchBtn.UseVisualStyleBackColor = true;
            this.tabNV_SearchBtn.Click += new System.EventHandler(this.tabNV_SearchBtn_Click);
            // 
            // tabPassenger
            // 
            this.tabPassenger.Controls.Add(this.HanhKhachGridView);
            this.tabPassenger.Controls.Add(this.tabHanhKhach_CB);
            this.tabPassenger.Controls.Add(this.tabHanhKhach_SearchBox);
            this.tabPassenger.Controls.Add(this.tabHanhKhach_RefreshBtn);
            this.tabPassenger.Controls.Add(this.tabHanhKhach_AddBtn);
            this.tabPassenger.Controls.Add(this.tabHanhKhach_SearchBtn);
            this.tabPassenger.Location = new System.Drawing.Point(4, 24);
            this.tabPassenger.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPassenger.Name = "tabPassenger";
            this.tabPassenger.Size = new System.Drawing.Size(685, 423);
            this.tabPassenger.TabIndex = 6;
            this.tabPassenger.Text = "Hành khách";
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
            this.tabHanhKhach_ViewCol,
            this.tabHanhKhach_EditCol,
            this.tabHanhKhach_DeleteCol});
            this.HanhKhachGridView.Location = new System.Drawing.Point(3, 105);
            this.HanhKhachGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HanhKhachGridView.Name = "HanhKhachGridView";
            this.HanhKhachGridView.RowHeadersVisible = false;
            this.HanhKhachGridView.RowHeadersWidth = 51;
            this.HanhKhachGridView.Size = new System.Drawing.Size(668, 280);
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
            this.tabHanhKhach_IDCol.Width = 43;
            // 
            // tabHanhKhach_MaKhachCol
            // 
            this.tabHanhKhach_MaKhachCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tabHanhKhach_MaKhachCol.HeaderText = "Mã khách";
            this.tabHanhKhach_MaKhachCol.MinimumWidth = 6;
            this.tabHanhKhach_MaKhachCol.Name = "tabHanhKhach_MaKhachCol";
            this.tabHanhKhach_MaKhachCol.ReadOnly = true;
            this.tabHanhKhach_MaKhachCol.Width = 84;
            // 
            // tabHanhKhach_TenCol
            // 
            this.tabHanhKhach_TenCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tabHanhKhach_TenCol.HeaderText = "Tên";
            this.tabHanhKhach_TenCol.MinimumWidth = 6;
            this.tabHanhKhach_TenCol.Name = "tabHanhKhach_TenCol";
            this.tabHanhKhach_TenCol.ReadOnly = true;
            // 
            // tabHanhKhach_SDTCol
            // 
            this.tabHanhKhach_SDTCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tabHanhKhach_SDTCol.HeaderText = "SĐT";
            this.tabHanhKhach_SDTCol.MinimumWidth = 6;
            this.tabHanhKhach_SDTCol.Name = "tabHanhKhach_SDTCol";
            this.tabHanhKhach_SDTCol.ReadOnly = true;
            this.tabHanhKhach_SDTCol.Width = 52;
            // 
            // tabHanhKhach_EmailCol
            // 
            this.tabHanhKhach_EmailCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tabHanhKhach_EmailCol.HeaderText = "Email";
            this.tabHanhKhach_EmailCol.MinimumWidth = 6;
            this.tabHanhKhach_EmailCol.Name = "tabHanhKhach_EmailCol";
            this.tabHanhKhach_EmailCol.ReadOnly = true;
            this.tabHanhKhach_EmailCol.Width = 61;
            // 
            // tabHanhKhach_ViewCol
            // 
            this.tabHanhKhach_ViewCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tabHanhKhach_ViewCol.HeaderText = "Xem";
            this.tabHanhKhach_ViewCol.MinimumWidth = 6;
            this.tabHanhKhach_ViewCol.Name = "tabHanhKhach_ViewCol";
            this.tabHanhKhach_ViewCol.ReadOnly = true;
            this.tabHanhKhach_ViewCol.Width = 37;
            // 
            // tabHanhKhach_EditCol
            // 
            this.tabHanhKhach_EditCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tabHanhKhach_EditCol.HeaderText = "Sửa";
            this.tabHanhKhach_EditCol.MinimumWidth = 6;
            this.tabHanhKhach_EditCol.Name = "tabHanhKhach_EditCol";
            this.tabHanhKhach_EditCol.ReadOnly = true;
            this.tabHanhKhach_EditCol.Width = 32;
            // 
            // tabHanhKhach_DeleteCol
            // 
            this.tabHanhKhach_DeleteCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tabHanhKhach_DeleteCol.HeaderText = "Xóa";
            this.tabHanhKhach_DeleteCol.MinimumWidth = 6;
            this.tabHanhKhach_DeleteCol.Name = "tabHanhKhach_DeleteCol";
            this.tabHanhKhach_DeleteCol.ReadOnly = true;
            this.tabHanhKhach_DeleteCol.Width = 33;
            // 
            // tabHanhKhach_CB
            // 
            this.tabHanhKhach_CB.AutoSize = true;
            this.tabHanhKhach_CB.Location = new System.Drawing.Point(4, 74);
            this.tabHanhKhach_CB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabHanhKhach_CB.Name = "tabHanhKhach_CB";
            this.tabHanhKhach_CB.Size = new System.Drawing.Size(62, 19);
            this.tabHanhKhach_CB.TabIndex = 4;
            this.tabHanhKhach_CB.Text = "Đã xóa";
            this.tabHanhKhach_CB.UseVisualStyleBackColor = true;
            this.tabHanhKhach_CB.CheckedChanged += new System.EventHandler(this.tabHanhKhach_CB_CheckedChanged);
            // 
            // tabHanhKhach_SearchBox
            // 
            this.tabHanhKhach_SearchBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabHanhKhach_SearchBox.Location = new System.Drawing.Point(482, 11);
            this.tabHanhKhach_SearchBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabHanhKhach_SearchBox.Name = "tabHanhKhach_SearchBox";
            this.tabHanhKhach_SearchBox.Size = new System.Drawing.Size(189, 32);
            this.tabHanhKhach_SearchBox.TabIndex = 3;
            this.tabHanhKhach_SearchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tabHanhKhach_SearchBox_KeyPress);
            // 
            // tabHanhKhach_RefreshBtn
            // 
            this.tabHanhKhach_RefreshBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabHanhKhach_RefreshBtn.BackgroundImage")));
            this.tabHanhKhach_RefreshBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabHanhKhach_RefreshBtn.Location = new System.Drawing.Point(584, 74);
            this.tabHanhKhach_RefreshBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabHanhKhach_RefreshBtn.Name = "tabHanhKhach_RefreshBtn";
            this.tabHanhKhach_RefreshBtn.Size = new System.Drawing.Size(36, 27);
            this.tabHanhKhach_RefreshBtn.TabIndex = 2;
            this.tabHanhKhach_RefreshBtn.UseVisualStyleBackColor = true;
            this.tabHanhKhach_RefreshBtn.Click += new System.EventHandler(this.tabHanhKhach_RefreshBtn_Click);
            // 
            // tabHanhKhach_AddBtn
            // 
            this.tabHanhKhach_AddBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabHanhKhach_AddBtn.BackgroundImage")));
            this.tabHanhKhach_AddBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabHanhKhach_AddBtn.Location = new System.Drawing.Point(628, 74);
            this.tabHanhKhach_AddBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabHanhKhach_AddBtn.Name = "tabHanhKhach_AddBtn";
            this.tabHanhKhach_AddBtn.Size = new System.Drawing.Size(42, 27);
            this.tabHanhKhach_AddBtn.TabIndex = 1;
            this.tabHanhKhach_AddBtn.UseVisualStyleBackColor = true;
            this.tabHanhKhach_AddBtn.Click += new System.EventHandler(this.tabHanhKhach_AddBtn_Click);
            // 
            // tabHanhKhach_SearchBtn
            // 
            this.tabHanhKhach_SearchBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabHanhKhach_SearchBtn.BackgroundImage")));
            this.tabHanhKhach_SearchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabHanhKhach_SearchBtn.Location = new System.Drawing.Point(435, 9);
            this.tabHanhKhach_SearchBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabHanhKhach_SearchBtn.Name = "tabHanhKhach_SearchBtn";
            this.tabHanhKhach_SearchBtn.Size = new System.Drawing.Size(37, 33);
            this.tabHanhKhach_SearchBtn.TabIndex = 0;
            this.tabHanhKhach_SearchBtn.UseVisualStyleBackColor = true;
            this.tabHanhKhach_SearchBtn.Click += new System.EventHandler(this.tabHanhKhach_SearchBtn_Click);
            // 
            // tabGroup
            // 
            this.tabGroup.Controls.Add(this.DoanGridView);
            this.tabGroup.Controls.Add(this.tabDoan_SearchBox);
            this.tabGroup.Controls.Add(this.tabDoan_CB);
            this.tabGroup.Controls.Add(this.tabDoan_AddBtn);
            this.tabGroup.Controls.Add(this.tabDoan_RefreshBtn);
            this.tabGroup.Controls.Add(this.tabDoan_SearchBtn);
            this.tabGroup.Location = new System.Drawing.Point(4, 24);
            this.tabGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabGroup.Name = "tabGroup";
            this.tabGroup.Size = new System.Drawing.Size(685, 423);
            this.tabGroup.TabIndex = 3;
            this.tabGroup.Text = "Đoàn";
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
            this.DoanGridView.Location = new System.Drawing.Point(3, 105);
            this.DoanGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DoanGridView.Name = "DoanGridView";
            this.DoanGridView.RowHeadersVisible = false;
            this.DoanGridView.RowHeadersWidth = 51;
            this.DoanGridView.Size = new System.Drawing.Size(668, 280);
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
            this.tabDoan_IDCol.Width = 43;
            // 
            // tabDoan_MaDoanCol
            // 
            this.tabDoan_MaDoanCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tabDoan_MaDoanCol.HeaderText = "Mã Đoàn";
            this.tabDoan_MaDoanCol.MinimumWidth = 6;
            this.tabDoan_MaDoanCol.Name = "tabDoan_MaDoanCol";
            this.tabDoan_MaDoanCol.ReadOnly = true;
            this.tabDoan_MaDoanCol.Width = 80;
            // 
            // tabDoan_TenCol
            // 
            this.tabDoan_TenCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tabDoan_TenCol.HeaderText = "Tên Đoàn";
            this.tabDoan_TenCol.MinimumWidth = 6;
            this.tabDoan_TenCol.Name = "tabDoan_TenCol";
            this.tabDoan_TenCol.ReadOnly = true;
            this.tabDoan_TenCol.Width = 81;
            // 
            // tabDoan_ChitietCol
            // 
            this.tabDoan_ChitietCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tabDoan_ChitietCol.HeaderText = "Chi tiết";
            this.tabDoan_ChitietCol.MinimumWidth = 6;
            this.tabDoan_ChitietCol.Name = "tabDoan_ChitietCol";
            this.tabDoan_ChitietCol.ReadOnly = true;
            // 
            // tabDoan_StatusCol
            // 
            this.tabDoan_StatusCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tabDoan_StatusCol.HeaderText = "Tình trạng";
            this.tabDoan_StatusCol.MinimumWidth = 6;
            this.tabDoan_StatusCol.Name = "tabDoan_StatusCol";
            this.tabDoan_StatusCol.ReadOnly = true;
            this.tabDoan_StatusCol.Width = 86;
            // 
            // tabDoan_TourIDCol
            // 
            this.tabDoan_TourIDCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tabDoan_TourIDCol.HeaderText = "Tour ID";
            this.tabDoan_TourIDCol.MinimumWidth = 6;
            this.tabDoan_TourIDCol.Name = "tabDoan_TourIDCol";
            this.tabDoan_TourIDCol.ReadOnly = true;
            this.tabDoan_TourIDCol.Width = 69;
            // 
            // tabDoan_MaTourCol
            // 
            this.tabDoan_MaTourCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tabDoan_MaTourCol.HeaderText = "Mã Tour";
            this.tabDoan_MaTourCol.MinimumWidth = 6;
            this.tabDoan_MaTourCol.Name = "tabDoan_MaTourCol";
            this.tabDoan_MaTourCol.ReadOnly = true;
            this.tabDoan_MaTourCol.Width = 75;
            // 
            // tabDoan_ViewCol
            // 
            this.tabDoan_ViewCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tabDoan_ViewCol.HeaderText = "Xem";
            this.tabDoan_ViewCol.MinimumWidth = 6;
            this.tabDoan_ViewCol.Name = "tabDoan_ViewCol";
            this.tabDoan_ViewCol.ReadOnly = true;
            this.tabDoan_ViewCol.Width = 37;
            // 
            // tabDoan_EditCol
            // 
            this.tabDoan_EditCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tabDoan_EditCol.HeaderText = "Sửa";
            this.tabDoan_EditCol.MinimumWidth = 6;
            this.tabDoan_EditCol.Name = "tabDoan_EditCol";
            this.tabDoan_EditCol.ReadOnly = true;
            this.tabDoan_EditCol.Width = 32;
            // 
            // tabDoan_DeleteCol
            // 
            this.tabDoan_DeleteCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tabDoan_DeleteCol.HeaderText = "Xóa";
            this.tabDoan_DeleteCol.MinimumWidth = 6;
            this.tabDoan_DeleteCol.Name = "tabDoan_DeleteCol";
            this.tabDoan_DeleteCol.ReadOnly = true;
            this.tabDoan_DeleteCol.Width = 33;
            // 
            // tabDoan_SearchBox
            // 
            this.tabDoan_SearchBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabDoan_SearchBox.Location = new System.Drawing.Point(482, 11);
            this.tabDoan_SearchBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabDoan_SearchBox.Name = "tabDoan_SearchBox";
            this.tabDoan_SearchBox.Size = new System.Drawing.Size(189, 32);
            this.tabDoan_SearchBox.TabIndex = 4;
            this.tabDoan_SearchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tabDoan_SearchBox_KeyPress);
            // 
            // tabDoan_CB
            // 
            this.tabDoan_CB.AutoSize = true;
            this.tabDoan_CB.Location = new System.Drawing.Point(4, 74);
            this.tabDoan_CB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabDoan_CB.Name = "tabDoan_CB";
            this.tabDoan_CB.Size = new System.Drawing.Size(62, 19);
            this.tabDoan_CB.TabIndex = 3;
            this.tabDoan_CB.Text = "Đã xóa";
            this.tabDoan_CB.UseVisualStyleBackColor = true;
            this.tabDoan_CB.CheckedChanged += new System.EventHandler(this.tabDoan_CB_CheckedChanged);
            // 
            // tabDoan_AddBtn
            // 
            this.tabDoan_AddBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabDoan_AddBtn.BackgroundImage")));
            this.tabDoan_AddBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabDoan_AddBtn.Location = new System.Drawing.Point(628, 74);
            this.tabDoan_AddBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabDoan_AddBtn.Name = "tabDoan_AddBtn";
            this.tabDoan_AddBtn.Size = new System.Drawing.Size(42, 27);
            this.tabDoan_AddBtn.TabIndex = 2;
            this.tabDoan_AddBtn.UseVisualStyleBackColor = true;
            this.tabDoan_AddBtn.Click += new System.EventHandler(this.tabDoan_AddBtn_Click);
            // 
            // tabDoan_RefreshBtn
            // 
            this.tabDoan_RefreshBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabDoan_RefreshBtn.BackgroundImage")));
            this.tabDoan_RefreshBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabDoan_RefreshBtn.Location = new System.Drawing.Point(584, 74);
            this.tabDoan_RefreshBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabDoan_RefreshBtn.Name = "tabDoan_RefreshBtn";
            this.tabDoan_RefreshBtn.Size = new System.Drawing.Size(36, 27);
            this.tabDoan_RefreshBtn.TabIndex = 1;
            this.tabDoan_RefreshBtn.UseVisualStyleBackColor = true;
            this.tabDoan_RefreshBtn.Click += new System.EventHandler(this.tabDoan_RefreshBtn_Click);
            // 
            // tabDoan_SearchBtn
            // 
            this.tabDoan_SearchBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabDoan_SearchBtn.BackgroundImage")));
            this.tabDoan_SearchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabDoan_SearchBtn.Location = new System.Drawing.Point(435, 9);
            this.tabDoan_SearchBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabDoan_SearchBtn.Name = "tabDoan_SearchBtn";
            this.tabDoan_SearchBtn.Size = new System.Drawing.Size(37, 33);
            this.tabDoan_SearchBtn.TabIndex = 0;
            this.tabDoan_SearchBtn.UseVisualStyleBackColor = true;
            this.tabDoan_SearchBtn.Click += new System.EventHandler(this.tabDoan_SearchBtn_Click);
            // 
            // tabCT
            // 
            this.tabCT.Controls.Add(this.ChiTieuGridView);
            this.tabCT.Controls.Add(this.tabCT_SearchBox);
            this.tabCT.Controls.Add(this.tabCT_RefreshBtn);
            this.tabCT.Controls.Add(this.tabCT_AddBtn);
            this.tabCT.Controls.Add(this.tabCT_SearchBtn);
            this.tabCT.Location = new System.Drawing.Point(4, 24);
            this.tabCT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabCT.Name = "tabCT";
            this.tabCT.Size = new System.Drawing.Size(685, 423);
            this.tabCT.TabIndex = 4;
            this.tabCT.Text = "Chi tiêu";
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
            this.ChiTieuGridView.Location = new System.Drawing.Point(3, 105);
            this.ChiTieuGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChiTieuGridView.Name = "ChiTieuGridView";
            this.ChiTieuGridView.RowHeadersVisible = false;
            this.ChiTieuGridView.RowHeadersWidth = 51;
            this.ChiTieuGridView.Size = new System.Drawing.Size(668, 280);
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
            this.tabCT_IDCol.Width = 43;
            // 
            // tabCT_TenCol
            // 
            this.tabCT_TenCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tabCT_TenCol.HeaderText = "Tên chỉ tiêu";
            this.tabCT_TenCol.MinimumWidth = 6;
            this.tabCT_TenCol.Name = "tabCT_TenCol";
            this.tabCT_TenCol.ReadOnly = true;
            this.tabCT_TenCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tabCT_TenCol.Width = 92;
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
            this.tabCT_ViewCol.Width = 37;
            // 
            // tabCT_EditCol
            // 
            this.tabCT_EditCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tabCT_EditCol.HeaderText = "Sửa";
            this.tabCT_EditCol.MinimumWidth = 6;
            this.tabCT_EditCol.Name = "tabCT_EditCol";
            this.tabCT_EditCol.ReadOnly = true;
            this.tabCT_EditCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tabCT_EditCol.Width = 32;
            // 
            // tabCT_DeleteCol
            // 
            this.tabCT_DeleteCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tabCT_DeleteCol.HeaderText = "Xóa";
            this.tabCT_DeleteCol.MinimumWidth = 6;
            this.tabCT_DeleteCol.Name = "tabCT_DeleteCol";
            this.tabCT_DeleteCol.ReadOnly = true;
            this.tabCT_DeleteCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tabCT_DeleteCol.Width = 33;
            // 
            // tabCT_SearchBox
            // 
            this.tabCT_SearchBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabCT_SearchBox.Location = new System.Drawing.Point(482, 11);
            this.tabCT_SearchBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabCT_SearchBox.Name = "tabCT_SearchBox";
            this.tabCT_SearchBox.Size = new System.Drawing.Size(189, 32);
            this.tabCT_SearchBox.TabIndex = 3;
            this.tabCT_SearchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tabCT_SearchBox_KeyPress);
            // 
            // tabCT_RefreshBtn
            // 
            this.tabCT_RefreshBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabCT_RefreshBtn.BackgroundImage")));
            this.tabCT_RefreshBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabCT_RefreshBtn.Location = new System.Drawing.Point(584, 74);
            this.tabCT_RefreshBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabCT_RefreshBtn.Name = "tabCT_RefreshBtn";
            this.tabCT_RefreshBtn.Size = new System.Drawing.Size(36, 27);
            this.tabCT_RefreshBtn.TabIndex = 2;
            this.tabCT_RefreshBtn.UseVisualStyleBackColor = true;
            this.tabCT_RefreshBtn.Click += new System.EventHandler(this.tabCT_RefreshBtn_Click);
            // 
            // tabCT_AddBtn
            // 
            this.tabCT_AddBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabCT_AddBtn.BackgroundImage")));
            this.tabCT_AddBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabCT_AddBtn.Location = new System.Drawing.Point(628, 74);
            this.tabCT_AddBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabCT_AddBtn.Name = "tabCT_AddBtn";
            this.tabCT_AddBtn.Size = new System.Drawing.Size(42, 27);
            this.tabCT_AddBtn.TabIndex = 1;
            this.tabCT_AddBtn.UseVisualStyleBackColor = true;
            this.tabCT_AddBtn.Click += new System.EventHandler(this.tabCT_AddBtn_Click);
            // 
            // tabCT_SearchBtn
            // 
            this.tabCT_SearchBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabCT_SearchBtn.BackgroundImage")));
            this.tabCT_SearchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabCT_SearchBtn.Location = new System.Drawing.Point(435, 9);
            this.tabCT_SearchBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabCT_SearchBtn.Name = "tabCT_SearchBtn";
            this.tabCT_SearchBtn.Size = new System.Drawing.Size(37, 33);
            this.tabCT_SearchBtn.TabIndex = 0;
            this.tabCT_SearchBtn.UseVisualStyleBackColor = true;
            this.tabCT_SearchBtn.Click += new System.EventHandler(this.tabCT_SearchBtn_Click);
            // 
            // tabDestination
            // 
            this.tabDestination.Location = new System.Drawing.Point(4, 24);
            this.tabDestination.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabDestination.Name = "tabDestination";
            this.tabDestination.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabDestination.Size = new System.Drawing.Size(685, 423);
            this.tabDestination.TabIndex = 2;
            this.tabDestination.Text = "Địa điểm";
            this.tabDestination.UseVisualStyleBackColor = true;
            // 
            // tabLHDL
            // 
            this.tabLHDL.Location = new System.Drawing.Point(4, 24);
            this.tabLHDL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabLHDL.Name = "tabLHDL";
            this.tabLHDL.Size = new System.Drawing.Size(685, 423);
            this.tabLHDL.TabIndex = 5;
            this.tabLHDL.Text = "Loại hình du lịch";
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu,
            this.SettingMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(693, 24);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menu";
            // 
            // FileMenu
            // 
            this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExportMenuBtn});
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(37, 20);
            this.FileMenu.Text = "File";
            this.FileMenu.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.FileMenu_DropDownItemClicked);
            // 
            // ExportMenuBtn
            // 
            this.ExportMenuBtn.Name = "ExportMenuBtn";
            this.ExportMenuBtn.Size = new System.Drawing.Size(152, 22);
            this.ExportMenuBtn.Text = "Export to excel";
            // 
            // SettingMenu
            // 
            this.SettingMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChangeThemeMenu});
            this.SettingMenu.Name = "SettingMenu";
            this.SettingMenu.Size = new System.Drawing.Size(56, 20);
            this.SettingMenu.Text = "Setting";
            // 
            // ChangeThemeMenu
            // 
            this.ChangeThemeMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DarkStripMenuItem,
            this.LightStripMenuItem,
            this.DefaultStripMenuItem});
            this.ChangeThemeMenu.Name = "ChangeThemeMenu";
            this.ChangeThemeMenu.Size = new System.Drawing.Size(152, 22);
            this.ChangeThemeMenu.Text = "Change theme";
            this.ChangeThemeMenu.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ChangeThemeMenu_DropDownItemClicked);
            // 
            // DarkStripMenuItem
            // 
            this.DarkStripMenuItem.CheckOnClick = true;
            this.DarkStripMenuItem.Name = "DarkStripMenuItem";
            this.DarkStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.DarkStripMenuItem.Text = "Dark ";
            // 
            // LightStripMenuItem
            // 
            this.LightStripMenuItem.CheckOnClick = true;
            this.LightStripMenuItem.Name = "LightStripMenuItem";
            this.LightStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.LightStripMenuItem.Text = "Light";
            // 
            // DefaultStripMenuItem
            // 
            this.DefaultStripMenuItem.Checked = true;
            this.DefaultStripMenuItem.CheckOnClick = true;
            this.DefaultStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DefaultStripMenuItem.Name = "DefaultStripMenuItem";
            this.DefaultStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.DefaultStripMenuItem.Text = "Default";
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(693, 478);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.menuStrip;
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
    }
}

