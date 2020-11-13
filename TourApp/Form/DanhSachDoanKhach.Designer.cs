namespace TourApp
{
    partial class DanhSachDoanKhach
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
            this.doankhachlist = new System.Windows.Forms.ListView();
            this.MaDoan = new System.Windows.Forms.ColumnHeader();
            this.TenDoan = new System.Windows.Forms.ColumnHeader();
            this.ChiTiet = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // doankhachlist
            // 
            this.doankhachlist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaDoan,
            this.TenDoan,
            this.ChiTiet});
            this.doankhachlist.HideSelection = false;
            this.doankhachlist.Location = new System.Drawing.Point(1, 6);
            this.doankhachlist.MultiSelect = false;
            this.doankhachlist.Name = "doankhachlist";
            this.doankhachlist.Size = new System.Drawing.Size(686, 426);
            this.doankhachlist.TabIndex = 0;
            this.doankhachlist.UseCompatibleStateImageBehavior = false;
            this.doankhachlist.View = System.Windows.Forms.View.Details;
            // 
            // MaDoan
            // 
            this.MaDoan.Text = "Mã Đoàn";
            this.MaDoan.Width = 100;
            // 
            // TenDoan
            // 
            this.TenDoan.Text = "Tên Đoàn";
            this.TenDoan.Width = 150;
            // 
            // ChiTiet
            // 
            this.ChiTiet.Text = "Chi Tiết Đoàn";
            this.ChiTiet.Width = 430;
            // 
            // DanhSachDoanKhach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 444);
            this.Controls.Add(this.doankhachlist);
            this.Name = "DanhSachDoanKhach";
            this.Text = "DanhSachDoanKhach";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView doankhachlist;
        private System.Windows.Forms.ColumnHeader MaDoan;
        private System.Windows.Forms.ColumnHeader TenDoan;
        private System.Windows.Forms.ColumnHeader ChiTiet;
    }
}