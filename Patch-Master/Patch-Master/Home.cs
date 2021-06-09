using Patch_Master.Forms;
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
        public static bool Userlogged = false;
        public static string UserName = string.Empty;
        public static string FirstName = string.Empty;
        public static string Role = string.Empty;
        public static int RoleId =0;

        //private void Login_Click(object sender, EventArgs e)
        //{
        //    Login login = new Login();
        //    login.Show();
        //}

        //private void label_loginMouseMove(object sender, MouseEventArgs e)
        //{
        //    label_login.Font = new Font(label_login.Font.FontFamily, label_login.Font.SizeInPoints, FontStyle.Underline);
        //}

        //private void label_loginMouseLeave(object sender, EventArgs e)
        //{
        //    label_login.Font = new Font(label_login.Font.FontFamily, label_login.Font.SizeInPoints, FontStyle.Regular);

        //}

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_Click(object sender, EventArgs e)
        {

        }
        private void menuStripLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DBAdder DBAdder = new DBAdder();
            DBAdder.Show();
          

            //this.Hide();
            /// DBAdder DBAdder = new DBAdder();
            //DBAdder.show();

        }
    }
}
