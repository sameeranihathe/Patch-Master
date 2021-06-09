using Patch_Master.DBHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Patch_Master.Forms
{
    public partial class DBAdder : Form
    {
        public DBAdder()
        {
            InitializeComponent();
        }

        private void connectToDB_Click(object sender, EventArgs e)
        {
            // string connectionString = string.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3};", cboServer.Text, txtDatabase.Text, txtUserName.Text, txtPasssword.Text);
            string connectionString = string.Format("Data Source={0};Initial Catalog={1};Integrated Security = true;", ServerName.Text, "master");

            try
            {
                sqlHelper helper = new sqlHelper(connectionString);
                if (helper.IsConnection)
                {
                    IList<string> databaseNameList = helper.databaseNameList();
                    if (databaseNameList.Count > 0)
                    {
                        AddDatabasesCheckboxButton(databaseNameList);
                        //AddDatabaselist(databaseNameList);
                    }
                   
                   // MessageBox.Show("Test connection succeeded.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DBAdder_Load(object sender, EventArgs e)
        {
            ServerName.Text = string.Format(@"{0}\SQLEXPRESS", Environment.MachineName);
            //cboServer.Items.Add(".");
            //cboServer.Items.Add("(local)");
            //cboServer.Items.Add(@".\SQLEXPRESS");
            //cboServer.Items.Add(string.Format(@"{0}\SQLEXPRESS", Environment.MachineName));
            //cboServer.SelectedIndex = 3;
        }

        /*public void AddDatabaselist(IList<string> databaseNameList)
        {
            dataBaseListCheckBox.Items.Clear();
            for (int i = 0; i < databaseNameList.Count; i++)
            {
                dataBaseListCheckBox.Items.Add(databaseNameList[i]);
            }

        }*/
        public void AddDatabasesCheckboxButton(IList<string> databaseNameList)
        {
            for (int i = 0; i < databaseNameList.Count; i++)
            {
                CheckBox rdo = new CheckBox();
                rdo.Name = "DBCheckboxButton" + i;
                rdo.Text = databaseNameList[i];
                rdo.Location = new Point(15,30+ 30 * i);
                this.Controls.Add(rdo);
                groupBox2.Controls.Add(rdo);
            }

        }

        public void AddDatabaseToSelectedGroup(IList<string> databaseNameList)
        {

               /* TextBox tbox = new TextBox();
                tbox.Name = "DBAliasTextBox" + i;
                tbox.Text = databaseNameList[i];
                tbox.Location = new Point(15, 30 + 30 * i);
                this.Controls.Add(tbox);
                groupBox3.Controls.Add(tbox);*/

        }
    }
}
