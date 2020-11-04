
namespace TourApp
{
    partial class TKChiPhi_Form
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            this.tourRadioBtn = new System.Windows.Forms.RadioButton();
            this.ChitieuRadioBtn = new System.Windows.Forms.RadioButton();
            this.groupRadio = new System.Windows.Forms.GroupBox();
            this.fromDate = new System.Windows.Forms.DateTimePicker();
            this.toDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this.LoaiChiPhiCol = new System.Windows.Forms.ColumnHeader();
            this.SoTienCol = new System.Windows.Forms.ColumnHeader();
            this.SelectLabel = new System.Windows.Forms.Label();
            this.selectCbb = new System.Windows.Forms.ComboBox();
            this.thongkeBtn = new System.Windows.Forms.Button();
            this.groupRadio.SuspendLayout();
            this.SuspendLayout();
            // 
            // tourRadioBtn
            // 
            this.tourRadioBtn.AutoSize = true;
            this.tourRadioBtn.Checked = true;
            this.tourRadioBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tourRadioBtn.Location = new System.Drawing.Point(29, 37);
            this.tourRadioBtn.Name = "tourRadioBtn";
            this.tourRadioBtn.Size = new System.Drawing.Size(59, 24);
            this.tourRadioBtn.TabIndex = 1;
            this.tourRadioBtn.TabStop = true;
            this.tourRadioBtn.Text = "Tour";
            this.tourRadioBtn.UseVisualStyleBackColor = true;
            this.tourRadioBtn.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // ChitieuRadioBtn
            // 
            this.ChitieuRadioBtn.AutoSize = true;
            this.ChitieuRadioBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChitieuRadioBtn.Location = new System.Drawing.Point(113, 37);
            this.ChitieuRadioBtn.Name = "ChitieuRadioBtn";
            this.ChitieuRadioBtn.Size = new System.Drawing.Size(80, 24);
            this.ChitieuRadioBtn.TabIndex = 2;
            this.ChitieuRadioBtn.Text = "Chi tiêu";
            this.ChitieuRadioBtn.UseVisualStyleBackColor = true;
            this.ChitieuRadioBtn.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // groupRadio
            // 
            this.groupRadio.Controls.Add(this.ChitieuRadioBtn);
            this.groupRadio.Controls.Add(this.tourRadioBtn);
            this.groupRadio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupRadio.Location = new System.Drawing.Point(7, 19);
            this.groupRadio.Name = "groupRadio";
            this.groupRadio.Size = new System.Drawing.Size(210, 85);
            this.groupRadio.TabIndex = 3;
            this.groupRadio.TabStop = false;
            this.groupRadio.Text = "Thống kê chi phí theo";
            // 
            // fromDate
            // 
            this.fromDate.Location = new System.Drawing.Point(295, 66);
            this.fromDate.Name = "fromDate";
            this.fromDate.Size = new System.Drawing.Size(250, 27);
            this.fromDate.TabIndex = 4;
            // 
            // toDate
            // 
            this.toDate.Location = new System.Drawing.Point(578, 66);
            this.toDate.Name = "toDate";
            this.toDate.Size = new System.Drawing.Size(250, 27);
            this.toDate.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Từ ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(578, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Đến ngày";
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.LoaiChiPhiCol,
            this.SoTienCol});
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "ListViewGroup";
            this.listView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(4, 213);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(869, 379);
            this.listView.TabIndex = 8;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // LoaiChiPhiCol
            // 
            this.LoaiChiPhiCol.Text = "Loại chi phí";
            this.LoaiChiPhiCol.Width = 600;
            // 
            // SoTienCol
            // 
            this.SoTienCol.Text = "Số tiền";
            this.SoTienCol.Width = 250;
            // 
            // SelectLabel
            // 
            this.SelectLabel.AutoSize = true;
            this.SelectLabel.Location = new System.Drawing.Point(8, 111);
            this.SelectLabel.Name = "SelectLabel";
            this.SelectLabel.Size = new System.Drawing.Size(49, 20);
            this.SelectLabel.TabIndex = 9;
            this.SelectLabel.Text = "Select";
            // 
            // selectCbb
            // 
            this.selectCbb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.selectCbb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.selectCbb.FormattingEnabled = true;
            this.selectCbb.Location = new System.Drawing.Point(8, 135);
            this.selectCbb.Name = "selectCbb";
            this.selectCbb.Size = new System.Drawing.Size(209, 28);
            this.selectCbb.TabIndex = 10;
            this.selectCbb.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.selectCbb_Format);
            // 
            // thongkeBtn
            // 
            this.thongkeBtn.Location = new System.Drawing.Point(763, 172);
            this.thongkeBtn.Name = "thongkeBtn";
            this.thongkeBtn.Size = new System.Drawing.Size(94, 29);
            this.thongkeBtn.TabIndex = 11;
            this.thongkeBtn.Text = "Thống kê";
            this.thongkeBtn.UseVisualStyleBackColor = true;
            this.thongkeBtn.Click += new System.EventHandler(this.thongkeBtn_Click);
            // 
            // TKChiPhi_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 608);
            this.Controls.Add(this.thongkeBtn);
            this.Controls.Add(this.selectCbb);
            this.Controls.Add(this.SelectLabel);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toDate);
            this.Controls.Add(this.fromDate);
            this.Controls.Add(this.groupRadio);
            this.Name = "TKChiPhi_Form";
            this.Text = "Thống kê chi phí";
            this.Load += new System.EventHandler(this.TKChiPhi_Form_Load);
            this.groupRadio.ResumeLayout(false);
            this.groupRadio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton tourRadioBtn;
        private System.Windows.Forms.RadioButton ChitieuRadioBtn;
        private System.Windows.Forms.GroupBox groupRadio;
        private System.Windows.Forms.DateTimePicker fromDate;
        private System.Windows.Forms.DateTimePicker toDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Label SelectLabel;
        private System.Windows.Forms.ComboBox selectCbb;
        private System.Windows.Forms.ColumnHeader LoaiChiPhiCol;
        private System.Windows.Forms.ColumnHeader SoTienCol;
        private System.Windows.Forms.Button thongkeBtn;
    }
}