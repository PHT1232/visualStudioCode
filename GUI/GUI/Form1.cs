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

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Khoa kh = new Khoa();
        string ma;
        private void them_Click(object sender, EventArgs e)
        {
            if (maKhoa.Text == "")
            {
                MessageBox.Show("Bạn chưa mã khoa!");
                maKhoa.Focus();
            }
            else
            {
                try
                {
                    kh.Insert(this.maKhoa.Text, this.tenKhoa.Text, this.emailedt.Text, this.phoneTxt.Text, this.addressedt.Text);
                    MessageBox.Show("Thêm thành công :)");
                    hienThi();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void DGV_khoa_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = e.RowIndex;
            maKhoa.Text = DGV_khoa.Rows[i].Cells[0].Value.ToString();
            maKhoa.Enabled = false;
            tenKhoa.Text = DGV_khoa.Rows[i].Cells[1].Value.ToString();
            addressedt.Text = DGV_khoa.Rows[i].Cells[2].Value.ToString();
            emailedt.Text = DGV_khoa.Rows[i].Cells[3].Value.ToString();
            phoneTxt.Text = DGV_khoa.Rows[i].Cells[4].Value.ToString();
        }

        private void sua_Click(object sender, EventArgs e)
        {
            if (maKhoa.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn !");
                maKhoa.Focus();
            }
            else
            {
                try
                {
                    kh.UpdateKhoa(this.tenKhoa.Text, this.emailedt.Text, this.phoneTxt.Text, this.addressedt.Text, this.maKhoa.Text);
                    MessageBox.Show("cập nhật thành thành công :)");
                    hienThi();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Chưa cập nhật thành công :(");
                }
            }
        }

        private void hienThi()
        {
            DataTable dt = new DataTable();
            dt = kh.HienThi_DG();
            DGV_khoa.DataSource = dt;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            maKhoa.Focus();
            hienThi();
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            if (maKhoa.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn !");
                maKhoa.Focus();
            }
            else
            {
                try
                {
                    kh.del_khoa(maKhoa.Text);
                    MessageBox.Show("Xóa thành công :)");
                    hienThi();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Chưa xóa thành công :(");
                }
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            maKhoa.Clear();
            maKhoa.Enabled = true;
            tenKhoa.Clear();
            emailedt.Clear();
            phoneTxt.Clear();
            addressedt.Clear();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            var frm = new searchFormKhoa();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Close(); };
            frm.Show();
            this.Hide();
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
