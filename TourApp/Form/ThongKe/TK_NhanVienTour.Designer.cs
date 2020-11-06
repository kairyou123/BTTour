namespace TourApp
{
    partial class TK_NhanVienTour
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
            this.lv = new System.Windows.Forms.ListView();
            this.maNV = new System.Windows.Forms.ColumnHeader();
            this.tenNV = new System.Windows.Forms.ColumnHeader();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.lbl_ten = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.dateStartPicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateEndPicker = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lv
            // 
            this.lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.maNV,
            this.tenNV,
            this.columnHeader1});
            this.lv.Enabled = false;
            this.lv.FullRowSelect = true;
            this.lv.HideSelection = false;
            this.lv.Location = new System.Drawing.Point(13, 111);
            this.lv.MultiSelect = false;
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(775, 327);
            this.lv.TabIndex = 0;
            this.lv.UseCompatibleStateImageBehavior = false;
            this.lv.View = System.Windows.Forms.View.Details;
            // 
            // maNV
            // 
            this.maNV.Text = "Mã Nhân Viên";
            this.maNV.Width = 200;
            // 
            // tenNV
            // 
            this.tenNV.Text = "Tên Nhân Viên";
            this.tenNV.Width = 440;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Số lần đi Tour";
            this.columnHeader1.Width = 120;
            // 
            // lbl_ten
            // 
            this.lbl_ten.AutoSize = true;
            this.lbl_ten.Location = new System.Drawing.Point(13, 53);
            this.lbl_ten.Name = "lbl_ten";
            this.lbl_ten.Size = new System.Drawing.Size(25, 15);
            this.lbl_ten.TabIndex = 1;
            this.lbl_ten.Text = "Tên";
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.title.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.title.Location = new System.Drawing.Point(0, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(801, 36);
            this.title.TabIndex = 2;
            this.title.Text = "SỐ LẦN NHÂN VIÊN ĐI TOUR";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateStartPicker
            // 
            this.dateStartPicker.Location = new System.Drawing.Point(27, 32);
            this.dateStartPicker.Name = "dateStartPicker";
            this.dateStartPicker.Size = new System.Drawing.Size(132, 23);
            this.dateStartPicker.TabIndex = 3;
            this.dateStartPicker.Value = new System.DateTime(2019, 11, 6, 14, 26, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Đến ngày";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Từ ngày";
            // 
            // dateEndPicker
            // 
            this.dateEndPicker.Location = new System.Drawing.Point(184, 32);
            this.dateEndPicker.Name = "dateEndPicker";
            this.dateEndPicker.Size = new System.Drawing.Size(144, 23);
            this.dateEndPicker.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn);
            this.panel1.Controls.Add(this.dateStartPicker);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dateEndPicker);
            this.panel1.Location = new System.Drawing.Point(275, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(513, 66);
            this.panel1.TabIndex = 5;
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(13, 74);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(256, 23);
            this.txt_search.TabIndex = 6;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(397, 32);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(99, 23);
            this.btn.TabIndex = 5;
            this.btn.Text = "Thống kê";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // TK_NhanVienTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.lbl_ten);
            this.Controls.Add(this.lv);
            this.Name = "TK_NhanVienTour";
            this.Text = "Thống Kê";
            this.Load += new System.EventHandler(this.TK_NhanVienTour_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv;
        private System.Windows.Forms.Label lbl_ten;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.DateTimePicker dateStartPicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateEndPicker;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.ColumnHeader maNV;
        private System.Windows.Forms.ColumnHeader tenNV;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btn;
    }
}