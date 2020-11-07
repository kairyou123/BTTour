namespace TourApp
{
    partial class ThemLHDuLich
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
            this.Savebtt = new System.Windows.Forms.Button();
            this.errorlabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Mota = new System.Windows.Forms.RichTextBox();
            this.LHname = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Savebtt);
            this.groupBox1.Controls.Add(this.errorlabel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Mota);
            this.groupBox1.Controls.Add(this.LHname);
            this.groupBox1.Location = new System.Drawing.Point(0, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(570, 341);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin loại hình du lịch";
            // 
            // Savebtt
            // 
            this.Savebtt.Location = new System.Drawing.Point(210, 281);
            this.Savebtt.Name = "Savebtt";
            this.Savebtt.Size = new System.Drawing.Size(121, 49);
            this.Savebtt.TabIndex = 5;
            this.Savebtt.Text = "SAVE";
            this.Savebtt.UseVisualStyleBackColor = true;
            this.Savebtt.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorlabel
            // 
            this.errorlabel.AutoSize = true;
            this.errorlabel.ForeColor = System.Drawing.Color.Red;
            this.errorlabel.Location = new System.Drawing.Point(161, 39);
            this.errorlabel.Name = "errorlabel";
            this.errorlabel.Size = new System.Drawing.Size(38, 15);
            this.errorlabel.TabIndex = 4;
            this.errorlabel.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mô tả";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên loại hình";
            // 
            // Mota
            // 
            this.Mota.Location = new System.Drawing.Point(50, 119);
            this.Mota.Name = "Mota";
            this.Mota.Size = new System.Drawing.Size(453, 134);
            this.Mota.TabIndex = 1;
            this.Mota.Text = "";
            // 
            // LHname
            // 
            this.LHname.Location = new System.Drawing.Point(50, 59);
            this.LHname.Name = "LHname";
            this.LHname.Size = new System.Drawing.Size(453, 23);
            this.LHname.TabIndex = 0;
            // 
            // ThemLHDuLich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 344);
            this.Controls.Add(this.groupBox1);
            this.Name = "ThemLHDuLich";
            this.Text = "ThemLHDuLich";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox LHname;
        private System.Windows.Forms.RichTextBox Mota;
        private System.Windows.Forms.Button Savebtt;
        private System.Windows.Forms.Label errorlabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}