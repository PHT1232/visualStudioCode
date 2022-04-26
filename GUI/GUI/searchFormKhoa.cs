using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BUS;

namespace GUI
{
    public partial class searchFormKhoa : Form
    {

        Khoa kh = new Khoa();
        lop lh = new lop();
        public searchFormKhoa()
        {
            InitializeComponent();
        }



        private void DGV_khoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void hienThi(string makhoa)
        {
            DataTable dt = new DataTable();
            dt = lh.search_khoa(makhoa);
            DGV_khoa_search.DataSource = dt;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            hienThi(khoaCB.Text);
        }

        private void searchForm_Load(object sender, EventArgs e)
        {
            SqlDataReader dr = kh.hienThiKhoa(); //khai báo đối tượng
            while (dr.Read())
            {
                khoaCB.Items.Add(dr[0].ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frm = new Form1();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Close(); };
            frm.Show();
            this.Hide();
        }
    }
}
