using Patch_Master.DbContext.Database;
using Patch_Master.DbContext.QueryReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Patch_Master.Forms
{
    public partial class QueryTypes : Form
    {
        public QueryTypes()
        {
            InitializeComponent();
            DataTable dt = LoadQueryTypes();
            int count = dataGridViewQueryTypes.RowCount;
            dataGridViewQueryTypes.Columns.Clear();
            dataGridViewQueryTypes.DataSource = dt;
           
            
        }
        private DataTable LoadQueryTypes()
        {
            DbConnector dbContext = new DbConnector();
            DataTable dt = new DataTable();
            bool status = true;
            try
            {
                string queryString = SqlQueryStringReader.GetQueryStringById("ListQueryTypes", "QueryTypes");
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("Status", Convert.ToBoolean(status)));
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

        private void buttonAppReq_Click(object sender, EventArgs e)
        {
            bool SetApprovalRequired = true;
            SetApprovalRequiredStatus(SetApprovalRequired);
        }

        private void buttonAppNotReq_Click(object sender, EventArgs e)
        {
            bool SetApprovalRequired = false;
            SetApprovalRequiredStatus(SetApprovalRequired);
        }

        private void buttonRetrun_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SetApprovalRequiredStatus(bool SetApprovalRequired)
        {
            DbConnector dbContext = new DbConnector();
            try
            {
                int QueryTypeId = Convert.ToInt32(dataGridViewQueryTypes.SelectedRows[0].Cells[0].Value.ToString());
                string queryString = SqlQueryStringReader.GetQueryStringById("ApprovalRequiredStatus", "QueryTypes");
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("QueryTypeId", QueryTypeId));
                sqlParams.Add(new SqlParameter("SetApprovalRequired", SetApprovalRequired));
                var dataReader = dbContext.ExecuteQueryWithIDataReader(queryString, sqlParams);
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {

                dbContext.CloseConnection();
            }
            DataTable dt = LoadQueryTypes();
            dataGridViewQueryTypes.Columns.Clear();
            dataGridViewQueryTypes.DataSource = dt;
        }
        private void dataGridViewQueryTypes_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string QueryType = (dataGridViewQueryTypes.SelectedRows[0].Cells[1].Value.ToString());
            bool ApprovalRequied = Convert.ToBoolean(dataGridViewQueryTypes.SelectedRows[0].Cells[2].Value.ToString());
            if (QueryType == "SELECT" || QueryType == "SELECT AGGREGATE")
            {
                if (ApprovalRequied)
                {
                    buttonAppNotReq.Visible = true;
                    buttonAppReq.Visible = false;
                    {

                    }
                }
                else
                {
                    buttonAppReq.Visible = true;
                    buttonAppNotReq.Visible = false;
                }
            }
            else
            {
                buttonAppReq.Visible = false;
                buttonAppNotReq.Visible = false;
            }
        }
            
    }
}
