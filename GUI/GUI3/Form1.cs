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

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void them_Click(object sender, EventArgs e)
        {
            if (maKhoa.Text == "")
            {
                MessageBox.Show("Bạn chưa mã khoa!");
                maKhoa.Focus();
            } else
            {
                try
                {
                    Khoa kh = new Khoa();
                    kh.Insert(this.maKhoa.Text, this.tenKhoa.Text, this.emailedt.Text, this.phoneTxt.Text, this.addressedt.Text);
                    MessageBox.Show("Thêm thành công :)");
                } catch (Exception ex)
                {
                    MessageBox.Show("Chưa thêm thành công :(");
                }
            }
        }
    }
}
