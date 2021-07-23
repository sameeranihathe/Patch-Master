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
    public partial class AvailableQueries : Form
    {
        bool userLogged = false;
        int loggedUserId = 0;
        string loggedUserName = string.Empty;
        string roleName = string.Empty;
        int roleId = 0;
        Requirements requirements;

        public AvailableQueries()
        {
            InitializeComponent();
            CheckLogin();
            LoadSavedQueriesGrid();
        }
        public AvailableQueries(Requirements Passedrequirements)
        {
            InitializeComponent();
            requirements = Passedrequirements;
            CheckLogin();
            LoadSavedQueriesGrid();
        }
        private void CheckLogin()
        {
            userLogged = Home.Userlogged;
            loggedUserId = Home.loggedUserId;
            loggedUserName = Home.UserName;
            roleId = Home.RoleId;
            roleName = Home.Role;

        }
        private void LoadSavedQueriesGrid()
        {
            DataTable dt = LoadQueries(Requirements.REQUIREMENTID);

            SavedQueries_dataGridView.Columns.Clear();
            SavedQueries_dataGridView.DataSource = dt;

            if (Requirements.NavigatedFrom == "Formulate") 
            {
                AddQuery_button.Visible = true;
                DeleteQuery_button.Visible = true;
                int numRows = SavedQueries_dataGridView.Rows.Count;
                if (numRows>0)
                {
                    buttonConfirmFormulation.Visible = true;
                }
            }
            else
            {
                AddQuery_button.Visible = false;
                DeleteQuery_button.Visible = false;
                buttonConfirmFormulation.Visible = false;
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
        private void AddQuery_button_Click(object sender, EventArgs e)
        {
            QueryTypeSelector queryTypeSelector = new QueryTypeSelector();
            queryTypeSelector.Show();
        }
        private void ViewQuery_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowindex = e.RowIndex;
            int QueryID = Convert.ToInt32(SavedQueries_dataGridView.Rows[rowindex].Cells[0].Value.ToString());

            string SavedQueryString = LoadQueryString(QueryID);
            Query_richTextBox.Text = SavedQueryString;
        }
        private string LoadQueryString(int queryID)
        {
            DbConnector dbContext = new DbConnector();
            string Query = string.Empty;
            try
            {
                string queryString = SqlQueryStringReader.GetQueryStringById("LoadQuery", "Queries");
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("QueryId", queryID));
                var dataReaders = dbContext.ExecuteQueryWithIDataReader(queryString, sqlParams);

                var reader = dataReaders[0];

                while (reader.Read())
                {
                    Query = reader["QueryString"].ToString();
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                dbContext.CloseConnection();
            }
            return Query;
        }
        private void DeleteQuery_button_Click(object sender, EventArgs e)
        {

        }
        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttonConfirmFormulation_Click(object sender, EventArgs e)
        {
            DbConnector dbContext = new DbConnector();
            try
            {
                string queryString = SqlQueryStringReader.GetQueryStringById("UpdateFormulation", "Requirements");
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("RequirmentID", Requirements.REQUIREMENTID));
                sqlParams.Add(new SqlParameter("LoginUserID", loggedUserId));
                var dataReaders = dbContext.ExecuteQueryWithIDataReader(queryString, sqlParams);
                var reader = dataReaders[0];
                int RequestId = 0;
                while (reader.Read())
                {
                    RequestId = Convert.ToInt32(reader["RequirmentID"]);

                }

                if (RequestId > 0)
                {
                    MessageBox.Show("Queries are Successfully Formulated Against the Requirment");
                    string selectedSubProcessId = (((KeyValuePair<int, string>)requirements.SubProcess_comboBox.SelectedItem).Key).ToString();
                    string selectedDatabaseID = (((KeyValuePair<int, string>)requirements.comboBoxDatabase.SelectedItem).Key).ToString();
                    requirements.ViewRequirements(selectedSubProcessId, selectedDatabaseID);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Formulation of Queries against the Requirment failed");
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
    }
}
