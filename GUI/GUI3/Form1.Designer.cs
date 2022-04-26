namespace GUI
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.label5 = new System.Windows.Forms.Label();
            this.maKhoa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tenKhoa = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.DGV_khoa = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsvk = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_khoa)).BeginInit();
            this.dsvk.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(295, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(605, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý khoa chuyên môn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(153, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên khoa:";
            // 
            // groupBox1
            // 
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
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.maKhoa);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tenKhoa);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(42, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1149, 391);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(502, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "(*)";
            // 
            // thoat
            // 
            this.thoat.Location = new System.Drawing.Point(848, 312);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(114, 50);
            this.thoat.TabIndex = 16;
            this.thoat.Text = "Thoát";
            this.thoat.UseVisualStyleBackColor = true;
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(694, 312);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(114, 50);
            this.Reset.TabIndex = 15;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            // 
            // xoa
            // 
            this.xoa.Location = new System.Drawing.Point(541, 312);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(114, 50);
            this.xoa.TabIndex = 14;
            this.xoa.Text = "Xóa";
            this.xoa.UseVisualStyleBackColor = true;
            // 
            // sua
            // 
            this.sua.Location = new System.Drawing.Point(387, 312);
            this.sua.Name = "sua";
            this.sua.Size = new System.Drawing.Size(114, 50);
            this.sua.TabIndex = 13;
            this.sua.Text = "Sửa";
            this.sua.UseVisualStyleBackColor = true;
            // 
            // them
            // 
            this.them.Location = new System.Drawing.Point(232, 312);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(114, 50);
            this.them.TabIndex = 12;
            this.them.Text = "Thêm";
            this.them.UseVisualStyleBackColor = true;
            this.them.Click += new System.EventHandler(this.them_Click);
            // 
            // addressedt
            // 
            this.addressedt.Location = new System.Drawing.Point(311, 242);
            this.addressedt.Name = "addressedt";
            this.addressedt.Size = new System.Drawing.Size(665, 26);
            this.addressedt.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(153, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 26);
            this.label3.TabIndex = 10;
            this.label3.Text = "Địa chỉ:";
            // 
            // phoneTxt
            // 
            this.phoneTxt.Location = new System.Drawing.Point(791, 181);
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.Size = new System.Drawing.Size(185, 26);
            this.phoneTxt.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.Location = new System.Drawing.Point(651, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 26);
            this.label6.TabIndex = 6;
            this.label6.Text = "Điện thoại:";
            // 
            // emailedt
            // 
            this.emailedt.Location = new System.Drawing.Point(311, 178);
            this.emailedt.Name = "emailedt";
            this.emailedt.Size = new System.Drawing.Size(303, 26);
            this.emailedt.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(153, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 26);
            this.label5.TabIndex = 7;
            this.label5.Text = "Mã khoa:";
            // 
            // maKhoa
            // 
            this.maKhoa.Location = new System.Drawing.Point(311, 57);
            this.maKhoa.Name = "maKhoa";
            this.maKhoa.Size = new System.Drawing.Size(185, 26);
            this.maKhoa.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(153, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "Email:";
            // 
            // tenKhoa
            // 
            this.tenKhoa.Location = new System.Drawing.Point(311, 121);
            this.tenKhoa.Name = "tenKhoa";
            this.tenKhoa.Size = new System.Drawing.Size(665, 26);
            this.tenKhoa.TabIndex = 3;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // DGV_khoa
            // 
            this.DGV_khoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_khoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.DGV_khoa.Location = new System.Drawing.Point(6, 25);
            this.DGV_khoa.Name = "DGV_khoa";
            this.DGV_khoa.RowHeadersWidth = 62;
            this.DGV_khoa.RowTemplate.Height = 28;
            this.DGV_khoa.Size = new System.Drawing.Size(1143, 401);
            this.DGV_khoa.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "maKhoa";
            this.Column1.HeaderText = "Mã khoa";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "tenKhoa";
            this.Column2.HeaderText = "Tên khoa";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "diaChi";
            this.Column3.HeaderText = "Địa chỉ";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
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
            // dsvk
            // 
            this.dsvk.Controls.Add(this.DGV_khoa);
            this.dsvk.Location = new System.Drawing.Point(42, 516);
            this.dsvk.Name = "dsvk";
            this.dsvk.Size = new System.Drawing.Size(1149, 430);
            this.dsvk.TabIndex = 5;
            this.dsvk.TabStop = false;
            this.dsvk.Text = "Danh sách khoa";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 972);
            this.Controls.Add(this.dsvk);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_khoa)).EndInit();
            this.dsvk.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox emailedt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox maKhoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tenKhoa;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox phoneTxt;
        private System.Windows.Forms.TextBox addressedt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button thoat;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Button sua;
        private System.Windows.Forms.Button them;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView DGV_khoa;
        private System.Windows.Forms.GroupBox dsvk;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label1;
    }
}
