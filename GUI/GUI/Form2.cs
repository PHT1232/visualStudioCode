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
    public partial class Form2 : Form
    {
        lop lh = new lop();
        Khoa kh = new Khoa();
        string maLopTxtTC;
        string tenLopTxtTC;
        string makhoaTC;

        public Form2()
        {
            InitializeComponent();
            SqlDataReader dr = kh.hienThiKhoa(); //khai báo đối tượng
            while (dr.Read())
            {
                cb_khoa.Items.Add(dr[0].ToString());
            }
            //cb_khoa.SelectedIndex = 0;
        }

        private void hienThi()
        {
            DataTable dt = new DataTable();
            dt = lh.HienThi_DG();
            DGV_lop.DataSource = dt;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            maLopTxt.Focus();
            hienThi();
        }

        private void DGV_lop_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            maLopTxtTC = maLopTxt.Text = DGV_lop.Rows[i].Cells[0].Value.ToString();
            maLopTxt.Enabled = false;
            tenLopTxtTC = tenLopTxt.Text = DGV_lop.Rows[i].Cells[1].Value.ToString();
            makhoaTC = DGV_lop.Rows[i].Cells[2].Value.ToString();
            int a = cb_khoa.Items.IndexOf(makhoaTC);
            cb_khoa.SelectedIndex = a;
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            maLopTxt.Clear();
            maLopTxt.Enabled = true;
            tenLopTxt.Clear();
        }

        private void suaBtn_Click(object sender, EventArgs e)
        {
            if (maLopTxt.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu cần sửa!");
                maLopTxt.Focus();
            } else
            {
                string malop = maLopTxt.Text;
                string tenlop = tenLopTxt.Text;
                string makhoa = cb_khoa.SelectedItem.ToString();
                if (!malop.Equals(maLopTxtTC) || !tenlop.Equals(tenLopTxtTC) || !makhoa.Equals(makhoaTC))
                {
                    try
                    {
                        lh.update(malop, tenlop, makhoa);
                        MessageBox.Show("Cập nhật thành công !");
                        hienThi();
                    } catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                } else
                {
                    MessageBox.Show("Bạn chưa sửa dữ liệu !");
                }
            }
        }

        private void themBtn_Click(object sender, EventArgs e)
        {
            if (maLopTxt.Text == "" || cb_khoa.SelectedItem.ToString().Equals(""))
            {
                MessageBox.Show("Bạn chưa nhập mã lớp hoặc mã khoa");
                maLopTxt.Focus();
            } else
            {
                try
                {
                    string malop = maLopTxt.Text;
                    string tenlop = tenLopTxt.Text;
                    string makhoa = cb_khoa.SelectedItem.ToString();
                    lh.insert(malop, tenlop, makhoa);
                    MessageBox.Show("insert thành công !");
                    hienThi();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void xoaBtn_Click(object sender, EventArgs e)
        {
            string malop = maLopTxt.Text;
            if (malop == "")
            {
                MessageBox.Show("Bạn chưa chọn mã lớp !");
            } else
            {
                try
                {
                    lh.delete(malop);
                    MessageBox.Show("Xóa thành công !");
                    hienThi();
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
