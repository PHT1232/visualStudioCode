﻿using System;
using System.IO;
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
    public partial class Form2 : Form
    {
        ThemForm tf;
        public Form2()
        {
            InitializeComponent();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            customizeDesing();
        }

        private void customizeDesing()
        {
            subMenu1.Visible = false;
            subMenu2.Visible = false;          
            subMenu3.Visible = false;
            settingPanel.Visible = false;
        }

        private void hideSubMenu(Panel submenu)
        {
            submenu.Visible = false;
        }

        private void showSubMenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                
                submenu.Visible = true;
            } else
            {
                hideSubMenu(submenu);
            }
        }

        private void sachMenuBtn_Click(object sender, EventArgs e)
        {
            showSubMenu(subMenu1);
        }

        private void docGiaMenuBtn_Click(object sender, EventArgs e)
        {
            showSubMenu(subMenu2);
        }

        private void nhanVienbtn_Click(object sender, EventArgs e)
        {
            showSubMenu(subMenu3);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void themSach_Click(object sender, EventArgs e)
        {
            pictureBox3.Hide();
            tf = new ThemForm();
            tf.TopLevel = false;
            tf.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(tf);
            tf.Show();
        }

        private void profile_Click_1(object sender, EventArgs e)
        {
            showSubMenu(settingPanel);
        }
    }
}
