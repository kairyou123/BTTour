namespace TourApp
{
    partial class DoanKhach_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateend = new System.Windows.Forms.DateTimePicker();
            this.datestart = new System.Windows.Forms.DateTimePicker();
            this.errormsg0 = new System.Windows.Forms.Label();
            this.tourd = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.errormsg1 = new System.Windows.Forms.Label();
            this.hk_btn = new System.Windows.Forms.Button();
            this.data_hk = new System.Windows.Forms.DataGridView();
            this.Ma_HK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_HK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDTHK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteHK = new System.Windows.Forms.DataGridViewButtonColumn();
            this.statusd = new System.Windows.Forms.RichTextBox();
            this.tend = new System.Windows.Forms.TextBox();
            this.mad = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.errormsg2 = new System.Windows.Forms.Label();
            this.data_nv = new System.Windows.Forms.DataGridView();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteNV = new System.Windows.Forms.DataGridViewButtonColumn();
            this.nv_btn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.errormsg3 = new System.Windows.Forms.Label();
            this.data_cp = new System.Windows.Forms.DataGridView();
            this.LoaiCP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteCP = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cp_btn = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_hk)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_nv)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_cp)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.dateend);
            this.groupBox1.Controls.Add(this.datestart);
            this.groupBox1.Controls.Add(this.errormsg0);
            this.groupBox1.Controls.Add(this.tourd);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.statusd);
            this.groupBox1.Controls.Add(this.tend);
            this.groupBox1.Controls.Add(this.mad);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Location = new System.Drawing.Point(14, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(905, 379);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN ĐOÀN KHÁCH";
            // 
            // dateend
            // 
            this.dateend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateend.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateend.Location = new System.Drawing.Point(145, 328);
            this.dateend.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateend.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dateend.Name = "dateend";
            this.dateend.Size = new System.Drawing.Size(302, 27);
            this.dateend.TabIndex = 6;
            this.dateend.Value = new System.DateTime(2020, 11, 1, 0, 0, 0, 0);
            // 
            // datestart
            // 
            this.datestart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.datestart.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.datestart.Location = new System.Drawing.Point(145, 279);
            this.datestart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.datestart.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.datestart.Name = "datestart";
            this.datestart.Size = new System.Drawing.Size(302, 27);
            this.datestart.TabIndex = 5;
            this.datestart.Value = new System.DateTime(2020, 11, 1, 0, 0, 0, 0);
            // 
            // errormsg0
            // 
            this.errormsg0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.errormsg0.AutoSize = true;
            this.errormsg0.BackColor = System.Drawing.Color.White;
            this.errormsg0.ForeColor = System.Drawing.Color.Red;
            this.errormsg0.Location = new System.Drawing.Point(145, 25);
            this.errormsg0.Name = "errormsg0";
            this.errormsg0.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.errormsg0.Size = new System.Drawing.Size(269, 20);
            this.errormsg0.TabIndex = 2;
            this.errormsg0.Text = "Xin vui lòng chọn hành khách cho Đoàn";
            this.errormsg0.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.errormsg0.Visible = false;
            // 
            // tourd
            // 
            this.tourd.FormattingEnabled = true;
            this.tourd.Location = new System.Drawing.Point(145, 152);
            this.tourd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tourd.Name = "tourd";
            this.tourd.Size = new System.Drawing.Size(302, 28);
            this.tourd.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.errormsg1);
            this.groupBox4.Controls.Add(this.hk_btn);
            this.groupBox4.Controls.Add(this.data_hk);
            this.groupBox4.Location = new System.Drawing.Point(483, 29);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(422, 329);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Hành Khách";
            // 
            // errormsg1
            // 
            this.errormsg1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.errormsg1.AutoSize = true;
            this.errormsg1.BackColor = System.Drawing.Color.White;
            this.errormsg1.ForeColor = System.Drawing.Color.Red;
            this.errormsg1.Location = new System.Drawing.Point(72, 35);
            this.errormsg1.Name = "errormsg1";
            this.errormsg1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.errormsg1.Size = new System.Drawing.Size(269, 20);
            this.errormsg1.TabIndex = 2;
            this.errormsg1.Text = "Xin vui lòng chọn hành khách cho Đoàn";
            this.errormsg1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.errormsg1.Visible = false;
            // 
            // hk_btn
            // 
            this.hk_btn.Location = new System.Drawing.Point(329, 29);
            this.hk_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hk_btn.Name = "hk_btn";
            this.hk_btn.Size = new System.Drawing.Size(86, 31);
            this.hk_btn.TabIndex = 1;
            this.hk_btn.Text = "Chọn";
            this.hk_btn.UseVisualStyleBackColor = true;
            this.hk_btn.Click += new System.EventHandler(this.hk_btn_Click);
            // 
            // data_hk
            // 
            this.data_hk.AllowUserToAddRows = false;
            this.data_hk.AllowUserToDeleteRows = false;
            this.data_hk.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.data_hk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_hk.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma_HK,
            this.Ten_HK,
            this.SDTHK,
            this.DeleteHK});
            this.data_hk.Location = new System.Drawing.Point(7, 75);
            this.data_hk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.data_hk.Name = "data_hk";
            this.data_hk.ReadOnly = true;
            this.data_hk.RowHeadersWidth = 51;
            this.data_hk.Size = new System.Drawing.Size(415, 247);
            this.data_hk.TabIndex = 2;
            this.data_hk.Text = "dataGridView3";
            this.data_hk.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_CellContentClick);
            // 
            // Ma_HK
            // 
            this.Ma_HK.FillWeight = 70F;
            this.Ma_HK.HeaderText = "Mã HK";
            this.Ma_HK.MinimumWidth = 6;
            this.Ma_HK.Name = "Ma_HK";
            this.Ma_HK.ReadOnly = true;
            this.Ma_HK.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Ma_HK.Width = 70;
            // 
            // Ten_HK
            // 
            this.Ten_HK.HeaderText = "Tên HK";
            this.Ten_HK.MinimumWidth = 6;
            this.Ten_HK.Name = "Ten_HK";
            this.Ten_HK.ReadOnly = true;
            this.Ten_HK.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Ten_HK.Width = 125;
            // 
            // SDTHK
            // 
            this.SDTHK.HeaderText = "SDT";
            this.SDTHK.MinimumWidth = 6;
            this.SDTHK.Name = "SDTHK";
            this.SDTHK.ReadOnly = true;
            this.SDTHK.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SDTHK.Width = 125;
            // 
            // DeleteHK
            // 
            this.DeleteHK.FillWeight = 50F;
            this.DeleteHK.HeaderText = "Xóa";
            this.DeleteHK.MinimumWidth = 6;
            this.DeleteHK.Name = "DeleteHK";
            this.DeleteHK.ReadOnly = true;
            this.DeleteHK.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DeleteHK.Text = "Xóa";
            this.DeleteHK.ToolTipText = "Xóa";
            this.DeleteHK.Width = 50;
            // 
            // statusd
            // 
            this.statusd.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.statusd.Location = new System.Drawing.Point(145, 200);
            this.statusd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.statusd.Name = "statusd";
            this.statusd.Size = new System.Drawing.Size(302, 63);
            this.statusd.TabIndex = 4;
            this.statusd.Text = "";
            // 
            // tend
            // 
            this.tend.Location = new System.Drawing.Point(145, 104);
            this.tend.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tend.Name = "tend";
            this.tend.Size = new System.Drawing.Size(302, 27);
            this.tend.TabIndex = 2;
            // 
            // mad
            // 
            this.mad.Location = new System.Drawing.Point(145, 59);
            this.mad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mad.Name = "mad";
            this.mad.Size = new System.Drawing.Size(302, 27);
            this.mad.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(21, 44);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(128, 327);
            this.panel2.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.PapayaWhip;
            this.label6.Location = new System.Drawing.Point(0, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 31);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ngày kết thúc";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.PapayaWhip;
            this.label5.Location = new System.Drawing.Point(0, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 31);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngày bắt đầu";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.PapayaWhip;
            this.label3.Location = new System.Drawing.Point(0, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "Thông tin thêm";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.PapayaWhip;
            this.label4.Location = new System.Drawing.Point(0, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 31);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tour";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.PapayaWhip;
            this.label2.Location = new System.Drawing.Point(0, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Đoàn";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.PapayaWhip;
            this.label1.Location = new System.Drawing.Point(0, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Đoàn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Controls.Add(this.errormsg2);
            this.groupBox2.Controls.Add(this.data_nv);
            this.groupBox2.Controls.Add(this.nv_btn);
            this.groupBox2.Location = new System.Drawing.Point(14, 417);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(448, 317);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhân Viên";
            // 
            // errormsg2
            // 
            this.errormsg2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.errormsg2.AutoSize = true;
            this.errormsg2.BackColor = System.Drawing.Color.White;
            this.errormsg2.ForeColor = System.Drawing.Color.Red;
            this.errormsg2.Location = new System.Drawing.Point(98, 57);
            this.errormsg2.Name = "errormsg2";
            this.errormsg2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.errormsg2.Size = new System.Drawing.Size(258, 20);
            this.errormsg2.TabIndex = 2;
            this.errormsg2.Text = "Xin vui lòng chọn nhân viên cho Đoàn";
            this.errormsg2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.errormsg2.Visible = false;
            // 
            // data_nv
            // 
            this.data_nv.AllowUserToAddRows = false;
            this.data_nv.AllowUserToDeleteRows = false;
            this.data_nv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.data_nv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_nv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.Ten,
            this.VT,
            this.DeleteNV});
            this.data_nv.Location = new System.Drawing.Point(7, 91);
            this.data_nv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.data_nv.Name = "data_nv";
            this.data_nv.ReadOnly = true;
            this.data_nv.RowHeadersWidth = 51;
            this.data_nv.Size = new System.Drawing.Size(434, 219);
            this.data_nv.TabIndex = 2;
            this.data_nv.Text = "dataGridView1";
            this.data_nv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_CellContentClick);
            // 
            // MaNV
            // 
            this.MaNV.FillWeight = 70F;
            this.MaNV.HeaderText = "Mã NV";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            this.MaNV.ReadOnly = true;
            this.MaNV.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaNV.Width = 70;
            // 
            // Ten
            // 
            this.Ten.HeaderText = "Tên";
            this.Ten.MinimumWidth = 6;
            this.Ten.Name = "Ten";
            this.Ten.ReadOnly = true;
            this.Ten.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Ten.Width = 125;
            // 
            // VT
            // 
            this.VT.HeaderText = "Vị Trí";
            this.VT.MinimumWidth = 6;
            this.VT.Name = "VT";
            this.VT.ReadOnly = true;
            this.VT.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.VT.Width = 125;
            // 
            // DeleteNV
            // 
            this.DeleteNV.FillWeight = 50F;
            this.DeleteNV.HeaderText = "Xóa";
            this.DeleteNV.MinimumWidth = 6;
            this.DeleteNV.Name = "DeleteNV";
            this.DeleteNV.ReadOnly = true;
            this.DeleteNV.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DeleteNV.Text = "Xóa";
            this.DeleteNV.Width = 50;
            // 
            // nv_btn
            // 
            this.nv_btn.Location = new System.Drawing.Point(355, 52);
            this.nv_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nv_btn.Name = "nv_btn";
            this.nv_btn.Size = new System.Drawing.Size(86, 31);
            this.nv_btn.TabIndex = 1;
            this.nv_btn.Text = "Chọn";
            this.nv_btn.UseVisualStyleBackColor = true;
            this.nv_btn.Click += new System.EventHandler(this.nv_btn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Controls.Add(this.errormsg3);
            this.groupBox3.Controls.Add(this.data_cp);
            this.groupBox3.Controls.Add(this.cp_btn);
            this.groupBox3.Location = new System.Drawing.Point(504, 417);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(415, 317);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi Phí";
            // 
            // errormsg3
            // 
            this.errormsg3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.errormsg3.AutoSize = true;
            this.errormsg3.BackColor = System.Drawing.Color.White;
            this.errormsg3.ForeColor = System.Drawing.Color.Red;
            this.errormsg3.Location = new System.Drawing.Point(93, 57);
            this.errormsg3.Name = "errormsg3";
            this.errormsg3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.errormsg3.Size = new System.Drawing.Size(239, 20);
            this.errormsg3.TabIndex = 2;
            this.errormsg3.Text = "Xin vui lòng chọn chi phí cho Đoàn";
            this.errormsg3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.errormsg3.Visible = false;
            // 
            // data_cp
            // 
            this.data_cp.AllowUserToAddRows = false;
            this.data_cp.AllowUserToDeleteRows = false;
            this.data_cp.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.data_cp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_cp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LoaiCP,
            this.Tien,
            this.DeleteCP});
            this.data_cp.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.data_cp.Location = new System.Drawing.Point(8, 91);
            this.data_cp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.data_cp.Name = "data_cp";
            this.data_cp.ReadOnly = true;
            this.data_cp.RowHeadersWidth = 51;
            this.data_cp.Size = new System.Drawing.Size(399, 219);
            this.data_cp.TabIndex = 2;
            this.data_cp.Text = "dataGridView2";
            this.data_cp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_CellContentClick);
            // 
            // LoaiCP
            // 
            this.LoaiCP.FillWeight = 150F;
            this.LoaiCP.HeaderText = "Loại Chi Phí";
            this.LoaiCP.MinimumWidth = 6;
            this.LoaiCP.Name = "LoaiCP";
            this.LoaiCP.ReadOnly = true;
            this.LoaiCP.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.LoaiCP.Width = 150;
            // 
            // Tien
            // 
            this.Tien.HeaderText = "Số tiền (VND)";
            this.Tien.MinimumWidth = 6;
            this.Tien.Name = "Tien";
            this.Tien.ReadOnly = true;
            this.Tien.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Tien.Width = 125;
            // 
            // DeleteCP
            // 
            this.DeleteCP.FillWeight = 50F;
            this.DeleteCP.HeaderText = "Xóa";
            this.DeleteCP.MinimumWidth = 6;
            this.DeleteCP.Name = "DeleteCP";
            this.DeleteCP.ReadOnly = true;
            this.DeleteCP.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DeleteCP.Text = "Xóa";
            this.DeleteCP.Width = 50;
            // 
            // cp_btn
            // 
            this.cp_btn.Location = new System.Drawing.Point(320, 52);
            this.cp_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cp_btn.Name = "cp_btn";
            this.cp_btn.Size = new System.Drawing.Size(86, 31);
            this.cp_btn.TabIndex = 1;
            this.cp_btn.Text = "Chọn";
            this.cp_btn.UseVisualStyleBackColor = true;
            this.cp_btn.Click += new System.EventHandler(this.cp_btn_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(791, 743);
            this.Save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(121, 47);
            this.Save.TabIndex = 3;
            this.Save.Text = "Lưu";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.button4_Click);
            // 
            // DoanKhach_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 805);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DoanKhach_Form";
            this.Text = "DoanKhach_Form";
            this.Load += new System.EventHandler(this.DoanKhach_Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_hk)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_nv)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_cp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox mad;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox statusd;
        private System.Windows.Forms.TextBox tend;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView data_nv;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button nv_btn;
        private System.Windows.Forms.Button cp_btn;
        private System.Windows.Forms.DataGridView data_cp;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button hk_btn;
        private System.Windows.Forms.DataGridView data_hk;
        private System.Windows.Forms.ComboBox tourd;
        private System.Windows.Forms.Label errormsg1;
        private System.Windows.Forms.Label errormsg2;
        private System.Windows.Forms.Label errormsg3;
        private System.Windows.Forms.Label errormsg0;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_HK;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_HK;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDTHK;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteHK;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiCP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tien;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteCP;
        private System.Windows.Forms.DateTimePicker dateend;
        private System.Windows.Forms.DateTimePicker datestart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn VT;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteNV;
    }
}