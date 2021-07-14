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
    public partial class RequestedQueries : Form
    {
        bool userLogged = false;
        int loggedUserId = 0;
        string loggedUserName = string.Empty;
        string roleName = string.Empty;
        int roleId = 0;
        public static int REQUESTID;
        DataTable dtQueryResults;


        public RequestedQueries()
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
        #region Display Queries
        private void RequestedQueries_Load(object sender, EventArgs e)
        {
            
            DataTable dt = LoadRequestedQueries();
            dataGridViewRequestedQueries.Columns.Clear();
            dataGridViewRequestedQueries.DataSource = dt;
        }
        private DataTable LoadRequestedQueries()
        {
            DbConnector dbContext = new DbConnector();
            DataTable dt = new DataTable();
            try
            {
                string queryString = SqlQueryStringReader.GetQueryStringById("ListRequestedQuery", "RequestedQueries");
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("RequestID", REQUESTID));
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
        private void dataGridViewRequestedQueries_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowindex = e.RowIndex;
            textBoxExOrder.Text = dataGridViewRequestedQueries.Rows[rowindex].Cells[3].Value.ToString();
            checkBoxExecuted.Checked = Convert.ToBoolean(dataGridViewRequestedQueries.Rows[rowindex].Cells[4].Value.ToString());
            textBoxExUser.Text = dataGridViewRequestedQueries.Rows[rowindex].Cells[5].Value.ToString();
            textBoxExDate.Text = dataGridViewRequestedQueries.Rows[rowindex].Cells[6].Value.ToString();
            richTextBoxQuery.Text = dataGridViewRequestedQueries.Rows[rowindex].Cells[7].Value.ToString();
            textBoxQueryType.Text = dataGridViewRequestedQueries.Rows[rowindex].Cells[8].Value.ToString();
            textBoxDatabase.Text = dataGridViewRequestedQueries.Rows[rowindex].Cells[9].Value.ToString();
            if (!checkBoxExecuted.Checked)
            {
                buttonExecute.Visible = true;
            }
            else
            {
                buttonExecute.Visible = false;
            }
        }
        #endregion
        #region Execute Query
        private void buttonExecute_Click(object sender, EventArgs e)
        {
            
            switch (textBoxQueryType.Text)
            {
                case "SELECT":
                    dtQueryResults = ExecuteQuery();
                    dataGridViewRetrievedData.Columns.Clear();
                    dataGridViewRetrievedData.DataSource = dtQueryResults;
                    groupBoxReqQueries.Visible = false;
                    groupBoxSELECTResults.Visible = true;
                    break;
                    
            }
            int RequestedQueryID = Convert.ToInt32(dataGridViewRequestedQueries.SelectedRows[0].Cells[0].Value.ToString());
            int RequestID = Convert.ToInt32(dataGridViewRequestedQueries.SelectedRows[0].Cells[1].Value.ToString());
            setExecutionStatus(RequestedQueryID, RequestID);
        }
        private DataTable ExecuteQuery()
        {
            DbConnector dbContext = new DbConnector();
            DataTable dt = new DataTable();
            try
            {
                string queryString = "USE "+ textBoxDatabase.Text+ " " +richTextBoxQuery.Text;
                List<SqlParameter> sqlParams = new List<SqlParameter>();
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
        private void setExecutionStatus(int RequestedQueryID, int RequestID)
        {
            #region Update Execution status of Requested Queries
            DbConnector dbContext = new DbConnector();
            try
            {
                string queryString= SqlQueryStringReader.GetQueryStringById("UpdateExecute", "RequestedQueries");
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("RequestedQueryId", RequestedQueryID));
                sqlParams.Add(new SqlParameter("LoggedUserId", loggedUserId));
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
            #endregion
            #region Check all requested Queries are executed
            bool Exist = false;
            Exist = CheckExecutedQueriesExist(RequestID);
            #endregion
            #region If all requested queries are executed, update request 
            if (Exist == true)
            {
                UpdateExecutionStatusOfRequest(RequestID);
            }
            #endregion

        }
        private bool CheckExecutedQueriesExist(int RequestID)
        {
            bool Exist = false;
            DbConnector dbContext = new DbConnector();
            try
            {
                string queryStringCRQ = SqlQueryStringReader.GetQueryStringById("CountExecutedQueries", "RequestedQueries");
                List<SqlParameter> sqlParamsCRQ = new List<SqlParameter>();
                sqlParamsCRQ.Add(new SqlParameter("RequestId", RequestID));
                var dataReadersER = dbContext.ExecuteQueryWithIDataReader(queryStringCRQ, sqlParamsCRQ);
                var reader = dataReadersER[0];
                int CountofNonExecutedQueries = 0;
                while (reader.Read())
                {
                    CountofNonExecutedQueries = Convert.ToInt32(reader["RQCount"]);

                }

                if (CountofNonExecutedQueries == 0)
                {
                    Exist = true;
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
            return Exist;

        }
        private void UpdateExecutionStatusOfRequest(int RequestID)
        {
            DbConnector dbContext = new DbConnector();
            try
            {
                string queryString = SqlQueryStringReader.GetQueryStringById("UpdateRequest", "RequestedQueries");
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("RequestId", RequestID));
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
        }
        #endregion
        #region Export to Excel
        private void buttonExcel_Click(object sender, EventArgs e)
        {
            //DataTable dtQueryResults = ExecuteQuery();
            string QueryName = dataGridViewRequestedQueries.SelectedRows[0].Cells[10].Value.ToString();
            string directory = ConfigurationManager.AppSettings["ExcelPatch"] + loggedUserName+@"\" + QueryName;
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
            DateTime now = DateTime.Now;
            string datetime = now.ToString("yyy-MM-dd hh-mm-ss tt");
            string filePath =  directory + @"\" + datetime;
            ExportToExcel(dtQueryResults, filePath);
        }
        private void ExportToExcel(DataTable DataTable, string ExcelFilePath)
        {
            try
            {
                int ColumnsCount;
                if (DataTable == null || (ColumnsCount = DataTable.Columns.Count) == 0)
                    throw new Exception("ExportToExcel: Null or empty input table!\n");
                // load excel, and create a new workbook
                Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();
                Excel.Workbooks.Add();
                // single worksheet
                Microsoft.Office.Interop.Excel._Worksheet Worksheet = Excel.ActiveSheet;
                object[] Header = new object[ColumnsCount];
                // column headings               
                for (int i = 0; i < ColumnsCount; i++)
                    Header[i] = DataTable.Columns[i].ColumnName;
                Microsoft.Office.Interop.Excel.Range HeaderRange = Worksheet.get_Range((Microsoft.Office.Interop.Excel.Range)(Worksheet.Cells[1, 1]), (Microsoft.Office.Interop.Excel.Range)(Worksheet.Cells[1, ColumnsCount]));
                HeaderRange.Value = Header;
                HeaderRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);
                HeaderRange.Font.Bold = true;
                // DataCells
                int RowsCount = DataTable.Rows.Count;
                object[,] Cells = new object[RowsCount, ColumnsCount];
                for (int j = 0; j < RowsCount; j++)
                    for (int i = 0; i < ColumnsCount; i++)
                        Cells[j, i] = DataTable.Rows[j][i];
                Worksheet.get_Range((Microsoft.Office.Interop.Excel.Range)(Worksheet.Cells[2, 1]), (Microsoft.Office.Interop.Excel.Range)(Worksheet.Cells[RowsCount + 1, ColumnsCount])).Value = Cells;
                // check fielpath
                if (ExcelFilePath != null && ExcelFilePath != "")
                {
                    try
                    {
                        
                        Worksheet.SaveAs(ExcelFilePath);
                        MessageBox.Show("Excel file saved!");
                        Excel.Visible = true;
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("ExportToExcel: Excel file could not be saved! Check filepath.\n"
                            + ex.Message);
                    }
                }
                else    // no filepath is given
                {
                    Excel.Visible = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("ExportToExcel: \n" + ex.Message);
            }
        }
        #endregion
        #region return and clear 
        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttonReturnFormRetreval_Click(object sender, EventArgs e)
        {
            groupBoxSELECTResults.Visible = false;
            
            DataTable dt = LoadRequestedQueries();
            dataGridViewRequestedQueries.Columns.Clear();
            dataGridViewRequestedQueries.DataSource = dt;
            clear();
            groupBoxReqQueries.Visible = true;
            
        }
        private void clear()
        {
            textBoxExOrder.Text = string.Empty;
            textBoxExDate.Text = string.Empty;
            textBoxDatabase.Text = string.Empty;
            textBoxExUser.Text = string.Empty;
            textBoxQueryType.Text = string.Empty;
            richTextBoxQuery.Text = string.Empty;
        }
        #endregion

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxReqQueries_Enter(object sender, EventArgs e)
        {

        }
    }
}
