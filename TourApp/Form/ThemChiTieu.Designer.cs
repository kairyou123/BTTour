namespace TourApp
{
    partial class ThemChiTieu
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
            this.CTname = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CTnameer = new System.Windows.Forms.Label();
            this.Submitbt = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên chi tiêu";
            // 
            // CTname
            // 
            this.CTname.Location = new System.Drawing.Point(42, 69);
            this.CTname.Name = "CTname";
            this.CTname.Size = new System.Drawing.Size(380, 23);
            this.CTname.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CTnameer);
            this.groupBox1.Controls.Add(this.Submitbt);
            this.groupBox1.Controls.Add(this.CTname);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 248);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiêu";
            // 
            // CTnameer
            // 
            this.CTnameer.AutoSize = true;
            this.CTnameer.ForeColor = System.Drawing.Color.Red;
            this.CTnameer.Location = new System.Drawing.Point(156, 51);
            this.CTnameer.Name = "CTnameer";
            this.CTnameer.Size = new System.Drawing.Size(38, 15);
            this.CTnameer.TabIndex = 6;
            this.CTnameer.Text = "label3";
            this.CTnameer.Visible = false;
            // 
            // Submitbt
            // 
            this.Submitbt.Location = new System.Drawing.Point(156, 126);
            this.Submitbt.Name = "Submitbt";
            this.Submitbt.Size = new System.Drawing.Size(139, 58);
            this.Submitbt.TabIndex = 5;
            this.Submitbt.Text = "Save";
            this.Submitbt.UseVisualStyleBackColor = true;
            this.Submitbt.Click += new System.EventHandler(this.Submitbt_Click_1);
            // 
            // ThemChiTieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 268);
            this.Controls.Add(this.groupBox1);
            this.Name = "ThemChiTieu";
            this.Text = "ThemChiTieu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CTname;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label CTnameer;
        private System.Windows.Forms.Button Submitbt;
    }
}