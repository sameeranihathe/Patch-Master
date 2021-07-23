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
    public partial class TableColumnConnector : Form
    {
        string clickedElementName = "";
        NameConditionBuilder ConditionGenerationForm;
        UpdateQueryBuilder UpdateQueryBuilderForm;
        string QueryGereratorQueryType = "";
        public TableColumnConnector()
        {
            InitializeComponent();
            LoadTableList();
        }
        #region New Computation Condition
        public TableColumnConnector(string elementName, NameConditionBuilder conditionForm)
        {
            InitializeComponent();
            clickedElementName = elementName;
            ConditionGenerationForm = conditionForm;
            LoadTableList();
            //conditionForm.
        }
        #endregion
        #region Load Tables and Colunms 
        private void LoadTableList()
        {
            List<string> tableList = SelectQueryBuilder.AddedTableList;
            comTableName_1.Items.Clear();
            if (QueryGereratorQueryType != null && QueryGereratorQueryType == "UpdateQueryBuilder" && clickedElementName != null)
            {
                CheckedListBox UpdateFormChecklistBox = (CheckedListBox)UpdateQueryBuilderForm.Controls["CheckListBoxTable"];
                foreach (var item in UpdateFormChecklistBox.CheckedItems)
                {
                    tableList.Add(item.ToString());
                }
            }
            foreach (var table in tableList)
            {
                comTableName_1.Items.Add(table);
            }
        }
        private void comTableName_1_SelectedIndexChanged(object sender, EventArgs e)
        {

            
            clickedElementName = elementName;
            ConditionGenerationForm = conditionForm;
            InitializeComponent();
            LoadTableList();
            //conditionForm.
        }
        public TableColumnConnector(string elementName, UpdateQueryBuilder conditionForm,string QueryGeneratorType)
        {
            clickedElementName = elementName;
            UpdateQueryBuilderForm = conditionForm;
            QueryGereratorQueryType = QueryGeneratorType;
            InitializeComponent();
            LoadTableList();
            //conditionForm.
        }


            if (TableSelectComboBox == null) // just to be on the safe side
                return;

            string GroupControllerName = "TcGoupBox_" + TableSelectComboBox.Name.Split("_")[1].ToString();
            string ControllerName = "cmbColumnName_" + TableSelectComboBox.Name.Split("_")[1].ToString();
            List<string> ColumnList = LoadAllColumns(selectedDatbase, TableSelectComboBox.SelectedItem.ToString());

            customGroupBox customGroupBox = (customGroupBox)this.ConditionContainerPanel.Controls[GroupControllerName];
            ComboBox ColumnBox = (ComboBox)customGroupBox.Controls[ControllerName];
            if (ColumnList != null && ColumnList.Count() > 0 && ColumnBox != null)
            {
                ColumnBox.Items.Clear();
                foreach (string item in ColumnList)
                {
                    ColumnBox.Items.Add(item);
                }
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
        #endregion
        #region Add Computation Row
        #region Computation Button Clicks 
        private void button1_Click(object sender, EventArgs e)
        {
            OperatorPanel.Show();

            OperatorPanel.Visible = true;

            Button conditionAddingButtton = sender as Button;

            if (conditionAddingButtton == null) // just to be on the safe side
                return;

            string Controllname = conditionAddingButtton.Parent.Name.ToString();

            customGroupBox GroupController = (customGroupBox)this.ConditionContainerPanel.Controls[Controllname];

            OperatorPanel.GroupBoxOrderNumber = GroupController.GroupBoxOrderNumber;
            this.OperatorPanel.Location = new System.Drawing.Point((64+conditionAddingButtton.Parent.Location.X) + conditionAddingButtton.Location.X - 6, (42+conditionAddingButtton.Parent.Location.Y) + conditionAddingButtton.Location.Y - 90);


        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            OperatorPanel.Visible = false;

            Button conditionAddingButtton = sender as Button;

            if (conditionAddingButtton == null) // just to be on the safe side
                return;

            string Controllname = conditionAddingButtton.Parent.Name.ToString();

            CustomPanel ConditionPanel = (CustomPanel)this.Controls[Controllname];

            int newGroupOrderNumber = ConditionPanel.GroupBoxOrderNumber +1;
            
            ReorderWhenAddingTCRow(newGroupOrderNumber);
            AddTableColumnRow("+", newGroupOrderNumber);
            
        }
        private void BtnSub_Click(object sender, EventArgs e)
        {
            OperatorPanel.Visible = false;

            Button conditionAddingButtton = sender as Button;

            if (conditionAddingButtton == null) // just to be on the safe side
                return;

            string Controllname = conditionAddingButtton.Parent.Name.ToString();

            CustomPanel ConditionPanel = (CustomPanel)this.Controls[Controllname];

            int newGroupOrderNumber = ConditionPanel.GroupBoxOrderNumber + 1;

            ReorderWhenAddingTCRow(newGroupOrderNumber);
            AddTableColumnRow("-", newGroupOrderNumber);
            
        }
        private void BtnMul_Click(object sender, EventArgs e)
        {
            OperatorPanel.Visible = false;

            Button conditionAddingButtton = sender as Button;

            if (conditionAddingButtton == null) // just to be on the safe side
                return;

            string Controllname = conditionAddingButtton.Parent.Name.ToString();

            CustomPanel ConditionPanel = (CustomPanel)this.Controls[Controllname];

            int newGroupOrderNumber = ConditionPanel.GroupBoxOrderNumber + 1;

            ReorderWhenAddingTCRow(newGroupOrderNumber);
            AddTableColumnRow("*", newGroupOrderNumber);
            
        }
        private void BtnDev_Click(object sender, EventArgs e)
        {
            OperatorPanel.Visible = false;

            Button conditionAddingButtton = sender as Button;

            if (conditionAddingButtton == null) // just to be on the safe side
                return;

            string Controllname = conditionAddingButtton.Parent.Name.ToString();

            CustomPanel ConditionPanel = (CustomPanel)this.Controls[Controllname];

            int newGroupOrderNumber = ConditionPanel.GroupBoxOrderNumber + 1;

            ReorderWhenAddingTCRow(newGroupOrderNumber);
            AddTableColumnRow("/", newGroupOrderNumber);
           
        }
        #endregion
        #region create New Row
        private void AddTableColumnRow(string OperatorType, int currentOrderNumber)
        {
            string GroupRowName = "";
            switch (OperatorType)
            {

                case "+":
                    GroupRowName = "Addition (+) ";
                    break;

                case "-":
                    GroupRowName = "Substration (-) ";
                    break;
                case "*":
                    GroupRowName = "Multiplication (*) ";
                    break;
                case "/":
                    GroupRowName = "Division (/) ";
                    break;

                default:
                    return;
                    break;
            }

            string ControllerName = "";
            List<int> GroupBoxCountValue = new List<int>();
            foreach (Control ctn in this.ConditionContainerPanel.Controls)
            {
                if (ctn is GroupBox)
                {
                    ControllerName = ctn.Name.ToString();
                    if (ControllerName != null && ControllerName.Split("_").Length > 0)
                    {
                        if (ControllerName.Split("_")[0] == "TcGoupBox")
                        {
                            GroupBoxCountValue.Add(Convert.ToInt32(ControllerName.Split("_")[1]));
                        }
                    }
                }
            }

            int GroupBoxSuffixValue = GroupBoxCountValue.Count > 0 ? GroupBoxCountValue.Max() + 1 : 1;
            string PreviousControllerName = getGroupRowElementfromOrderNumber(currentOrderNumber - 1);
            int PreviousControllerLocationY = this.ConditionContainerPanel.Controls[PreviousControllerName].Location.Y;

            int GroupRowdrawingLocationY = (50 + PreviousControllerLocationY);
            customGroupBox TCGoupBox = new customGroupBox();
            {
                TCGoupBox.Location = new System.Drawing.Point(35, 21 + GroupRowdrawingLocationY);
                TCGoupBox.Name = "TcGoupBox_" + GroupBoxSuffixValue;
                TCGoupBox.Size = new System.Drawing.Size(733, 66);
                TCGoupBox.TabIndex = 1;
                TCGoupBox.TabStop = false;
                TCGoupBox.Text = GroupRowName;
                TCGoupBox.GroupBoxOrderNumber = currentOrderNumber;
                TCGoupBox.OperatorType = OperatorType;
                this.Controls.Add(TCGoupBox);
            }

            ComboBox OpenBacket = new ComboBox();
            {
                OpenBacket.FormattingEnabled = true;
                OpenBacket.Location = new System.Drawing.Point(23, 36);
                OpenBacket.Items.AddRange(new object[] {
            "(",
            "((",
            "(((",
            "((((",
            "AddMore"});
                OpenBacket.Name = "cmbOpenBacket_" + GroupBoxSuffixValue;
                OpenBacket.Size = new System.Drawing.Size(74, 23);
                OpenBacket.TabIndex = 0;
            }
            ComboBox TableName_1 = new ComboBox();
            {
                TableName_1.FormattingEnabled = true;

                TableName_1.Name = "comTableName_"+ GroupBoxSuffixValue;
                

                List<string> tableList = SelectQueryBuilder.AddedTableList;

                if (QueryGereratorQueryType != null && QueryGereratorQueryType == "UpdateQueryBuilder" && clickedElementName != null)
                {
                   CheckedListBox UpdateFormChecklistBox  = (CheckedListBox)UpdateQueryBuilderForm.Controls["CheckListBoxTable"];
                    tableList.Clear();
                    foreach (var item in UpdateFormChecklistBox.CheckedItems)
                    {
                        tableList.Add(item.ToString());
                    }
                }
                TableName_1.Items.Clear();
                foreach (string TableName in tableList)
                {
                    TableName_1.Items.Add(TableName);
                }
                //    TableName_1.Items.AddRange(new object[] {
                //"Tab1",
                //"Tab2",
                //"Tab3"});
                TableName_1.Size = new System.Drawing.Size(161, 23);
                TableName_1.TabIndex = 0;
                TableName_1.SelectedIndexChanged += new System.EventHandler(this.comTableName_1_SelectedIndexChanged);
            }
            ComboBox TableColumn = new ComboBox();
            {
                TableColumn.FormattingEnabled = true;
                TableColumn.Name = "cmbColumnName_" + GroupBoxSuffixValue;
                TableColumn.Items.AddRange(new object[] {
            "Col1",
            "Col2",
            "Col3",
            "Col4"});
                TableColumn.Size = new System.Drawing.Size(161, 23);
                TableColumn.TabIndex = 0;
            }
            ComboBox CloseBracket = new ComboBox();
            {
                CloseBracket.FormattingEnabled = true;
                CloseBracket.Items.AddRange(new object[] {
            ")",
            "))",
            ")))",
            "))))",
            "AddMore"});
                CloseBracket.Name = "cmbClosedBacket_" + GroupBoxSuffixValue;
                CloseBracket.Size = new System.Drawing.Size(81, 23);
                CloseBracket.TabIndex = 0;
            }

            Button Addtablecolumn = new Button();
            {
                Addtablecolumn.Location = new System.Drawing.Point(567, 36);
                Addtablecolumn.Name = "BtnAddOperator_" + GroupBoxSuffixValue;
                Addtablecolumn.Size = new System.Drawing.Size(75, 23);
                Addtablecolumn.TabIndex = 1;
                Addtablecolumn.Text = "+";
                Addtablecolumn.UseVisualStyleBackColor = true;
                Addtablecolumn.Click += new System.EventHandler(this.button1_Click);
            }
            Button DeleteRowButton = new Button();
            {
                DeleteRowButton.Enabled = true;
                DeleteRowButton.Name = "BtnDeleteRow";
                DeleteRowButton.Size = new System.Drawing.Size(57, 23);
                DeleteRowButton.TabIndex = 3;
                DeleteRowButton.Text = "Delete";
                DeleteRowButton.UseVisualStyleBackColor = true;
                DeleteRowButton.Click += new System.EventHandler(this.BtnDeleteRow_Click);
            }

            TCGoupBox.Controls.Add(OpenBacket);
            TCGoupBox.Controls.Add(TableName_1);
            TCGoupBox.Controls.Add(TableColumn);
            TCGoupBox.Controls.Add(CloseBracket);
            TCGoupBox.Controls.Add(Addtablecolumn);
            TCGoupBox.Controls.Add(DeleteRowButton);

            TableColumn.Location = new Point(23, 36);
            TableName_1.Location = new Point(117, 36);
            TableColumn.Location = new Point(284, 36);
            CloseBracket.Location = new Point(463, 36);
            Addtablecolumn.Location = new Point(567, 36);
            DeleteRowButton.Location = new Point(661, 36);

            ConditionContainerPanel.Controls.Add(TCGoupBox);

        }
        private void ReorderWhenAddingTCRow(int orderNumber)
        {
            int newlyAddedOrderNumber = orderNumber;

            string ControllerName = "";
            List<int> GroupBoxCountValue = new List<int>();
            foreach (Control ctn in this.ConditionContainerPanel.Controls)
            {
                if (ctn is GroupBox)
                {
                    ControllerName = ctn.Name.ToString();
                    if (ControllerName != null && ControllerName.Split("_").Length > 0)
                    {
                        if (ControllerName.Split("_")[0] == "TcGoupBox")
                        {
                            customGroupBox customGroupBox = (customGroupBox)this.ConditionContainerPanel.Controls[ControllerName];

                            if (customGroupBox.GroupBoxOrderNumber >= newlyAddedOrderNumber)
                            {

                                int newLocationY = customGroupBox.Location.Y + 70;
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
        private string getGroupRowElementfromOrderNumber(int GroupBoxOrderNumber)
        {
            string groupElementName = "";
            string ControllerName = "";
            foreach (Control ctn in this.ConditionContainerPanel.Controls)
            {
                if (ctn is GroupBox)
                {
                    ControllerName = ctn.Name.ToString();
                    if (ControllerName != null && ControllerName.Split("_").Length > 0)
                    {
                        if (ControllerName.Split("_")[0] == "TcGoupBox")
                        {
                            customGroupBox customGroupBox = (customGroupBox)this.ConditionContainerPanel.Controls[ControllerName];

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
        #endregion
        #endregion
        #region Delete Computation Condition Row
        private void BtnDeleteRow_Click(object sender, EventArgs e)
        {
            Button DeleteRowButton = sender as Button;

            if (DeleteRowButton == null) // just to be on the safe side
                return;

            string Controllname = DeleteRowButton.Parent.Name.ToString();
            customGroupBox customGroupBox = (customGroupBox)this.ConditionContainerPanel.Controls[Controllname];

            if (customGroupBox !=null)
            {
                int deleteRowOrderNumber = customGroupBox.GroupBoxOrderNumber;
                this.ConditionContainerPanel.Controls.Remove(customGroupBox);
                ReorderWhenDeletingTCRow(deleteRowOrderNumber);
            }
        }
        private void ReorderWhenDeletingTCRow(int orderNumber)
        {
            int DeletedRowOrderNumber = orderNumber;

            string ControllerName = "";
            List<int> GroupBoxCountValue = new List<int>();
            foreach (Control ctn in this.ConditionContainerPanel.Controls)
            {
                if (ctn is GroupBox)
                {
                    ControllerName = ctn.Name.ToString();
                    if (ControllerName != null && ControllerName.Split("_").Length > 0)
                    {
                        if (ControllerName.Split("_")[0] == "TcGoupBox")
                        {
                            customGroupBox customGroupBox = (customGroupBox)this.ConditionContainerPanel.Controls[ControllerName];

                            if (customGroupBox.GroupBoxOrderNumber > DeletedRowOrderNumber)
                            {

                                int newLocationY = customGroupBox.Location.Y - 70;
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
        #endregion
        #region Genarate Condition
        private void GenerateTCCondition_Click(object sender, EventArgs e)
        {
            String generatedTCConditionString =  GenerateTCConditionString();
            GeneratedTCConditionBox.Text = generatedTCConditionString;
            GeneratedTCConditionBox.ReadOnly = true;

        }
        private string GenerateTCConditionString()
        {
            string GeneratedString = "";
            List<customGroupBox> TCGroupBoxElementList = getAllGroupBoxRowConditions();
            TCGroupBoxElementList.OrderBy(e => e.GroupBoxOrderNumber);

            foreach (customGroupBox GroupBoxRow in TCGroupBoxElementList)
            {
                String TableColumnContent = "";
                string OpenBracket = "";
                string TableName = "";
                string ColumnName = "";
                string closeBracket = "";
                foreach (Control ctn in GroupBoxRow.Controls)
                {
                   

                    if (ctn is ComboBox)
                    {
                        string ControllerName = ctn.Name.ToString();
                        if (ControllerName != null && ControllerName.Split("_").Length > 0)
                        {
                            ComboBox TCComboBox = (ComboBox)GroupBoxRow.Controls[ControllerName];
                            if (ControllerName.Split("_")[0] == "cmbOpenBacket")
                            {

                                OpenBracket = TCComboBox.SelectedItem != null ? TCComboBox.SelectedItem.ToString() : "";

                            }
                            if (ControllerName.Split("_")[0] == "comTableName")
                            {
                                
                                TableName = TCComboBox.SelectedItem != null ? TCComboBox.SelectedItem.ToString() : "";

                            }
                            if (ControllerName.Split("_")[0] == "cmbColumnName")
                            {
                               
                                ColumnName = TCComboBox.SelectedItem != null ? TCComboBox.SelectedItem.ToString() : "";

                            }
                            if (ControllerName.Split("_")[0] == "cmbClosedBacket")
                            {

                                closeBracket = TCComboBox.SelectedItem != null ? TCComboBox.SelectedItem.ToString():"" ;

                            }
                        }
                    }
                    
                }
                TableColumnContent = OpenBracket + " " + TableName + "." + ColumnName + " " + closeBracket;
                GeneratedString += " "+ GroupBoxRow.OperatorType +" "+ TableColumnContent ;
            }
            return GeneratedString;
        }
        private List<customGroupBox> getAllGroupBoxRowConditions()
        {
            string groupElementName = "";
            string ControllerName = "";
            List<customGroupBox> GroupBoxElementList = new List<customGroupBox>();

            foreach (Control ctn in this.ConditionContainerPanel.Controls)
            {
                if (ctn is GroupBox)
                {
                    ControllerName = ctn.Name.ToString();
                    if (ControllerName != null && ControllerName.Split("_").Length > 0)
                    {
                        if (ControllerName.Split("_")[0] == "TcGoupBox")
                        {
                            customGroupBox customGroupBox = (customGroupBox)this.ConditionContainerPanel.Controls[ControllerName];

                            GroupBoxElementList.Add(customGroupBox);
                           
                        }
                    }
                }
            }
            return GroupBoxElementList;
        }
        private void BtnAddCondition_Click(object sender, EventArgs e)
        {
            if (QueryGereratorQueryType != null && QueryGereratorQueryType == "UpdateQueryBuilder" && clickedElementName !=null)
            {
                if (clickedElementName.Split("_")[0] == "BtnAddTableColumnValue")
                {
                    foreach (Control ctn in UpdateQueryBuilderForm.Controls)
                    {
                        if (ctn.Name == "panel2")
                        {


                                if (ctn.Controls["textColumnValue_" + clickedElementName.Split("_")[1].ToString()] != null)
                                {
                                
                                ctn.Controls["textColumnValue_" + clickedElementName.Split("_")[1].ToString()].Text = GeneratedTCConditionBox.Text;
                                CustomTextBox TableColumnValue = (CustomTextBox)ctn.Controls["textColumnName_" + clickedElementName.Split("_")[1].ToString()];
                                TableColumnValue.isTCCombinedValue = true;

                            }
                          

                            
                        }
                    }
                }
                this.Hide();
                UpdateQueryBuilderForm.Show();
                return;
            }

            else if(clickedElementName != null)
            {
                if(clickedElementName.Split("_")[0] == "BtnTCCondition2")
                {

                    foreach (Control ctn in ConditionGenerationForm.Controls)
                    {
                        if(ctn.Name == "PanelConditionContainer")
                        {

                            foreach (customGroupBox conditionGroupBox in ctn.Controls)
                            {
                                if (conditionGroupBox.Controls["textValue_" + clickedElementName.Split("_")[1].ToString()] != null)
                                {
                                    CustomTextBox TextBoxValue = (CustomTextBox)conditionGroupBox.Controls["textValue_" + clickedElementName.Split("_")[1].ToString()];
                                    TextBoxValue.Text = GeneratedTCConditionBox.Text;
                                    TextBoxValue.isTCCombinedValue = true;
                                   //conditionGroupBox.Controls["textValue_" + clickedElementName.Split("_")[1].ToString()].Text = GeneratedTCConditionBox.Text;
                                 

                                }
                            }    
                                
                            
                        }
                       
                    }  

                }
                else if(clickedElementName.Split("_")[0] == "BtnTCCondition1")
                {
                    foreach (Control ctn in ConditionGenerationForm.Controls)
                    {
                        if (ctn.Name == "PanelConditionContainer")
                        {

                            foreach (customGroupBox conditionGroupBox in ctn.Controls)
                            {
                                if (conditionGroupBox.Controls["textValue1_" + clickedElementName.Split("_")[1].ToString()] != null)
                                {
                                    int TextValue1LocationY = conditionGroupBox.Controls["textValue1_" + clickedElementName.Split("_")[1].ToString()].Location.Y;
                                    if(conditionGroupBox.Controls["textValue1_" + clickedElementName.Split("_")[1].ToString()].Visible == false)
                                    {
                                        TextValue1LocationY = TextValue1LocationY - 11;
                                    }
                                   
                                    int TextValue1LocationX = conditionGroupBox.Controls["textValue1_" + clickedElementName.Split("_")[1].ToString()].Location.X;
                                    
                                    
                                    conditionGroupBox.Controls["CmbTable_" + clickedElementName.Split("_")[1].ToString()].Visible = false;
                                    conditionGroupBox.Controls["CmbColumn_" + clickedElementName.Split("_")[1].ToString()].Visible = false;
                                    conditionGroupBox.Controls["textValue1_" + clickedElementName.Split("_")[1].ToString()].Visible = true;
                                    conditionGroupBox.Controls["textValue1_" + clickedElementName.Split("_")[1].ToString()].Location = new System.Drawing.Point(TextValue1LocationX, TextValue1LocationY); 
                                    conditionGroupBox.Controls["textValue1_" + clickedElementName.Split("_")[1].ToString()].Text = GeneratedTCConditionBox.Text;

                                    if(clickedElementName.Split("_")[1].ToString() == "1")
                                    {
                                        int LableValue1LocationY = conditionGroupBox.Controls["LbTablecolumn_" + clickedElementName.Split("_")[1].ToString()].Location.Y - 11;
                                        int LableValue1LocationX = conditionGroupBox.Controls["LbTablecolumn_" + clickedElementName.Split("_")[1].ToString()].Location.X;

                                        conditionGroupBox.Controls["LblTable_" + clickedElementName.Split("_")[1].ToString()].Visible = false;
                                        conditionGroupBox.Controls["LblColumn_" + clickedElementName.Split("_")[1].ToString()].Visible = false;
                                        conditionGroupBox.Controls["LbTablecolumn_" + clickedElementName.Split("_")[1].ToString()].Visible = true;
                                        conditionGroupBox.Controls["LbTablecolumn_" + clickedElementName.Split("_")[1].ToString()].Location = new System.Drawing.Point(LableValue1LocationX, LableValue1LocationY);

                                    }



                                }
                            }


                        }

                    }

                }

            }
            this.Hide();
            ConditionGenerationForm.Show();
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {

        }

        #endregion
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void TableColumnConnector_Load(object sender, EventArgs e)
        {
            //AddTableColumnRow("+", 1);
        }
        private void TcGoupBox_1_Enter(object sender, EventArgs e)
        {

        }
        private void cmbColumnName_1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
