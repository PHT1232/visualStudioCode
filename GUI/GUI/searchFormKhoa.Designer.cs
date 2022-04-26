namespace GUI
{
    partial class searchFormKhoa
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
            this.khoaCB = new System.Windows.Forms.ComboBox();
            this.DGV_khoa_search = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_khoa_search)).BeginInit();
            this.SuspendLayout();
            // 
            // khoaCB
            // 
            this.khoaCB.FormattingEnabled = true;
            this.khoaCB.Location = new System.Drawing.Point(42, 64);
            this.khoaCB.Name = "khoaCB";
            this.khoaCB.Size = new System.Drawing.Size(192, 28);
            this.khoaCB.TabIndex = 0;
            this.khoaCB.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // DGV_khoa_search
            // 
            this.DGV_khoa_search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_khoa_search.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column2});
            this.DGV_khoa_search.Location = new System.Drawing.Point(12, 227);
            this.DGV_khoa_search.Name = "DGV_khoa_search";
            this.DGV_khoa_search.RowHeadersWidth = 62;
            this.DGV_khoa_search.RowTemplate.Height = 28;
            this.DGV_khoa_search.Size = new System.Drawing.Size(1143, 401);
            this.DGV_khoa_search.TabIndex = 5;
            this.DGV_khoa_search.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_khoa_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(308, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "Quay lại";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "maKhoa";
            this.Column1.HeaderText = "Mã khoa";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "maLop";
            this.Column3.HeaderText = "Mã lớp";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "tenLop";
            this.Column2.HeaderText = "Tên lớp";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // searchFormKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 650);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DGV_khoa_search);
            this.Controls.Add(this.khoaCB);
            this.Name = "searchFormKhoa";
            this.Text = "searchForm";
            this.Load += new System.EventHandler(this.searchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_khoa_search)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox khoaCB;
        private System.Windows.Forms.DataGridView DGV_khoa_search;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}