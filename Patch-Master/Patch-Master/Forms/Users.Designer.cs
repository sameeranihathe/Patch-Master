
namespace Patch_Master.Forms
{
    partial class Users
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Users_dataGridView = new System.Windows.Forms.DataGridView();
            this.Delete_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_firstname = new System.Windows.Forms.TextBox();
            this.textBox_lastname = new System.Windows.Forms.TextBox();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.labelPW = new System.Windows.Forms.Label();
            this.textBox_confirmPassword = new System.Windows.Forms.TextBox();
            this.labelCPW = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_roles = new System.Windows.Forms.ComboBox();
            this.ClearUserFields_button = new System.Windows.Forms.Button();
            this.AddUser_button = new System.Windows.Forms.Button();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.labelDesignation = new System.Windows.Forms.Label();
            this.textBoxDesignation = new System.Windows.Forms.TextBox();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.checkBoxAccepted = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.Users_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Users_dataGridView
            // 
            this.Users_dataGridView.AllowUserToDeleteRows = false;
            this.Users_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Users_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Users_dataGridView.Location = new System.Drawing.Point(21, 13);
            this.Users_dataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Users_dataGridView.Name = "Users_dataGridView";
            this.Users_dataGridView.ReadOnly = true;
            this.Users_dataGridView.RowHeadersWidth = 51;
            this.Users_dataGridView.RowTemplate.Height = 25;
            this.Users_dataGridView.Size = new System.Drawing.Size(881, 201);
            this.Users_dataGridView.TabIndex = 0;
            this.Users_dataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Users_dataGridView_RowHeaderMouseClick);
            // 
            // Delete_button
            // 
            this.Delete_button.Location = new System.Drawing.Point(606, 454);
            this.Delete_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(86, 31);
            this.Delete_button.TabIndex = 1;
            this.Delete_button.Text = "Remove";
            this.Delete_button.UseVisualStyleBackColor = true;
            this.Delete_button.Visible = false;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "First name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last name";
            // 
            // textBox_firstname
            // 
            this.textBox_firstname.Location = new System.Drawing.Point(197, 222);
            this.textBox_firstname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_firstname.Name = "textBox_firstname";
            this.textBox_firstname.Size = new System.Drawing.Size(386, 27);
            this.textBox_firstname.TabIndex = 4;
            // 
            // textBox_lastname
            // 
            this.textBox_lastname.Location = new System.Drawing.Point(197, 257);
            this.textBox_lastname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_lastname.Name = "textBox_lastname";
            this.textBox_lastname.Size = new System.Drawing.Size(386, 27);
            this.textBox_lastname.TabIndex = 5;
            // 
            // textBox_username
            // 
            this.textBox_username.Location = new System.Drawing.Point(197, 328);
            this.textBox_username.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(232, 27);
            this.textBox_username.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "User Name";
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(197, 363);
            this.textBox_password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.Size = new System.Drawing.Size(232, 27);
            this.textBox_password.TabIndex = 9;
            this.textBox_password.Visible = false;
            // 
            // labelPW
            // 
            this.labelPW.AutoSize = true;
            this.labelPW.Location = new System.Drawing.Point(62, 363);
            this.labelPW.Name = "labelPW";
            this.labelPW.Size = new System.Drawing.Size(70, 20);
            this.labelPW.TabIndex = 8;
            this.labelPW.Text = "Password";
            this.labelPW.Visible = false;
            // 
            // textBox_confirmPassword
            // 
            this.textBox_confirmPassword.Location = new System.Drawing.Point(197, 398);
            this.textBox_confirmPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_confirmPassword.Name = "textBox_confirmPassword";
            this.textBox_confirmPassword.PasswordChar = '*';
            this.textBox_confirmPassword.Size = new System.Drawing.Size(232, 27);
            this.textBox_confirmPassword.TabIndex = 11;
            this.textBox_confirmPassword.Visible = false;
            // 
            // labelCPW
            // 
            this.labelCPW.AutoSize = true;
            this.labelCPW.Location = new System.Drawing.Point(62, 398);
            this.labelCPW.Name = "labelCPW";
            this.labelCPW.Size = new System.Drawing.Size(127, 20);
            this.labelCPW.TabIndex = 10;
            this.labelCPW.Text = "Confirm Password";
            this.labelCPW.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(645, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "User Role";
            // 
            // comboBox_roles
            // 
            this.comboBox_roles.FormattingEnabled = true;
            this.comboBox_roles.Location = new System.Drawing.Point(780, 233);
            this.comboBox_roles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox_roles.Name = "comboBox_roles";
            this.comboBox_roles.Size = new System.Drawing.Size(104, 28);
            this.comboBox_roles.TabIndex = 13;
            // 
            // ClearUserFields_button
            // 
            this.ClearUserFields_button.Location = new System.Drawing.Point(65, 454);
            this.ClearUserFields_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ClearUserFields_button.Name = "ClearUserFields_button";
            this.ClearUserFields_button.Size = new System.Drawing.Size(86, 31);
            this.ClearUserFields_button.TabIndex = 14;
            this.ClearUserFields_button.Text = "Clear";
            this.ClearUserFields_button.UseVisualStyleBackColor = true;
            this.ClearUserFields_button.Visible = false;
            this.ClearUserFields_button.Click += new System.EventHandler(this.ClearUserFields_button_Click);
            // 
            // AddUser_button
            // 
            this.AddUser_button.Location = new System.Drawing.Point(166, 454);
            this.AddUser_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddUser_button.Name = "AddUser_button";
            this.AddUser_button.Size = new System.Drawing.Size(86, 31);
            this.AddUser_button.TabIndex = 15;
            this.AddUser_button.Text = "Add";
            this.AddUser_button.UseVisualStyleBackColor = true;
            this.AddUser_button.Visible = false;
            this.AddUser_button.Click += new System.EventHandler(this.AddUser_button_Click);
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(778, 456);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(94, 29);
            this.buttonReturn.TabIndex = 16;
            this.buttonReturn.Text = "Return";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // labelDesignation
            // 
            this.labelDesignation.AutoSize = true;
            this.labelDesignation.Location = new System.Drawing.Point(62, 294);
            this.labelDesignation.Name = "labelDesignation";
            this.labelDesignation.Size = new System.Drawing.Size(89, 20);
            this.labelDesignation.TabIndex = 17;
            this.labelDesignation.Text = "Designation";
            // 
            // textBoxDesignation
            // 
            this.textBoxDesignation.Location = new System.Drawing.Point(197, 294);
            this.textBoxDesignation.Name = "textBoxDesignation";
            this.textBoxDesignation.Size = new System.Drawing.Size(386, 27);
            this.textBoxDesignation.TabIndex = 18;
            // 
            // buttonAccept
            // 
            this.buttonAccept.Location = new System.Drawing.Point(477, 454);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(94, 29);
            this.buttonAccept.TabIndex = 19;
            this.buttonAccept.Text = "Accept";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Visible = false;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // checkBoxAccepted
            // 
            this.checkBoxAccepted.AutoSize = true;
            this.checkBoxAccepted.Location = new System.Drawing.Point(720, 268);
            this.checkBoxAccepted.Name = "checkBoxAccepted";
            this.checkBoxAccepted.Size = new System.Drawing.Size(152, 24);
            this.checkBoxAccepted.TabIndex = 21;
            this.checkBoxAccepted.Text = "Acceptance Status";
            this.checkBoxAccepted.UseVisualStyleBackColor = true;
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 500);
            this.Controls.Add(this.checkBoxAccepted);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.textBoxDesignation);
            this.Controls.Add(this.labelDesignation);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.AddUser_button);
            this.Controls.Add(this.ClearUserFields_button);
            this.Controls.Add(this.comboBox_roles);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_confirmPassword);
            this.Controls.Add(this.labelCPW);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.labelPW);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_lastname);
            this.Controls.Add(this.textBox_firstname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.Users_dataGridView);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Users";
            this.Text = "Users";
            ((System.ComponentModel.ISupportInitialize)(this.Users_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Users_dataGridView;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_firstname;
        private System.Windows.Forms.TextBox textBox_lastname;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label labelPW;
        private System.Windows.Forms.TextBox textBox_confirmPassword;
        private System.Windows.Forms.Label labelCPW;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_roles;
        private System.Windows.Forms.Button ClearUserFields_button;
        private System.Windows.Forms.Button AddUser_button;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Label labelDesignation;
        private System.Windows.Forms.TextBox textBoxDesignation;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.CheckBox checkBoxAccepted;
    }
}