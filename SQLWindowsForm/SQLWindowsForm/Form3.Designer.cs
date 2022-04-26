namespace SQLWindowsForm
{
    partial class Form3
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
            System.Windows.Forms.Label label8;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cb_maLop = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ngaySinhtxt = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_gender = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.thoat = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.sua = new System.Windows.Forms.Button();
            this.them = new System.Windows.Forms.Button();
            this.addressedt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.phoneTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.emailedt = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.masvtxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tenSvTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DGV_sinhvien = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_sinhvien)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            label8.ForeColor = System.Drawing.Color.DeepSkyBlue;
            label8.Location = new System.Drawing.Point(207, 34);
            label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(433, 39);
            label8.TabIndex = 6;
            label8.Text = "Quản lý sinh viên chính quy";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cb_maLop);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.ngaySinhtxt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cb_gender);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.thoat);
            this.groupBox1.Controls.Add(this.Reset);
            this.groupBox1.Controls.Add(this.xoa);
            this.groupBox1.Controls.Add(this.sua);
            this.groupBox1.Controls.Add(this.them);
            this.groupBox1.Controls.Add(this.addressedt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.phoneTxt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.emailedt);
            this.groupBox1.Controls.Add(this.label);
            this.groupBox1.Controls.Add(this.masvtxt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tenSvTxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(19, 102);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(766, 308);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(654, 39);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "(*)";
            // 
            // cb_maLop
            // 
            this.cb_maLop.FormattingEnabled = true;
            this.cb_maLop.Location = new System.Drawing.Point(447, 38);
            this.cb_maLop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_maLop.Name = "cb_maLop";
            this.cb_maLop.Size = new System.Drawing.Size(204, 21);
            this.cb_maLop.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label9.Location = new System.Drawing.Point(383, 38);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 18);
            this.label9.TabIndex = 22;
            this.label9.Text = "Mã Lớp:";
            // 
            // ngaySinhtxt
            // 
            this.ngaySinhtxt.Location = new System.Drawing.Point(526, 117);
            this.ngaySinhtxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ngaySinhtxt.Name = "ngaySinhtxt";
            this.ngaySinhtxt.Size = new System.Drawing.Size(125, 20);
            this.ngaySinhtxt.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(434, 116);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 18);
            this.label5.TabIndex = 20;
            this.label5.Text = "Ngày sinh:";
            // 
            // cb_gender
            // 
            this.cb_gender.FormattingEnabled = true;
            this.cb_gender.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cb_gender.Location = new System.Drawing.Point(207, 114);
            this.cb_gender.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_gender.Name = "cb_gender";
            this.cb_gender.Size = new System.Drawing.Size(143, 21);
            this.cb_gender.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(102, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Giới tính:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(335, 39);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "(*)";
            // 
            // thoat
            // 
            this.thoat.Location = new System.Drawing.Point(550, 243);
            this.thoat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(76, 32);
            this.thoat.TabIndex = 16;
            this.thoat.Text = "Thoát";
            this.thoat.UseVisualStyleBackColor = true;
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(447, 243);
            this.Reset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(76, 32);
            this.Reset.TabIndex = 15;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            // 
            // xoa
            // 
            this.xoa.Location = new System.Drawing.Point(345, 243);
            this.xoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(76, 32);
            this.xoa.TabIndex = 14;
            this.xoa.Text = "Xóa";
            this.xoa.UseVisualStyleBackColor = true;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // sua
            // 
            this.sua.Location = new System.Drawing.Point(243, 243);
            this.sua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sua.Name = "sua";
            this.sua.Size = new System.Drawing.Size(76, 32);
            this.sua.TabIndex = 13;
            this.sua.Text = "Sửa";
            this.sua.UseVisualStyleBackColor = true;
            this.sua.Click += new System.EventHandler(this.sua_Click);
            // 
            // them
            // 
            this.them.Location = new System.Drawing.Point(139, 243);
            this.them.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(76, 32);
            this.them.TabIndex = 12;
            this.them.Text = "Thêm";
            this.them.UseVisualStyleBackColor = true;
            this.them.Click += new System.EventHandler(this.them_Click);
            // 
            // addressedt
            // 
            this.addressedt.Location = new System.Drawing.Point(207, 198);
            this.addressedt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addressedt.Name = "addressedt";
            this.addressedt.Size = new System.Drawing.Size(445, 20);
            this.addressedt.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(102, 195);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Địa chỉ:";
            // 
            // phoneTxt
            // 
            this.phoneTxt.Location = new System.Drawing.Point(527, 158);
            this.phoneTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.Size = new System.Drawing.Size(125, 20);
            this.phoneTxt.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.Location = new System.Drawing.Point(434, 156);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Điện thoại:";
            // 
            // emailedt
            // 
            this.emailedt.Location = new System.Drawing.Point(207, 156);
            this.emailedt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.emailedt.Name = "emailedt";
            this.emailedt.Size = new System.Drawing.Size(203, 20);
            this.emailedt.TabIndex = 8;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label.Location = new System.Drawing.Point(102, 37);
            this.label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(94, 18);
            this.label.TabIndex = 7;
            this.label.Text = "Mã sinh viên:";
            // 
            // masvtxt
            // 
            this.masvtxt.Location = new System.Drawing.Point(207, 37);
            this.masvtxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.masvtxt.Name = "masvtxt";
            this.masvtxt.Size = new System.Drawing.Size(125, 20);
            this.masvtxt.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(102, 153);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Email:";
            // 
            // tenSvTxt
            // 
            this.tenSvTxt.Location = new System.Drawing.Point(207, 79);
            this.tenSvTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tenSvTxt.Name = "tenSvTxt";
            this.tenSvTxt.Size = new System.Drawing.Size(445, 20);
            this.tenSvTxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(102, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên sinh viên:";
            // 
            // DGV_sinhvien
            // 
            this.DGV_sinhvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_sinhvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.gioitinh,
            this.Column6,
            this.Column4,
            this.Column5,
            this.Column3,
            this.malop});
            this.DGV_sinhvien.Location = new System.Drawing.Point(19, 421);
            this.DGV_sinhvien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DGV_sinhvien.Name = "DGV_sinhvien";
            this.DGV_sinhvien.RowHeadersWidth = 62;
            this.DGV_sinhvien.RowTemplate.Height = 28;
            this.DGV_sinhvien.Size = new System.Drawing.Size(766, 371);
            this.DGV_sinhvien.TabIndex = 5;
            this.DGV_sinhvien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_sinhvien_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "masv";
            this.Column1.HeaderText = "Mã sinh viên";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "tensv";
            this.Column2.HeaderText = "Tên sinh viên";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // gioitinh
            // 
            this.gioitinh.DataPropertyName = "gioitinh";
            this.gioitinh.HeaderText = "Giới tính";
            this.gioitinh.MinimumWidth = 8;
            this.gioitinh.Name = "gioitinh";
            this.gioitinh.Width = 150;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "ngaySinh";
            this.Column6.HeaderText = "Ngày sinh";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.Width = 150;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "email";
            this.Column4.HeaderText = "email";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "sdt";
            this.Column5.HeaderText = "SĐT";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "diaChi";
            this.Column3.HeaderText = "Địa chỉ";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // malop
            // 
            this.malop.DataPropertyName = "maLop";
            this.malop.HeaderText = "Mã lớp";
            this.malop.MinimumWidth = 8;
            this.malop.Name = "malop";
            this.malop.Width = 150;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 806);
            this.Controls.Add(label8);
            this.Controls.Add(this.DGV_sinhvien);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_sinhvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button thoat;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Button sua;
        private System.Windows.Forms.Button them;
        private System.Windows.Forms.TextBox addressedt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox phoneTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox emailedt;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox masvtxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tenSvTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker ngaySinhtxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_gender;
        private System.Windows.Forms.DataGridView DGV_sinhvien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cb_maLop;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn malop;
    }
}