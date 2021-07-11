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
                ViewDataTable();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #region Main Process
        #region Data Grid
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
            finally
            {
                dbContext.CloseConnection();
            }

            return dt;
        }
        private void button_clear_Click(object sender, EventArgs e)
        {
            textBoxMPName.Text = string.Empty;
            textBoxMPDesc.Text = string.Empty;
        }
        private void dataGridView_Processws_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowindex = e.RowIndex;

            textBoxMPName.Text = dataGridView_Processws.Rows[rowindex].Cells[1].Value.ToString();
            textBoxMPDesc.Text = dataGridView_Processws.Rows[rowindex].Cells[2].Value.ToString();
            textBoxMPCreatedUser.Text = dataGridView_Processws.Rows[rowindex].Cells[3].Value.ToString();
            textBoxMPCreatedDate.Text = dataGridView_Processws.Rows[rowindex].Cells[4].Value.ToString();
            if (textBoxMPName.Text == "")
            {
                button_SaveProcess.Visible = true;
                buttonModifyMP.Visible = false;
                DeleteProcess_btn.Visible = false;
                SubProcesses_btn.Visible = false;
                textBoxMPName.Enabled = true;
            }
            else
            {
                buttonModifyMP.Visible = true;
                DeleteProcess_btn.Visible = true;
                SubProcesses_btn.Visible = true;
                textBoxMPName.Enabled = false;
            }
        }
        #endregion
        #region Add  Process
        private void button_SaveProcess_Click(object sender, EventArgs e)
        {
            string ProcessName = textBoxMPName.Text.ToString();
            string ProcessDescription = textBoxMPDesc.Text.ToString();

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
                //sqlParams.Add(new SqlParameter("CreatedUserName", loggedUserName));
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

                textBoxMPName.Text = string.Empty;
                textBoxMPDesc.Text = string.Empty;

                ViewDataTable();
            }
        }
        #endregion
        #region Delete Process
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
        #endregion
        #region Modify main Process
        private void buttonModifyMP_Click(object sender, EventArgs e)
        {
            string MPDescription = textBoxMPDesc.Text;
            string processId = dataGridView_Processws.SelectedRows[0].Cells[0].Value.ToString();
            this.ModifyMainProcess(processId,MPDescription);
        }
        private void ModifyMainProcess(string ProcessId, string MPDescription)
        {
            DbConnector dbContext = new DbConnector();
            
            try
            {
                string queryString = SqlQueryStringReader.GetQueryStringById("ModifyProcess", "Processes");
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("Description", MPDescription));
                sqlParams.Add(new SqlParameter("ProcessID", ProcessId));
                var dataReaders = dbContext.ExecuteQueryWithIDataReader(queryString, sqlParams);
                
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                this.ViewDataTable();
                dbContext.CloseConnection();
            }

        }
    
        #endregion
        #region  Sub Process
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
                //buttonModifyMP.Visible = false;
                //DeleteProcess_btn.Visible = false;
                //button_SaveProcess.Visible = false;
                groupBoxMainProcess.Enabled = false;
                SubProcess_panel.Visible = true;

                string processId = dataGridView_Processws.SelectedRows[0].Cells[0].Value.ToString();
                string processName = dataGridView_Processws.SelectedRows[0].Cells[1].Value.ToString();

                lbl_processName.Text = processName;
                ViewSubProcessDataTable(processId);
            }
        }
        #endregion
        #region Return
        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        #endregion
        #endregion
        #region Sub Process
        #region Data grid 
        private void ViewSubProcessDataTable(string processId)
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
        private void btn_subProcessDone_Click_1(object sender, EventArgs e)
        {
            groupBoxMainProcess.Enabled = true;
            SubProcess_panel.Visible = false;
        }
        private void dataGridView_SubProcesses_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowindex = e.RowIndex;

            textBoxSPName.Text = dataGridView_SubProcesses.Rows[rowindex].Cells[1].Value.ToString();
            textBoxSPDescription.Text = dataGridView_SubProcesses.Rows[rowindex].Cells[2].Value.ToString();
            textBoxSPCreatedUser.Text = dataGridView_SubProcesses.Rows[rowindex].Cells[3].Value.ToString();
            textBoxSPCreatedDate.Text = dataGridView_SubProcesses.Rows[rowindex].Cells[4].Value.ToString();
            if (textBoxSPName.Text == "")
            {
                btn_AddSubProcess.Visible = true;
                buttonModifySP.Visible = false;
                btn_DeleteSubProcess.Visible = false;
                textBoxSPName.Enabled = true;
            }
            else
            {
                buttonModifySP.Visible = true;
                btn_DeleteSubProcess.Visible = true;
                textBoxSPName.Enabled = false;
                btn_AddSubProcess.Visible = false;
            }
        }
        #endregion
        #region Delete Sub Process
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
        #endregion
        #region Add Sub Process
        private void btn_AddSubProcess_Click_1(object sender, EventArgs e)
        {
            string processId = dataGridView_Processws.SelectedRows[0].Cells[0].Value.ToString();
            string subProcessName = textBoxSPName.Text.ToString();//dataGridView_Processws.SelectedRows[0].Cells[1].Value.ToString();
            string subProcessDescription = textBoxSPDescription.Text.ToString(); //dataGridView_Processws.SelectedRows[0].Cells[2].Value.ToString();

            this.AddSubProcess(processId, subProcessName, subProcessDescription);
        }
        private void AddSubProcess(string processId, string subProcessName, string subProcessDescription)
        {
            DbConnector dbContext = new DbConnector();

            try
            {
                string queryString = SqlQueryStringReader.GetQueryStringById("AddSubProcess", "Processes");
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@SubProcessName", subProcessName));
                sqlParams.Add(new SqlParameter("@ProcessId", processId));
                sqlParams.Add(new SqlParameter("@CreatedBy", loggedUserId));
                sqlParams.Add(new SqlParameter("@Description", subProcessDescription));
                var dataReaders = dbContext.ExecuteQueryWithIDataReader(queryString, sqlParams);
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



        #endregion
        #region Modify Sub Process
        private void buttonModifySP_Click(object sender, EventArgs e)
        {
            string SPDescription = textBoxSPDescription.Text;
            string processId = dataGridView_SubProcesses.SelectedRows[0].Cells[0].Value.ToString();
            this.ModifySubProcess(processId, SPDescription);
        }

        private void ModifySubProcess (string processID, string SPDescription)
        {
            DbConnector dbContext = new DbConnector();

            try
            {
                string queryString = SqlQueryStringReader.GetQueryStringById("ModifySubProcess", "Processes");
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("Description", SPDescription));
                sqlParams.Add(new SqlParameter("ProcessID", processID));
                var dataReaders = dbContext.ExecuteQueryWithIDataReader(queryString, sqlParams);

            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                string MPprocessId = dataGridView_Processws.SelectedRows[0].Cells[0].Value.ToString();
                this.ViewSubProcessDataTable(MPprocessId);
                dbContext.CloseConnection();
            }
        }
        #endregion

        #endregion
    }
}
