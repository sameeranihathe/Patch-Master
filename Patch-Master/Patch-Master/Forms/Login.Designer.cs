
namespace Patch_Master.Forms
{
    partial class Login
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
            this.UserName = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.button_login = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.textBox_UserName = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.pictureBox_Login = new System.Windows.Forms.PictureBox();
            this.label_errorMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Login)).BeginInit();
            this.SuspendLayout();
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserName.Location = new System.Drawing.Point(305, 133);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(104, 28);
            this.UserName.TabIndex = 0;
            this.UserName.Text = "User name";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Password.Location = new System.Drawing.Point(305, 205);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(93, 28);
            this.Password.TabIndex = 1;
            this.Password.Text = "Password";
            // 
            // button_login
            // 
            this.button_login.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_login.Location = new System.Drawing.Point(323, 327);
            this.button_login.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(97, 49);
            this.button_login.TabIndex = 2;
            this.button_login.Text = "Login";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Cancel.Location = new System.Drawing.Point(526, 327);
            this.button_Cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(89, 49);
            this.button_Cancel.TabIndex = 3;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // textBox_UserName
            // 
            this.textBox_UserName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_UserName.Location = new System.Drawing.Point(432, 123);
            this.textBox_UserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_UserName.Name = "textBox_UserName";
            this.textBox_UserName.Size = new System.Drawing.Size(197, 34);
            this.textBox_UserName.TabIndex = 4;
            // 
            // textBox_Password
            // 
            this.textBox_Password.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_Password.HideSelection = false;
            this.textBox_Password.Location = new System.Drawing.Point(432, 195);
            this.textBox_Password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.PasswordChar = '*';
            this.textBox_Password.Size = new System.Drawing.Size(197, 34);
            this.textBox_Password.TabIndex = 5;
            this.textBox_Password.UseSystemPasswordChar = true;
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoginLabel.Location = new System.Drawing.Point(311, 42);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(318, 41);
            this.LoginLabel.TabIndex = 6;
            this.LoginLabel.Text = "Login to PatchMaster";
            // 
            // pictureBox_Login
            // 
            this.pictureBox_Login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_Login.Location = new System.Drawing.Point(34, 54);
            this.pictureBox_Login.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox_Login.Name = "pictureBox_Login";
            this.pictureBox_Login.Size = new System.Drawing.Size(200, 201);
            this.pictureBox_Login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Login.TabIndex = 7;
            this.pictureBox_Login.TabStop = false;
            // 
            // label_errorMessage
            // 
            this.label_errorMessage.AutoSize = true;
            this.label_errorMessage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_errorMessage.ForeColor = System.Drawing.Color.Red;
            this.label_errorMessage.Location = new System.Drawing.Point(305, 270);
            this.label_errorMessage.Name = "label_errorMessage";
            this.label_errorMessage.Size = new System.Drawing.Size(310, 23);
            this.label_errorMessage.TabIndex = 8;
            this.label_errorMessage.Text = "Username and password do not match.";
            this.label_errorMessage.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 432);
            this.Controls.Add(this.label_errorMessage);
            this.Controls.Add(this.pictureBox_Login);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_UserName);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.UserName);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Login)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.TextBox textBox_UserName;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.PictureBox pictureBox_Login;
        private System.Windows.Forms.Label label_errorMessage;
    }
}