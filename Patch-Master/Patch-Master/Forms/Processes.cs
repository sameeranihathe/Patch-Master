using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Patch_Master.DbContext.QueryReader;
using Patch_Master.DbContext.Database;
using Patch_Master.CustomInputField;
using System.Data.SqlClient;

namespace Patch_Master.Forms
{
    public partial class Processes : Form
    {
        bool userLogged = false;
        int loggedUserId = 0;
        string loggedUserName = string.Empty;
        string roleName = string.Empty;
        int roleId = 0;
        public Processes()
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
        private void Processes_Load(object sender, EventArgs e)
        {
            try
            {
                AddProcess_panel.Visible = false;
                SubProcess_panel.Visible = false;
                ViewDataTable();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void ViewDataTable()
        {
            DataTable dt = LoadProcesses();
            dataGridView_Processws.Columns.Clear();
            dataGridView_Processws.DataSource = dt;
        }


        private static DataTable LoadProcesses()
        {
            DbConnector dbContext = new DbConnector();
            DataTable dt = new DataTable();
            bool Status = true;
            try
            {
                string queryString = SqlQueryStringReader.GetQueryStringById("LoadAvailableProcesses", "Processes");
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("Status", Convert.ToBoolean(Status)));
                DataSet ds = dbContext.ExecuteQueryWithDataSet(queryString, sqlParams);
                dt = ds.Tables[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return dt;
        }

        private void AddProcess_btn_Click(object sender, EventArgs e)
        {
            DeleteProcess_btn.Enabled = false;
            SubProcesses_btn.Enabled = false;
            AddProcess_panel.Visible = true;

        }

        private void button_SaveProcess_Click(object sender, EventArgs e)
        {
            string ProcessName = textBox_ProcessName.Text.ToString();
            string ProcessDescription = richTextBox_ProcessDescription.Text.ToString();

            string MessageDisplay = string.Empty;
            if (ProcessName == "")
            {
                MessageDisplay = "Process name cannot be empty";
            }
            else if (ProcessDescription == "")
            {
                MessageDisplay = "Process description cannot be empty";
            }
            else
            {
                DbConnector dbContext = new DbConnector();
                string queryString = SqlQueryStringReader.GetQueryStringById("AddProcess", "Processes");
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("ProcessName", ProcessName));
                sqlParams.Add(new SqlParameter("ProcessDescription", ProcessDescription));
                sqlParams.Add(new SqlParameter("CreatedBy", loggedUserId));
                var dataReaders = dbContext.ExecuteQueryWithIDataReader(queryString, sqlParams);

                var reader = dataReaders[0];
                int ProcessId = 0;
                while (reader.Read())
                {
                    ProcessId = Convert.ToInt32(reader["ProcessId"]);
                }

                dbContext.CloseConnection();

                if (ProcessId > 0)
                {
                    MessageDisplay = "Process added successfully";
                }
                else
                {
                    MessageDisplay = "Process saving failed";
                }
                MessageBox.Show(MessageDisplay, "Add Process");

                textBox_ProcessName.Text = string.Empty;
                richTextBox_ProcessDescription.Text = string.Empty;

                ViewDataTable();
            }
        }

        private void DeleteProcess_btn_Click(object sender, EventArgs e)
        {
            if (dataGridView_Processws.SelectedRows.Count > 0)
            {
                List<string> ProcessIdList = new List<string>();
                List<string> ProcessNameList = new List<string>();
                foreach (DataGridViewRow row in dataGridView_Processws.SelectedRows)
                {
                    ProcessIdList.Add(row.Cells[0].Value.ToString());
                    ProcessNameList.Add(row.Cells[1].Value.ToString());
                }
                string joined = string.Join(",", ProcessNameList);
                string message = "Are you sure you want to delete following processes? " + joined;
                string title = "Confirm Delete";
                MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
                DialogResult result = MessageBox.Show(message, title, buttons);

                if (result == DialogResult.Yes)
                {
                    DeleteSelectedProcesses(ProcessIdList);
                    ViewDataTable();

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
                MessageBox.Show("No processes seleted", "Delete Porcess");

            }
        }

        private void DeleteSelectedProcesses(List<string> processIdList)
        {
            DbConnector dbContext = new DbConnector();

            try
            {

                string joinedprocessIdList = string.Join(",", processIdList);

                string queryString = SqlQueryStringReader.GetQueryStringById("DeleteProcesses", "Processes");
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@ProcessIdList", joinedprocessIdList));
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

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_ProcessName.Text = string.Empty;
            richTextBox_ProcessDescription.Text = string.Empty;
        }

        private void button_Done_Click(object sender, EventArgs e)
        {
            DeleteProcess_btn.Enabled = true;
            SubProcesses_btn.Enabled = true;
            AddProcess_panel.Visible = false;
        }

        private void SubProcesses_btn_Click(object sender, EventArgs e)
        {
            if (dataGridView_Processws.SelectedRows.Count > 1)
            {
                MessageBox.Show("Only one process can be selected at a time!", "Sub Process");
            }
            else if (dataGridView_Processws.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a process to view subprocesses", "Sub Process");
            }
            else if (dataGridView_Processws.SelectedRows.Count == 1)
            {
                SubProcess_panel.Visible = true;
                DeleteProcess_btn.Enabled = false;
                AddProcess_btn.Enabled = false;

                string processId = dataGridView_Processws.SelectedRows[0].Cells[0].Value.ToString();
                string processName = dataGridView_Processws.SelectedRows[0].Cells[1].Value.ToString();

                lbl_processName.Text = processName;
                ViewSubProcesses(processId);
            }
        }

        private void ViewSubProcesses(string processId)
        {
            DataTable dt = LoadSubProcesses(processId);
            dataGridView_SubProcesses.Columns.Clear();
            dataGridView_SubProcesses.DataSource = dt;
        }

        private static DataTable LoadSubProcesses(string processId)
        {
            DbConnector dbContext = new DbConnector();
            DataTable dt = new DataTable();
            try
            {
                string queryString = SqlQueryStringReader.GetQueryStringById("LoadAvailableSubProcesses", "Processes");
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("ProcessId", processId));
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

        private void btn_subProcessDone_Click(object sender, EventArgs e)
        {
            SubProcess_panel.Visible = false;
            DeleteProcess_btn.Enabled = true;
            AddProcess_btn.Enabled = true;
        }

        private void btn_DeleteSubProcess_Click(object sender, EventArgs e)
        {
            if (dataGridView_SubProcesses.SelectedRows.Count > 0)
            {
                List<string> SubProcessIdList = new List<string>();
                List<string> SubProcessNameList = new List<string>();
                foreach (DataGridViewRow row in dataGridView_SubProcesses.SelectedRows)
                {
                    SubProcessIdList.Add(row.Cells[0].Value.ToString());
                    SubProcessNameList.Add(row.Cells[1].Value.ToString());
                }
                string joined = string.Join(",", SubProcessNameList);
                string message = "Are you sure you want to delete following sub processes? " + joined;
                string title = "Confirm Delete";
                MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
                DialogResult result = MessageBox.Show(message, title, buttons);

                string processId = dataGridView_Processws.SelectedRows[0].Cells[0].Value.ToString();

                if (result == DialogResult.Yes)
                {
                    DeleteSelectedSubProcesses(SubProcessIdList);
                    ViewSubProcessDataTable(processId);

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
                MessageBox.Show("No processes seleted", "Delete Porcess");

            }
        }

        private void DeleteSelectedSubProcesses(List<string> subProcessIdList)
        {
            DbConnector dbContext = new DbConnector();

            try
            {
                string joinedprocessIdList = string.Join(",", subProcessIdList);

                string queryString = SqlQueryStringReader.GetQueryStringById("DeleteSubProcesses", "Processes");
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@SubProcessIdList", joinedprocessIdList));
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
        private void ViewSubProcessDataTable(string processId)
        {
            DataTable dt = LoadSubProcesses(processId);
            dataGridView_SubProcesses.Columns.Clear();
            dataGridView_SubProcesses.DataSource = dt;
        }

        private void btn_AddSubProcess_Click(object sender, EventArgs e)
        {
            string subProcessName = string.Empty;
            string value = "Sub process";
            if (CustomInput.InputDialogBox("Add SubProcess", "Sub Process:", ref value) == DialogResult.OK)
            {
                subProcessName = value;
            }
            string processId = dataGridView_Processws.SelectedRows[0].Cells[0].Value.ToString();
            
            if (subProcessName!=string.Empty)
            {
                AddSubProcess(processId, subProcessName);
            }

        }

        private void AddSubProcess(string processId, string subProcessName)
        {
            DbConnector dbContext = new DbConnector();

            try
            {
                string queryString = SqlQueryStringReader.GetQueryStringById("AddSubProcess", "Processes");
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@SubProcessName", subProcessName));
                sqlParams.Add(new SqlParameter("@ProcessId", processId));
                var dataReaders= dbContext.ExecuteQueryWithIDataReader(queryString, sqlParams);
                var reader = dataReaders[0];

                int SubProcessId = 0;
                while (reader.Read())
                {
                    SubProcessId = Convert.ToInt32(reader["SubProcessId"]);
                }
                ViewSubProcessDataTable(processId);
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

        private void SubProcess_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
