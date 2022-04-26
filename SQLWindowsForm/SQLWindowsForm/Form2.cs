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

namespace SQLWindowsForm
{
    public partial class Form2 : Form
    {
        SqlConnection conn;
        string maLopTxtTC;
        string tenLopTxtTC;
        string makhoaTC;
        public Form2()
        {
            InitializeComponent();
        }
        
        public void hienThiDuLieu()
        {
            ketNoiCDSL();
            string sql_ht = "Select * from lopHoc";
            SqlDataAdapter mydata = new SqlDataAdapter(sql_ht, conn);

            DataTable mydt = new DataTable();
            mydata.Fill(mydt);
            DGV_lop.DataSource = mydt;
        }

        public void reset()
        {
            maLopTxt.Clear();
            maLopTxt.Enabled = true;
            tenLopTxt.Clear();
        }

        private void ketNoiCDSL()
        {
            string chuoiKn = @"Data Source=NGUYENTANPHAT\SQLEXPRESS;Initial Catalog=DH9C5;Integrated Security=True";
            conn = new SqlConnection(chuoiKn);
            conn.Open();
        }

        private void dongKetNoiCSDL()
        {
            conn.Close();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            hienThiDuLieu();
            string sql_cb = "Select makhoa, tenkhoa from t_khoa";
            SqlCommand cmd = new SqlCommand(sql_cb, conn);
            SqlDataReader dr; //khai báo đối tượng
            dr = cmd.ExecuteReader(); //Đổ dữ liệu vào Datareader
            while (dr.Read())
            {
                cb_khoa.Items.Add(dr[0].ToString());
            }
            dongKetNoiCSDL();
        }

        private void themBtn_Click(object sender, EventArgs e)
        {
            ketNoiCDSL();
            string maLop = maLopTxt.Text;
            string tenLop = tenLopTxt.Text;
            string makhoa = cb_khoa.SelectedItem.ToString();
            string sql_add = "Insert into lopHoc values (N'" + maLop + "', N'" + tenLop + "', N'" + makhoa + "')";
            SqlCommand cmd = new SqlCommand(sql_add, conn);
            if (maLop == "" || makhoa == "")
            {
                if (maLop == "")
                {
                    MessageBox.Show("Bạn chưa nhập mã Lớp!");
                    maLopTxt.Focus();
                } else
                {
                    MessageBox.Show("Bạn chưa nhập mã Khoa!");
                    cb_khoa.Focus();
                }
            } else
            {
                cmd.ExecuteNonQuery();
                reset();
                maLopTxt.Focus();
            }
            hienThiDuLieu();
            dongKetNoiCSDL();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void DGV_lop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            maLopTxtTC = maLopTxt.Text = DGV_lop.CurrentRow.Cells[0].Value.ToString();
            maLopTxt.Enabled = false;
            tenLopTxtTC = tenLopTxt.Text = DGV_lop.CurrentRow.Cells[1].Value.ToString();   
            cb_khoa.SelectedIndex = cb_khoa.Items.IndexOf(DGV_lop.CurrentRow.Cells[2].Value.ToString());
            makhoaTC = DGV_lop.CurrentRow.Cells[2].Value.ToString();
        }

        private void suaBtn_Click(object sender, EventArgs e)
        {
            if (maLopTxt.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu cần sửa!");
            }
            else
            {
                if (!maLopTxtTC.Equals(maLopTxt.Text) || !tenLopTxtTC.Equals(tenLopTxt.Text) || !makhoaTC.Equals(cb_khoa.SelectedItem.ToString())) {
                    ketNoiCDSL();
                    string malop = maLopTxt.Text;
                    string tenlop = tenLopTxt.Text;
                    string makhoa = cb_khoa.Text.ToString();

                    string sql_update = "Update lopHoc set tenLop = N'" + tenlop + "', maKhoa = N'" + makhoa + "' where maLop = '" + malop + "'";
                    SqlCommand cmd = new SqlCommand(sql_update, conn);
                    maLopTxt.Focus();
                    cmd.ExecuteNonQuery();
                    hienThiDuLieu();
                    dongKetNoiCSDL();
                } 
                else
                {
                    MessageBox.Show("Xin hãy sửa dữ liệu");
                }
            }
        }

        private void thoatBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void xoaBtn_Click(object sender, EventArgs e)
        {
            string malop = maLopTxt.Text;
            if (malop == "")
            {
                MessageBox.Show("Bạn chưa chọn mã lớp!");
                maLopTxt.Focus();
            }
            else
            {
                ketNoiCDSL();
                string sql_del = "Delete from lopHoc where maLop = N'" + malop + "'";
                SqlCommand cmd = new SqlCommand(sql_del, conn);
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    cmd.ExecuteNonQuery();
                    hienThiDuLieu();
                    reset();
                    dongKetNoiCSDL();
                }
            }
        }
    }
}
