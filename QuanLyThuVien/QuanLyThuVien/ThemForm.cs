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
using System.Data;
using BUS;

namespace QuanLyThuVien
{
    public partial class ThemForm : Form
    {

        tacGiaBus tgb = new tacGiaBus();
        nhaXuatBanBus nxbb = new nhaXuatBanBus();
        theLoaiBus tlb = new theLoaiBus();

        public ThemForm()
        {
            InitializeComponent();
        }

        private void ThemForm_Load(object sender, EventArgs e)
        {
            SqlDataReader dr = tgb.hienThiTacGia();
            SqlDataReader dr2 = tlb.hienthitheloai();
            SqlDataReader dr3 = nxbb.hienThiNhaXuatBan();
            while (dr.Read())
            {
                cb_tacgia.Items.Add(dr[0].ToString());
                cb_theLoai.Items.Add(dr2[0].ToString());
                nhaxuatbancb.Items.Add(dr3[0].ToString());
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void them_Click(object sender, EventArgs e)
        {
            string masach = masachtxt.Text.ToString();
            string tenSach = tenSachTxt.Text.ToString();
            string theLoai = cb_theLoai.Texts.ToString();
            string tacgia = cb_tacgia.Text.ToString();
            string namxuatban = namXuatBan.Value.ToString("dd-MM-yyyy");
            string filename = System.IO.Path.GetFileName(openFileDialog1.FileName);
            string nhaxuatban = nhaxuatbancb.Text.ToString();
            if (masach == "" || tenSach == "" || theLoai == "" || tacgia == "" || namxuatban == "" || filename == null || nhaxuatban == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ dữ liệu!");
            } else
            {

            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C://Desktop";
            openFileDialog1.Title = "Select image to be upload";
            openFileDialog1.Filter = "Image Only(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*jpg; *.jpeg; *.gif; *.bmp; *.png";
            openFileDialog1.FilterIndex = 1;
            try
            {
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (openFileDialog1.CheckFileExists)
                    {
                        string path = System.IO.Path.GetFullPath(openFileDialog1.FileName);
                        anhSach.Image = new Bitmap(openFileDialog1.FileName);
                    }
                }
                else
                {
                    MessageBox.Show("Please Upload image");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
