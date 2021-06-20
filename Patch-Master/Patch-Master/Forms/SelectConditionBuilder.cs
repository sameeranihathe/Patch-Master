using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        }
    }
}
