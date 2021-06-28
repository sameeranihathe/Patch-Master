using Patch_Master.DbContext.Database;
using Patch_Master.DbContext.QueryReader;
using Patch_Master.Dto;
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
    public partial class SelectQueryBuilder : Form
    {
        bool userLogged = false;
        int loggedUserId = 0;
        string loggedUserName = string.Empty;
        string roleName = string.Empty;
        int roleId = 0;
        public SelectQueryBuilder()
        {
            InitializeComponent();
            LoadAvailableDatabases();

        }
        private void CheckLogin()
        {
            userLogged = Home.Userlogged;
            loggedUserId = Home.loggedUserId;
            loggedUserName = Home.UserName;
            roleId = Home.RoleId;
            roleName = Home.Role;

        }
        private void LoadAvailableDatabases()
        {
            Dictionary<int, string> savedDatabases = GetDatabaseList();
            foreach (var db in savedDatabases)
            {
                DatabaseList_comboBox.Items.Add(db);
            }
            this.DatabaseList_comboBox.SelectedIndexChanged -= new EventHandler(DatabaseList_comboBox_SelectedIndexChanged);

            DatabaseList_comboBox.DataSource = new BindingSource(savedDatabases, null);
            DatabaseList_comboBox.DisplayMember = "Value";
            DatabaseList_comboBox.ValueMember = "Key";

            this.DatabaseList_comboBox.SelectedIndexChanged += new EventHandler(DatabaseList_comboBox_SelectedIndexChanged);

        }

        private void DatabaseList_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private Dictionary<int, string> GetDatabaseList()
        {
            Dictionary<int, string> savedDatabasesList = new Dictionary<int, string>();
            DbConnector dbContext = new DbConnector();
            bool Status = true;
            try
            {
                string queryString = SqlQueryStringReader.GetQueryStringById("loadDatabases", "DBConnections");
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("Status", Convert.ToBoolean(Status)));
                var dataReaders = dbContext.ExecuteQueryWithIDataReader(queryString, sqlParams);
                var reader = dataReaders[0];

                while (reader.Read())
                {

                    var DatabaseId = Convert.ToInt32(reader["DB_Id"]);
                    var DatabaseName = reader["DBName"].ToString();

                    savedDatabasesList.Add(DatabaseId, DatabaseName);
                }

            }
            catch (Exception ex)
            {

                throw;
            }
            return savedDatabasesList;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void btnSingleSelectCondition_Click(object sender, EventArgs e)
        {
            this.Hide();
            SelectConditionBuilder selectConditionBuilder = new SelectConditionBuilder();
            selectConditionBuilder.Show();
        }
    }
}
