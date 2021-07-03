using NETCore.Encrypt;
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
            LoadRoleList();

            LoadUserList();

        }

        private void LoadRoleList()
        {
            Dictionary<int, string> savedRolesList = LoadsavedRolesList();

            comboBox_roles.DataSource = new BindingSource(savedRolesList, null);
            comboBox_roles.DisplayMember = "Value";
            comboBox_roles.ValueMember = "Key";
        }

        private void LoadUserList()
        {
            DataTable userList = LoadAvailableUsers();
            Users_dataGridView.Columns.Clear();
            Users_dataGridView.DataSource = userList;
        }

        private Dictionary<int, string> LoadsavedRolesList()
        {
            DbConnector dbContext = new DbConnector();

            Dictionary<int, string> savedRolesList = new Dictionary<int, string>();
            bool Status = true;
            try
            {
                string queryString = SqlQueryStringReader.GetQueryStringById("LoadsavedRolesList", "User");
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("Status", Convert.ToBoolean(Status)));

                var dataReaders = dbContext.ExecuteQueryWithIDataReader(queryString, sqlParams);

                if (dataReaders.Length == 0)
                {

                }
                var reader = dataReaders[0];

                while (reader.Read())
                {
                    var databaseId = Convert.ToInt32(reader["RoleId"]);
                    var databaseName = reader["RoleName"].ToString();

                    savedRolesList.Add(databaseId, databaseName);
                }


            }
            catch (Exception ex)
            {

                //throw ex;
            }
            finally
            {
                dbContext.CloseConnection();
            }
            return savedRolesList;
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

            if (Users_dataGridView.SelectedRows.Count > 0)
            {
                List<string> UsertIdList = new List<string>();
                List<string> UserNameList = new List<string>();
                foreach (DataGridViewRow row in Users_dataGridView.SelectedRows)
                {
                    UsertIdList.Add(row.Cells[0].Value.ToString());
                    UserNameList.Add(row.Cells[1].Value.ToString());
                }
                string joined = string.Join(",", UserNameList);
                string message = "Are you sure you want to delete following users? " + joined;
                string title = "Confirm Delete";
                MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
                DialogResult result = MessageBox.Show(message, title, buttons);

                if (result == DialogResult.Yes)
                {
                    DeleteSelectedUsers(UsertIdList);
                    LoadUserList();

                }
                else if (result == DialogResult.No)
                {
                    //...
                }
                else
                {
                    //...
                }

            }
            else
            {
                MessageBox.Show("No requirement seleted", "Delete Porcess");

            }
        }

        private void DeleteSelectedUsers(List<string> usertIdList)
        {
            DbConnector dbContext = new DbConnector();
            try
            {
                string joinedRequirementIdList = string.Join(",", usertIdList);

                string queryString = SqlQueryStringReader.GetQueryStringById("DeleteUsers", "User");
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("UserIdList", joinedRequirementIdList));
                dbContext.ExecuteQueryWithIDataReader(queryString, sqlParams);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                dbContext.CloseConnection();
            }
        }

        private void AddUser_button_Click(object sender, EventArgs e)
        {
            if (textBox_firstname.Text=="")
            {
                MessageBox.Show("First name cannot be empty", "Add User");
                return;
            }
            if (textBox_lastname.Text == "")
            {
                MessageBox.Show("Last name cannot be empty", "Add User");
                return;
            }
            if (textBox_username.Text == "")
            {
                MessageBox.Show("User name cannot be empty", "Add User");
                return;
            }
            if (textBox_password.Text == "")
            {
                MessageBox.Show("Password cannot be empty", "Add User");
                return;
            }
            if (textBox_confirmPassword.Text == "")
            {
                MessageBox.Show("Confirm password cannot be empty", "Add User");
                return;
            }

            string selectedRoleId = (((KeyValuePair<int, string>)comboBox_roles.SelectedItem).Key).ToString();

            if (selectedRoleId == "")
            {
                MessageBox.Show("Please select the role", "Add User");
                return;
            }
            if (textBox_password.Text != textBox_confirmPassword.Text)
            {
                MessageBox.Show("Confirm password do not match", "Add User");
                return;
            }

            AddUser();
        }

        private void AddUser()
        {
            string MessageDisplay = string.Empty;
            DbConnector dbContext = new DbConnector();
            string selectedRoleId = (((KeyValuePair<int, string>)comboBox_roles.SelectedItem).Key).ToString();

            try
            {
                string queryString = SqlQueryStringReader.GetQueryStringById("AddUser", "User");
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("firstName", textBox_firstname.Text.ToString()));
                sqlParams.Add(new SqlParameter("lastName", textBox_lastname.Text.ToString()));
                sqlParams.Add(new SqlParameter("password", EncryptProvider.Base64Encrypt(textBox_password.Text.ToString())));
                sqlParams.Add(new SqlParameter("userName", textBox_username.Text.ToString()));
                sqlParams.Add(new SqlParameter("roleId", selectedRoleId));

                var dataReaders = dbContext.ExecuteQueryWithIDataReader(queryString, sqlParams);

                var reader = dataReaders[0];
                int UserId = 0;
                while (reader.Read())
                {
                    UserId = Convert.ToInt32(reader["User_Id"]);
                }

                if (UserId > 0)
                {
                    MessageDisplay = "User saved successfully";
                }
                else
                {
                    MessageDisplay = "User saving failed";
                }
                MessageBox.Show(MessageDisplay, "Add user");

            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                ClearTextBoxes();
                LoadUserList();
                dbContext.CloseConnection();
            }
        }

        private void ClearTextBoxes()
        {
            textBox_firstname.Text = string.Empty;
            textBox_lastname.Text = string.Empty;
            textBox_username.Text = string.Empty;
            textBox_password.Text = string.Empty;
            textBox_confirmPassword.Text = string.Empty;
        }

        private void ClearUserFields_button_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
