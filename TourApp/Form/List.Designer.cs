using System.Windows.Forms;

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
            this.isDeleted_ChB = new System.Windows.Forms.CheckBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tourGridView = new System.Windows.Forms.DataGridView();
            this.TourIdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTourCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LHDLCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ViewCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.EditCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.Staff = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Destination = new System.Windows.Forms.TabPage();
            this.Group = new System.Windows.Forms.TabPage();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.DarkStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LightStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DefaultStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.tabControl1.SuspendLayout();
            this.Tour.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tourGridView)).BeginInit();
            this.Staff.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Tour);
            this.tabControl1.Controls.Add(this.Staff);
            this.tabControl1.Controls.Add(this.Destination);
            this.tabControl1.Controls.Add(this.Group);
            this.tabControl1.Location = new System.Drawing.Point(0, 26);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 2;
            this.tabControl1.Size = new System.Drawing.Size(684, 386);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // Tour
            // 
            this.Tour.Controls.Add(this.isDeleted_ChB);
            this.Tour.Controls.Add(this.btnRefresh);
            this.Tour.Controls.Add(this.button2);
            this.Tour.Controls.Add(this.tourGridView);
            this.Tour.Controls.Add(this.button1);
            this.Tour.Controls.Add(this.searchBox);
            this.Tour.Location = new System.Drawing.Point(4, 24);
            this.Tour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tour.Name = "Tour";
            this.Tour.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tour.Size = new System.Drawing.Size(676, 358);
            this.Tour.TabIndex = 0;
            this.Tour.Text = "Tour";
            this.Tour.UseVisualStyleBackColor = true;
            // 
            // isDeleted_ChB
            // 
            this.isDeleted_ChB.AutoSize = true;
            this.isDeleted_ChB.Location = new System.Drawing.Point(4, 74);
            this.isDeleted_ChB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.isDeleted_ChB.Name = "isDeleted_ChB";
            this.isDeleted_ChB.Size = new System.Drawing.Size(62, 19);
            this.isDeleted_ChB.TabIndex = 4;
            this.isDeleted_ChB.Text = "Đã xóa";
            this.isDeleted_ChB.UseVisualStyleBackColor = true;
            this.isDeleted_ChB.CheckedChanged += new System.EventHandler(this.isDeleted_CheckedChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.BackgroundImage")));
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.Location = new System.Drawing.Point(584, 74);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(36, 27);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(628, 74);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 27);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tourGridView
            // 
            this.tourGridView.AllowUserToAddRows = false;
            this.tourGridView.AllowUserToDeleteRows = false;
            this.tourGridView.AllowUserToOrderColumns = true;
            this.tourGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tourGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TourIdCol,
            this.MaTourCol,
            this.TenCol,
            this.LHDLCol,
            this.ViewCol,
            this.EditCol,
            this.DeleteCol});
            this.tourGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.tourGridView.Location = new System.Drawing.Point(3, 105);
            this.tourGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tourGridView.Name = "tourGridView";
            this.tourGridView.ReadOnly = true;
            this.tourGridView.RowHeadersVisible = false;
            this.tourGridView.RowHeadersWidth = 51;
            this.tourGridView.Size = new System.Drawing.Size(668, 280);
            this.tourGridView.TabIndex = 0;
            this.tourGridView.Text = "dataGridView1";
            this.tourGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tourGridView_CellClick);
            this.tourGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tourGridView_CellDoubleClick);
            this.tourGridView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.tourGridView_CellPainting_1);
            // 
            // TourIdCol
            // 
            this.TourIdCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TourIdCol.HeaderText = "TourID";
            this.TourIdCol.MinimumWidth = 6;
            this.TourIdCol.Name = "TourIdCol";
            this.TourIdCol.ReadOnly = true;
            this.TourIdCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TourIdCol.Width = 66;
            // 
            // MaTourCol
            // 
            this.MaTourCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MaTourCol.HeaderText = "Mã tour";
            this.MaTourCol.MinimumWidth = 6;
            this.MaTourCol.Name = "MaTourCol";
            this.MaTourCol.ReadOnly = true;
            this.MaTourCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaTourCol.Width = 69;
            // 
            // TenCol
            // 
            this.TenCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TenCol.HeaderText = "Tên";
            this.TenCol.MinimumWidth = 6;
            this.TenCol.Name = "TenCol";
            this.TenCol.ReadOnly = true;
            this.TenCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TenCol.Width = 50;
            // 
            // LHDLCol
            // 
            this.LHDLCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LHDLCol.HeaderText = "Loại hình du lịch";
            this.LHDLCol.MinimumWidth = 6;
            this.LHDLCol.Name = "LHDLCol";
            this.LHDLCol.ReadOnly = true;
            this.LHDLCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ViewCol
            // 
            this.ViewCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ViewCol.HeaderText = "Xem";
            this.ViewCol.MinimumWidth = 6;
            this.ViewCol.Name = "ViewCol";
            this.ViewCol.ReadOnly = true;
            this.ViewCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ViewCol.Width = 37;
            // 
            // EditCol
            // 
            this.EditCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.EditCol.HeaderText = "Sửa";
            this.EditCol.MinimumWidth = 6;
            this.EditCol.Name = "EditCol";
            this.EditCol.ReadOnly = true;
            this.EditCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EditCol.Width = 32;
            // 
            // DeleteCol
            // 
            this.DeleteCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.DeleteCol.HeaderText = "Xóa";
            this.DeleteCol.MinimumWidth = 6;
            this.DeleteCol.Name = "DeleteCol";
            this.DeleteCol.ReadOnly = true;
            this.DeleteCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DeleteCol.Width = 33;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(435, 9);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(37, 33);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchBox.Location = new System.Drawing.Point(482, 11);
            this.searchBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(189, 32);
            this.searchBox.TabIndex = 0;
            this.searchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchBox_KeyPress);
            // 
            // Staff
            // 
            this.Staff.Controls.Add(this.textBox1);
            this.Staff.Controls.Add(this.checkBox1);
            this.Staff.Controls.Add(this.button5);
            this.Staff.Controls.Add(this.button4);
            this.Staff.Controls.Add(this.button3);
            this.Staff.Location = new System.Drawing.Point(4, 24);
            this.Staff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Staff.Name = "Staff";
            this.Staff.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Staff.Size = new System.Drawing.Size(676, 358);
            this.Staff.TabIndex = 1;
            this.Staff.Text = "Nhân viên";
            this.Staff.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(532, 34);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(110, 23);
            this.textBox1.TabIndex = 4;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(206, 103);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(83, 19);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(396, 137);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(82, 22);
            this.button5.TabIndex = 2;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(505, 103);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(82, 22);
            this.button4.TabIndex = 1;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(435, 9);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(37, 33);
            this.button3.TabIndex = 0;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Destination
            // 
            this.Destination.Location = new System.Drawing.Point(4, 24);
            this.Destination.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Destination.Name = "Destination";
            this.Destination.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Destination.Size = new System.Drawing.Size(676, 358);
            this.Destination.TabIndex = 2;
            this.Destination.Text = "Địa điểm";
            this.Destination.UseVisualStyleBackColor = true;
            // 
            // Group
            // 
            this.Group.Location = new System.Drawing.Point(4, 24);
            this.Group.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Group.Name = "Group";
            this.Group.Size = new System.Drawing.Size(676, 358);
            this.Group.TabIndex = 3;
            this.Group.Text = "Đoàn";
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(684, 24);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menu";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(61, 20);
            this.toolStripMenuItem1.Text = "Settings";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DarkStripMenuItem,
            this.LightStripMenuItem,
            this.DefaultStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem2.Text = "Change theme";
            this.toolStripMenuItem2.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStripMenuItem2_DropDownItemClicked);
            // 
            // DarkStripMenuItem
            // 
            this.DarkStripMenuItem.CheckOnClick = true;
            this.DarkStripMenuItem.Name = "DarkStripMenuItem";
            this.DarkStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.DarkStripMenuItem.Text = "Dark ";
            // 
            // LightStripMenuItem
            // 
            this.LightStripMenuItem.CheckOnClick = true;
            this.LightStripMenuItem.Name = "LightStripMenuItem";
            this.LightStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.LightStripMenuItem.Text = "Light";
            // 
            // DefaultStripMenuItem
            // 
            this.DefaultStripMenuItem.Checked = true;
            this.DefaultStripMenuItem.CheckOnClick = true;
            this.DefaultStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DefaultStripMenuItem.Name = "DefaultStripMenuItem";
            this.DefaultStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.DefaultStripMenuItem.Text = "Default";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "Dark",
            "Light"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 28);
            // 
            // List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(684, 415);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "List";
            this.Text = "Danh sách";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.Tour.ResumeLayout(false);
            this.Tour.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tourGridView)).EndInit();
            this.Staff.ResumeLayout(false);
            this.Staff.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Tour;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.TabPage Staff;
        private System.Windows.Forms.TabPage Destination;
        private System.Windows.Forms.TabPage Group;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView tourGridView;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TourIdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTourCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn LHDLCol;
        private System.Windows.Forms.DataGridViewButtonColumn ViewCol;
        private System.Windows.Forms.DataGridViewButtonColumn EditCol;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteCol;
        private System.Windows.Forms.CheckBox isDeleted_ChB;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem DarkStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LightStripMenuItem;
        private ToolStripComboBox toolStripComboBox1;
        private ToolStripMenuItem DefaultStripMenuItem;
        private TextBox textBox1;
        private CheckBox checkBox1;
        private Button button5;
        private Button button4;
        private Button button3;
    }
}

