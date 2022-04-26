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
    public partial class Form3 : Form
    {
        SqlConnection conn;
        string maSvTxtTC;
        string tenSvTxtTC;
        string gioiTinhTxtTC;
        string ngaySinhTxtTC;
        string emailTxtTC;
        string phoneTxtTC;
        string addressTxtTC;
        string maLopTC;
        public Form3()
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
            string sql_ht = "Select * from sinhVien";
            SqlDataAdapter mydata = new SqlDataAdapter(sql_ht, conn);

            DataTable mydt = new DataTable();
            mydata.Fill(mydt);
            DGV_sinhvien.DataSource = mydt;
        }

        public void reset()
        {
            masvtxt.Clear();
            masvtxt.Enabled = false;
            tenSvTxt.Clear();
            gioitinh.Dispose();
            ngaySinhtxt.Dispose();
            emailedt.Clear();
            phoneTxt.Clear();
            addressedt.Clear();
        }

        private void them_Click(object sender, EventArgs e)
        {
            ketNoiCDSL();
            string maSinhVien = masvtxt.Text;
            string malop = cb_maLop.Text.ToString();
            string tensv = tenSvTxt.Text;
            string gioiTinh = cb_gender.Text.ToString();
            string ngaysinh = ngaySinhtxt.Value.ToString("dd-MM-yyyy");
            string email = emailedt.Text;
            string dienthoai = phoneTxt.Text;
            string diachi = addressedt.Text;
            string sql_add = "Insert into sinhVien values(N'" + maSinhVien + "',N'" + tensv +"', N'" + gioiTinh + "', N'" + ngaysinh + "', N'" + email + "', N'" + dienthoai + "', N'" + diachi + "', N'" + malop + "')";
            SqlCommand cmd = new SqlCommand(sql_add, conn);
            if (maSinhVien == "" || malop == "")
            {
                if (maSinhVien == "")
                {
                    MessageBox.Show("Bạn chưa nhập mã Lớp!");
                    masvtxt.Focus();
                }
                else
                {
                    MessageBox.Show("Bạn chưa nhập mã Khoa!");
                    cb_maLop.Focus();
                }
            }
            else
            {
                cmd.ExecuteNonQuery();
                reset();
                masvtxt.Focus();
            }
            hienThiDuLieu();
            conn.Close();
        }

        private void DGV_sinhvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            maSvTxtTC = masvtxt.Text = DGV_sinhvien.CurrentRow.Cells[0].Value.ToString();
            them.Enabled = false;
            masvtxt.Enabled = false;
            tenSvTxtTC = tenSvTxt.Text = DGV_sinhvien.CurrentRow.Cells[1].Value.ToString();
            cb_gender.SelectedIndex = cb_gender.Items.IndexOf(DGV_sinhvien.CurrentRow.Cells[2].Value.ToString());
            gioiTinhTxtTC = DGV_sinhvien.CurrentRow.Cells[2].Value.ToString();
            ngaySinhTxtTC = DGV_sinhvien.CurrentRow.Cells[3].Value.ToString();
            DateTime dt = DateTime.ParseExact(ngaySinhTxtTC, "dd-MM-yyyy", null);
            ngaySinhtxt.Value = dt;
            emailTxtTC = emailedt.Text = DGV_sinhvien.CurrentRow.Cells[4].Value.ToString();
            phoneTxtTC = phoneTxt.Text = DGV_sinhvien.CurrentRow.Cells[5].Value.ToString();
            addressTxtTC = addressedt.Text = DGV_sinhvien.CurrentRow.Cells[6].Value.ToString();
            cb_maLop.SelectedIndex = cb_maLop.Items.IndexOf(DGV_sinhvien.CurrentRow.Cells[7].Value.ToString());
            maLopTC = DGV_sinhvien.CurrentRow.Cells[7].Value.ToString();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            hienThiDuLieu();
            String sql_cb_lop;
            SqlCommand cmd;
            SqlDataReader dr;
            sql_cb_lop = "Select maLop, tenLop from lopHoc";
            cmd = new SqlCommand(sql_cb_lop, conn);   
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cb_maLop.Items.Add(dr[0].ToString());
            }
            conn.Close();
        }

        private void sua_Click(object sender, EventArgs e)
        {
            if (masvtxt.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu cần sửa!");
            }
            else
            {
                if (!maSvTxtTC.Equals(masvtxt.Text) || !tenSvTxtTC.Equals(tenSvTxt.Text) || !maLopTC.Equals(cb_maLop.SelectedItem.ToString()) || !gioiTinhTxtTC.Equals(cb_gender.SelectedItem.ToString()) || !ngaySinhTxtTC.Equals(ngaySinhtxt.Value.ToString("dd-MM-yyyy")) || !emailTxtTC.Equals(emailedt.Text) || !phoneTxtTC.Equals(phoneTxt.Text) || !addressTxtTC.Equals(addressedt.Text))
                {
                    ketNoiCDSL();
                    string masinhvien = masvtxt.Text;
                    string malop = cb_maLop.Text.ToString();
                    string tensv = tenSvTxt.Text;
                    string gioiTinh = cb_gender.Text.ToString();
                    string ngaysinh = ngaySinhtxt.Value.ToString("dd-MM-yyyy");
                    string email = emailedt.Text;
                    string dienthoai = phoneTxt.Text;
                    string diachi = addressedt.Text;

                    string sql_update = "Update sinhVien set tensv = N'" + tensv + "', gioiTinh = N'" + gioiTinh + "', ngaySinh = N'" + ngaysinh + "', email = N'" + email +"', sdt = '" + dienthoai + "', diachi = N'" + diachi + "'" + ", maLop = N'" + malop + "' where masv = N'" + masinhvien + "'";
                    SqlCommand cmd = new SqlCommand(sql_update, conn);
                    masvtxt.Focus();
                    cmd.ExecuteNonQuery();
                    hienThiDuLieu();
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Xin hãy sửa dữ liệu");
                }
            }
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            string masinhvien = masvtxt.Text;
            if (masinhvien == "")
            {
                MessageBox.Show("Bạn chưa chọn mã sinh viên!");
                masvtxt.Focus();
            }
            else
            {
                ketNoiCDSL();
                string sql_del = "Delete from sinhVien where masv = N'" + masinhvien + "'";
                SqlCommand cmd = new SqlCommand(sql_del, conn);
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    cmd.ExecuteNonQuery();
                    hienThiDuLieu();
                    reset();
                    conn.Close();
                }
            }
        }
    }
}
