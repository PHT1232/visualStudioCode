using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using System.Data.SqlClient;

namespace GUI
{
    public partial class Form3 : Form
    {
        lop lh = new lop();
        sinhVien sv = new sinhVien();
        string masvTC, tensvTC, gioiTinhTC, ngaySinhTC, emailTC, dienThoaiTC, diaChiTC, malopTC;

        private void Reset_Click(object sender, EventArgs e)
        {
            masvtxt.Clear();
            masvtxt.Enabled = true;
            tenSvTxt.Clear();
            emailedt.Clear();
            phoneTxt.Clear();
            addressedt.Clear();
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
                try
                {
                    sv.delete(masinhvien);
                    MessageBox.Show("Xóa thành công");
                    hienThi();
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public Form3()
        {
            InitializeComponent();
            SqlDataReader dr = lh.hienThiLop();
            while (dr.Read())
            {
                cb_maLop.Items.Add(dr[0].ToString());
            }
        }

        private void hienThi()
        {
            DataTable dt = new DataTable();
            dt = sv.HienThi_DG();
            DGV_sinhvien.DataSource = dt;
        }

        private void them_Click(object sender, EventArgs e)
        {
            string masv = masvtxt.Text;
            string tensv = tenSvTxt.Text;
            string gioiTinh = cb_gender.SelectedItem.ToString();
            string ngaySinh = ngaySinhtxt.Value.ToString("dd-MM-yyyy");
            string email = emailedt.Text;
            string sdt = phoneTxt.Text;
            string diaChi = addressedt.Text;
            string malop = cb_maLop.SelectedItem.ToString();
            if (masv == "")
            {
                MessageBox.Show("Bạn chưa nhập mã sinh viên !");
            } else
            {
                try
                {
                    sv.insert(masv, tensv, gioiTinh, ngaySinh, email, sdt, diaChi, malop);
                    MessageBox.Show("insert thành công");
                    hienThi();
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            hienThi();
        }

        private void sua_Click(object sender, EventArgs e)
        {
            string masv = masvtxt.Text;
            string tensv = tenSvTxt.Text;
            string gioiTinh = cb_gender.SelectedItem.ToString();
            string ngaySinh = ngaySinhtxt.Value.ToString("dd-MM-yyyy");
            string email = emailedt.Text;
            string sdt = phoneTxt.Text;
            string diaChi = addressedt.Text;
            string malop = cb_maLop.SelectedItem.ToString();
            if (masv == "")
            {
                MessageBox.Show("Bạn chưa chọn mã sinh viên !");
            }
            else
            {
                if (!masvTC.Equals(masv) || !tensvTC.Equals(tensv) || !gioiTinhTC.Equals(gioiTinh) || !ngaySinhTC.Equals(ngaySinh) || !emailTC.Equals(email) || !dienThoaiTC.Equals(sdt) || !diaChiTC.Equals(diaChi) || !malopTC.Equals(diaChi))
                {
                    try
                    {
                        sv.update(masv, tensv, gioiTinh, ngaySinh, email, sdt, diaChi, malop);
                        MessageBox.Show("update thành công");
                        hienThi();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                } else
                {
                    MessageBox.Show("Xin hãy sửa dữ liệu");
                }
            }
        }

        private void DGV_sinhvien_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            masvTC = masvtxt.Text = DGV_sinhvien.Rows[i].Cells[0].Value.ToString();
            masvtxt.Enabled = false;
            tensvTC = tenSvTxt.Text = DGV_sinhvien.Rows[i].Cells[1].Value.ToString();
            gioiTinhTC = DGV_sinhvien.Rows[i].Cells[2].Value.ToString();
            cb_gender.SelectedIndex = cb_gender.Items.IndexOf(gioiTinhTC);
            ngaySinhTC = DGV_sinhvien.Rows[i].Cells[3].Value.ToString();
            DateTime dt = DateTime.ParseExact(ngaySinhTC, "dd-MM-yyyy", null);
            ngaySinhtxt.Value = dt;
            emailTC = emailedt.Text = DGV_sinhvien.Rows[i].Cells[4].Value.ToString();
            dienThoaiTC = phoneTxt.Text = DGV_sinhvien.Rows[i].Cells[5].Value.ToString();
            diaChiTC = addressedt.Text = DGV_sinhvien.Rows[i].Cells[6].Value.ToString();
            malopTC = DGV_sinhvien.Rows[i].Cells[7].Value.ToString();
            cb_maLop.SelectedIndex = cb_maLop.Items.IndexOf(malopTC);
        }
    }
}
