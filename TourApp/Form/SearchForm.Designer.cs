namespace TourApp
{
    partial class SearchForm
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
            this.btn_search = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lv_radio = new System.Windows.Forms.ListView();
            this.lv_search = new System.Windows.Forms.ListView();
            this.ID = new System.Windows.Forms.ColumnHeader();
            this.MaSo = new System.Windows.Forms.ColumnHeader();
            this.name = new System.Windows.Forms.ColumnHeader();
            this.title = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_select = new System.Windows.Forms.Button();
            this.text_search = new System.Windows.Forms.TextBox();
            this.txt_option = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.TextBox();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.errorlbl = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(58, 115);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(85, 27);
            this.btn_search.TabIndex = 0;
            this.btn_search.Text = "Tìm Kiếm";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Controls.Add(this.lv_radio);
            this.panel3.Controls.Add(this.lv_search);
            this.panel3.Location = new System.Drawing.Point(200, 55);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(326, 290);
            this.panel3.TabIndex = 0;
            // 
            // lv_radio
            // 
            this.lv_radio.CheckBoxes = true;
            this.lv_radio.FullRowSelect = true;
            this.lv_radio.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv_radio.HideSelection = false;
            this.lv_radio.Location = new System.Drawing.Point(39, 60);
            this.lv_radio.MultiSelect = false;
            this.lv_radio.Name = "lv_radio";
            this.lv_radio.Size = new System.Drawing.Size(56, 102);
            this.lv_radio.TabIndex = 0;
            this.lv_radio.UseCompatibleStateImageBehavior = false;
            this.lv_radio.View = System.Windows.Forms.View.Details;
            this.lv_radio.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lv_radio_ItemCheck);
            // 
            // lv_search
            // 
            this.lv_search.CheckBoxes = true;
            this.lv_search.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.MaSo,
            this.name});
            this.lv_search.FullRowSelect = true;
            this.lv_search.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv_search.HideSelection = false;
            this.lv_search.Location = new System.Drawing.Point(12, 16);
            this.lv_search.MultiSelect = false;
            this.lv_search.Name = "lv_search";
            this.lv_search.Size = new System.Drawing.Size(300, 260);
            this.lv_search.TabIndex = 0;
            this.lv_search.UseCompatibleStateImageBehavior = false;
            this.lv_search.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // MaSo
            // 
            this.MaSo.Text = "Mã Số";
            this.MaSo.Width = 100;
            // 
            // name
            // 
            this.name.Text = "Tên";
            this.name.Width = 110;
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.title.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.title.Location = new System.Drawing.Point(24, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(502, 39);
            this.title.TabIndex = 1;
            this.title.Text = "SEARCH CONTROL";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox1.Location = new System.Drawing.Point(24, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(46, 23);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "TÊN";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_select
            // 
            this.btn_select.Location = new System.Drawing.Point(109, 318);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(85, 27);
            this.btn_select.TabIndex = 0;
            this.btn_select.Text = "OK";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // text_search
            // 
            this.text_search.ForeColor = System.Drawing.SystemColors.InfoText;
            this.text_search.Location = new System.Drawing.Point(24, 85);
            this.text_search.Name = "text_search";
            this.text_search.Size = new System.Drawing.Size(170, 23);
            this.text_search.TabIndex = 3;
            // 
            // txt_option
            // 
            this.txt_option.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txt_option.Location = new System.Drawing.Point(24, 178);
            this.txt_option.Name = "txt_option";
            this.txt_option.Size = new System.Drawing.Size(170, 23);
            this.txt_option.TabIndex = 3;
            this.txt_option.Visible = false;
            // 
            // lbl
            // 
            this.lbl.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl.Location = new System.Drawing.Point(24, 149);
            this.lbl.Name = "lbl";
            this.lbl.ReadOnly = true;
            this.lbl.Size = new System.Drawing.Size(46, 23);
            this.lbl.TabIndex = 2;
            this.lbl.Text = "TÊN";
            this.lbl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lbl.Visible = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "columnHeader1";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mã Số";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tên";
            this.columnHeader3.Width = 110;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "columnHeader4";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Mã Số";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tên";
            this.columnHeader6.Width = 110;
            // 
            // errorlbl
            // 
            this.errorlbl.AutoSize = true;
            this.errorlbl.ForeColor = System.Drawing.Color.Red;
            this.errorlbl.Location = new System.Drawing.Point(76, 145);
            this.errorlbl.MaximumSize = new System.Drawing.Size(130, 0);
            this.errorlbl.Name = "errorlbl";
            this.errorlbl.Size = new System.Drawing.Size(124, 30);
            this.errorlbl.TabIndex = 4;
            this.errorlbl.Text = "Xin nhập số và không để trống";
            this.errorlbl.Visible = false;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 357);
            this.Controls.Add(this.errorlbl);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.txt_option);
            this.Controls.Add(this.text_search);
            this.Controls.Add(this.btn_select);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btn_search);
            this.MaximizeBox = false;
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView lv_search;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.TextBox text_search;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader MaSo;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ListView lv_radio;
        private System.Windows.Forms.TextBox txt_option;
        private System.Windows.Forms.TextBox lbl;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label errorlbl;
    }
}