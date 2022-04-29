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

namespace QuanLyThuVien
{
    public partial class theloai : Form
    {
        theLoaiBus tlb = new theLoaiBus();
        public theloai()
        {
            InitializeComponent();
        }

        public void hienThi()
        {
            DataTable dt = new DataTable();
            dt = tlb.HienThi_DG();
            DGV_Theloai.DataSource = dt;
        }

        private void theloai_Load(object sender, EventArgs e)
        {
            hienThi();
        }

        private void them_Click(object sender, EventArgs e)
        {
            string matheloai = matltxt.Texts.ToString();
            string tentheloai = tentlTxt.Texts.ToString();
            string ghichu = ghichutxt.Texts.ToString();
            if (matheloai == "" || tentheloai == "")
            {
                MessageBox.Show("Bạn chưa nhập dữ liệu");
            } else
            {
                try
                {
                    tlb.insert(matheloai, tentheloai, ghichu);
                    hienThi();
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


    }
}
