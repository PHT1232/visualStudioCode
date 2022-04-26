using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class Form1 : Form
    {
        dangNhap dang = new dangNhap();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = usernametxt.Texts.ToString();
            string password = passwordtxt.Texts.ToString();
            if (username == "" || password == "")
            {
                MessageBox.Show("Xin hãy nhập dữ liệu trước!");
            }
            else
            {
                if (dang.select(username, password))
                {
                    var frm = new LoadingScreen();
                    frm.Location = this.Location;
                    frm.StartPosition = FormStartPosition.Manual;
                    frm.FormClosing += delegate { this.Close(); };
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sai username hoặc mật khẩu!");
                }
            }
        }
    }
}
