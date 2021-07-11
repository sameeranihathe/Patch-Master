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
using Patch_Master.Dto;
using Microsoft.Reporting.WebForms;
using Microsoft.ReportingServices.Interfaces;
using Report = Microsoft.ReportingServices.Interfaces.Report;

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
            this.HideFunctionalitesByRoles();

            label_processCount.Text = LoadProcessCount().ToString();

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
        private void HideFunctionalitesByRoles()
        {
            if (Role != "Admin")
            {
                toolStripMenuIAddUser.Visible = false;
                connectDbToolStripMenu.Visible = false;
                AprovalToolStripMenu.Visible = false;
                processesToolStripMenu.Visible = false;
                ApproveRequestToolStripMenu.Visible = false;
            }
        }
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
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            QueryTypeSelector QueryTypeSelector = new QueryTypeSelector();
            QueryTypeSelector.Show();
        }

        private void FormulateQuery_Click(object sender, EventArgs e)
        {
            Requirements requirements = new Requirements();
            Requirements.NavigatedFrom = "Formulate";
            requirements.Show();

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
        private void ViewAllProcesses_label_MouseEnter(object sender, EventArgs e)
        {
            ViewAllProcesses_label.Font = new Font(ViewAllProcesses_label.Font.Name, ViewAllProcesses_label.Font.SizeInPoints, FontStyle.Underline);

        }
        private void ViewAllProcesses_label_MouseLeave(object sender, EventArgs e)
        {
            ViewAllProcesses_label.Font = new Font(ViewAllProcesses_label.Font.Name, ViewAllProcesses_label.Font.SizeInPoints, FontStyle.Regular);
        }
        private void label4_Click(object sender, EventArgs e)
        {
            List<ProcessDetails> ProcessDetails = LoadAvailableProcessesUserWise(loggedUserId);
        }
        private List<ProcessDetails> LoadAvailableProcessesUserWise(int loggedUserId)
        {
            List<ProcessDetails> ProcessDetailsList = new List<ProcessDetails>();
            DbConnector dbContext = new DbConnector();

            try
            {
                string queryString = SqlQueryStringReader.GetQueryStringById("LoadUserWiseProcessDetails", "Processes");
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@CreatedUser", loggedUserId));
                var dataReaders = dbContext.ExecuteQueryWithIDataReader(queryString, sqlParams);
                var reader = dataReaders[0];

                while (reader.Read())
                {
                    ProcessDetails processDetails = new ProcessDetails
                    {
                        ProcessId = Convert.ToInt32(reader["ProcessId"]),
                        ProcessName = reader["ProcessName"].ToString(),
                        ProcessDescription = reader["ProcessDescription"].ToString(),
                        CreatedDate = reader["CreatedDate"].ToString()
                    };
                    ProcessDetailsList.Add(processDetails);
                }

            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                dbContext.CloseConnection();

            }

            return ProcessDetailsList;
        }
        private void MakeRequestToolStripMenu_Click(object sender, EventArgs e)
        {
            Request request = new Request();
            request.Show();
        }
        private void ApproveRequestToolStripMenu_Click(object sender, EventArgs e)
        {
            InquireRequest inquireRequest = new InquireRequest();
            inquireRequest.NavigatedFrom = "ApproveRequest";
            inquireRequest.Show();
        }
        private void ExecuteRequestToolStripMenu_Click(object sender, EventArgs e)
        {
            InquireRequest inquireRequest = new InquireRequest();
            inquireRequest.NavigatedFrom = "ExecuteRequest";
            inquireRequest.Show();
        }

        private void hometabPage_mine_Click(object sender, EventArgs e)
        {

        }

        private void requirmentsByProcessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
