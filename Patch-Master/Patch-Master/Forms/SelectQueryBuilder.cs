using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Patch_Master.Forms
{
    public partial class SelectQueryBuilder : Form
    {
        public SelectQueryBuilder()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void btnSingleSelectCondition_Click(object sender, EventArgs e)
        {
            this.Hide();
            SelectConditionBuilder selectConditionBuilder = new SelectConditionBuilder();
            selectConditionBuilder.Show();
        }
    }
}
