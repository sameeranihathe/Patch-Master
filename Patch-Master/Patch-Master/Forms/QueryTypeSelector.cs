using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Patch_Master.Forms
{
    public partial class QueryTypeSelector : Form
    {
        public QueryTypeSelector()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void QueryTypeSelector_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            //SelectQueryBuilder selectQueryBuilder = new SelectQueryBuilder();
            //selectQueryBuilder.Show();
            ConditionBuilder ConditionBuilder = new ConditionBuilder();
            ConditionBuilder.Show();
        }
    }
}
