namespace TourApp
{
    partial class ThemGia
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
            this.button1 = new System.Windows.Forms.Button();
            this.denngay = new System.Windows.Forms.DateTimePicker();
            this.tungay = new System.Windows.Forms.DateTimePicker();
            this.mucgia = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.mucgia)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(194, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // denngay
            // 
            this.denngay.Location = new System.Drawing.Point(95, 92);
            this.denngay.Name = "denngay";
            this.denngay.Size = new System.Drawing.Size(213, 23);
            this.denngay.TabIndex = 4;
            // 
            // tungay
            // 
            this.tungay.Location = new System.Drawing.Point(95, 57);
            this.tungay.Name = "tungay";
            this.tungay.Size = new System.Drawing.Size(213, 23);
            this.tungay.TabIndex = 3;
            // 
            // mucgia
            // 
            this.mucgia.Location = new System.Drawing.Point(95, 25);
            this.mucgia.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.mucgia.Name = "mucgia";
            this.mucgia.Size = new System.Drawing.Size(213, 23);
            this.mucgia.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đến ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Từ ngày";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mức giá";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.denngay);
            this.panel1.Controls.Add(this.tungay);
            this.panel1.Controls.Add(this.mucgia);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(55, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 143);
            this.panel1.TabIndex = 0;
            // 
            // ThemGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 281);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Name = "ThemGia";
            this.Text = "ThemGia";
            ((System.ComponentModel.ISupportInitialize)(this.mucgia)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker denngay;
        private System.Windows.Forms.DateTimePicker tungay;
        private System.Windows.Forms.NumericUpDown mucgia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
    }
}