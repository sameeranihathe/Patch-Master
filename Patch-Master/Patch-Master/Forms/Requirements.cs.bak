using Patch_Master.DbContext.Database;
using Patch_Master.DbContext.QueryReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace Patch_Master.Forms
{
    public partial class Requirements : Form
    {
        bool userLogged = false;
        int loggedUserId = 0;
        string loggedUserName = string.Empty;
        string roleName = string.Empty;
        int roleId = 0;
        int RequirmentID;
        public static string NavigatedFrom= string.Empty;

        public static string REQUIREMENTID = string.Empty; 
        public static string REQUIREMENTNAME = string.Empty;
        public static string SELECTEDDATABASEID = string.Empty;
        public static string SELECTEDDATABSENAME = string.Empty;

        public Requirements()
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
        private void Requirements_Load(object sender, EventArgs e)
        {
            #region  Load Main Process
            //ViewRequirement_button.Enabled = false;
            Dictionary<int, string> AvailableProcesses = LoadAvailableProcesses();
            this.Process_comboBox.SelectedIndexChanged -= new EventHandler(Process_comboBox_SelectedIndexChanged);
            Process_comboBox.DataSource = new BindingSource(AvailableProcesses, null);
            Process_comboBox.DisplayMember = "Value";
            Process_comboBox.ValueMember = "Key";
            this.Process_comboBox.SelectedIndexChanged += new EventHandler(Process_comboBox_SelectedIndexChanged);
            #endregion
            #region Load Database
            Dictionary<int, string> AvailableDatabases = LoadAvailableDatabases();
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
            if (NavigatedFrom == "Formulate")
            {
                ButtonNewReq.Visible = false;
            }
            else
            {
                ButtonNewReq.Visible = true;
            }
        }
        #region  Main Process 
        public Dictionary<int, string> LoadAvailableProcesses()
        {
            DbConnector dbContext = new DbConnector();

            Dictionary<int, string> AvailableProcesses = new Dictionary<int, string>();
            bool Status = true;
            try
            {
                string queryString = SqlQueryStringReader.GetQueryStringById("LoadAvailableProcessNameList", "Processes");
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("Status", Convert.ToBoolean(Status)));

                var dataReaders = dbContext.ExecuteQueryWithIDataReader(queryString, sqlParams);

                if (dataReaders.Length == 0)
                {

                }
                var reader = dataReaders[0];

                while (reader.Read())
                {
                    var processId = Convert.ToInt32(reader["ProcessId"]);
                    var processName = reader["ProcessName"].ToString();

                    AvailableProcesses.Add(processId, processName);
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
            return AvailableProcesses;
        }
        private void Process_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedProcessId = (((KeyValuePair<int, string>)Process_comboBox.SelectedItem).Key).ToString();
            LoadSubProcesses(selectedProcessId);
        }
        #endregion
        #region Sub Process
        private void SubProcess_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ViewRequirement_button.Enabled = true;
            //string selectedSubProcessId = (((KeyValuePair<int, string>)SubProcess_comboBox.SelectedItem).Key).ToString();

            //Dictionary<int, string> AvailableDatabases = LoadAvailableDatabases();
            //Databases_comboBox.DataSource = new BindingSource(AvailableDatabases, null);
            //Databases_comboBox.DisplayMember = "Value";
            //Databases_comboBox.ValueMember = "Key";
        }
        public void LoadSubProcesses(string selectedProcessId)
        {
            Dictionary<int, string> AvailableSubProcesses = LoadAvailableSubProcesses(selectedProcessId);
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
        public Dictionary<int, string> LoadAvailableSubProcesses(string selectedProcessId)
        {
            DbConnector dbContext = new DbConnector();

            Dictionary<int, string> AvailableSubProcesses = new Dictionary<int, string>();
            bool Status = true;
            try
            
            {

                string queryString = SqlQueryStringReader.GetQueryStringById("LoadAvailableSubProcesses", "Processes");
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("ProcessId", selectedProcessId));

                var dataReaders = dbContext.ExecuteQueryWithIDataReader(queryString, sqlParams);

                if (dataReaders.Length == 0)
                {

                }
                var reader = dataReaders[0];

                while (reader.Read())
                {
                    var subprocessId = Convert.ToInt32(reader["Sub Process ID"]);
                    var subprocessName = reader["Sub Process Name"].ToString();

                    AvailableSubProcesses.Add(subprocessId, subprocessName);
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
            return AvailableSubProcesses;
        }
        #endregion
        #region Database 
        public Dictionary<int, string> LoadAvailableDatabases()
        {
            DbConnector dbContext = new DbConnector();

            Dictionary<int, string> AvailableDatabases = new Dictionary<int, string>();
            bool Status = true;
            try
            {

                string queryString = SqlQueryStringReader.GetQueryStringById("loadDatabases", "DBConnections");
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("Status", Convert.ToBoolean(Status)));
                var dataReaders = dbContext.ExecuteQueryWithIDataReader(queryString, sqlParams);

                if (dataReaders.Length == 0)
                {

                }
                var reader = dataReaders[0];

                while (reader.Read())
                {
                    var databaseID = Convert.ToInt32(reader["DB_Id"]);
                    var databaseName = reader["DBName"].ToString();
                    AvailableDatabases.Add(databaseID, databaseName);
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
        private void Database_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedDatabaseId = (((KeyValuePair<int, string>)comboBoxDatabase.SelectedItem).Key).ToString();
            SELECTEDDATABSENAME = (((KeyValuePair<int, string>)comboBoxDatabase.SelectedItem).Value).ToString();
            SELECTEDDATABASEID = selectedDatabaseId;

        }
        #endregion
        #region Requirment 
        #region View Requirment 
        private void ViewRequirement_button_Click(object sender, EventArgs e)
        {
            string selectedSubProcessId = (((KeyValuePair<int, string>)SubProcess_comboBox.SelectedItem).Key).ToString();
            string selectedDatabaseID = (((KeyValuePair<int, string>)comboBoxDatabase.SelectedItem).Key).ToString();
            ViewRequirements(selectedSubProcessId, selectedDatabaseID);
            DisplayRequirement_comboBox.Visible = true;
            #region Load Database
            Dictionary<int, string> AvailableDatabases = LoadAvailableDatabases();
            int count = AvailableDatabases.Count;
            if (count > 0)
            {
                Databases_comboBox.DataSource = new BindingSource(AvailableDatabases, null);
                Databases_comboBox.DisplayMember = "Value";
                Databases_comboBox.ValueMember = "Key";
            }
            else
            {
                Databases_comboBox.DataSource = new BindingSource(null, null);
            }

            #endregion
        }
        private void ViewRequirements(string SubprocessId, string DatabaseID)
        {
            
            DataTable dt = LoadRequirements(SubprocessId, DatabaseID);
            Requirements_dataGridView.Columns.Clear();
            Requirements_dataGridView.DataSource = dt;
        }
        public DataTable LoadRequirements(string SubprocessId, string DatabaseID)
        {
            DbConnector dbContext = new DbConnector();
            DataTable dt = new DataTable();
            bool Status = true;
            try
            {
                string queryString = SqlQueryStringReader.GetQueryStringById("LoadAvailableRequirements", "Requirements");
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("SubProcessId", SubprocessId));
                sqlParams.Add(new SqlParameter("DB_Id", DatabaseID));
                sqlParams.Add(new SqlParameter("Status", Convert.ToBoolean(Status)));
                sqlParams.Add(new SqlParameter("NavigatedFrom", NavigatedFrom));
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
            Databases_comboBox.Text = Requirements_dataGridView.Rows[rowindex].Cells[4].Value.ToString();
            textBoxCreatedUser.Text = Requirements_dataGridView.Rows[rowindex].Cells[5].Value.ToString();
            textBoxCreatedDate.Text = Requirements_dataGridView.Rows[rowindex].Cells[6].Value.ToString();
            checkBoxQueryformulated.Checked = Convert.ToBoolean(Requirements_dataGridView.Rows[rowindex].Cells[7].Value.ToString());
            if (NavigatedFrom == "Formulate")
            {
                buttonModifyReq.Visible = false;
                DeleteRequiremet_button.Visible = false;
                buttonViewQueries.Visible = true;
            }
            else
            {
                
                if (checkBoxQueryformulated.Checked)
                {
                    buttonViewQueries.Visible = true;
                    buttonModifyReq.Visible = false;
                    DeleteRequiremet_button.Visible = false;
                }
                else
                {
                    buttonViewQueries.Visible = false;
                    buttonModifyReq.Visible = true;
                    DeleteRequiremet_button.Visible = true;
                }
            }
           
            

        }
        #endregion
        #region Add Requirment 
        private void ButtonNewReq_Click(object sender, EventArgs e)
        {
            AddReqGroupBox.Visible = true;
            DisplayRequirement_comboBox.Visible = false;
        }
        private void AddRequirement_button_Click(object sender, EventArgs e)
        {
            
            string RequirementName = textBoxReqName.Text;
            string RequirementDescription = richTextBoxDescription.Text;
            string RequirementObjective = richTextBoxObjective.Text;

            if (RequirementName == string.Empty || RequirementName == "")
            {
                MessageBox.Show("Requirement name cannot be empty", "Add Requirement");
                return;
            }
            if (RequirementDescription == string.Empty || RequirementDescription == "")
            {
                MessageBox.Show("Requirement description cannot be empty", "Add Requirement");
                return;
            }
            if (RequirementObjective == string.Empty || RequirementObjective == "")
            {
                MessageBox.Show("Requirement objective cannot be empty", "Add Requirement");
                return;
            }

            AddRequirements(RequirementName, RequirementDescription, RequirementObjective);
            AddReqGroupBox.Visible = false;
            DisplayRequirement_comboBox.Visible = true;
        }
        private void AddRequirements(string requirementName, string requirementDescription, string requirementObjective)
        {
            string MessageDisplay = string.Empty;
            DbConnector dbContext = new DbConnector();
            string selectedSubProcessId = (((KeyValuePair<int, string>)SubProcess_comboBox.SelectedItem).Key).ToString();
            string selectedDatabaseId = (((KeyValuePair<int, string>)comboBoxDatabase.SelectedItem).Key).ToString();
            SELECTEDDATABSENAME = (((KeyValuePair<int, string>)comboBoxDatabase.SelectedItem).Value).ToString();
            SELECTEDDATABASEID = selectedDatabaseId;
            try
            {
                string queryString = SqlQueryStringReader.GetQueryStringById("AddRequirement", "Requirements");
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("RequirementName", requirementName));
                sqlParams.Add(new SqlParameter("RequirementDescription", requirementDescription));
                sqlParams.Add(new SqlParameter("RequirementObjective", requirementObjective));
                sqlParams.Add(new SqlParameter("SubProcessId", selectedSubProcessId));
                sqlParams.Add(new SqlParameter("DatabaseId", selectedDatabaseId));
                sqlParams.Add(new SqlParameter("UserID", loggedUserId));
                sqlParams.Add(new SqlParameter("UserName", loggedUserName));
                var dataReaders = dbContext.ExecuteQueryWithIDataReader(queryString, sqlParams);

                var reader = dataReaders[0];
                int RequirementId = 0;
                while (reader.Read())
                {
                    RequirementId = Convert.ToInt32(reader["RequirementId"]);
                }

                if (RequirementId > 0)
                {
                    MessageBox.Show("Requirment added successfully");
                }
                else
                {
                    MessageBox.Show("fail adiing Requirment");
                }
                

                this.clearRequirment();
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                ViewRequirements(selectedSubProcessId, selectedDatabaseId);
                dbContext.CloseConnection();
            }
        }
        #endregion
        #region Delete/ Clear Requirment 
        private void DeleteRequiremet_button_Click(object sender, EventArgs e)
        {
            string selectedSubProcessId = (((KeyValuePair<int, string>)SubProcess_comboBox.SelectedItem).Key).ToString();
            string selectedDatabaseID = (((KeyValuePair<int, string>)Databases_comboBox.SelectedItem).Key).ToString();

            if (Requirements_dataGridView.SelectedRows.Count > 0)
            {
                List<string> RequirementIdList = new List<string>();
                List<string> RequirementNameList = new List<string>();
                foreach (DataGridViewRow row in Requirements_dataGridView.SelectedRows)
                {
                    RequirementIdList.Add(row.Cells[0].Value.ToString());
                    RequirementNameList.Add(row.Cells[1].Value.ToString());
                }
                string joined = string.Join(",", RequirementNameList);
                string message = "Are you sure you want to delete following requirements? " + joined;
                string title = "Confirm Delete";
                MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
                DialogResult result = MessageBox.Show(message, title, buttons);

                if (result == DialogResult.Yes)
                {
                    DeleteSelectedRequirements(RequirementIdList);
                    ViewRequirements(selectedSubProcessId, selectedDatabaseID);

                }
                else if (result == DialogResult.No)
                {
                    //...
                }
                else
                {
                    //...
                }

            }
            else
            {
                MessageBox.Show("No requirement seleted", "Delete Porcess");

            }
        }
        private void DeleteSelectedRequirements(List<string> requirementIdList)
        {
            DbConnector dbContext = new DbConnector();
            try
            {
                string joinedRequirementIdList = string.Join(",", requirementIdList);

                string queryString = SqlQueryStringReader.GetQueryStringById("DeleteRequirements", "Requirements");
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("RequirementIdList", joinedRequirementIdList));
                dbContext.ExecuteQueryWithIDataReader(queryString, sqlParams);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                dbContext.CloseConnection();
            }

        }
        private void ClearRequirement_button_Click(object sender, EventArgs e)
        {

            this.clearRequirment();
        }
        private void clearRequirment()
        {
            RequirementName_textBox.Text = string.Empty;
            RequirementDescription_richTextBox.Text = string.Empty;
            RequirementObjective_richTextBox.Text = string.Empty;
            Databases_comboBox.Text = string.Empty;
        }
        #endregion
        #region Modify Requirment
        private void buttonModifyReq_Click(object sender, EventArgs e)
        {
            string RequirmentObjective = RequirementObjective_richTextBox.Text;
            string RequirmentDescription = RequirementDescription_richTextBox.Text;
            this.ModifyRequirment(RequirmentObjective, RequirmentDescription);

        }
        private void ModifyRequirment(string Objective, string Description)
        {
            DbConnector dbContext = new DbConnector();
            string selectedSubProcessId = (((KeyValuePair<int, string>)SubProcess_comboBox.SelectedItem).Key).ToString();
            string selectedDatabaseId = (((KeyValuePair<int, string>)comboBoxDatabase.SelectedItem).Key).ToString();
            try
            {
                string queryString = SqlQueryStringReader.GetQueryStringById("UpdateRequirement", "Requirements");
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("Description", Description));
                sqlParams.Add(new SqlParameter("Objective", Objective));
                sqlParams.Add(new SqlParameter("RequirmentId", RequirmentID));
                var dataReaders = dbContext.ExecuteQueryWithIDataReader(queryString, sqlParams);
                this.clearRequirment();
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                ViewRequirements(selectedSubProcessId, selectedDatabaseId);
                dbContext.CloseConnection();
            }

        }
        #endregion
        private void SetRequirementDetails(string requirementName, string requirementDescription)
        {
            RequirementNameView_textBox.Text = requirementName;
            RequirementDescriptionView_richTextBox.Text = requirementDescription;
        }
        #endregion
        #region Query 
        private void ViewQueries_button_Click(object sender, EventArgs e)
        {
            if (Requirements_dataGridView.SelectedRows.Count > 1)
            {
                MessageBox.Show("Only one requirement can be selected at a time!", "Sub Process");
            }
            else if (Requirements_dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a requirement to view subprocesses", "Sub Process");
            }
            else if (Requirements_dataGridView.SelectedRows.Count == 1)
            {

                REQUIREMENTID = Requirements_dataGridView.SelectedRows[0].Cells[0].Value.ToString();
                REQUIREMENTNAME = Requirements_dataGridView.SelectedRows[0].Cells[1].Value.ToString();
                string requirementDescription = Requirements_dataGridView.SelectedRows[0].Cells[2].Value.ToString();
                
                AvailableQueries availableQueries = new AvailableQueries();
                availableQueries.Show();
            }
        }
        #endregion
        private void buttonReturn_Click(object sender, EventArgs e)
        {
            NavigatedFrom = string.Empty;
            this.Close();
        }
       


    }
}
