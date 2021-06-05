﻿using Patch_Master.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patch_Master
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
        }

        private void label_loginMouseMove(object sender, MouseEventArgs e)
        {
            label_login.Font = new Font(label_login.Font.FontFamily, label_login.Font.SizeInPoints, FontStyle.Underline);
        }

        private void label_loginMouseLeave(object sender, EventArgs e)
        {
            label_login.Font = new Font(label_login.Font.FontFamily, label_login.Font.SizeInPoints, FontStyle.Regular);

        }
    }
}