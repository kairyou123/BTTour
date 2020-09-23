namespace TourApp
{
    partial class List
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(List));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Tour = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Staff = new System.Windows.Forms.TabPage();
            this.Destination = new System.Windows.Forms.TabPage();
            this.Group = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Tour.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Tour);
            this.tabControl1.Controls.Add(this.Staff);
            this.tabControl1.Controls.Add(this.Destination);
            this.tabControl1.Controls.Add(this.Group);
            this.tabControl1.Location = new System.Drawing.Point(0, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 2;
            this.tabControl1.Size = new System.Drawing.Size(782, 555);
            this.tabControl1.TabIndex = 0;
            // 
            // Tour
            // 
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 140);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(768, 374);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.Text = "dataGridView1";
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.Tour.Controls.Add(this.dataGridView1);
            this.Tour.Controls.Add(this.button1);
            this.Tour.Controls.Add(this.textBox1);
            this.Tour.Location = new System.Drawing.Point(4, 29);
            this.Tour.Name = "Tour";
            this.Tour.Padding = new System.Windows.Forms.Padding(3);
            this.Tour.Size = new System.Drawing.Size(774, 522);
            this.Tour.TabIndex = 0;
            this.Tour.Text = "Tour";
            this.Tour.UseVisualStyleBackColor = true;
            this.Tour.Click += new System.EventHandler(this.Tour_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(497, 12);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(42, 44);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(551, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(205, 38);
            this.textBox1.TabIndex = 0;
            // 
            // Staff
            // 
            this.Staff.Location = new System.Drawing.Point(4, 29);
            this.Staff.Name = "Staff";
            this.Staff.Padding = new System.Windows.Forms.Padding(3);
            this.Staff.Size = new System.Drawing.Size(774, 522);
            this.Staff.TabIndex = 1;
            this.Staff.Text = "Nhân viên";
            this.Staff.UseVisualStyleBackColor = true;
            // 
            // Destination
            // 
            this.Destination.Location = new System.Drawing.Point(4, 29);
            this.Destination.Name = "Destination";
            this.Destination.Padding = new System.Windows.Forms.Padding(3);
            this.Destination.Size = new System.Drawing.Size(774, 522);
            this.Destination.TabIndex = 2;
            this.Destination.Text = "Địa điểm";
            this.Destination.UseVisualStyleBackColor = true;
            // 
            // Group
            // 
            this.Group.Location = new System.Drawing.Point(4, 29);
            this.Group.Name = "Group";
            this.Group.Size = new System.Drawing.Size(774, 522);
            this.Group.TabIndex = 3;
            this.Group.Text = "Đoàn";
            // 
            // List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "List";
            this.Text = "Danh sách";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Tour.ResumeLayout(false);
            this.Tour.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Tour;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage Staff;
        private System.Windows.Forms.TabPage Destination;
        private System.Windows.Forms.TabPage Group;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

