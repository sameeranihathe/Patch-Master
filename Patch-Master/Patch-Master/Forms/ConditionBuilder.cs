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
    public partial class ConditionBuilder : Form
    {
        public ConditionBuilder()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

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

            int GroupBoxSuffixValue = GroupBoxCountValue.Count > 0 ? GroupBoxCountValue.Max() + 1 : 1;
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
                this.Controls.Add(GroupConditionRow);

            }

            ComboBox CmbOpenBracket = new ComboBox();
            {
                CmbOpenBracket.FormattingEnabled = true;
                CmbOpenBracket.Location = new System.Drawing.Point(25, 42);
                CmbOpenBracket.Name = "CmbOpenBracket_"+ GroupBoxSuffixValue;
                CmbOpenBracket.Size = new System.Drawing.Size(75, 23);
                CmbOpenBracket.TabIndex = 0;
            }

            ComboBox CmbTable = new ComboBox();
            {
                CmbTable.FormattingEnabled = true;
                CmbTable.Location = new System.Drawing.Point(116, 42);
                CmbTable.Name = "CmbTable_"+ GroupBoxSuffixValue;
                CmbTable.Size = new System.Drawing.Size(121, 23);
                CmbTable.TabIndex = 0;
            }

            ComboBox CmbColumn = new ComboBox();
            {
                CmbColumn.FormattingEnabled = true;
                CmbColumn.Location = new System.Drawing.Point(239, 42);
                CmbColumn.Name = "CmbColumn_"+ GroupBoxSuffixValue;
                CmbColumn.Size = new System.Drawing.Size(131, 23);
                CmbColumn.TabIndex = 0;
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



            PanelConditionContainer.Controls.Add(GroupConditionRow);
        }

        private void BtnTCCondition1_1_Click(object sender, EventArgs e)
        {

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
    }
}
