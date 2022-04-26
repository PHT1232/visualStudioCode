using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLWindowsForm
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        string maKhoaTxtTC;
        string tenKhoaTxtTC;
        string emailTxtTC;
        string diaChiTxtTC;
        string phoneTxtTC;
        public Form1()
        {
            InitializeComponent();
        }

        private void ketNoiCDSL()
        {
            string chuoiKn = @"Data Source=NGUYENTANPHAT\SQLEXPRESS;Initial Catalog=DH9C5;Integrated Security=True";
            conn = new SqlConnection(chuoiKn);
            conn.Open();
        }
        
        public void hienThiDuLieu()
        {
            ketNoiCDSL();
            string sql_ht = "Select * from t_Khoa";
            SqlDataAdapter myData = new SqlDataAdapter(sql_ht, conn);

            DataTable myDt = new DataTable();
            myData.Fill(myDt);
            DGV_khoa.DataSource = myDt;
            conn.Close();
        }
        public void reset()
        {
            maKhoa.Clear();
            tenKhoa.Text = "";
            maKhoa.Enabled = true;
            addressedt.Clear();
            emailedt.Clear();
            phoneTxt.Clear();
        }

        private void them_Click(object sender, EventArgs e)
        {
            ketNoiCDSL();
            string makhoa = maKhoa.Text;
            string tenkhoa = tenKhoa.Text;
            string email = emailedt.Text;
            string phone = phoneTxt.Text;
            string address = addressedt.Text;
            string sql_add = "Insert into t_khoa values(N'" + makhoa + "', N'" + tenkhoa + "', N'" + address + "', '" + email + "', N'" + phone + "')";
            SqlCommand cmd = new SqlCommand(sql_add, conn);
            if (makhoa == "")
            {
                MessageBox.Show("Bạn chưa nhập mã khóa!");
                maKhoa.Focus();
            }
            else
            {
                cmd.ExecuteNonQuery();
                reset();
                maKhoa.Focus();
            }
            hienThiDuLieu();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hienThiDuLieu();
        }

        private void DGV_khoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            maKhoaTxtTC = maKhoa.Text = DGV_khoa.CurrentRow.Cells[0].Value.ToString();
            maKhoa.Enabled = false;
            tenKhoaTxtTC = tenKhoa.Text = DGV_khoa.CurrentRow.Cells[1].Value.ToString();
            diaChiTxtTC = addressedt.Text = DGV_khoa.CurrentRow.Cells[2].Value.ToString();
            emailTxtTC = emailedt.Text = DGV_khoa.CurrentRow.Cells[3].Value.ToString();
            phoneTxtTC = phoneTxt.Text = DGV_khoa.CurrentRow.Cells[4].Value.ToString();
        }

        private void sua_Click(object sender, EventArgs e)
        {
            if (maKhoa.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu cần sửa");
            }
            else
            {
                if (!maKhoaTxtTC.Equals(maKhoa.Text) || !tenKhoaTxtTC.Equals(tenKhoa.Text) || !emailTxtTC.Equals(emailedt.Text) || !phoneTxtTC.Equals(phoneTxt.Text) || !diaChiTxtTC.Equals(addressedt.Text))
                {
                    ketNoiCDSL();
                    string makhoa = maKhoa.Text;
                    string tenkhoa = tenKhoa.Text;
                    string email = emailedt.Text;
                    string phone = phoneTxt.Text;
                    string address = addressedt.Text;

                    string sql_update = "Update t_khoa set tenKhoa = N'" + tenkhoa + "'" + ", email = N'" + email + "', sdt = '" + phone + "', diaChi = N'" + address + "' where makhoa = N'" + makhoa + "'";
                    SqlCommand cmd = new SqlCommand(sql_update, conn);
                    maKhoa.Focus();
                    cmd.ExecuteNonQuery();
                    reset();
                    maKhoa.Focus();

                    hienThiDuLieu();
                }
                else
                {
                    MessageBox.Show("Xin hãy sửa dữ liệu");
                }
            }
        }

        private void xoa_Click(object sender, EventArgs e)
        {   
            string makhoa = maKhoa.Text;
            if (makhoa == "")
            {
                MessageBox.Show("Bạn chưa chọn mã khoa!");
                maKhoa.Focus();
            }
            else
            {
                ketNoiCDSL();
                string sql_del = "Delete from t_khoa where makhoa = N'" + makhoa + "'";
                SqlCommand cmd = new SqlCommand(sql_del, conn);
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Thông báo", MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    cmd.ExecuteNonQuery();
                    hienThiDuLieu();
                    reset();
                }
            }
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
