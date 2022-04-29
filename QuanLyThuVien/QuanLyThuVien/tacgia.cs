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
    public partial class tacgia : Form
    {
        tacGiaBus tgb = new tacGiaBus();

        public tacgia()
        {
            InitializeComponent();
        }

        public void hienThi()
        {
            DataTable dt = new DataTable();
            dt = tgb.hienThi_DG();
            DGV_Tacgia.DataSource = dt;
        }

        private void tacgia_Load(object sender, EventArgs e)
        {
            hienThi();
        }

        private void them_Click(object sender, EventArgs e)
        {
            string matacgia = matgtxt.Texts.ToString();
            string tentacgia = tentgTxt.Texts.ToString();  
            string gioitinh = cb_gioiTinh.SelectedItem.ToString();
            string email = emailtxt.Texts.ToString();
            string ghichu = ghichutxt.Texts.ToString();

            if (matacgia == "" || tentacgia == "" || gioitinh == "" || email == "")
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ dữ liệu");
            } else
            {
                try
                {
                    tgb.insert(tentacgia, email, gioitinh, ghichu, matacgia);
                    hienThi();
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void xoabtn_Click(object sender, EventArgs e)
        {
            string matacgia = matgtxt.Texts.ToString();
            if (matacgia == "")
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ dữ liệu");
            }
            else
            {
                try
                {
                    tgb.delete(matacgia);
                    hienThi();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        private void suabtn_Click(object sender, EventArgs e)
        {
            string matacgia = matgtxt.Texts.ToString();
            string tentacgia = tentgTxt.Texts.ToString();
            string gioitinh = cb_gioiTinh.SelectedItem.ToString();
            string email = emailtxt.Texts.ToString();
            string ghichu = ghichutxt.Texts.ToString();
            if (matacgia == "" || tentacgia == "" || gioitinh == "" || email == "")
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ dữ liệu");
            } else
            {
                try
                {
                    tgb.update(tentacgia, email, gioitinh, ghichu, matacgia);
                    hienThi();
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
               
            }
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            matgtxt.Texts = "";
            tentgTxt.Texts = "";
            cb_gioiTinh.SelectedIndex = 0;
            emailtxt.Texts = "";
            ghichutxt.Texts = "";
        }

        private void DGV_Tacgia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            matgtxt.Texts = DGV_Tacgia.CurrentRow.Cells[0].Value.ToString();
            tentgTxt.Texts = DGV_Tacgia.CurrentRow.Cells[1].Value.ToString();
            ghichutxt.Texts = DGV_Tacgia.CurrentRow.Cells[2].Value.ToString();
            emailtxt.Texts = DGV_Tacgia.CurrentRow.Cells[3].Value.ToString();
            cb_gioiTinh.SelectedIndex = cb_gioiTinh.Items.IndexOf(DGV_Tacgia.CurrentRow.Cells[4].Value.ToString());
            matgtxt.Enabled = false;
        }
    }
}

