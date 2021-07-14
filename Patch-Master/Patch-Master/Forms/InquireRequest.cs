using Patch_Master.DbContext.Database;
using Patch_Master.DbContext.QueryReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
            this.ClearRequest();
        }
        
        #endregion
        #region Request Details
        #region search Request
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            this.ClearRequest();
            string bApprovalStatus;
            bool bExecutionStatus;
            string result = "";
            string ApprovalStatus = comboBoxApproved.Text;
            string ExecutionStatus = comboBoxExecuted.Text;
            bApprovalStatus = comboBoxApproved.Text;
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
        private DataTable LoadRequestByStatus(string result, string bApproved, bool bExecuted)
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
            checkBoxApproved.Text  =dataGridViewRequestDetails.Rows[rowindex].Cells[8].Value.ToString();
            checkBoxExecuted.Checked = Convert.ToBoolean(dataGridViewRequestDetails.Rows[rowindex].Cells[9].Value.ToString());
            textBoxApproveUser.Text = (dataGridViewRequestDetails.Rows[rowindex].Cells[10].Value.ToString());
            textBoxApprovedDate.Text = (dataGridViewRequestDetails.Rows[rowindex].Cells[11].Value.ToString());
            richTextBoxComment.Text = (dataGridViewRequestDetails.Rows[rowindex].Cells[12].Value.ToString());
            if (checkBoxApproved.Text =="Pending" && NavigatedFrom != "MakeRequest")
            {
                ButtonApprove.Visible = true;
                buttonRejectRequest.Visible = true;
            }
            else
            {
                ButtonApprove.Visible = false;
                buttonRejectRequest.Visible =false;
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
            checkBoxApproved.Text = string.Empty;
            checkBoxExecuted.Checked = false;
        }
        #endregion
        #region Approve Request 
        private void ButtonApprove_Click(object sender, EventArgs e)
        {
            string ApprovedRejected = "Approved";
            string Commnent = richTextBoxComment.Text;
            this.UpdateApprovalStatus(ApprovedRejected, Commnent);
            DataTable dt = LoadRequest();
            dataGridViewRequestDetails.Columns.Clear();
            dataGridViewRequestDetails.DataSource = dt;
            this.ClearRequest();

        }
        private void UpdateApprovalStatus (string ApprovedRejected, string Commnent)
        {
            string MessageDisplay = string.Empty;
            DbConnector dbContext = new DbConnector();

            try
            {
                string queryString = SqlQueryStringReader.GetQueryStringById("ApproveRequest", "Request");
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("RequestId", RequestID));;
                sqlParams.Add(new SqlParameter("LoginUserID", loggedUserId)); 
                sqlParams.Add(new SqlParameter("ApprovedRejected", ApprovedRejected));
                sqlParams.Add(new SqlParameter("Comment", Commnent));
                var dataReaders = dbContext.ExecuteQueryWithIDataReader(queryString, sqlParams);
                var reader = dataReaders[0];
                int RequestId = 0;
                while (reader.Read())
                {
                    RequestId = Convert.ToInt32(reader["Request_Id"]);
                   
                }

                if (RequestId > 0)
                {
                    MessageBox.Show("Request " + ApprovedRejected);
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
        private void buttonRejectRequest_Click(object sender, EventArgs e)
        {
            string ApprovedRejected = "Rejected";
            string Commnent = richTextBoxComment.Text;
            this.UpdateApprovalStatus(ApprovedRejected, Commnent);
            DataTable dt = LoadRequest();
            dataGridViewRequestDetails.Columns.Clear();
            dataGridViewRequestDetails.DataSource = dt;
            this.ClearRequest();
        }
        private void buttonRequestedQueries_Click(object sender, EventArgs e)
        {
            RequestedQueries requestedQueries = new RequestedQueries();
            RequestedQueries.REQUESTID = RequestID;
            requestedQueries.textBoxrequestID.Text = RequestID.ToString();
            requestedQueries.richTextBoxRequestDes.Text = textBoxRequestDescription.Text;
            requestedQueries.Show();
        }
    }
}
