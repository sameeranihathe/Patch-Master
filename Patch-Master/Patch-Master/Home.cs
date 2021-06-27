using Patch_Master.DbContext.Database;
using Patch_Master.DbContext.QueryReader;
using Patch_Master.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patch_Master
{
    public partial class Home : Form
    {
        public static int loggedUserId = 0;
        public static bool Userlogged = false;
        public static string UserName = string.Empty;
        public static string FirstName = string.Empty;
        public static string Role = string.Empty;
        public static int RoleId = 0;
        public Home()
        {
            InitializeComponent();


            label_processCount.Text = LoadProcessCount().ToString();


            if (Role!="Admin")
            {
                this.toolStripMenuIAddUser.Visible = false;
                //this.ta tabControl.TabPages.Remove(tabPage);
                this.tabControl_home.TabPages.Remove(hometabPage_all);
            }
            else
            {
            }

        }

        private int LoadProcessCount()
        {
            DbConnector dbContext = new DbConnector();
            int ProcessCount = 0;

            try
            {
                string queryString = SqlQueryStringReader.GetQueryStringById("LoadUserWiseProcessCount", "Processes");
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@loggedUserId", loggedUserId));
                var dataReaders = dbContext.ExecuteQueryWithIDataReader(queryString, sqlParams);
                var reader = dataReaders[0];

                while (reader.Read())
                {
                    ProcessCount = Convert.ToInt32(reader["ProcessCount"]);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dbContext.CloseConnection();
            }
            return ProcessCount;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UserFirstName_label.Text = FirstName;
        }


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
            //Login login = new Login();
            //login.Show();

            this.Dispose();

        }

        private void ConnectDb_Click(object sender, EventArgs e)
        {
            DBAdder DBAdder = new DBAdder();
            DBAdder.Show();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            //this.Hide();
          

            //this.Hide();
            /// DBAdder DBAdder = new DBAdder();
            //DBAdder.show();

        }
        private void DefineRequirements_Click(object sender, EventArgs e)
        {
            Requirements requirements = new Requirements();
            requirements.Show();

        }
        private void Processes_Click(object sender, EventArgs e)
        {
            Processes processes = new Processes();
            processes.Show();
        }
        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UserList_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            users.Show();
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            label4.Font = new Font(label4.Font.Name, label4.Font.SizeInPoints, FontStyle.Underline);

        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.Font = new Font(label4.Font.Name, label4.Font.SizeInPoints, FontStyle.Regular);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
