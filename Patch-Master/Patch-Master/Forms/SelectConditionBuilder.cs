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
    public partial class SelectConditionBuilder : Form
    {
        public SelectConditionBuilder()
        {
            InitializeComponent();
        }

        private void SelectConditionBuilder_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SelectQueryBuilder selectQueryBuilder = new SelectQueryBuilder();
            selectQueryBuilder.Show();

        }

        private void btnAddCondition_Click(object sender, EventArgs e)
        {
            OperatorPanel.Visible = true;

            Button conditionAddingButtton = sender as Button;

            if (conditionAddingButtton == null) // just to be on the safe side
                return;

            this.OperatorPanel.Location = new System.Drawing.Point(conditionAddingButtton.Parent.Location.X + conditionAddingButtton.Location.X - 2, conditionAddingButtton.Parent.Location.Y + conditionAddingButtton.Location.Y - 70);
   
        }

        private void BtnAND_Click(object sender, EventArgs e)
        {
            OperatorPanel.Visible = false;
            ConditionElementGenerator("AND");
        }

        private void txtValue_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void AddTableColumn1_Click(object sender, EventArgs e)
        {
            Button AddTableColumnBtn = sender as Button;

            if (AddTableColumnBtn == null) // just to be on the safe side
                return;

            //TableColumnConnector  tableColumnSelector = new TableColumnConnector(AddTableColumnBtn.Name.ToString());
            //tableColumnSelector.Show();
            
        }

        private void AddTablecolumn2_Click(object sender, EventArgs e)
        {
            TableColumnConnector tableColumnSelector = new TableColumnConnector();
            tableColumnSelector.Show();
        }
        private void BtnOR_Click(object sender, EventArgs e)
        {
            OperatorPanel.Visible = false;
            ConditionElementGenerator("OR");
        }

        private void ConditionElementGenerator(string OperatorType)
        {
            string ControllerName = "";
            List<int> GroupBoxCountValue = new List<int>();
            foreach (Control ctn in this.Controls)
            {
                if (ctn is GroupBox)
                {
                    ControllerName = ctn.Name.ToString();
                    if (ControllerName != null && ControllerName.Split("_").Length > 0)
                    {
                        if (ControllerName.Split("_")[0] == "ConditionGroup")
                        {
                            GroupBoxCountValue.Add(Convert.ToInt32(ControllerName.Split("_")[1]));
                        }
                    }
                }
            }

            int GroupBoxSuffixValue = GroupBoxCountValue.Count > 0 ? GroupBoxCountValue.Max() + 1 : 1;


            customGroupBox newgroupBox = new customGroupBox();
            {
                this.ConditionGroup_1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                this.ConditionGroup_1.Location = new System.Drawing.Point(183, 200);
                this.ConditionGroup_1.Name = "ConditionGroup_"+ GroupBoxSuffixValue;
                this.ConditionGroup_1.Size = new System.Drawing.Size(1009, 84);
                this.ConditionGroup_1.TabIndex = 5;
                this.ConditionGroup_1.TabStop = false;
                this.ConditionGroup_1.Text = "Condition group";
            }

            ComboBox cmbOpenBracket = new ComboBox();
            {
                cmbOpenBracket.FormattingEnabled = true;
                cmbOpenBracket.Items.AddRange(new object[] {
            ")",
            "))",
            ")))",
            "))))",
            "Add More"});
                cmbOpenBracket.Name = "CmbOpenBracket_" + GroupBoxSuffixValue;
                cmbOpenBracket.Size = new System.Drawing.Size(82, 23);
                cmbOpenBracket.TabIndex = 11;
            }

            ComboBox cmbBoxcolumn_1 = new ComboBox();
            {
                cmbBoxcolumn_1.FormattingEnabled = true;
                cmbBoxcolumn_1.Name = "CmbColumn_" + GroupBoxSuffixValue;
                cmbBoxcolumn_1.Size = new System.Drawing.Size(188, 23);
                cmbBoxcolumn_1.TabIndex = 0;
                // 
            }

            Button AddTableColumn11 = new Button();
            {
                AddTableColumn11.Name = "AddTableColumn1_" + GroupBoxSuffixValue;
                AddTableColumn11.Size = new System.Drawing.Size(27, 23);
                AddTableColumn11.TabIndex = 12;
                AddTableColumn11.Text = "...";
                AddTableColumn11.UseVisualStyleBackColor = true;
                AddTableColumn11.Click += new System.EventHandler(this.AddTableColumn1_Click);
            }

            ComboBox cmbComparer_1 = new ComboBox();
            {
                cmbComparer_1.FormattingEnabled = true;
                cmbComparer_1.Name = "CmbComparer_" + GroupBoxSuffixValue;
                cmbComparer_1.Size = new System.Drawing.Size(95, 23);
                cmbComparer_1.TabIndex = 1;
            }
            TextBox txtValue_1 = new TextBox();
            {
                txtValue_1.Name = "txtValue_" + GroupBoxSuffixValue;
                txtValue_1.Size = new System.Drawing.Size(192, 23);
                txtValue_1.TabIndex = 2;
            }

            Button AddColumnValue22 = new Button();
            {
                AddColumnValue22.Name = "AddTablecolumn2_" + GroupBoxSuffixValue;
                AddColumnValue22.Size = new System.Drawing.Size(27, 23);
                AddColumnValue22.TabIndex = 9;
                AddColumnValue22.Text = "...";
                AddColumnValue22.UseVisualStyleBackColor = true;
                AddColumnValue22.Click += new System.EventHandler(this.AddTablecolumn2_Click);
            }

            ComboBox CloseBracket1 = new ComboBox();
            {
                CloseBracket1.FormattingEnabled = true;
                CloseBracket1.Items.AddRange(new object[] {
            ")",
            "))",
            ")))",
            "))))",
            "Add More"});
                CloseBracket1.Name = "cmbCloseBracket_" + GroupBoxSuffixValue;
                CloseBracket1.Size = new System.Drawing.Size(82, 23);
                CloseBracket1.TabIndex = 11;
            }

            Button btnCondition_1 = new Button();
            {
                btnCondition_1.Name = "btnAddCondition_" + GroupBoxSuffixValue;
                btnCondition_1.Size = new System.Drawing.Size(75, 23);
                btnCondition_1.TabIndex = 3;
                btnCondition_1.Text = "+";
                btnCondition_1.UseVisualStyleBackColor = true;
                btnCondition_1.Click += new System.EventHandler(this.btnAddCondition_Click);
            }



            /* Panel OperatorPanel_1 = new Panel();
             {
                 OperatorPanel_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                 OperatorPanel_1.Controls.Add(this.BtnAND);
                 OperatorPanel_1.Controls.Add(this.BtnOR);
                 //OperatorPanel_1.Location = new System.Drawing.Point(1016, 46);
                 OperatorPanel_1.Name = "OperatorPanel_1";
                 OperatorPanel_1.Size = new System.Drawing.Size(78, 66);
                 OperatorPanel_1.TabIndex = 7;
                 OperatorPanel_1.Visible = true;
             }*/






            newgroupBox.Controls.Add(cmbOpenBracket);
            newgroupBox.Controls.Add(cmbBoxcolumn_1);
            newgroupBox.Controls.Add(AddTableColumn11);
            newgroupBox.Controls.Add(cmbComparer_1);
            newgroupBox.Controls.Add(txtValue_1);
            newgroupBox.Controls.Add(AddColumnValue22);
            newgroupBox.Controls.Add(CloseBracket1);
            newgroupBox.Controls.Add(btnCondition_1);
            //newgroupBox.Controls.Add(OperatorPanel_1);

            cmbOpenBracket.Location = new Point(17, 46);
            cmbBoxcolumn_1.Location = new Point(120, 46);
            AddTableColumn11.Location = new Point(307, 46);
            cmbComparer_1.Location = new Point(351, 46);
            txtValue_1.Location = new Point(479, 46);
            AddColumnValue22.Location = new Point(670, 46);
            CloseBracket1.Location = new Point(707, 46);
            btnCondition_1.Location = new Point(805, 46);
            // OperatorPanel_1.Location = new Point(805, -50);
            ConditionContainerPanel.Controls.Add(newgroupBox);
        }

        private void cmbTable_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox TableSelectComboBox = sender as ComboBox;

            if (TableSelectComboBox == null) // just to be on the safe side
                return;
        }
    }

}
