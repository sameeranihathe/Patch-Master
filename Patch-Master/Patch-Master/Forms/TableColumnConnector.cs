using Patch_Master.CustomElements;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public TableColumnConnector()
        {
            InitializeComponent();
        }

        public TableColumnConnector(string elementName, NameConditionBuilder conditionForm)
        {
            InitializeComponent();
            clickedElementName = elementName;
            ConditionGenerationForm = conditionForm;
            //conditionForm.
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

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

        private void AddTableColumnRow(string OperatorType,int currentOrderNumber)
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

            int GroupRowdrawingLocationY = (50 +PreviousControllerLocationY);
            customGroupBox TCGoupBox = new customGroupBox();
            {
                TCGoupBox.Location = new System.Drawing.Point(35, 21+GroupRowdrawingLocationY);
                TCGoupBox.Name = "TcGoupBox_"+GroupBoxSuffixValue;
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
                OpenBacket.Name = "cmbOpenBacket_"+ GroupBoxSuffixValue;
                OpenBacket.Size = new System.Drawing.Size(74, 23);
                OpenBacket.TabIndex = 0;
            }
            ComboBox TableName_1 = new ComboBox();
            {
                TableName_1.FormattingEnabled = true;
                TableName_1.Name = "comTableName_"+ GroupBoxSuffixValue;
                TableName_1.Items.AddRange(new object[] {
            "Tab1",
            "Tab2",
            "Tab3"});
                TableName_1.Size = new System.Drawing.Size(161, 23);
                TableName_1.TabIndex = 0;
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
                CloseBracket.Name = "cmbClosedBacket_"+ GroupBoxSuffixValue;
                CloseBracket.Size = new System.Drawing.Size(81, 23);
                CloseBracket.TabIndex = 0;
            }

            Button Addtablecolumn = new Button();
            {
                Addtablecolumn.Location = new System.Drawing.Point(567, 36);
                Addtablecolumn.Name = "BtnAddOperator_"+ GroupBoxSuffixValue;
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

        private void TableColumnConnector_Load(object sender, EventArgs e)
        {
            //AddTableColumnRow("+", 1);
        }

        private void TcGoupBox_1_Enter(object sender, EventArgs e)
        {

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
                           
                            if (customGroupBox.GroupBoxOrderNumber>= newlyAddedOrderNumber)
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

        private void GenerateTCCondition_Click(object sender, EventArgs e)
        {
            String generatedTCConditionString =  GenerateTCConditionString();
            GeneratedTCConditionBox.Text = generatedTCConditionString;
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
            if(clickedElementName != null)
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

                                    conditionGroupBox.Controls["textValue_" + clickedElementName.Split("_")[1].ToString()].Text = GeneratedTCConditionBox.Text;

                                }
                            }    
                                
                            
                        }
                       
                    }  

                }
                else if(clickedElementName.Split("_")[0] == "BtnTCCondition1")
                {


                }

            }
            this.Hide();
            ConditionGenerationForm.Show();
        }
    }
}
