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
            this.SuspendLayout();
            // 
            // doankhachlist
            // 
            this.doankhachlist.HideSelection = false;
            this.doankhachlist.Location = new System.Drawing.Point(1, 8);
            this.doankhachlist.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.doankhachlist.MultiSelect = false;
            this.doankhachlist.Name = "doankhachlist";
            this.doankhachlist.Size = new System.Drawing.Size(783, 567);
            this.doankhachlist.TabIndex = 0;
            this.doankhachlist.UseCompatibleStateImageBehavior = false;
            // 
            // DanhSachDoanKhach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 592);
            this.Controls.Add(this.doankhachlist);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DanhSachDoanKhach";
            this.Text = "DanhSachDoanKhach";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView doankhachlist;
    }
}