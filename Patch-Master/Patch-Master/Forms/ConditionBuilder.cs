using Patch_Master.CustomElements;
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
    public partial class NameConditionBuilder : Form
    {
        public static string CONDITIONSTRING = string.Empty;
        public static string FROMQUERYTYPE = string.Empty;
        public NameConditionBuilder(string fromQueryType)
        {
            InitializeComponent();
            LoadTableList();

            CONDITIONSTRING = string.Empty;
            FROMQUERYTYPE = fromQueryType;
        }

        private void LoadTableList()
        {
          
            List<string> tableList = SelectQueryBuilder.AddedTableList;
            if(FROMQUERYTYPE == "UpdateQueryBuilder")
            {
                tableList.Clear();
                //tableList.Add(UpdateQueryBuilder.CmbTable.SelectedItem.ToString());
            }
            CmbTable_1.Items.Clear();
            foreach (var table in tableList)
            {
                tableList_listBox.Items.Add(table);               
                CmbTable_1.Items.Add(table);

            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Button AddTableColumnBtn = sender as Button;

            if (AddTableColumnBtn == null) // just to be on the safe side
                return;

            TableColumnConnector tableColumnSelector = new TableColumnConnector(AddTableColumnBtn.Name.ToString(), this);
            tableColumnSelector.Show();
        }

        private void butnAddNewRow_1_Click(object sender, EventArgs e)
        {
            PanelOperator.Visible = true;

            Button conditionAddingButtton = sender as Button;

            if (conditionAddingButtton == null) // just to be on the safe side
                return;

            string Controllname = conditionAddingButtton.Parent.Name.ToString();

            customGroupBox GroupController = (customGroupBox)this.PanelConditionContainer.Controls[Controllname];

            PanelOperator.GroupBoxOrderNumber = GroupController.GroupBoxOrderNumber;
            this.PanelOperator.Location = new System.Drawing.Point((conditionAddingButtton.Parent.Location.X + conditionAddingButtton.Location.X)+150 , (42 + conditionAddingButtton.Parent.Location.Y) + conditionAddingButtton.Location.Y - 90);


        }

        private void btnConAND_Click(object sender, EventArgs e)
        {
            PanelOperator.Visible = false;

            Button conditionAddingButtton = sender as Button;

            if (conditionAddingButtton == null) // just to be on the safe side
                return;

            string Controllname = conditionAddingButtton.Parent.Name.ToString();

            CustomPanel ConditionPanel = (CustomPanel)this.Controls[Controllname];

            int newGroupOrderNumber = ConditionPanel.GroupBoxOrderNumber + 1;

            //ReorderWhenAddingTCRow(newGroupOrderNumber);

            ReorderWhenAddingConditionRow(newGroupOrderNumber);
            conditionRowGenerator("AND", newGroupOrderNumber);
            
            
        }

        private void conditionRowGenerator(String OperatorType,int newGroupOrderNumber)
        {
            

            string ControllerName = "";
            List<int> GroupBoxCountValue = new List<int>();
            foreach (Control ctn in this.PanelConditionContainer.Controls)
            {
                if (ctn is GroupBox)
                {
                    ControllerName = ctn.Name.ToString();
                    if (ControllerName != null && ControllerName.Split("_").Length > 0)
                    {
                        if (ControllerName.Split("_")[0] == "GroupConditionRow")
                        {
                            GroupBoxCountValue.Add(Convert.ToInt32(ControllerName.Split("_")[1]));
                        }
                    }
                }
            }

            int GroupBoxSuffixValue = GroupBoxCountValue.Count > 0 ? GroupBoxCountValue.Max() + 1 : 1;// Ternary operator
            string PreviousControllerName = getGroupRowElementfromOrderNumber(newGroupOrderNumber - 1);
            int PreviousControllerLocationY = this.PanelConditionContainer.Controls[PreviousControllerName].Location.Y;

            int GroupRowdrawingLocationY = (90 + PreviousControllerLocationY);

            customGroupBox GroupConditionRow = new customGroupBox();
            {
                GroupConditionRow.Location = new System.Drawing.Point(27, GroupRowdrawingLocationY);
                GroupConditionRow.Name = "GroupConditionRow_"+ GroupBoxSuffixValue;
                GroupConditionRow.Size = new System.Drawing.Size(953, 82);
                GroupConditionRow.TabIndex = 0;
                GroupConditionRow.TabStop = false;
                GroupConditionRow.Text = OperatorType;
                GroupConditionRow.GroupBoxOrderNumber = newGroupOrderNumber;
                GroupConditionRow.OperatorType = OperatorType;
                this.Controls.Add(GroupConditionRow);

            }

            ComboBox CmbOpenBracket = new ComboBox();
            {
                CmbOpenBracket.FormattingEnabled = true;
                CmbOpenBracket.Location = new System.Drawing.Point(25, 42);
                CmbOpenBracket.Name = "CmbOpenBracket_"+ GroupBoxSuffixValue;
                CmbOpenBracket.Size = new System.Drawing.Size(75, 23);
                CmbOpenBracket.TabIndex = 0;
                CmbOpenBracket.Items.AddRange(new object[] {
            "(",
            "((",
            "(((",
            "((((",
            "Add More"});
            }

            ComboBox CmbTable = new ComboBox();
            {
                CmbTable.FormattingEnabled = true;
                CmbTable.Location = new System.Drawing.Point(116, 42);
                CmbTable.Name = "CmbTable_"+ GroupBoxSuffixValue;
                CmbTable.Size = new System.Drawing.Size(121, 23);
                CmbTable.TabIndex = 0;
                CmbTable.SelectedIndexChanged += new System.EventHandler(this.CmbTable_1_SelectedIndexChanged);
                List<string> tableList = SelectQueryBuilder.AddedTableList;
                foreach (string TableName in tableList)
                {
                    CmbTable.Items.Add(TableName);
                }
            //    CmbTable.Items.AddRange(new object[] {
            //"TableOne",
            //"TableTwo",
            //"TableThree",
            //"TableFour"});
            }

            ComboBox CmbColumn = new ComboBox();
            {
                CmbColumn.FormattingEnabled = true;
                CmbColumn.Location = new System.Drawing.Point(239, 42);
                CmbColumn.Name = "CmbColumn_"+ GroupBoxSuffixValue;
                CmbColumn.Size = new System.Drawing.Size(131, 23);
                CmbColumn.TabIndex = 0;
                CmbColumn.Items.AddRange(new object[] {
            "ColumnOne",
            "ColumnTwo",
            "ColumnThree",
            "ColumnFour",
            "ColumnFive"});

            }

            Button BtnTCCondition1 = new Button();
            {
                BtnTCCondition1.Location = new System.Drawing.Point(371, 42);
                BtnTCCondition1.Name = "BtnTCCondition1_"+ GroupBoxSuffixValue;
                BtnTCCondition1.Size = new System.Drawing.Size(30, 23);
                BtnTCCondition1.TabIndex = 2;
                BtnTCCondition1.Text = "...";
                BtnTCCondition1.UseVisualStyleBackColor = true;
                BtnTCCondition1.Click += new System.EventHandler(this.BtnTCCondition1_1_Click);
            }
            ComboBox CmbComparer = new ComboBox();
            {
                CmbComparer.FormattingEnabled = true;
                CmbComparer.Location = new System.Drawing.Point(413, 42);
                CmbComparer.Name = "CmbComparer_"+ GroupBoxSuffixValue;
                CmbComparer.Size = new System.Drawing.Size(80, 23);
                CmbComparer.TabIndex = 0;
                CmbComparer.Items.AddRange(new object[] {
            "like",
            "=",
            ">",
            ">=",
            "<",
            "<="});
            }
            TextBox textValue = new TextBox();
            {
                textValue.Location = new System.Drawing.Point(509, 42);
                textValue.Name = "textValue_"+ GroupBoxSuffixValue;
                textValue.Size = new System.Drawing.Size(139, 23);
                textValue.TabIndex = 1;
            }
            Button BtnTCCondition2 = new Button();
            {
                BtnTCCondition2.Location = new System.Drawing.Point(649, 41);
                BtnTCCondition2.Name = "BtnTCCondition2_"+ GroupBoxSuffixValue;
                BtnTCCondition2.Size = new System.Drawing.Size(30, 23);
                BtnTCCondition2.TabIndex = 2;
                BtnTCCondition2.Text = "...";
                BtnTCCondition2.UseVisualStyleBackColor = true;
                BtnTCCondition2.Click += new System.EventHandler(this.button2_Click);
            }
            ComboBox CmbCloseBracket = new ComboBox();
            {
                CmbCloseBracket.FormattingEnabled = true;
                CmbCloseBracket.Location = new System.Drawing.Point(698, 42);
                CmbCloseBracket.Name = "CmbCloseBracket_"+ GroupBoxSuffixValue;
                CmbCloseBracket.Size = new System.Drawing.Size(75, 23);
                CmbCloseBracket.TabIndex = 0;
                CmbCloseBracket.Items.AddRange(new object[] {
            ")",
            "))",
            ")))",
            "))))",
            "Add More"});
            }
            Button butnAddNewRow = new Button();
            {
                butnAddNewRow.Location = new System.Drawing.Point(795, 40);
                butnAddNewRow.Name = "butnAddNewRow_"+ GroupBoxSuffixValue;
                butnAddNewRow.Size = new System.Drawing.Size(75, 23);
                butnAddNewRow.TabIndex = 4;
                butnAddNewRow.Text = "+";
                butnAddNewRow.UseVisualStyleBackColor = true;
                butnAddNewRow.Click += new System.EventHandler(this.butnAddNewRow_1_Click);
            }
            Button Delete = new Button();
            {
                Delete.Location = new System.Drawing.Point(887, 40);
                Delete.Name = "Delete_"+ GroupBoxSuffixValue;
                Delete.Size = new System.Drawing.Size(53, 23);
                Delete.TabIndex = 5;
                Delete.Text = "Delete";
                Delete.UseVisualStyleBackColor = true;
                Delete.Click += new System.EventHandler(this.Delete_1_Click);
            }
            TextBox textValue1 = new TextBox();
            {
                textValue1.Location = new System.Drawing.Point(116, 53);
                textValue1.Name = "textValue1_"+ GroupBoxSuffixValue;
                textValue1.Size = new System.Drawing.Size(254, 23);
                textValue1.TabIndex = 6;
                textValue1.Visible = false;
            }

            GroupConditionRow.Controls.Add(CmbOpenBracket);
            GroupConditionRow.Controls.Add(CmbTable);
            GroupConditionRow.Controls.Add(CmbColumn);
            GroupConditionRow.Controls.Add(BtnTCCondition1);
            GroupConditionRow.Controls.Add(CmbComparer);
            GroupConditionRow.Controls.Add(textValue);
            GroupConditionRow.Controls.Add(BtnTCCondition2);
            GroupConditionRow.Controls.Add(CmbCloseBracket);
            GroupConditionRow.Controls.Add(butnAddNewRow);
            GroupConditionRow.Controls.Add(Delete);
            GroupConditionRow.Controls.Add(textValue1);
            



            PanelConditionContainer.Controls.Add(GroupConditionRow);
        }

        private void BtnTCCondition1_1_Click(object sender, EventArgs e)
        {
            Button AddTableColumnBtn = sender as Button;

            if (AddTableColumnBtn == null) // just to be on the safe side
                return;

            TableColumnConnector tableColumnSelector = new TableColumnConnector(AddTableColumnBtn.Name.ToString(),this);
            tableColumnSelector.Show();
        }

        private void Delete_1_Click(object sender, EventArgs e)
        {
            Button DeleteRowButton = sender as Button;

            if (DeleteRowButton == null) // just to be on the safe side
                return;

            string Controllname = DeleteRowButton.Parent.Name.ToString();
            customGroupBox customGroupBox = (customGroupBox)this.PanelConditionContainer.Controls[Controllname];

            if (customGroupBox != null)
            {
                int deleteRowOrderNumber = customGroupBox.GroupBoxOrderNumber;
                this.PanelConditionContainer.Controls.Remove(customGroupBox);
                ReorderWhenDeletingConditionRow(deleteRowOrderNumber);
            }
        }
        private void ReorderWhenDeletingConditionRow(int orderNumber)
        {
            int DeletedRowOrderNumber = orderNumber;

            string ControllerName = "";
            List<int> GroupBoxCountValue = new List<int>();
            foreach (Control ctn in this.PanelConditionContainer.Controls)
            {
                if (ctn is GroupBox)
                {
                    ControllerName = ctn.Name.ToString();
                    if (ControllerName != null && ControllerName.Split("_").Length > 0)
                    {
                        if (ControllerName.Split("_")[0] == "GroupConditionRow")
                        {
                            customGroupBox customGroupBox = (customGroupBox)this.PanelConditionContainer.Controls[ControllerName];

                            if (customGroupBox.GroupBoxOrderNumber > DeletedRowOrderNumber)
                            {

                                int newLocationY = customGroupBox.Location.Y - 90;
                                int newLocationX = customGroupBox.Location.X;
                                int GroupBoxNewOrderNumber = customGroupBox.GroupBoxOrderNumber - 1;

                                customGroupBox.Location = new System.Drawing.Point(newLocationX, newLocationY);
                                customGroupBox.GroupBoxOrderNumber = GroupBoxNewOrderNumber;
                            }

                        }
                    }
                }
            }

        }
        private string getGroupRowElementfromOrderNumber(int GroupBoxOrderNumber)
        {
            string groupElementName = "";
            string ControllerName = "";
            foreach (Control ctn in this.PanelConditionContainer.Controls)
            {
                if (ctn is GroupBox)
                {
                    ControllerName = ctn.Name.ToString();
                    if (ControllerName != null && ControllerName.Split("_").Length > 0)
                    {
                        if (ControllerName.Split("_")[0] == "GroupConditionRow")
                        {
                            customGroupBox customGroupBox = (customGroupBox)this.PanelConditionContainer.Controls[ControllerName];

                            if (customGroupBox.GroupBoxOrderNumber == GroupBoxOrderNumber)
                            {
                                groupElementName = ControllerName;
                            }

                        }
                    }
                }
            }
            return groupElementName;
        }

        private void ReorderWhenAddingConditionRow(int orderNumber)
        {
            int newlyAddedOrderNumber = orderNumber;

            string ControllerName = "";
            List<int> GroupBoxCountValue = new List<int>();
            foreach (Control ctn in this.PanelConditionContainer.Controls)
            {
                if (ctn is GroupBox)
                {
                    ControllerName = ctn.Name.ToString();
                    if (ControllerName != null && ControllerName.Split("_").Length > 0)
                    {
                        if (ControllerName.Split("_")[0] == "GroupConditionRow")
                        {
                            customGroupBox customGroupBox = (customGroupBox)this.PanelConditionContainer.Controls[ControllerName];

                            if (customGroupBox.GroupBoxOrderNumber >= newlyAddedOrderNumber)
                            {

                                int newLocationY = customGroupBox.Location.Y + 90;
                                int newLocationX = customGroupBox.Location.X;
                                int GroupBoxNewOrderNumber = customGroupBox.GroupBoxOrderNumber + 1;

                                customGroupBox.Location = new System.Drawing.Point(newLocationX, newLocationY);
                                customGroupBox.GroupBoxOrderNumber = GroupBoxNewOrderNumber;
                            }

                        }
                    }
                }
            }

        }

        private void BtnConditionOR_Click(object sender, EventArgs e)
        {
            PanelOperator.Visible = false;

            Button conditionAddingButtton = sender as Button;

            if (conditionAddingButtton == null) // just to be on the safe side
                return;

            string Controllname = conditionAddingButtton.Parent.Name.ToString();

            CustomPanel ConditionPanel = (CustomPanel)this.Controls[Controllname];

            int newGroupOrderNumber = ConditionPanel.GroupBoxOrderNumber + 1;

            //ReorderWhenAddingTCRow(newGroupOrderNumber);

            ReorderWhenAddingConditionRow(newGroupOrderNumber);
            conditionRowGenerator("OR", newGroupOrderNumber);
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            String generatedConditionString = GenerateConditionString();
            ConditionBox.Text = generatedConditionString;
        }
        private string GenerateConditionString()
        {
            string GeneratedString = "";
            List<customGroupBox> TCGroupBoxElementList = getAllGroupBoxRowConditions();
            TCGroupBoxElementList.OrderBy(e => e.GroupBoxOrderNumber);

            foreach (customGroupBox GroupBoxRow in TCGroupBoxElementList)
            {
                String Condition = "";
                string OpenBracket = "";
                string TCValye1 = "";
                string TableName = "";
                string ColumnName = "";
                string Comparer = "";
                string Value2 = "";
                string CloseBracket = "";



                foreach (Control ctn in GroupBoxRow.Controls)
                {
                    if (ctn is TextBox)
                    {
                        string ControllerName = ctn.Name.ToString();
                        if (ControllerName != null && ControllerName.Split("_").Length > 0 && ctn.Visible ==true)
                        {
                            TextBox ValuerBox = (TextBox)GroupBoxRow.Controls[ControllerName];

                            if (ControllerName.Split("_")[0] == "textValue1")
                            {

                                TCValye1 = ValuerBox.Text;

                            }
                            if (ControllerName.Split("_")[0] == "textValue")
                            {

                                Value2 = ValuerBox.Text;

                            }
                        }                          
                           
                    }

                    if (ctn is ComboBox && ctn.Visible == true)
                    {
                        string ControllerName = ctn.Name.ToString();
                        if (ControllerName != null && ControllerName.Split("_").Length > 0)
                        {
                            ComboBox TCComboBox = (ComboBox)GroupBoxRow.Controls[ControllerName];
                            if (ControllerName.Split("_")[0] == "CmbOpenBracket")
                            {

                                OpenBracket = TCComboBox.SelectedItem != null ? TCComboBox.SelectedItem.ToString() : "";

                            }
                            if (ControllerName.Split("_")[0] == "CmbTable")
                            {

                                TableName = TCComboBox.SelectedItem != null ? TCComboBox.SelectedItem.ToString() : "";

                            }
                            if (ControllerName.Split("_")[0] == "CmbColumn")
                            {

                                ColumnName = TCComboBox.SelectedItem != null ? TCComboBox.SelectedItem.ToString() : "";

                            }

                            if (ControllerName.Split("_")[0] == "CmbComparer")
                            {

                                Comparer = TCComboBox.SelectedItem != null ? TCComboBox.SelectedItem.ToString() : "";

                            }


                            if (ControllerName.Split("_")[0] == "CmbCloseBracket")
                            {

                                CloseBracket = TCComboBox.SelectedItem != null ? TCComboBox.SelectedItem.ToString() : "";

                            }
                        }
                    }

                }
                if(TableName != "")
                {
                    Condition = OpenBracket + " " + TableName + "." + ColumnName + " " + Comparer + " " + Value2 + " " + CloseBracket; 
                }
                else
                {
                    Condition = OpenBracket + " " + TCValye1 + " " + Comparer + " " + Value2 + " " + CloseBracket;
                }
               
                GeneratedString += " " + GroupBoxRow.OperatorType + " " + Condition;
            }
            return GeneratedString;
        }

        private List<customGroupBox> getAllGroupBoxRowConditions()
        {
            string groupElementName = "";
            string ControllerName = "";
            List<customGroupBox> GroupBoxElementList = new List<customGroupBox>();

            foreach (Control ctn in this.PanelConditionContainer.Controls)
            {
                if (ctn is GroupBox)
                {
                    ControllerName = ctn.Name.ToString();
                    if (ControllerName != null && ControllerName.Split("_").Length > 0)
                    {
                        if (ControllerName.Split("_")[0] == "GroupConditionRow")
                        {
                            customGroupBox customGroupBox = (customGroupBox)this.PanelConditionContainer.Controls[ControllerName];

                            GroupBoxElementList.Add(customGroupBox);

                        }
                    }
                }
            }
            return GroupBoxElementList;
        }

        private void tableList_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CmbTable_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedDatbase = Requirements.SELECTEDDATABSENAME;
            ComboBox TableSelectComboBox = sender as ComboBox;

            if (TableSelectComboBox == null) // just to be on the safe side
                return;

            string GroupControllerName = "GroupConditionRow_" + TableSelectComboBox.Name.Split("_")[1].ToString();
            string ControllerName = "CmbColumn_" + TableSelectComboBox.Name.Split("_")[1].ToString();
            List<string> ColumnList = LoadAllColumns(selectedDatbase, TableSelectComboBox.SelectedItem.ToString());

            customGroupBox customGroupBox = (customGroupBox)this.PanelConditionContainer.Controls[GroupControllerName];
            ComboBox ColumnBox = (ComboBox)customGroupBox.Controls[ControllerName];
            if (ColumnList != null && ColumnList.Count() > 0 && ColumnBox != null)
            {
                ColumnBox.Items.Clear();
                foreach (string item in ColumnList)
                {
                    ColumnBox.Items.Add(item);
                }
            }
           

            // LoadAllColumns();
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

        private void CmbColumn_1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textValue1_1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddCondition_Click(object sender, EventArgs e)
        {
            string condition = ConditionBox.Text.ToString();

            if (!string.IsNullOrEmpty(condition))
            {
                CONDITIONSTRING = condition;
            }
            else
            {
                MessageBox.Show("No condition created", "Conditions");
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
