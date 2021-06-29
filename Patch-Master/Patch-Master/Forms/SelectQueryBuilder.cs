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

        int availablecheckedListBoxCount = 0;
        public SelectQueryBuilder()
        {
            InitializeComponent();
            InitializeScrollBars();
            LoadAvailableDatabases();

        }

        private void InitializeScrollBars()
        {
            TableView_panel.AutoScroll = false;
            TableView_panel.VerticalScroll.Enabled = false;
            TableView_panel.VerticalScroll.Visible = false;
            TableView_panel.VerticalScroll.Maximum = 0;
            TableView_panel.AutoScroll = true;
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
            string DbName = (((KeyValuePair<int, string>)DatabaseList_comboBox.SelectedItem).Value).ToString();

            List<string> AvailableTables = LoadAvailableTablesFromDb(DbName);

            foreach (var tableName in AvailableTables)
            {
                TableList_treeView.Nodes.Add(tableName);
            }
        }

        private List<string> LoadAvailableTablesFromDb(string dbName)
        {
            DbConnector dbContext = new DbConnector();
            List<string> AvailableTableList = new List<string>();
            try
            {
                string queryString = SqlQueryStringReader.GetQueryStringById("LoadAvailableTables", "DBConnections");
                List<SqlParameter> sqlParams = new List<SqlParameter>();

                sqlParams.Add(new SqlParameter("DbName", dbName));
                var dataReaders = dbContext.ExecuteQueryWithIDataReader(queryString, sqlParams);
                var reader = dataReaders[0];

                while (reader.Read())
                {
                    var TableName = reader["TableName"].ToString();

                    AvailableTableList.Add(TableName);
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
            return AvailableTableList;
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
            finally
            {
                dbContext.CloseConnection();
            }
            return savedDatabasesList;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string DbName = (((KeyValuePair<int, string>)DatabaseList_comboBox.SelectedItem).Value).ToString();
            string tableName = e.Node.Text;

            List<string> columnNameList = LoadAllColumns(DbName, tableName);
            
            Label label = new Label();
            label.Name = tableName + "_label";
            label.Text = tableName;
            label.Location = new Point(availablecheckedListBoxCount * (10 + 100), 0);

            CheckedListBox checkedListBox = new CheckedListBox();
            checkedListBox.Name = tableName + "_checkedListBox";
            foreach (var column in columnNameList)
            {
                checkedListBox.Items.Add(column);
            }
            checkedListBox.Location = new Point(availablecheckedListBoxCount*(10+100), 30);
            checkedListBox.Size = new Size(100, 150);

            TableView_panel.Controls.Add(label);
            TableView_panel.Controls.Add(checkedListBox);
            availablecheckedListBoxCount++;

        }

        private List<string> LoadAllColumns(string dbName, string tableName)
        {
            DbConnector dbContext = new DbConnector();
            List<string> columnList = new List<string>();
            try
            {
                string queryString = SqlQueryStringReader.GetQueryStringById("LoadColumnList", "QueryBuilder");
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("DbName", dbName));
                sqlParams.Add(new SqlParameter("Table", tableName));
                var dataReaders = dbContext.ExecuteQueryWithIDataReader(queryString, sqlParams);
                var reader = dataReaders[0];

                while (reader.Read())
                {
                    var column = reader["ColumnName"].ToString();
                    columnList.Add(column);
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
            return columnList;
        }

        private void btnSingleSelectCondition_Click(object sender, EventArgs e)
        {
            this.Hide();
            SelectConditionBuilder selectConditionBuilder = new SelectConditionBuilder();
            selectConditionBuilder.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }
    }
}
