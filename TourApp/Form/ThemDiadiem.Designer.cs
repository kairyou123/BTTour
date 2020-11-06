namespace TourApp
{
    partial class ThemDiadiem
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Thoon = new System.Windows.Forms.GroupBox();
            this.savebtt = new System.Windows.Forms.Button();
            this.errorlabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.diadiemname = new System.Windows.Forms.TextBox();
            this.Thoon.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(156, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "label3";
            this.label1.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(156, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 58);
            this.button1.TabIndex = 5;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(42, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(380, 23);
            this.textBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên chi tiêu";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(42, 69);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(380, 23);
            this.textBox2.TabIndex = 3;
            // 
            // Thoon
            // 
            this.Thoon.Controls.Add(this.savebtt);
            this.Thoon.Controls.Add(this.errorlabel);
            this.Thoon.Controls.Add(this.label3);
            this.Thoon.Controls.Add(this.diadiemname);
            this.Thoon.Location = new System.Drawing.Point(2, 2);
            this.Thoon.Name = "Thoon";
            this.Thoon.Size = new System.Drawing.Size(444, 227);
            this.Thoon.TabIndex = 0;
            this.Thoon.TabStop = false;
            this.Thoon.Text = "Thông tin địa điểm";
            // 
            // savebtt
            // 
            this.savebtt.Location = new System.Drawing.Point(146, 126);
            this.savebtt.Name = "savebtt";
            this.savebtt.Size = new System.Drawing.Size(150, 57);
            this.savebtt.TabIndex = 3;
            this.savebtt.Text = "SAVE";
            this.savebtt.UseVisualStyleBackColor = true;
            this.savebtt.Click += new System.EventHandler(this.savebtt_Click);
            // 
            // errorlabel
            // 
            this.errorlabel.AutoSize = true;
            this.errorlabel.ForeColor = System.Drawing.Color.Red;
            this.errorlabel.Location = new System.Drawing.Point(146, 60);
            this.errorlabel.Name = "errorlabel";
            this.errorlabel.Size = new System.Drawing.Size(38, 15);
            this.errorlabel.TabIndex = 2;
            this.errorlabel.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên địa điểm";
            // 
            // diadiemname
            // 
            this.diadiemname.Location = new System.Drawing.Point(38, 81);
            this.diadiemname.Name = "diadiemname";
            this.diadiemname.Size = new System.Drawing.Size(359, 23);
            this.diadiemname.TabIndex = 0;
            // 
            // ThemDiadiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 234);
            this.Controls.Add(this.Thoon);
            this.Name = "ThemDiadiem";
            this.Thoon.ResumeLayout(false);
            this.Thoon.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox Thoon;
        private System.Windows.Forms.TextBox diadiemname;
        private System.Windows.Forms.Label errorlabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button savebtt;
    }
}