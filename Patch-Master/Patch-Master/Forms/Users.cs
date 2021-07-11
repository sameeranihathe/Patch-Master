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
                sqlParams.Add(new SqlParameter("Designation", textBoxDesignation.Text.ToString()));

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
            checkBoxAccepted.Checked = false;
            textBoxDesignation.Text = string.Empty;
        }
        private void ClearUserFields_button_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }
        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Users_dataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowindex = e.RowIndex;
            textBox_firstname.Text = Users_dataGridView.Rows[rowindex].Cells[2].Value.ToString();
            textBox_username.Text = Users_dataGridView.Rows[rowindex].Cells[1].Value.ToString();
            textBox_lastname.Text = Users_dataGridView.Rows[rowindex].Cells[3].Value.ToString();
            textBoxDesignation.Text = Users_dataGridView.Rows[rowindex].Cells[4].Value.ToString();
            comboBox_roles.Text = Users_dataGridView.Rows[rowindex].Cells[5].Value.ToString();
            if (textBox_username.Text == "")
            {
                AddUser_button.Visible=true;
                labelPW.Visible = true;
                labelCPW.Visible = true;
                textBox_password.Visible = true;
                textBox_confirmPassword.Visible = true;
                buttonAccept.Visible = false;
                Delete_button.Visible = false;
                ClearUserFields_button.Visible = false;

            }
            else
            {
                checkBoxAccepted.Checked = Convert.ToBoolean(Users_dataGridView.Rows[rowindex].Cells[6].Value.ToString());
                AddUser_button.Visible = false;
                labelPW.Visible = false;
                labelCPW.Visible = false;
                textBox_password.Visible = false;
                textBox_confirmPassword.Visible = false;
                Delete_button.Visible = true;
                ClearUserFields_button.Visible = true;
                if (!checkBoxAccepted.Checked)
                {
                    buttonAccept.Visible = true;
                }
                else
                {
                    buttonAccept.Visible = false;
                }

            }

        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            int UserId = Convert.ToInt32(Users_dataGridView.SelectedRows[0].Cells[0].Value.ToString());
            string selectedRoleId = (((KeyValuePair<int, string>)comboBox_roles.SelectedItem).Key).ToString();
            AcceptUser(UserId, selectedRoleId);
            LoadUserList();
            ClearTextBoxes();
        }
        private void AcceptUser(int UserId, string RoleID)
        {
            DbConnector dbContext = new DbConnector();

            try
            {
                string queryString = SqlQueryStringReader.GetQueryStringById("AcceptUser", "User");
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("UserId", UserId));
                sqlParams.Add(new SqlParameter("RoleId", RoleID));
                var dataReaders = dbContext.ExecuteQueryWithIDataReader(queryString, sqlParams);
                

            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                
                dbContext.CloseConnection();
            }

        }
    }
}
