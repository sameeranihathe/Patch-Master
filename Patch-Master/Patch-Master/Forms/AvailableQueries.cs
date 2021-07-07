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
        public AvailableQueries()
        {
            InitializeComponent();
            LoadSavedQueriesGrid();
        }

        private void LoadSavedQueriesGrid()
        {
            DataTable dt = LoadQueries(Requirements.REQUIREMENTID);

            SavedQueries_dataGridView.Columns.Clear();
            SavedQueries_dataGridView.DataSource = dt;
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
    }
}
