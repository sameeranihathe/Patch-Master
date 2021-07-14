using Patch_Master.DbContext.Database;
using Patch_Master.DbContext.QueryReader;
using Patch_Master.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Patch_Master.Forms
{
    public partial class SelectQueryBuilder : Form
    {
        public static string SelectedDatabase;

        bool userLogged = false;
        int loggedUserId = 0;
        string loggedUserName = string.Empty;
        string roleName = string.Empty;
        int roleId = 0;

        int availablecheckedListBoxCount = 0;

        bool queryValidated = true;
        string firstSelectedTable = string.Empty;

        Dictionary<string, string> SelectedColumnList = new Dictionary<string, string>();
        public static List<String> AddedTableList = new List<string>();
        public SelectQueryBuilder()
        {
            InitializeComponent(); 
            CheckLogin();
            InitializeScrollBars();
            //LoadAvailableDatabases();
            LoadAvailableTablesForDb(Requirements.SELECTEDDATABSENAME);
            
        }

        private void LoadAvailableTablesForDb(string databaseName)
        {
            List<string> AvailableTables = LoadAvailableTablesFromDb(databaseName);

            foreach (var tableName in AvailableTables)
            {
                TableList_treeView.Nodes.Add(tableName);
            }

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
        //private void LoadAvailableDatabases()
        //{
        //    Dictionary<int, string> savedDatabases = GetDatabaseList();
        //    foreach (var db in savedDatabases)
        //    {
        //        DatabaseList_comboBox.Items.Add(db);
        //    }
        //    this.DatabaseList_comboBox.SelectedIndexChanged -= new EventHandler(DatabaseList_comboBox_SelectedIndexChanged);

        //    DatabaseList_comboBox.DataSource = new BindingSource(savedDatabases, null);
        //    DatabaseList_comboBox.DisplayMember = "Value";
        //    DatabaseList_comboBox.ValueMember = "Key";

        //    this.DatabaseList_comboBox.SelectedIndexChanged += new EventHandler(DatabaseList_comboBox_SelectedIndexChanged);

        //}

        //private void DatabaseList_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    string DbName = (((KeyValuePair<int, string>)DatabaseList_comboBox.SelectedItem).Value).ToString();
        //    SelectedDatabase = DbName;
        //    List<string> AvailableTables = LoadAvailableTablesFromDb(DbName);

        //    foreach (var tableName in AvailableTables)
        //    {
        //        TableList_treeView.Nodes.Add(tableName);
        //    }
        //}

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
            bool tableAlreadyAdded = false;
            string DbName = Requirements.SELECTEDDATABSENAME;
            string tableName = e.Node.Text;

            List<string> columnNameList = LoadAllColumns(DbName, tableName);
            foreach (Control ctrl in TableView_panel.Controls)
            {
                if (ctrl.Name == tableName+ "_label")
                {
                    tableAlreadyAdded = true;
                }
            }
            if (!tableAlreadyAdded)
            {
                Label label = new Label();
                label.Name = tableName + "_label";
                label.Text = tableName;
                label.Location = new Point(availablecheckedListBoxCount * (10 + 250), 0);
                label.Size = new Size(100, 20);
                label.AutoSize = true;

                CheckedListBox checkedListBox = new CheckedListBox();
                checkedListBox.Name = tableName;
                foreach (var column in columnNameList)
                {
                    checkedListBox.Items.Add(column);
                }
                checkedListBox.ItemCheck += (s, e) => BeginInvoke((MethodInvoker)(() => CheckTableColumn(s, e)));
                checkedListBox.Location = new Point(availablecheckedListBoxCount * (10 + 250), 30);
                checkedListBox.Size = new Size(250, 250);

                TableView_panel.Controls.Add(label);
                TableView_panel.Controls.Add(checkedListBox);

                AddedTableList.Add(tableName);
                availablecheckedListBoxCount++; 
            }
            if (availablecheckedListBoxCount>0)
            {
                btnSingleSelectCondition.Enabled = true;
            }
            if (availablecheckedListBoxCount>1)
            {
                AddJoins_button.Enabled = true;
            }
            if (AddedTableList.Count ==1)
            {
                firstSelectedTable = tableName;
            }

        }
        private void CheckTableColumn(object sender, ItemCheckEventArgs e)
        {

            CheckedListBox btn = (CheckedListBox)sender;
            string selectedTable = btn.AccessibilityObject.Name;

            string selectedColumn = btn.SelectedItem.ToString();

            string key = selectedTable + "&" + selectedColumn;

            if (e.NewValue == CheckState.Checked)
            {
                SelectedColumnList.Add(key, selectedColumn);
            }
            else
            {
                SelectedColumnList.Remove(key);
            }
            //string AvailableQuery = Query_richTextBox.Text;

                //if (AvailableQuery == null || AvailableQuery=="")
                //{
                //    string QuerySelect = "SELECT " + selectedTable + "." + selectedColumn;
                //    Query_richTextBox.Text = QuerySelect;

                //    string QueryFrom = "FROM " + selectedTable;
                //    Query_richTextBox.Text += Environment.NewLine + QueryFrom;

                //}
                //else
                //{
                //    string AvailableText = Query_richTextBox.Text;
                //}
        }
        public List<string> LoadAllColumns(string dbName, string tableName)
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
                    var dataType = reader["DataType"].ToString();
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
            // this.Hide();
            NameConditionBuilder conditionBuilder = new NameConditionBuilder("SelectQueryBuilder");            
            conditionBuilder.Show();
            //SelectConditionBuilder selectConditionBuilder = new SelectConditionBuilder();
            //selectConditionBuilder.Show();
        }

        private void SaveQuerybutton_Click(object sender, EventArgs e)
        {
            string QueryString = Query_richTextBox.Text;

            if (!string.IsNullOrEmpty(QueryString))
            {
                SaveQuery(QueryString);
            }
            else
            {
                MessageBox.Show("Please build a query to save.", "Save Query");
            }
        }

        private void SaveQuery(string queryString)
        {
            DbConnector dbContext = new DbConnector();

            try
            {
                int QueryId = QueryTypeSelector.SAVEDQUERYID;
                string query = SqlQueryStringReader.GetQueryStringById("SaveQueryString", "Queries");
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("QueryId", QueryId));
                sqlParams.Add(new SqlParameter("QueryString", queryString));
                dbContext.ExecuteQueryWithIDataReader(query, sqlParams);

            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                dbContext.CloseConnection();
                this.Dispose();

                Application.OpenForms["QueryTypeSelector"].Close();
                Application.OpenForms["AvailableQueries"].Close();

                AvailableQueries availableQueries = new AvailableQueries();
                availableQueries.Show();
                
            }
        }

        private void BuildQuery_button_Click(object sender, EventArgs e)
        {
            Query_richTextBox.Text = string.Empty;
            var joinDetails = SelectJoinBuilder.joindetailList;
            if (joinDetails.Count>0)
            {
                string joinstring = string.Empty;
                if (SelectedColumnList.Count > 0)
                {
                    int i = 0;
                    string SelectString = string.Empty;
                    string FromString = "FROM";
                    string TableString = string.Empty;
                    
                    foreach (var item in SelectedColumnList)
                    {
                        var column = item.Value;
                        var table = (item.Key).Split('&')[0];

                        if (i == 0)
                        {
                            SelectString = "SELECT " + table + "." + column;
                            TableString = table;
                        }
                        else
                        {
                            SelectString += "," + table + "." + column;
                        }
                        i++;

                    }
                    foreach (var join in joinDetails)
                    {

                        joinstring += $"{join.JoinName} {join.TableTwo} ON {join.TableOne}.{join.TableOneColumn} = {join.TableTwo}.{join.TableTwoColumn} {Environment.NewLine}";

                    }
                    Query_richTextBox.Text = SelectString;
                    Query_richTextBox.Text += Environment.NewLine + FromString + " " + firstSelectedTable + Environment.NewLine;
                    Query_richTextBox.Text += joinstring;


                }
            }
            else
            {
                if (SelectedColumnList.Count > 0)
                {
                    int i = 0;
                    string SelectString = string.Empty;
                    string FromString = "FROM";
                    string TableString = string.Empty;

                    foreach (var item in SelectedColumnList)
                    {
                        var column = item.Value;
                        var table = (item.Key).Split('&')[0];

                        if (i == 0)
                        {
                            SelectString = "SELECT " + table + "." + column;
                            TableString = table;
                        }
                        else
                        {
                            SelectString += "," + table + "." + column;
                            string[] tableList = TableString.Split(',');

                            if (!tableList.Contains(table))
                            {
                                TableString += "," + table;
                            }
                        }
                        i++;
                    }
                    Query_richTextBox.Text = SelectString;
                    Query_richTextBox.Text += Environment.NewLine + FromString + " " + firstSelectedTable;

                }
            }
            string conditionstring = NameConditionBuilder.CONDITIONSTRING;
            if (!string.IsNullOrEmpty(conditionstring))
            {
                conditionstring = $"WHERE {conditionstring}";

                Query_richTextBox.Text += Environment.NewLine + conditionstring;
            }

        }

        private void Clear_button_Click(object sender, EventArgs e)
        {
            firstSelectedTable = string.Empty;
            availablecheckedListBoxCount = 0;
            AddJoins_button.Enabled = false;
            AddedTableList = new List<string>();
            SelectedColumnList = new Dictionary<string, string>();
            TableView_panel.Controls.Clear();
            foreach (Control item in TableView_panel.Controls.OfType<CheckedListBox>())
            {
                TableView_panel.Controls.Remove(item);
            }
            foreach (Control item in TableView_panel.Controls.OfType<Label>())
            {
                TableView_panel.Controls.Remove(item);
            }
            Query_richTextBox.Text = string.Empty;
        }

        private void AddJoins_button_Click(object sender, EventArgs e)
        {
            SelectJoinBuilder selectJoinBuilder = new SelectJoinBuilder();
            selectJoinBuilder.Show();
        }

        private void ValidateQuery_button1_Click(object sender, EventArgs e)
        {
            DbConnector dbContext = new DbConnector();
            queryValidated = true;
            try
            {
                string Query = Query_richTextBox.Text;
                if (!string.IsNullOrEmpty(Query))
                {
                    string query = SqlQueryStringReader.GetQueryStringById("CheckQueryValidation", "Queries");
                    List<SqlParameter> sqlParams = new List<SqlParameter>();
                    sqlParams.Add(new SqlParameter("Query", Query));
                    sqlParams.Add(new SqlParameter("Database", Requirements.SELECTEDDATABSENAME.ToString()));
                    dbContext.ExecuteQueryWithIDataReader(query, sqlParams);

                }
                else
                {
                    MessageBox.Show("No built query available!", "Validate Query");
                }

            }
            catch (Exception ex)
            {
                queryValidated = false;
                MessageBox.Show(ex.Message.ToString(), "Validate Query");
            }
            //finally
            //{
            //    dbContext.CloseConnection();
            //}

            if (queryValidated)
            {
                MessageBox.Show("Query successfully validated!", "Validate Query");
            }
            dbContext.CloseConnection();
        }
    }
}
