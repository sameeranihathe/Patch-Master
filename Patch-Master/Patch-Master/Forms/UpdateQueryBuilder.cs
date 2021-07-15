using Patch_Master.DbContext.Database;
using Patch_Master.DbContext.QueryReader;
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
    public partial class UpdateQueryBuilder : Form
    {
        public UpdateQueryBuilder()
        {
            InitializeComponent();
            //LoadAvailableTablesForDb(Requirements.SELECTEDDATABSENAME);
            LoadAvailableTablesForDb("PatchMaster-1");
            
        }

        private void LoadAvailableTablesForDb(string databaseName)
        {
            List<string> AvailableTables = LoadAvailableTablesFromDb(databaseName);
            CmbTable.Items.Clear();
            foreach (var tableName in AvailableTables)
            {
                // TabletreeView.Nodes.Add(tableName);
                CheckListBoxTable.Items.Add(tableName);
                CmbTable.Items.Add(tableName);

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

        private void CmbTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string selectedDatbase = Requirements.SELECTEDDATABSENAME;
            string selectedDatbase = "PatchMaster-1";//Need to change
            ComboBox TableSelectComboBox = sender as ComboBox;

            if (TableSelectComboBox == null) // just to be on the safe side
                return;

            List<string> ColumnList = LoadAllColumns(selectedDatbase, TableSelectComboBox.SelectedItem.ToString());
            checkedListBox1.Items.Clear();
            foreach (var item in ColumnList)
            {
                checkedListBox1.Items.Add(item);
            }
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

        private void BtnValue_Click(object sender, EventArgs e)
        {
            List<string> selectedColumnList = new List<string>();

            int Count = 0;
            panel2.Controls.Clear();
            foreach (object itemChecked in checkedListBox1.CheckedItems)
            {
                Count++;
                TextBoxgenerator(itemChecked.ToString(),Count.ToString(),19 + ((Count-1)*50));
               // selectedColumnList.Add(itemChecked.ToString());

            }


            //    for (int x = 0; x < checkedListBox1.Items.Count; x++)
            //{
            //    selectedColumnList.Add(checkedListBox1.Items[x]);
            //}
           int count  = selectedColumnList.Count();
                
        }
        private void TextBoxgenerator(string itemName,string nameSufficx,int LocationY)
        {
            TextBox textColumnName = new TextBox();
            {
                textColumnName.Location = new System.Drawing.Point(20, LocationY);
                textColumnName.Name = "textColumnName_" + nameSufficx;
                textColumnName.Size = new System.Drawing.Size(145, 23);
                textColumnName.TabIndex = 0;
                textColumnName.Text = itemName;
            }

            TextBox textColumnValue = new TextBox();
            {
                textColumnValue.Location = new System.Drawing.Point(171, LocationY);
                textColumnValue.Name = "textColumnValue_" + nameSufficx;
                textColumnValue.Size = new System.Drawing.Size(138, 23);
                textColumnValue.TabIndex = 0;
            }

            Button TableColumnBtn = new Button();
            {
                TableColumnBtn.Location = new System.Drawing.Point(310, LocationY);
                TableColumnBtn.Name = "BtnAddTableColumnValue_"+ nameSufficx;
                TableColumnBtn.Size = new System.Drawing.Size(26, 25);
                TableColumnBtn.TabIndex = 1;
                TableColumnBtn.Text = "...";
                TableColumnBtn.UseVisualStyleBackColor = true;
                TableColumnBtn.Click += new System.EventHandler(this.BtnAddTableColumnValue_1_Click);
            }

            panel2.Controls.Add(textColumnValue);
            panel2.Controls.Add(textColumnName);
            panel2.Controls.Add(TableColumnBtn);
        }

        private void BtnCondition_Click(object sender, EventArgs e)
        {
            NameConditionBuilder nameConditionBuilder = new NameConditionBuilder("UpdateQueryBuilder");
            this.Hide();
            nameConditionBuilder.Show();

        }

        private void BtnAddTableColumnValue_1_Click(object sender, EventArgs e)
        {
            Button AddTableColumnBtn = sender as Button;

            if (AddTableColumnBtn == null) // just to be on the safe side
                return;

            TableColumnConnector tableColumnSelector = new TableColumnConnector(AddTableColumnBtn.Name.ToString(), this, "UpdateQueryBuilder");
            tableColumnSelector.Show();
        }
    }
}
