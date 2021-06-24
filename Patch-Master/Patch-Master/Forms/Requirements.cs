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
            ViewRequirement_button.Enabled = false;
            Dictionary<int, string> AvailableProcesses = LoadAvailableProcesses();
            this.Process_comboBox.SelectedIndexChanged -= new EventHandler(Process_comboBox_SelectedIndexChanged);

            Process_comboBox.DataSource = new BindingSource(AvailableProcesses, null);
            Process_comboBox.DisplayMember = "Value";
            Process_comboBox.ValueMember = "Key";

            //S string valuex = ((KeyValuePair<int, string>)Process_comboBox.SelectedItem).Value;
            //foreach (var process in AvailableProcesses)
            //{
            //    Process_comboBox.Items.Add(new { process.Key, process.Value });
            //    Process_comboBox.DisplayMember = "Value";
            //    Process_comboBox.ValueMember = "Key";

            //}
            this.Process_comboBox.SelectedIndexChanged += new EventHandler(Process_comboBox_SelectedIndexChanged);

        }

        private Dictionary<int, string> LoadAvailableProcesses()
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
        private void SubProcess_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ViewRequirement_button.Enabled = true;
            string selectedSubProcessId = (((KeyValuePair<int, string>)SubProcess_comboBox.SelectedItem).Key).ToString();

            Dictionary<int, string> AvailableDatabases = LoadAvailableDatabases();
            
            Databases_comboBox.DataSource = new BindingSource(AvailableDatabases, null);
            Databases_comboBox.DisplayMember = "Value";
            Databases_comboBox.ValueMember = "Key";
        }

        private Dictionary<int, string> LoadAvailableDatabases()
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

        private void LoadSubProcesses(string selectedProcessId)
        {
            Dictionary<int, string> AvailableSubProcesses = LoadAvailableSubProcesses(selectedProcessId);
            this.SubProcess_comboBox.SelectedIndexChanged -= new EventHandler(SubProcess_comboBox_SelectedIndexChanged);

            SubProcess_comboBox.DataSource = new BindingSource(AvailableSubProcesses, null);
            SubProcess_comboBox.DisplayMember = "Value";
            SubProcess_comboBox.ValueMember = "Key";

            this.SubProcess_comboBox.SelectedIndexChanged += new EventHandler(SubProcess_comboBox_SelectedIndexChanged);

        }

        private Dictionary<int, string> LoadAvailableSubProcesses(string selectedProcessId)
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
                    var subprocessId = Convert.ToInt32(reader["SubProcessId"]);
                    var subprocessName = reader["SubProcessName"].ToString();

                    AvailableSubProcesses.Add(subprocessId, subprocessName);
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
            return AvailableSubProcesses;
        }

        private void ViewRequirement_button_Click(object sender, EventArgs e)
        {
            string selectedSubProcessId = (((KeyValuePair<int, string>)SubProcess_comboBox.SelectedItem).Key).ToString();

            ViewRequirements(selectedSubProcessId);

            DisplayRequirement_comboBox.Visible = true;

            Process_comboBox.Enabled = false;
            SubProcess_comboBox.Enabled = false;
        }

        private void AddRequirement_button_Click(object sender, EventArgs e)
        {
            string RequirementName = RequirementName_textBox.Text;
            string RequirementDescription = RequirementDescription_richTextBox.Text;
            string RequirementObjective = RequirementObjective_richTextBox.Text;

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
        }

        private void AddRequirements(string requirementName, string requirementDescription, string requirementObjective)
        {
            string MessageDisplay = string.Empty;
            DbConnector dbContext = new DbConnector();
            string selectedSubProcessId = (((KeyValuePair<int, string>)SubProcess_comboBox.SelectedItem).Key).ToString();
            string selectedDatabaseId = (((KeyValuePair<int, string>)Databases_comboBox.SelectedItem).Key).ToString();

            try
            {
                string queryString = SqlQueryStringReader.GetQueryStringById("AddRequirement", "Requirements");
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("RequirementName", requirementName));
                sqlParams.Add(new SqlParameter("RequirementDescription", requirementDescription));
                sqlParams.Add(new SqlParameter("RequirementObjective", requirementObjective));
                sqlParams.Add(new SqlParameter("SubProcessId", selectedSubProcessId));
                sqlParams.Add(new SqlParameter("DatabaseId", selectedDatabaseId));

                var dataReaders = dbContext.ExecuteQueryWithIDataReader(queryString, sqlParams);

                var reader = dataReaders[0];
                int RequirementId = 0;
                while (reader.Read())
                {
                    RequirementId = Convert.ToInt32(reader["RequirementId"]);
                }

                if (RequirementId > 0)
                {
                    MessageDisplay = "Process added successfully";
                }
                else
                {
                    MessageDisplay = "Process saving failed";
                }
                MessageBox.Show(MessageDisplay, "Add Process");

                RequirementName_textBox.Text = string.Empty;
                RequirementDescription_richTextBox.Text = string.Empty;
                RequirementObjective_richTextBox.Text = string.Empty;
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                ViewRequirements(selectedSubProcessId);
                dbContext.CloseConnection();
            }
        }

        private void ViewRequirements(string SubprocessId)
        {
            DataTable dt = LoadRequirements(SubprocessId);
            Requirements_dataGridView.Columns.Clear();
            Requirements_dataGridView.DataSource = dt;
        }

        private DataTable LoadRequirements(string SubprocessId)
        {
            DbConnector dbContext = new DbConnector();
            DataTable dt = new DataTable();
            try
            {
                string queryString = SqlQueryStringReader.GetQueryStringById("LoadAvailableRequirements", "Requirements");
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("SubProcessId", SubprocessId));
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

        private void DeleteRequiremet_button_Click(object sender, EventArgs e)
        {
            string selectedSubProcessId = (((KeyValuePair<int, string>)SubProcess_comboBox.SelectedItem).Key).ToString();

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
                    ViewRequirements(selectedSubProcessId);

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
            RequirementName_textBox.Text = string.Empty;
            RequirementDescription_richTextBox.Text = string.Empty;
            RequirementObjective_richTextBox.Text = string.Empty;

        }

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

                string requirementId = Requirements_dataGridView.SelectedRows[0].Cells[0].Value.ToString();
                string requirementName = Requirements_dataGridView.SelectedRows[0].Cells[1].Value.ToString();
                string requirementDescription = Requirements_dataGridView.SelectedRows[0].Cells[2].Value.ToString();

                SetRequirementDetails(requirementName, requirementDescription);
                ViewSavedQueries(requirementId);
            }
        }

        private void ViewSavedQueries(string requirementId)
        {
            DataTable dt = LoadQueries(requirementId);
            if (dt.Rows.Count>0)
            {
                ViewRequirement_button.Enabled = false;
                DisplayQueries_groupBox.Visible = true;
                RequirementDetails_groupBox.Visible = true;

                Queries_dataGridView.Columns.Clear();
                Queries_dataGridView.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No available queries to display!", "Requirements");
                return;
            }
        }

        private DataTable LoadQueries(string requirementId)
        {
            DbConnector dbContext = new DbConnector();
            DataTable dt = new DataTable();
            try
            {
                string queryString = SqlQueryStringReader.GetQueryStringById("LoadAvailableQueries", "Queries");
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("RequirementId", requirementId));
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

        private void SetRequirementDetails(string requirementName, string requirementDescription)
        {
            RequirementNameView_textBox.Text = requirementName;
            RequirementDescriptionView_richTextBox.Text = requirementDescription;
        }

        private void Returm_button_Click(object sender, EventArgs e)
        {
            DisplayQueries_groupBox.Visible = false;
            RequirementDetails_groupBox.Visible = false;
        }
    }
}
