using Patch_Master.DbContext.Database;
using Patch_Master.DbContext.QueryReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Patch_Master.Forms
{
    public partial class Users : Form
    {
        bool userLogged = false;
        int loggedUserId = 0;
        string loggedUserName = string.Empty;
        string roleName = string.Empty;
        int roleId = 0;

        public Users()
        {
            InitializeComponent();
            CheckLogin();
            DataTable userList = LoadAvailableUsers();

            Users_dataGridView.Columns.Clear();
            Users_dataGridView.DataSource = userList;


        }
        private void CheckLogin()
        {
            userLogged = Home.Userlogged;
            loggedUserId = Home.loggedUserId;
            loggedUserName = Home.UserName;
            roleId = Home.RoleId;
            roleName = Home.Role;

        }
        private DataTable LoadAvailableUsers()
        {
            DbConnector dbContext = new DbConnector();
            DataTable dt = new DataTable();
            bool status = true;
            try
            {
                string queryString = SqlQueryStringReader.GetQueryStringById("LoadAvailableUsers", "User");
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("Status", status));
                DataSet ds = dbContext.ExecuteQueryWithDataSet(queryString, sqlParams);
                dt = ds.Tables[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dbContext.CloseConnection();

            }

            return dt;
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {

        }
    }
}
