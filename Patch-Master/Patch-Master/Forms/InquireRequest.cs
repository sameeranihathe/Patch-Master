﻿using Patch_Master.DbContext.Database;
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
    public partial class InquireRequest : Form
    {
        bool userLogged = false;
        int loggedUserId = 0;
        string loggedUserName = string.Empty;
        string roleName = string.Empty;
        int roleId = 0;
        public int RequirmentID;
        public string NavigatedFrom;
        int RequestID;
        Requirements rq = new Requirements();
        public InquireRequest()
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
        private void InquireRequest_Load(object sender, EventArgs e)
        {
         
            #region Laod Requests 
            if (NavigatedFrom =="MakeRequest")
            {
                DataTable dt = LoadRequest();
                dataGridViewRequestDetails.Columns.Clear();
                dataGridViewRequestDetails.DataSource = dt;
            }
            else
            {
                #region  Load Main Process
                Dictionary<int, string> AvailableProcesses = rq.LoadAvailableProcesses();
                this.comboBoxProcess.SelectedIndexChanged -= new EventHandler(comboBoxProcess_SelectedIndexChanged);
                comboBoxProcess.DataSource = new BindingSource(AvailableProcesses, null);
                comboBoxProcess.DisplayMember = "Value";
                comboBoxProcess.ValueMember = "Key";
                this.comboBoxProcess.SelectedIndexChanged += new EventHandler(comboBoxProcess_SelectedIndexChanged);
                #endregion
                groupBoxSearchRequest.Visible = true;
            }
            #endregion
        }
        #region Process
        private void comboBoxProcess_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedProcessId = (((KeyValuePair<int, string>)comboBoxProcess.SelectedItem).Key).ToString();
            Dictionary<int, string> AvailableSubProcesses = rq.LoadAvailableSubProcesses(selectedProcessId);
            int count = AvailableSubProcesses.Count;
            if (count > 0)
            {
                comboBoxSubProcess.DataSource = new BindingSource(AvailableSubProcesses, null);
                comboBoxSubProcess.DisplayMember = "Value";
                comboBoxSubProcess.ValueMember = "Key";
            }
            else
            {
                comboBoxSubProcess.DataSource = new BindingSource(null, null);

            }
        }
        private void buttonViewRequests_Click(object sender, EventArgs e)
        {
            DataTable dt = LoadRequest();
            dataGridViewRequestDetails.Columns.Clear();
            dataGridViewRequestDetails.DataSource = dt;
            groupBoxRequest.Visible=true;
        }
        #endregion
        #region Request Details
        #region search Request
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            this.ClearRequest();
            bool bApprovalStatus;
            bool bExecutionStatus;
            string result = "";
            string ApprovalStatus = comboBoxApproved.Text;
            string ExecutionStatus = comboBoxExecuted.Text;
            this.SetStatus(ApprovalStatus, out int APStatus);
            bApprovalStatus = Convert.ToBoolean(APStatus);
            this.SetStatus(ExecutionStatus, out int ExStatus);
            bExecutionStatus = Convert.ToBoolean(ExStatus);
            if (ApprovalStatus != "Any" && ExecutionStatus != "Any")
            {
                result = "both";
            }
            else if (ApprovalStatus != "Any")
            {
                result = "ApOnly";
            }
            else if (ExecutionStatus != "Any")
            {
                result = "ExOnly";
            }

            DataTable dt = LoadRequestByStatus(result, bApprovalStatus, bExecutionStatus);
            dataGridViewRequestDetails.Columns.Clear();
            dataGridViewRequestDetails.DataSource = dt;

        }
        #endregion
        private DataTable LoadRequest()
        {
            DbConnector dbContext = new DbConnector();
            DataTable dt = new DataTable();
            string selectedSubProcessId ="";
            try
            {
                if (NavigatedFrom !="MakeRequest")
                {
                    selectedSubProcessId = (((KeyValuePair<int, string>)comboBoxSubProcess.SelectedItem).Key).ToString();
                }
                string queryString = SqlQueryStringReader.GetQueryStringById("RequestList", "Request");
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("RequirmentId", RequirmentID));
                sqlParams.Add(new SqlParameter("NavigatedFrom", NavigatedFrom)); 
                sqlParams.Add(new SqlParameter("SubProcessId", selectedSubProcessId));
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
        private void SetStatus(string YesNo, out int Status)
        {
            Status = 0;
            if (YesNo == "Yes")
            {
                Status = 1;
            }
            else
            {
                Status = 0;
            }
          
        }
        private DataTable LoadRequestByStatus(string result, bool bApproved, bool bExecuted)
        {
            DbConnector dbContext = new DbConnector();
            DataTable dt = new DataTable();
            try
            {
                string queryString = SqlQueryStringReader.GetQueryStringById("RequestListByStatus", "Request");
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("result", result));
                sqlParams.Add(new SqlParameter("ApStatus", bApproved));
                sqlParams.Add(new SqlParameter("ExStatus", bExecuted));
                sqlParams.Add(new SqlParameter("RequirmentId", RequirmentID));
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
        private void dataGridViewRequestDetails_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowindex = e.RowIndex;
            RequestID = Convert.ToInt32(dataGridViewRequestDetails.Rows[rowindex].Cells[1].Value.ToString());
            textBoxRequirmentName.Text = (dataGridViewRequestDetails.Rows[rowindex].Cells[2].Value.ToString());
            textBoxDatabase.Text = (dataGridViewRequestDetails.Rows[rowindex].Cells[5].Value.ToString());
            textBoxRequirmentObjective.Text = (dataGridViewRequestDetails.Rows[rowindex].Cells[3].Value.ToString());
            textBoxRequestDescription.Text = (dataGridViewRequestDetails.Rows[rowindex].Cells[4].Value.ToString());
            textBoxReqUser.Text = (dataGridViewRequestDetails.Rows[rowindex].Cells[6].Value.ToString());
            textBoxRequestDate.Text = (dataGridViewRequestDetails.Rows[rowindex].Cells[7].Value.ToString());
            checkBoxApproved.Checked  =Convert.ToBoolean(dataGridViewRequestDetails.Rows[rowindex].Cells[8].Value.ToString());
            checkBoxExecuted.Checked = Convert.ToBoolean(dataGridViewRequestDetails.Rows[rowindex].Cells[9].Value.ToString());
            textBoxApproveUser.Text = (dataGridViewRequestDetails.Rows[rowindex].Cells[10].Value.ToString());
            textBoxApprovedDate.Text = (dataGridViewRequestDetails.Rows[rowindex].Cells[11].Value.ToString());
            if (!checkBoxApproved.Checked && NavigatedFrom != "MakeRequest")
            {
                ButtonApprove.Visible = true;
            }
            buttonRequestedQueries.Visible = true;

        }
        private void ClearRequest()
        {
            textBoxRequirmentName.Text = string.Empty;
            textBoxDatabase.Text = string.Empty;
            textBoxRequirmentObjective.Text = string.Empty;
            textBoxRequestDescription.Text = string.Empty;
            textBoxReqUser.Text = string.Empty;
            textBoxRequestDate.Text = string.Empty;
            checkBoxApproved.Checked = false;
            checkBoxExecuted.Checked = false;
        }
        #endregion
        #region Approve Request 
        private void ButtonApprove_Click(object sender, EventArgs e)
        {
            this.UpdateApproval();
            DataTable dt = LoadRequest();
            dataGridViewRequestDetails.Columns.Clear();
            dataGridViewRequestDetails.DataSource = dt;
        }
        private void UpdateApproval ()
        {
            string MessageDisplay = string.Empty;
            DbConnector dbContext = new DbConnector();

            try
            {
                string queryString = SqlQueryStringReader.GetQueryStringById("ApproveRequest", "Request");
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("RequestId", RequestID));
                sqlParams.Add(new SqlParameter("LoginUser", loggedUserName));
                sqlParams.Add(new SqlParameter("LoginUserID", loggedUserId));
                var dataReaders = dbContext.ExecuteQueryWithIDataReader(queryString, sqlParams);
                var reader = dataReaders[0];
                int RequestId = 0;
                while (reader.Read())
                {
                    RequestId = Convert.ToInt32(reader["Request_Id"]);
                    int ApprovalStat = Convert.ToInt32(reader["Approval_Status"]);
                }

                if (RequestId > 0)
                {
                    MessageBox.Show("Request Approved");
                }
                else
                {
                    MessageBox.Show("Approval Failed");
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
        #endregion

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}