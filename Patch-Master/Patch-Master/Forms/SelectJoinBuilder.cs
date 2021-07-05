using Patch_Master.Dto;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Patch_Master.Forms
{
    public partial class SelectJoinBuilder : Form
    {
        public static List<SelectJoinDetails> joindetailList = new List<SelectJoinDetails>();
        string currentJoin = string.Empty;
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
            comboBox2.SelectedIndexChanged += new EventHandler(ColumnList_SelectdIndexChanged);
           
            panel.Controls.Add(comboBox2);

            Label label5 = new Label();
            label5.Text = "Join Type";
            label5.Location = new Point(300);
            panel.Controls.Add(label5);

            ComboBox comboBox5 = new ComboBox();
            comboBox5.Name = "JoinType_" + i;
            comboBox5.Location = new Point(300, 25);
            comboBox5.SelectedIndexChanged += new EventHandler(JoinList__SelectedIndexChanged);

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
            comboBox4.SelectedIndexChanged += new EventHandler(ColumnList_SelectdIndexChanged);

            panel.Controls.Add(comboBox4);

            JoinBuilder_panel.Controls.Add(panel);
        }

        private void JoinList__SelectedIndexChanged(object sender, EventArgs e)
        {
            string comboboxName = (sender as ComboBox).Name;

            string selectedJoin = (sender as ComboBox).SelectedItem.ToString();
            int currentRow = Convert.ToInt32(comboboxName.Split("_")[1]);

            var join = joindetailList.SingleOrDefault(a => a.RowId == currentRow);

            if (join != null)
            {
                join.JoinName = selectedJoin;
            }
        }

        private void ColumnList_SelectdIndexChanged(object sender, EventArgs e)
        {

            string selectedColumn = (sender as ComboBox).SelectedItem.ToString();
            string comboboxName = (sender as ComboBox).Name;
            Panel JoinPanelControll = (Panel)JoinBuilder_panel.Controls["JoinPanel_" + comboboxName.Split("_")[1]];


            string tableComboboxName = comboboxName.Remove(0, 6);


            int currentRow = Convert.ToInt32(comboboxName.Split("_")[1]);
            var join = joindetailList.SingleOrDefault(a => a.RowId == currentRow);

            if (comboboxName.Split("_")[0].ToString() == "ColumnTableList1")
            {
                ComboBox tableComboBox = (ComboBox)JoinPanelControll.Controls["TableList1_" + comboboxName.Split("_")[1]];

                if (join != null)
                {
                    join.RowId = currentRow;
                    join.TableOne = tableComboBox.SelectedItem.ToString();
                    join.TableOneColumn = selectedColumn;
                }
                else
                {
                    SelectJoinDetails selectJoinDetails = new SelectJoinDetails();
                    selectJoinDetails.RowId = currentRow;
                    selectJoinDetails.TableOne = tableComboBox.SelectedItem.ToString();
                    selectJoinDetails.TableOneColumn = selectedColumn;

                    joindetailList.Add(selectJoinDetails);
                }
            }
            else if (comboboxName.Split("_")[0].ToString() == "ColumnTableList2")
            {
                ComboBox tableComboBox = (ComboBox)JoinPanelControll.Controls["TableList2_" + comboboxName.Split("_")[1]];
                if (join != null)
                {
                    join.RowId = currentRow;
                    join.TableTwo = tableComboBox.SelectedItem.ToString();
                    join.TableTwoColumn = selectedColumn;
                }
                else
                {
                    SelectJoinDetails selectJoinDetails = new SelectJoinDetails();
                    selectJoinDetails.RowId = currentRow;
                    selectJoinDetails.TableTwo = tableComboBox.SelectedItem.ToString();
                    selectJoinDetails.TableTwoColumn = selectedColumn;

                    joindetailList.Add(selectJoinDetails);
                }
            }
        }

        private void TableList__SelectedIndexChanged(object sender, EventArgs e)
        {

            string selectedTable = (sender as ComboBox).SelectedItem.ToString();
            string comboboxName = (sender as ComboBox).Name;
            SelectQueryBuilder selectQueryBuilder = new SelectQueryBuilder();
            List<String> columnList =  selectQueryBuilder.LoadAllColumns(SelectQueryBuilder.SelectedDatabase, selectedTable);

            ///Control[] comboBoxColumn = Controls["JoinPanel_" + comboboxName.Split("_")[1]];
            Panel JoinPanelControll = (Panel)JoinBuilder_panel.Controls["JoinPanel_" + comboboxName.Split("_")[1]];
            if(comboboxName.Split("_")[0].ToString() == "TableList1")
            {
                ComboBox GetColumnLoadingCmbBox1 = (ComboBox)JoinPanelControll.Controls["ColumnTableList1_" + comboboxName.Split("_")[1]];
                foreach (string column in columnList)
                {
                    GetColumnLoadingCmbBox1.Items.Add(column);
                }
            }
            else if(comboboxName.Split("_")[0].ToString() == "TableList2")
            {
                ComboBox GetColumnLoadingCmbBox1 = (ComboBox)JoinPanelControll.Controls["ColumnTableList2_" + comboboxName.Split("_")[1]];
                foreach (string column in columnList)
                {
                    GetColumnLoadingCmbBox1.Items.Add(column);
                }
            }
        }
        private void SelectJoinBuilder_Load(object sender, EventArgs e)
        {

        }

        private void AddJoins_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<SelectJoinDetails> joindetailList = new List<SelectJoinDetails>();
            string currentJoin = string.Empty;
            //need to add removing selected items from comboboxes
        }
    }
}
