using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Patch_Master.Forms
{
    public partial class SelectJoinBuilder : Form
    {
        public SelectJoinBuilder()
        {
            InitializeComponent();
            InitializeJoinConditions();
        }

        private void InitializeJoinConditions()
        {
            var AddedTableList = SelectQueryBuilder.AddedTableList;

            for (int i = 0; i < AddedTableList.Count-1; i++)
            {
                DrawJoinPanel(AddedTableList, i);
            }
        }

        private void DrawJoinPanel(List<string> addedTableList, int i)
        {
            Panel panel = new Panel();
            panel.Name = "JoinPanel_" + i;
            panel.Size = new Size(750, 75);
            panel.Location = new Point(10, i*(75 + 10));

            Label label1 = new Label();
            label1.Text = "Table";
            label1.Location = new Point(10);
            panel.Controls.Add(label1);

            ComboBox comboBox1 = new ComboBox();
            comboBox1.Name = "TableList1_" + i;
            comboBox1.Location = new Point(10, 25);
            foreach (var item in addedTableList)
            {
                comboBox1.Items.Add(item);
            }
            comboBox1.SelectedIndexChanged += new EventHandler(TableList__SelectedIndexChanged);
            panel.Controls.Add(comboBox1);

            Label label2 = new Label();
            label2.Text = "Column";
            label2.Location = new Point(130);
            panel.Controls.Add(label2);

            ComboBox comboBox2 = new ComboBox();
            comboBox2.Name = "ColumnTableList1_" + i;
            comboBox2.Location = new Point(130, 25);
           
            panel.Controls.Add(comboBox2);

            Label label5 = new Label();
            label5.Text = "Join Type";
            label5.Location = new Point(300);
            panel.Controls.Add(label5);

            ComboBox comboBox5 = new ComboBox();
            comboBox5.Name = "JoinType_" + i;
            comboBox5.Location = new Point(300, 25);
            
            comboBox5.Items.Add("Full Join");
            comboBox5.Items.Add("Left Join");
            comboBox5.Items.Add("Right Join");
            comboBox5.Items.Add("Inner Join");
            panel.Controls.Add(comboBox5);

            Label label3 = new Label();
            label3.Text = "Table";
            label3.Location = new Point(450);
            panel.Controls.Add(label3);

            ComboBox comboBox3 = new ComboBox();
            comboBox3.Name = "TableList2_" + i;
            comboBox3.Location = new Point(450, 25);
            foreach (var item in addedTableList)
            {
                comboBox3.Items.Add(item);
            }
            comboBox3.SelectedIndexChanged += new EventHandler(TableList__SelectedIndexChanged);
            panel.Controls.Add(comboBox3);

            Label label4 = new Label();
            label4.Text = "Column";
            label4.Location = new Point(570);
            panel.Controls.Add(label4);

            ComboBox comboBox4 = new ComboBox();
            comboBox4.Name = "ColumnTableList2_" + i;
            comboBox4.Location = new Point(570, 25);
            panel.Controls.Add(comboBox4);

            JoinBuilder_panel.Controls.Add(panel);
        }

        private void TableList__SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTable = (sender as ComboBox).SelectedItem.ToString();
            string comboboxName = (sender as ComboBox).Name;
            SelectQueryBuilder selectQueryBuilder = new SelectQueryBuilder();
            List<String> columnList =  selectQueryBuilder.LoadAllColumns(SelectQueryBuilder.SelectedDatabase, selectedTable);

            Control[] comboBoxColumn = Controls.Find("Column" + comboboxName, true);
            
            //foreach (var comb in comboBoxColumn)
            //{
            //    comb.Controls.Items.Add(item);
            //}

            //string selectedComboboxName = "Column" + comboboxName;
            //Control controlColumnList = GetControlByName(selectedComboboxName);

            //foreach (Control  ctn in this.JoinBuilder_panel.Controls)
            //{
            //    if (ctn is ComboBox)
            //    {

            //    }
            //    if (ctn is Panel)
            //    {
            //        string ControllerName = ctn.Name.ToString();
            //        if (ControllerName != null && ControllerName.Split("_").Length > 0)
            //        {
            //            Panel TCComboBox = (Panel)JoinBuilder_panel.Controls[ControllerName];
            //        }
            //    }
            //}
        }

        Control GetControlByName(string Name)
        {
            foreach (Control c in this.Controls)
                if (c.Name == Name)
                    return c;

            return null;
        }
    }
}
