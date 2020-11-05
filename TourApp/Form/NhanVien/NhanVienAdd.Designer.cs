namespace TourApp
{
    partial class NhanVienAdd
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.err_msg4 = new System.Windows.Forms.Label();
            this.err_msg2 = new System.Windows.Forms.Label();
            this.err_msg1 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.btn = new System.Windows.Forms.Button();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LBL1 = new System.Windows.Forms.Label();
            this.LBL = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.Controls.Add(this.err_msg4);
            this.panel1.Controls.Add(this.err_msg2);
            this.panel1.Controls.Add(this.err_msg1);
            this.panel1.Controls.Add(this.title);
            this.panel1.Controls.Add(this.btn);
            this.panel1.Controls.Add(this.txt_phone);
            this.panel1.Controls.Add(this.txt_name);
            this.panel1.Controls.Add(this.txt_id);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.LBL1);
            this.panel1.Controls.Add(this.LBL);
            this.panel1.Location = new System.Drawing.Point(20, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 426);
            this.panel1.TabIndex = 0;
            // 
            // err_msg4
            // 
            this.err_msg4.AutoSize = true;
            this.err_msg4.ForeColor = System.Drawing.Color.Red;
            this.err_msg4.Location = new System.Drawing.Point(136, 182);
            this.err_msg4.Name = "err_msg4";
            this.err_msg4.Size = new System.Drawing.Size(44, 15);
            this.err_msg4.TabIndex = 7;
            this.err_msg4.Text = "label15";
            this.err_msg4.Visible = false;
            // 
            // err_msg2
            // 
            this.err_msg2.AutoSize = true;
            this.err_msg2.ForeColor = System.Drawing.Color.Red;
            this.err_msg2.Location = new System.Drawing.Point(136, 112);
            this.err_msg2.Name = "err_msg2";
            this.err_msg2.Size = new System.Drawing.Size(38, 15);
            this.err_msg2.TabIndex = 7;
            this.err_msg2.Text = "label4";
            this.err_msg2.Visible = false;
            // 
            // err_msg1
            // 
            this.err_msg1.AutoSize = true;
            this.err_msg1.ForeColor = System.Drawing.Color.Red;
            this.err_msg1.Location = new System.Drawing.Point(136, 46);
            this.err_msg1.Name = "err_msg1";
            this.err_msg1.Size = new System.Drawing.Size(38, 15);
            this.err_msg1.TabIndex = 7;
            this.err_msg1.Text = "label4";
            this.err_msg1.Visible = false;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.title.Location = new System.Drawing.Point(258, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(188, 30);
            this.title.TabIndex = 6;
            this.title.Text = "THÊM NHÂN VIÊN";
            // 
            // btn
            // 
            this.btn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn.Location = new System.Drawing.Point(605, 382);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(120, 31);
            this.btn.TabIndex = 9;
            this.btn.Text = "Xác Nhận";
            this.btn.UseVisualStyleBackColor = false;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(38, 213);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(272, 23);
            this.txt_phone.TabIndex = 3;
            this.txt_phone.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_KeyUp);
            this.txt_phone.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Validating);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(38, 143);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(270, 23);
            this.txt_name.TabIndex = 1;
            this.txt_name.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_KeyUp);
            this.txt_name.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Validating);
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(38, 75);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(270, 23);
            this.txt_id.TabIndex = 0;
            this.txt_id.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_KeyUp);
            this.txt_id.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(38, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Số Điện Thoại";
            // 
            // LBL1
            // 
            this.LBL1.AutoSize = true;
            this.LBL1.BackColor = System.Drawing.SystemColors.Info;
            this.LBL1.Location = new System.Drawing.Point(37, 112);
            this.LBL1.Name = "LBL1";
            this.LBL1.Size = new System.Drawing.Size(83, 15);
            this.LBL1.TabIndex = 1;
            this.LBL1.Text = "Tên Nhân Viên";
            // 
            // LBL
            // 
            this.LBL.AutoSize = true;
            this.LBL.BackColor = System.Drawing.SystemColors.Info;
            this.LBL.Location = new System.Drawing.Point(38, 46);
            this.LBL.Name = "LBL";
            this.LBL.Size = new System.Drawing.Size(82, 15);
            this.LBL.TabIndex = 0;
            this.LBL.Text = "Mã Nhân Viên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(171, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(224, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(224, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "label4";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(258, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(210, 30);
            this.label9.TabIndex = 6;
            this.label9.Text = "THÊM HÀNH KHÁCH";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(460, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 31);
            this.button1.TabIndex = 5;
            this.button1.Text = "Xác Nhận";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(156, 287);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(226, 23);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(156, 207);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(424, 23);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(156, 144);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(424, 23);
            this.textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(156, 75);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(424, 23);
            this.textBox4.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Info;
            this.label10.Location = new System.Drawing.Point(116, 182);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 15);
            this.label10.TabIndex = 3;
            this.label10.Text = "Email";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Info;
            this.label11.Location = new System.Drawing.Point(116, 257);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 15);
            this.label11.TabIndex = 2;
            this.label11.Text = "Số Điện Thoại";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.Info;
            this.label12.Location = new System.Drawing.Point(116, 112);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 15);
            this.label12.TabIndex = 1;
            this.label12.Text = "Tên Khách Hàng";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.Info;
            this.label13.Location = new System.Drawing.Point(116, 46);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 15);
            this.label13.TabIndex = 0;
            this.label13.Text = "Mã Khách Hàng";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(171, 182);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 15);
            this.label14.TabIndex = 7;
            this.label14.Text = "label14";
            // 
            // NhanVienAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "NhanVienAdd";
            this.Text = "Hành Khách";
            this.Load += new System.EventHandler(this.NhanVienAdd_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBL1;
        private System.Windows.Forms.Label LBL;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label err_msg4;
        private System.Windows.Forms.Label err_msg2;
        private System.Windows.Forms.Label err_msg1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}
