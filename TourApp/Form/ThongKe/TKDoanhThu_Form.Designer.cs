namespace TourApp
{
    partial class TKDoanhThu_Form
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("babc", System.Windows.Forms.HorizontalAlignment.Left);
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lv = new System.Windows.Forms.ListView();
            this.radio_doan = new System.Windows.Forms.RadioButton();
            this.radio_tour = new System.Windows.Forms.RadioButton();
            this.datestart = new System.Windows.Forms.DateTimePicker();
            this.dateend = new System.Windows.Forms.DateTimePicker();
            this.lbl_start = new System.Windows.Forms.Label();
            this.lbl_end = new System.Windows.Forms.Label();
            this.search_panel = new System.Windows.Forms.Panel();
            this.lv_doanhthu1 = new System.Windows.Forms.ListView();
            this.lcp = new System.Windows.Forms.ColumnHeader();
            this.sotien = new System.Windows.Forms.ColumnHeader();
            this.panel1.SuspendLayout();
            this.search_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(1, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(837, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "DOANH THU";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.lv);
            this.panel1.Controls.Add(this.radio_doan);
            this.panel1.Controls.Add(this.radio_tour);
            this.panel1.Location = new System.Drawing.Point(13, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 366);
            this.panel1.TabIndex = 1;
            // 
            // lv
            // 
            this.lv.FullRowSelect = true;
            this.lv.HideSelection = false;
            this.lv.Location = new System.Drawing.Point(10, 64);
            this.lv.MultiSelect = false;
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(254, 287);
            this.lv.TabIndex = 1;
            this.lv.UseCompatibleStateImageBehavior = false;
            this.lv.View = System.Windows.Forms.View.Details;
            this.lv.SelectedIndexChanged += new System.EventHandler(this.lv_SelectedIndexChanged);
            // 
            // radio_doan
            // 
            this.radio_doan.AutoSize = true;
            this.radio_doan.Location = new System.Drawing.Point(178, 21);
            this.radio_doan.Name = "radio_doan";
            this.radio_doan.Size = new System.Drawing.Size(53, 19);
            this.radio_doan.TabIndex = 0;
            this.radio_doan.Text = "Đoàn";
            this.radio_doan.UseVisualStyleBackColor = true;
            this.radio_doan.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // radio_tour
            // 
            this.radio_tour.AutoSize = true;
            this.radio_tour.Checked = true;
            this.radio_tour.Location = new System.Drawing.Point(19, 21);
            this.radio_tour.Name = "radio_tour";
            this.radio_tour.Size = new System.Drawing.Size(48, 19);
            this.radio_tour.TabIndex = 0;
            this.radio_tour.TabStop = true;
            this.radio_tour.Text = "Tour";
            this.radio_tour.UseVisualStyleBackColor = true;
            this.radio_tour.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // datestart
            // 
            this.datestart.Location = new System.Drawing.Point(18, 48);
            this.datestart.Name = "datestart";
            this.datestart.Size = new System.Drawing.Size(139, 23);
            this.datestart.TabIndex = 3;
            this.datestart.Value = new System.DateTime(2019, 11, 6, 14, 26, 0, 0);
            this.datestart.ValueChanged += new System.EventHandler(this.date_ValueChanged);
            // 
            // dateend
            // 
            this.dateend.Location = new System.Drawing.Point(184, 48);
            this.dateend.Name = "dateend";
            this.dateend.Size = new System.Drawing.Size(151, 23);
            this.dateend.TabIndex = 3;
            this.dateend.ValueChanged += new System.EventHandler(this.date_ValueChanged);
            // 
            // lbl_start
            // 
            this.lbl_start.AutoSize = true;
            this.lbl_start.Location = new System.Drawing.Point(18, 18);
            this.lbl_start.Name = "lbl_start";
            this.lbl_start.Size = new System.Drawing.Size(49, 15);
            this.lbl_start.TabIndex = 4;
            this.lbl_start.Text = "Từ ngày";
            // 
            // lbl_end
            // 
            this.lbl_end.AutoSize = true;
            this.lbl_end.Location = new System.Drawing.Point(184, 18);
            this.lbl_end.Name = "lbl_end";
            this.lbl_end.Size = new System.Drawing.Size(57, 15);
            this.lbl_end.TabIndex = 4;
            this.lbl_end.Text = "Đến ngày";
            this.lbl_end.Click += new System.EventHandler(this.label3_Click);
            // 
            // search_panel
            // 
            this.search_panel.Controls.Add(this.datestart);
            this.search_panel.Controls.Add(this.lbl_end);
            this.search_panel.Controls.Add(this.lbl_start);
            this.search_panel.Controls.Add(this.dateend);
            this.search_panel.Location = new System.Drawing.Point(305, 43);
            this.search_panel.Name = "search_panel";
            this.search_panel.Size = new System.Drawing.Size(520, 87);
            this.search_panel.TabIndex = 5;
            // 
            // lv_doanhthu1
            // 
            this.lv_doanhthu1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lcp,
            this.sotien});
            this.lv_doanhthu1.Enabled = false;
            this.lv_doanhthu1.FullRowSelect = true;
            listViewGroup1.Header = "babc";
            listViewGroup1.Name = "total";
            this.lv_doanhthu1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.lv_doanhthu1.HideSelection = false;
            this.lv_doanhthu1.Location = new System.Drawing.Point(305, 136);
            this.lv_doanhthu1.MultiSelect = false;
            this.lv_doanhthu1.Name = "lv_doanhthu1";
            this.lv_doanhthu1.Size = new System.Drawing.Size(520, 297);
            this.lv_doanhthu1.TabIndex = 1;
            this.lv_doanhthu1.UseCompatibleStateImageBehavior = false;
            this.lv_doanhthu1.View = System.Windows.Forms.View.Details;
            // 
            // lcp
            // 
            this.lcp.Text = "Loại Chi Phí";
            this.lcp.Width = 340;
            // 
            // sotien
            // 
            this.sotien.Text = "Số Tiền (VND)";
            this.sotien.Width = 170;
            // 
            // TKDoanhThu_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 457);
            this.Controls.Add(this.lv_doanhthu1);
            this.Controls.Add(this.search_panel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "TKDoanhThu_Form";
            this.Text = "Doanh Thu";
            this.Load += new System.EventHandler(this.TKDoanhThu_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.search_panel.ResumeLayout(false);
            this.search_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lv;
        private System.Windows.Forms.RadioButton radio_doan;
        private System.Windows.Forms.RadioButton radio_tour;
        private System.Windows.Forms.DateTimePicker datestart;
        private System.Windows.Forms.DateTimePicker dateend;
        private System.Windows.Forms.Label lbl_start;
        private System.Windows.Forms.Label lbl_end;
        private System.Windows.Forms.Panel search_panel;
        private System.Windows.Forms.ListView lv_doanhthu1;
        private System.Windows.Forms.ColumnHeader lcp;
        private System.Windows.Forms.ColumnHeader sotien;
    }
}