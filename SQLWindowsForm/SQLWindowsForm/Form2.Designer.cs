namespace SQLWindowsForm
{
    partial class Form2
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
            System.Windows.Forms.Label label2;
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_khoa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.thoatBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.xoaBtn = new System.Windows.Forms.Button();
            this.suaBtn = new System.Windows.Forms.Button();
            this.themBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.maLopTxt = new System.Windows.Forms.TextBox();
            this.tenLopTxt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.DGV_lop = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_lop)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            label2.Location = new System.Drawing.Point(386, 30);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(371, 58);
            label2.TabIndex = 7;
            label2.Text = "Quản lý lớp dạy";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cb_khoa);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.thoatBtn);
            this.groupBox2.Controls.Add(this.resetBtn);
            this.groupBox2.Controls.Add(this.xoaBtn);
            this.groupBox2.Controls.Add(this.suaBtn);
            this.groupBox2.Controls.Add(this.themBtn);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.maLopTxt);
            this.groupBox2.Controls.Add(this.tenLopTxt);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(29, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1149, 307);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhập thông tin";
            // 
            // cb_khoa
            // 
            this.cb_khoa.FormattingEnabled = true;
            this.cb_khoa.Location = new System.Drawing.Point(732, 60);
            this.cb_khoa.Name = "cb_khoa";
            this.cb_khoa.Size = new System.Drawing.Size(185, 28);
            this.cb_khoa.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(502, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "(*)";
            // 
            // thoatBtn
            // 
            this.thoatBtn.Location = new System.Drawing.Point(829, 194);
            this.thoatBtn.Name = "thoatBtn";
            this.thoatBtn.Size = new System.Drawing.Size(114, 50);
            this.thoatBtn.TabIndex = 16;
            this.thoatBtn.Text = "Thoát";
            this.thoatBtn.UseVisualStyleBackColor = true;
            this.thoatBtn.Click += new System.EventHandler(this.thoatBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(675, 194);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(114, 50);
            this.resetBtn.TabIndex = 15;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // xoaBtn
            // 
            this.xoaBtn.Location = new System.Drawing.Point(522, 194);
            this.xoaBtn.Name = "xoaBtn";
            this.xoaBtn.Size = new System.Drawing.Size(114, 50);
            this.xoaBtn.TabIndex = 14;
            this.xoaBtn.Text = "Xóa";
            this.xoaBtn.UseVisualStyleBackColor = true;
            this.xoaBtn.Click += new System.EventHandler(this.xoaBtn_Click);
            // 
            // suaBtn
            // 
            this.suaBtn.Location = new System.Drawing.Point(368, 194);
            this.suaBtn.Name = "suaBtn";
            this.suaBtn.Size = new System.Drawing.Size(114, 50);
            this.suaBtn.TabIndex = 13;
            this.suaBtn.Text = "Sửa";
            this.suaBtn.UseVisualStyleBackColor = true;
            this.suaBtn.Click += new System.EventHandler(this.suaBtn_Click);
            // 
            // themBtn
            // 
            this.themBtn.Location = new System.Drawing.Point(213, 194);
            this.themBtn.Name = "themBtn";
            this.themBtn.Size = new System.Drawing.Size(114, 50);
            this.themBtn.TabIndex = 12;
            this.themBtn.Text = "Thêm";
            this.themBtn.UseVisualStyleBackColor = true;
            this.themBtn.Click += new System.EventHandler(this.themBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label8.Location = new System.Drawing.Point(574, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 26);
            this.label8.TabIndex = 10;
            this.label8.Text = "Mã khoa:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label10.Location = new System.Drawing.Point(153, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 26);
            this.label10.TabIndex = 7;
            this.label10.Text = "Mã lớp:";
            // 
            // maLopTxt
            // 
            this.maLopTxt.Location = new System.Drawing.Point(311, 57);
            this.maLopTxt.Name = "maLopTxt";
            this.maLopTxt.Size = new System.Drawing.Size(185, 26);
            this.maLopTxt.TabIndex = 6;
            // 
            // tenLopTxt
            // 
            this.tenLopTxt.Location = new System.Drawing.Point(311, 121);
            this.tenLopTxt.Name = "tenLopTxt";
            this.tenLopTxt.Size = new System.Drawing.Size(665, 26);
            this.tenLopTxt.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label12.Location = new System.Drawing.Point(153, 117);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 26);
            this.label12.TabIndex = 1;
            this.label12.Text = "Tên lớp:";
            // 
            // DGV_lop
            // 
            this.DGV_lop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_lop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column5});
            this.DGV_lop.Location = new System.Drawing.Point(29, 502);
            this.DGV_lop.Name = "DGV_lop";
            this.DGV_lop.RowHeadersWidth = 62;
            this.DGV_lop.RowTemplate.Height = 28;
            this.DGV_lop.Size = new System.Drawing.Size(1149, 422);
            this.DGV_lop.TabIndex = 6;
            this.DGV_lop.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_lop_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "maLop";
            this.Column1.HeaderText = "Mã lớp";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "tenLop";
            this.Column2.HeaderText = "Tên lớp";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "makhoa";
            this.Column5.HeaderText = "Mã khoa";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.Width = 150;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(923, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "(*)";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 939);
            this.Controls.Add(label2);
            this.Controls.Add(this.DGV_lop);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_lop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cb_khoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button thoatBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button xoaBtn;
        private System.Windows.Forms.Button suaBtn;
        private System.Windows.Forms.Button themBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox maLopTxt;
        private System.Windows.Forms.TextBox tenLopTxt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView DGV_lop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label7;
    }
}