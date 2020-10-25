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
            this.errormsg0 = new System.Windows.Forms.Label();
            this.tourd = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.data_hk = new System.Windows.Forms.DataGridView();
            this.errormsg1 = new System.Windows.Forms.Label();
            this.hk_btn = new System.Windows.Forms.Button();
            this.statusd = new System.Windows.Forms.RichTextBox();
            this.tend = new System.Windows.Forms.TextBox();
            this.mad = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
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
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.nv_btn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.data_cp = new System.Windows.Forms.DataGridView();
            this.errormsg3 = new System.Windows.Forms.Label();
            this.LoaiCP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cp_btn = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Ma_HK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_HK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDTHK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteHK = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_hk)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_nv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_cp)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.errormsg0);
            this.groupBox1.Controls.Add(this.tourd);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.statusd);
            this.groupBox1.Controls.Add(this.tend);
            this.groupBox1.Controls.Add(this.mad);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Location = new System.Drawing.Point(12, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(792, 284);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN ĐOÀN KHÁCH";
            // 
            // errormsg0
            // 
            this.errormsg0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.errormsg0.AutoSize = true;
            this.errormsg0.BackColor = System.Drawing.Color.White;
            this.errormsg0.ForeColor = System.Drawing.Color.Red;
            this.errormsg0.Location = new System.Drawing.Point(127, 19);
            this.errormsg0.Name = "errormsg0";
            this.errormsg0.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.errormsg0.Size = new System.Drawing.Size(219, 15);
            this.errormsg0.TabIndex = 2;
            this.errormsg0.Text = "Xin vui lòng chọn hành khách cho Đoàn";
            this.errormsg0.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.errormsg0.Visible = false;
            // 
            // tourd
            // 
            this.tourd.FormattingEnabled = true;
            this.tourd.Location = new System.Drawing.Point(127, 114);
            this.tourd.Name = "tourd";
            this.tourd.Size = new System.Drawing.Size(265, 23);
            this.tourd.TabIndex = 6;
            // 
            // groupBox4
            // 
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
            this.data_hk.Location = new System.Drawing.Point(6, 56);
            this.data_hk.Name = "data_hk";
            this.data_hk.ReadOnly = true;
            this.data_hk.Size = new System.Drawing.Size(363, 185);
            this.data_hk.TabIndex = 0;
            this.data_hk.Text = "dataGridView3";
            this.groupBox4.Controls.Add(this.errormsg1);
            this.groupBox4.Controls.Add(this.hk_btn);
            this.groupBox4.Controls.Add(this.data_hk);
            this.groupBox4.Location = new System.Drawing.Point(423, 22);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(369, 247);
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
            this.errormsg1.Location = new System.Drawing.Point(63, 26);
            this.errormsg1.Name = "errormsg1";
            this.errormsg1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.errormsg1.Size = new System.Drawing.Size(219, 15);
            this.errormsg1.TabIndex = 2;
            this.errormsg1.Text = "Xin vui lòng chọn hành khách cho Đoàn";
            this.errormsg1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.errormsg1.Visible = false;
            // 
            // hk_btn
            // 
            this.hk_btn.Location = new System.Drawing.Point(288, 22);
            this.hk_btn.Name = "hk_btn";
            this.hk_btn.Size = new System.Drawing.Size(75, 23);
            this.hk_btn.TabIndex = 1;
            this.hk_btn.Text = "Chọn";
            this.hk_btn.UseVisualStyleBackColor = true;
            // 
            // statusd
            // 
            this.statusd.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.statusd.Location = new System.Drawing.Point(127, 150);
            this.statusd.Name = "statusd";
            this.statusd.Size = new System.Drawing.Size(265, 96);
            this.statusd.TabIndex = 2;
            this.statusd.Text = "";
            // 
            // tend
            // 
            this.tend.Location = new System.Drawing.Point(127, 78);
            this.tend.Name = "tend";
            this.tend.Size = new System.Drawing.Size(265, 23);
            this.tend.TabIndex = 1;
            // 
            // mad
            // 
            this.mad.Location = new System.Drawing.Point(127, 44);
            this.mad.Name = "mad";
            this.mad.Size = new System.Drawing.Size(265, 23);
            this.mad.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(18, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(112, 165);
            this.panel2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.PapayaWhip;
            this.label3.Location = new System.Drawing.Point(0, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Thông tin thêm";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.PapayaWhip;
            this.label4.Location = new System.Drawing.Point(0, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tour";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.PapayaWhip;
            this.label2.Location = new System.Drawing.Point(0, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Đoàn";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.PapayaWhip;
            this.label1.Location = new System.Drawing.Point(0, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 23);
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
            this.groupBox2.Location = new System.Drawing.Point(12, 313);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(392, 238);
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
            this.errormsg2.Location = new System.Drawing.Point(86, 43);
            this.errormsg2.Name = "errormsg2";
            this.errormsg2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.errormsg2.Size = new System.Drawing.Size(209, 15);
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
            this.Delete});
            this.data_nv.Location = new System.Drawing.Point(6, 68);
            this.data_nv.Name = "data_nv";
            this.data_nv.ReadOnly = true;
            this.data_nv.Size = new System.Drawing.Size(380, 164);
            this.data_nv.TabIndex = 2;
            this.data_nv.Text = "dataGridView1";
            // 
            // MaNV
            // 
            this.MaNV.FillWeight = 70F;
            this.MaNV.HeaderText = "Mã NV";
            this.MaNV.Name = "MaNV";
            this.MaNV.ReadOnly = true;
            this.MaNV.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaNV.Width = 70;
            // 
            // Ten
            // 
            this.Ten.HeaderText = "Tên";
            this.Ten.Name = "Ten";
            this.Ten.ReadOnly = true;
            this.Ten.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // VT
            // 
            this.VT.HeaderText = "Vị Trí";
            this.VT.Name = "VT";
            this.VT.ReadOnly = true;
            this.VT.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Delete
            // 
            this.Delete.FillWeight = 50F;
            this.Delete.HeaderText = "Xóa";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.Text = "Xóa";
            this.Delete.Width = 50;
            // 
            // nv_btn
            // 
            this.nv_btn.Location = new System.Drawing.Point(311, 39);
            this.nv_btn.Name = "nv_btn";
            this.nv_btn.Size = new System.Drawing.Size(75, 23);
            this.nv_btn.TabIndex = 1;
            this.nv_btn.Text = "Chọn";
            this.nv_btn.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlLightLight;
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
            this.Delete1});
            this.data_cp.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.data_cp.Location = new System.Drawing.Point(7, 68);
            this.data_cp.Name = "data_cp";
            this.data_cp.ReadOnly = true;
            this.data_cp.Size = new System.Drawing.Size(349, 164);
            this.data_cp.TabIndex = 2;
            this.data_cp.Text = "dataGridView2";
            this.groupBox3.Controls.Add(this.errormsg3);
            this.groupBox3.Controls.Add(this.data_cp);
            this.groupBox3.Controls.Add(this.cp_btn);
            this.groupBox3.Location = new System.Drawing.Point(441, 313);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(363, 238);
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
            this.errormsg3.Location = new System.Drawing.Point(81, 43);
            this.errormsg3.Name = "errormsg3";
            this.errormsg3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.errormsg3.Size = new System.Drawing.Size(193, 15);
            this.errormsg3.TabIndex = 2;
            this.errormsg3.Text = "Xin vui lòng chọn chi phí cho Đoàn";
            this.errormsg3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.errormsg3.Visible = false;
            // 
            // LoaiCP
            // 
            this.LoaiCP.FillWeight = 150F;
            this.LoaiCP.HeaderText = "Loại Chi Phí";
            this.LoaiCP.Name = "LoaiCP";
            this.LoaiCP.ReadOnly = true;
            this.LoaiCP.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.LoaiCP.Width = 150;
            // 
            // Tien
            // 
            this.Tien.HeaderText = "Số tiền (VND)";
            this.Tien.Name = "Tien";
            this.Tien.ReadOnly = true;
            this.Tien.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Delete1
            // 
            this.Delete1.FillWeight = 50F;
            this.Delete1.HeaderText = "Xóa";
            this.Delete1.Name = "Delete1";
            this.Delete1.ReadOnly = true;
            this.Delete1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete1.Text = "Xóa";
            this.Delete1.Width = 50;
            // 
            // cp_btn
            // 
            this.cp_btn.Location = new System.Drawing.Point(280, 39);
            this.cp_btn.Name = "cp_btn";
            this.cp_btn.Size = new System.Drawing.Size(75, 23);
            this.cp_btn.TabIndex = 1;
            this.cp_btn.Text = "Chọn";
            this.cp_btn.UseVisualStyleBackColor = true;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(692, 557);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(106, 35);
            this.Save.TabIndex = 3;
            this.Save.Text = "Lưu";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.button4_Click);
            // 
            // Ma_HK
            // 
            this.Ma_HK.FillWeight = 70F;
            this.Ma_HK.HeaderText = "Mã HK";
            this.Ma_HK.Name = "Ma_HK";
            this.Ma_HK.ReadOnly = true;
            this.Ma_HK.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Ma_HK.Width = 70;
            // 
            // Ten_HK
            // 
            this.Ten_HK.HeaderText = "Tên HK";
            this.Ten_HK.Name = "Ten_HK";
            this.Ten_HK.ReadOnly = true;
            this.Ten_HK.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // SDTHK
            // 
            this.SDTHK.HeaderText = "SDT";
            this.SDTHK.Name = "SDTHK";
            this.SDTHK.ReadOnly = true;
            this.SDTHK.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // DeleteHK
            // 
            this.DeleteHK.FillWeight = 50F;
            this.DeleteHK.HeaderText = "Xóa";
            this.DeleteHK.Name = "DeleteHK";
            this.DeleteHK.ReadOnly = true;
            this.DeleteHK.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DeleteHK.Text = "Xóa";
            this.DeleteHK.ToolTipText = "Xóa";
            this.DeleteHK.Width = 50;
            // 
            // DoanKhach_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 604);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "DoanKhach_Form";
            this.Text = "DoanKhach_Form";
            this.Load += new System.EventHandler(this.DoanKhach_Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_hk)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_nv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_cp)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn VT;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiCP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tien;
        private System.Windows.Forms.DataGridViewButtonColumn Delete1;
        private System.Windows.Forms.Label errormsg1;
        private System.Windows.Forms.Label errormsg2;
        private System.Windows.Forms.Label errormsg3;
        private System.Windows.Forms.Label errormsg0;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_HK;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_HK;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDTHK;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteHK;
    }
}