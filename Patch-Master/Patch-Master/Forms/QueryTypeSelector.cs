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
    public partial class QueryTypeSelector : Form
    {
        public static int SAVEDQUERYID = 0;

        bool userLogged = false;
        int loggedUserId = 0;
        string loggedUserName = string.Empty;
        string roleName = string.Empty;
        int roleId = 0;

        string QueryType =string.Empty;
        //int SavedQueryId = 0;
        public QueryTypeSelector()
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
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void QueryTypeSelector_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string queryType = string.Empty;
            if (Select.Checked)
            {
                queryType = "select";
            }
            else if (Insert.Checked)
            {
                queryType = "insert";
            }
            else if(Update.Checked)
            {
                queryType = "update";
            }
            else if (Delete.Checked)
            {
                queryType = "delete";
            }

            SaveQueryDetails(queryType);
        }

        private void SaveQueryDetails(string queryType)
        {
            DbConnector dbContext = new DbConnector();
            SAVEDQUERYID = 0;
            try
            {
                string RequirementId = Requirements.REQUIREMENTID;
                string RequirementName = Requirements.REQUIREMENTNAME;
                string SelectedDatabaseId = Requirements.SELECTEDDATABASEID;

                string QueryName = QueryName_textBox.Text;
                string QueryDescription = QueryDecription_richTextBox.Text;

                if (string.IsNullOrEmpty(QueryName))
                {
                    MessageBox.Show("Query name cannot be empty", "Add Query");
                    return;

                }
                if (string.IsNullOrEmpty(QueryDescription))
                {
                    MessageBox.Show("Query description cannot be empty", "Add Query");
                    return;
                }
                if (string.IsNullOrEmpty(QueryType))
                {
                    MessageBox.Show("Please select a query type to proceed", "Add Query");
                    return;
                }

                string queryString = SqlQueryStringReader.GetQueryStringById("SaveQueryDetails", "Queries");
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("RequirementId", RequirementId));
                sqlParams.Add(new SqlParameter("QueryName", QueryName));
                sqlParams.Add(new SqlParameter("QueryDescription", QueryDescription));
                sqlParams.Add(new SqlParameter("QueryType", QueryType));
                sqlParams.Add(new SqlParameter("CreatedBy", loggedUserId));

                var dataReaders = dbContext.ExecuteQueryWithIDataReader(queryString, sqlParams);
                var reader = dataReaders[0];

                //int RequirementId = 0;
                while (reader.Read())
                {
                    SAVEDQUERYID = Convert.ToInt32(reader["QueryId"]);
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                dbContext.CloseConnection();

                if (SAVEDQUERYID > 0)
                {
                    if (queryType=="select")
                    {
                        SelectQueryBuilder selectQueryBuilder = new SelectQueryBuilder();
                        selectQueryBuilder.Show();
                    }
                    else if (queryType == "insert")
                    {

                    }
                    else if (queryType == "update")
                    {
                        UpdateQueryBuilder updateQueryBuilder = new UpdateQueryBuilder();
                        updateQueryBuilder.Show();
                    }
                    else if (queryType == "delete")
                    {

                    }
                }
            }

        }

        private void selectQueryType(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                RadioButton rb = (RadioButton)sender;
                QueryType = rb.TabIndex.ToString();
            }
        }
    }
}
