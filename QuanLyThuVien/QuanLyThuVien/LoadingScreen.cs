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
    public partial class LoadingScreen : Form
    {
        int phanTramTxt = 0;
        public LoadingScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Width += 5;
            
            phanTramTxt += 1;
            phanTram.Text = phanTramTxt + "%";

            if (panel1.Width >= 599)
            {
                timer1.Stop();
                Form2 fm2 = new Form2();
                fm2.FormClosing += delegate { this.Close(); };
                fm2.Show();
                this.Hide();
            }

        }
    }
}
