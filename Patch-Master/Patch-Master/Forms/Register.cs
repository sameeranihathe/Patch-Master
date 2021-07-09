using Patch_Master.DbContext.QueryReader;
using Patch_Master.DbContext.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using NETCore.Encrypt;

namespace Patch_Master.Forms
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {

            if (textBox_firstname.Text == "")
            {
                MessageBox.Show("First Name cannot be empty", "Register");
                return;
            }
            if (textBox_lastname.Text == "")
            {
                MessageBox.Show("Last Name cannot be empty", "Register");
                return;
            }
            if (textBox_username.Text == "")
            {
                MessageBox.Show("User Name cannot be empty", "Register");
                return;
            }
            if (textBox_password.Text == "")
            {
                MessageBox.Show("Password cannot be empty", "Register");
                return;
            }
            if (textBox_confirmPassword.Text == "")
            {
                MessageBox.Show("Confirm password cannot be empty", "Register");
                return;
            }

            
            if (textBox_password.Text != textBox_confirmPassword.Text)
            {
                MessageBox.Show("Confirm password do not match", "Register");
                return;
            }

            AddUser();
        }
        private void AddUser()
        {
            string MessageDisplay = string.Empty;
            DbConnector dbContext = new DbConnector();
            int roleid = 2;

            try
            {
                string queryString = SqlQueryStringReader.GetQueryStringById("AddUser", "User");
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("firstName", textBox_firstname.Text.ToString()));
                sqlParams.Add(new SqlParameter("lastName", textBox_lastname.Text.ToString()));
                sqlParams.Add(new SqlParameter("password", EncryptProvider.Base64Encrypt(textBox_password.Text.ToString())));
                sqlParams.Add(new SqlParameter("userName", textBox_username.Text.ToString()));
                sqlParams.Add(new SqlParameter("roleId", roleid));
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
                    MessageDisplay = "Registered Sucessfully. You Can Login When the Admistrator Accept You";
                }
                else
                {
                    MessageDisplay = "Registration Failed";
                }
                MessageBox.Show(MessageDisplay, "Register");
                this.ClearTextBoxes();
                this.Close();

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
        private void ClearTextBoxes()
        {
            textBox_firstname.Text = string.Empty;
            textBox_lastname.Text = string.Empty;
            textBox_username.Text = string.Empty;
            textBox_password.Text = string.Empty;
            textBox_confirmPassword.Text = string.Empty;
        }
    }
}
