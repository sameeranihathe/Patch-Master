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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void button_login_Click(object sender, EventArgs e)
        {
            string usernme = textBox_UserName.Text.ToString();
            string password = textBox_Password.Text.ToString();
            bool Accepted=false;
            if (usernme=="")
            {
                label_errorMessage.Visible = true;
                label_errorMessage.Text = "Username cannot be empty.";
                return;
            }
            if (password == "")
            {
                label_errorMessage.Visible = true;
                label_errorMessage.Text = "Password cannot be empty.";
                return;
            }

            password = EncryptProvider.Base64Encrypt(password);

            DbConnector dbContext = new DbConnector();

            string queryString = SqlQueryStringReader.GetQueryStringById("CheckAuthentication", "user");
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            sqlParams.Add(new SqlParameter("UserName", usernme));
            sqlParams.Add(new SqlParameter("Password", password));


            var dataReaders = dbContext.ExecuteQueryWithIDataReader(queryString, sqlParams);
            
            if (dataReaders.Length == 0)
            {
                label_errorMessage.Text = "Incorrect Username or Password.";
                return;
            }
            var reader = dataReaders[0];

            while (reader.Read())
            {

                Home.loggedUserId = Convert.ToInt32(reader["User_Id"]);
                Home.Userlogged = Convert.ToBoolean(reader["Authenticated"]); 
                Home.UserName = reader["Username"].ToString();
                Home.FirstName = reader["First_Name"].ToString();
                Home.Role = reader["RoleName"].ToString();
                Home.RoleId = Convert.ToInt32(reader["RoleId"]);
                Accepted = Convert.ToBoolean(reader["Accepted"]);
            }

            dbContext.CloseConnection();

            if (Home.Userlogged && Accepted)
            {
                label_errorMessage.Text = "Login Successfull.";
                Home newHome = new Home();
                newHome.Show();
                this.Hide();
                return;

            }
            else
            {
                label_errorMessage.Visible = true;
                label_errorMessage.Text = "You are Not Beign Accepted or You have Input an Incorrect Username or Password.";
                return;

            }

        }
        private void button_Cancel_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
        }
    }
}
