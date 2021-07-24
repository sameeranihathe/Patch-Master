using Patch_Master.DbContext.Database;
using Patch_Master.DbContext.QueryReader;
using Patch_Master.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Patch_Master
{
    public partial class Request : Form
    {
        bool userLogged = false;
        int loggedUserId = 0;
        string loggedUserName = string.Empty;
        string roleName = string.Empty;
        int roleId = 0;
        int RequirmentID;
        public Request()
        {
            InitializeComponent();
            CheckLogin();
        }
        private void CheckLogin()
        {
            userLogged = Home.Userlogged;
            loggedUserId = Home.loggedUserId;
            loggedUserName = Home.UserName;
            roleId = Home.RoleId;
            roleName = Home.Role;
        }
        Requirements rq = new Requirements();
        private void Request_Load(object sender, EventArgs e)
        {
            //ViewRequirement_button.Enabled = false;
            #region Load Main Process
            Dictionary<int, string> AvailableProcesses = rq.LoadAvailableProcesses();
            this.Process_comboBox.SelectedIndexChanged -= new EventHandler(Process_comboBox_SelectedIndexChanged);
            Process_comboBox.DataSource = new BindingSource(AvailableProcesses, null);
            Process_comboBox.DisplayMember = "Value";
            Process_comboBox.ValueMember = "Key";
            this.Process_comboBox.SelectedIndexChanged += new EventHandler(Process_comboBox_SelectedIndexChanged);
            #endregion
            #region Load Database
            Dictionary<int, string> AvailableDatabases = rq.LoadAvailableDatabases();
            int count = AvailableDatabases.Count;
            if (count > 0)
            {
                comboBoxDatabase.DataSource = new BindingSource(AvailableDatabases, null);
                comboBoxDatabase.DisplayMember = "Value";
                comboBoxDatabase.ValueMember = "Key";
            }
            else
            {
                comboBoxDatabase.DataSource = new BindingSource(null, null);
            }
            
            #endregion
        }
        #region Inquire By Sub Process
        private void Process_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedProcessId = (((KeyValuePair<int, string>)Process_comboBox.SelectedItem).Key).ToString();
            LoadSubProcesses(selectedProcessId);
        }
        public void LoadSubProcesses(string selectedProcessId)
        {
            Dictionary<int, string> AvailableSubProcesses = rq.LoadAvailableSubProcesses(selectedProcessId);
            //this.SubProcess_comboBox.SelectedIndexChanged -= new EventHandler(SubProcess_comboBox_SelectedIndexChanged);
            int count = AvailableSubProcesses.Count;
            if (count > 0)
            {
                SubProcess_comboBox.DataSource = new BindingSource(AvailableSubProcesses, null);
                SubProcess_comboBox.DisplayMember = "Value";
                SubProcess_comboBox.ValueMember = "Key";
            }
            else
            {

                SubProcess_comboBox.DataSource = new BindingSource(null, null);
            }

            //this.SubProcess_comboBox.SelectedIndexChanged += new EventHandler(SubProcess_comboBox_SelectedIndexChanged);
        }
        #endregion
        #region  Inquire by Database
        public Dictionary<int, string> LoadAvailableDatabases()
        {
            DbConnector dbContext = new DbConnector();

            Dictionary<int, string> AvailableDatabases = new Dictionary<int, string>();
            bool Status = true;
            bool FormulationStatus = true;
            try
            {
                string queryString = SqlQueryStringReader.GetQueryStringById("loadDatabases", "DBConnections");
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("Status", Convert.ToBoolean(Status)));
                sqlParams.Add(new SqlParameter("FormulationStatus", Convert.ToBoolean(FormulationStatus)));
                var dataReaders = dbContext.ExecuteQueryWithIDataReader(queryString, sqlParams);

                if (dataReaders.Length == 0)
                {

                }
                var reader = dataReaders[0];

                while (reader.Read())
                {
                    var DbID = Convert.ToInt32(reader["DB_Id"]);
                    var DBNameName = reader["DBName"].ToString();

                    AvailableDatabases.Add(DbID, DBNameName);
                }


            }
            catch (Exception ex)
            {

                //throw ex;
            }
            finally
            {
                dbContext.CloseConnection();
            }
            return AvailableDatabases;
        }
        #endregion
        #region Display Requirment 
        private void ViewRequirement_button_Click(object sender, EventArgs e)
        {
            DisplayRequirementGroupBox.Visible = true;
            this.ViewRequirements();
            this.clear();
        }
        private void ViewRequirements()
        {
            string selectedSubProcessId = (((KeyValuePair<int, string>)SubProcess_comboBox.SelectedItem).Key).ToString();
            string selectedDatabaseID = (((KeyValuePair<int, string>)comboBoxDatabase.SelectedItem).Key).ToString();
            
            DataTable dt = LoadRequirements(selectedSubProcessId, selectedDatabaseID);
            Requirements_dataGridView.Columns.Clear();
            Requirements_dataGridView.DataSource = dt;
        }
        public DataTable LoadRequirements(string SubprocessId, String DatabaseID)
        {
            DbConnector dbContext = new DbConnector();
            DataTable dt = new DataTable();
            bool Status = true;
            bool FormulationStatus = true;
            try
            {
                string queryString = SqlQueryStringReader.GetQueryStringById("LoadFormulatedRequirements", "Requirements");
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("SubProcessId", SubprocessId));
                sqlParams.Add(new SqlParameter("Status", Convert.ToBoolean(Status)));
                sqlParams.Add(new SqlParameter("DB_Id", DatabaseID));
                sqlParams.Add(new SqlParameter("FormulationStatus", Convert.ToBoolean(FormulationStatus)));
                DataSet ds = dbContext.ExecuteQueryWithDataSet(queryString, sqlParams);
                dt = ds.Tables[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dbContext.CloseConnection();

            }

            return dt;
        }
        private void Requirements_dataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowindex = e.RowIndex;
            RequirmentID = Convert.ToInt32(Requirements_dataGridView.Rows[rowindex].Cells[0].Value.ToString());
            RequirementName_textBox.Text = Requirements_dataGridView.Rows[rowindex].Cells[1].Value.ToString();
            RequirementObjective_richTextBox.Text = Requirements_dataGridView.Rows[rowindex].Cells[3].Value.ToString();
            RequirementDescription_richTextBox.Text = Requirements_dataGridView.Rows[rowindex].Cells[2].Value.ToString();
            DatabaseTextBox.Text = Requirements_dataGridView.Rows[rowindex].Cells[4].Value.ToString();
            textBoxCreatedUser.Text = Requirements_dataGridView.Rows[rowindex].Cells[5].Value.ToString();
            textBoxCreatedDate.Text = Requirements_dataGridView.Rows[rowindex].Cells[6].Value.ToString();
            button_RequestToExecute.Visible = true;
            buttonViewRequests.Visible = true;
        }
        private void button_RequestToExecute_Click(object sender, EventArgs e)
        {
            DisplayRequirementGroupBox.Visible = false;
            string RequirmentDescription = RequirementDescription_richTextBox.Text;
            this.CreateNewRequest(RequirmentDescription);
            RequestGroupBox.Visible = true;
        }
        private void clear()
        {
            RequirementName_textBox.Text = string.Empty;
            DatabaseTextBox.Text = string.Empty;
            RequirementObjective_richTextBox.Text = string.Empty;
            RequirementDescription_richTextBox.Text = string.Empty;
            textBoxCreatedUser.Text = string.Empty;
            textBoxCreatedDate.Text = string.Empty;
        }
        #endregion
        #region Request 
        private void CreateNewRequest(String RequirmentDescription)
        {
            string MessageDisplay = string.Empty;
            DbConnector dbContext = new DbConnector();

            try
            {
                string queryString = SqlQueryStringReader.GetQueryStringById("CreateRequest", "Request");
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("RequirmentId", RequirmentID));
                sqlParams.Add(new SqlParameter("RequirmentDescription", RequirmentDescription));
                sqlParams.Add(new SqlParameter("LoginUser", loggedUserName));
                sqlParams.Add(new SqlParameter("LoginUserID", loggedUserId));
                var dataReaders = dbContext.ExecuteQueryWithIDataReader(queryString, sqlParams);

                var reader = dataReaders[0];
                int RequuestId = 0;
                while (reader.Read())
                {
                    RequuestId = Convert.ToInt32(reader["Request_Id"]);
                    textRequestID.Text = Convert.ToString(reader["Request_Id"]);
                    textRequestDescription.Text = Convert.ToString(reader["Description"]);
                    textRequestDate.Text = Convert.ToString(reader["Request_Date"]);
                }

                if (RequuestId > 0)
                {
                    MessageBox.Show("Request Created successfully");
                }
                else
                {
                    MessageBox.Show("Fail in Creating Request");
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

        }
        private void btnDone_Click(object sender, EventArgs e)
        {
            string ModifiedDescription = textRequestDescription.Text;
            int RequestId = Convert.ToInt32(textRequestID.Text);
            RequestGroupBox.Visible = false;
            this.ModifyRequest(RequestId, ModifiedDescription);
            DisplayRequirementGroupBox.Visible = true;
        }
        private void ModifyRequest(int RequestId, string ModifiedDescription)
        {
            string MessageDisplay = string.Empty;
            DbConnector dbContext = new DbConnector();

            try
            {
                string queryString = SqlQueryStringReader.GetQueryStringById("ModifyRequestDescription", "Request");
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("RequestId", RequestId));
                sqlParams.Add(new SqlParameter("RequestDescription", ModifiedDescription));
                sqlParams.Add(new SqlParameter("LoginUser", loggedUserName));
                var dataReaders = dbContext.ExecuteQueryWithIDataReader(queryString, sqlParams);
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {

                dbContext.CloseConnection();
            }
        }
        private void buttonViewRequests_Click(object sender, EventArgs e)
        {
            InquireRequest inquireRequest = new InquireRequest();
            inquireRequest.RequirmentID = RequirmentID;
            inquireRequest.NavigatedFrom = "MakeRequest";
            inquireRequest.groupBoxRequest.Visible = true;
            inquireRequest.groupBoxSearchByStatus.Visible = true;
            inquireRequest.Show();
        }

        #endregion

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
