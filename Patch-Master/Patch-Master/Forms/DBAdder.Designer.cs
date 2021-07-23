namespace Patch_Master.Forms
{
    partial class DBAdder
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ConnectionIntregatedSecurity = new System.Windows.Forms.CheckBox();
            this.connectProgress = new System.Windows.Forms.ProgressBar();
            this.passWord = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.connectToDB = new System.Windows.Forms.Button();
            this.userName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ServerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DatabaseCheckList = new System.Windows.Forms.CheckedListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SavedDBChecklist = new System.Windows.Forms.CheckedListBox();
            this.btnSaveDB = new System.Windows.Forms.Button();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(318, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select and add the database into your system";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ConnectionIntregatedSecurity);
            this.groupBox1.Controls.Add(this.connectProgress);
            this.groupBox1.Controls.Add(this.passWord);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.connectToDB);
            this.groupBox1.Controls.Add(this.userName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ServerName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(29, 71);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(353, 492);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Test the connection";
            // 
            // ConnectionIntregatedSecurity
            // 
            this.ConnectionIntregatedSecurity.AutoSize = true;
            this.ConnectionIntregatedSecurity.Checked = true;
            this.ConnectionIntregatedSecurity.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ConnectionIntregatedSecurity.Location = new System.Drawing.Point(26, 151);
            this.ConnectionIntregatedSecurity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConnectionIntregatedSecurity.Name = "ConnectionIntregatedSecurity";
            this.ConnectionIntregatedSecurity.Size = new System.Drawing.Size(244, 24);
            this.ConnectionIntregatedSecurity.TabIndex = 8;
            this.ConnectionIntregatedSecurity.Text = "Use windows Intregated security";
            this.ConnectionIntregatedSecurity.UseVisualStyleBackColor = true;
            // 
            // connectProgress
            // 
            this.connectProgress.Location = new System.Drawing.Point(14, 420);
            this.connectProgress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.connectProgress.Name = "connectProgress";
            this.connectProgress.Size = new System.Drawing.Size(333, 27);
            this.connectProgress.TabIndex = 7;
            // 
            // passWord
            // 
            this.passWord.Location = new System.Drawing.Point(98, 265);
            this.passWord.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.passWord.Name = "passWord";
            this.passWord.Size = new System.Drawing.Size(247, 27);
            this.passWord.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Password";
            // 
            // connectToDB
            // 
            this.connectToDB.Location = new System.Drawing.Point(240, 347);
            this.connectToDB.Margin = new System.Windows.Forms.Padding(3, 13, 3, 13);
            this.connectToDB.Name = "connectToDB";
            this.connectToDB.Size = new System.Drawing.Size(113, 43);
            this.connectToDB.TabIndex = 4;
            this.connectToDB.Text = "Connect";
            this.connectToDB.UseVisualStyleBackColor = true;
            this.connectToDB.Click += new System.EventHandler(this.connectToDB_Click);
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(98, 208);
            this.userName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(247, 27);
            this.userName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "User name";
            // 
            // ServerName
            // 
            this.ServerName.Location = new System.Drawing.Point(98, 55);
            this.ServerName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ServerName.Name = "ServerName";
            this.ServerName.Size = new System.Drawing.Size(247, 27);
            this.ServerName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Server Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DatabaseCheckList);
            this.groupBox2.Location = new System.Drawing.Point(415, 71);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(190, 491);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Database list";
            // 
            // DatabaseCheckList
            // 
            this.DatabaseCheckList.FormattingEnabled = true;
            this.DatabaseCheckList.Location = new System.Drawing.Point(7, 31);
            this.DatabaseCheckList.Margin = new System.Windows.Forms.Padding(3, 13, 3, 13);
            this.DatabaseCheckList.Name = "DatabaseCheckList";
            this.DatabaseCheckList.Size = new System.Drawing.Size(177, 400);
            this.DatabaseCheckList.TabIndex = 0;
            this.DatabaseCheckList.SelectedIndexChanged += new System.EventHandler(this.DatabaseCheckList_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.SavedDBChecklist);
            this.groupBox3.Location = new System.Drawing.Point(657, 71);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(281, 489);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Saved databases";
            // 
            // SavedDBChecklist
            // 
            this.SavedDBChecklist.FormattingEnabled = true;
            this.SavedDBChecklist.Location = new System.Drawing.Point(63, 31);
            this.SavedDBChecklist.Margin = new System.Windows.Forms.Padding(3, 13, 3, 13);
            this.SavedDBChecklist.Name = "SavedDBChecklist";
            this.SavedDBChecklist.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.SavedDBChecklist.Size = new System.Drawing.Size(177, 400);
            this.SavedDBChecklist.TabIndex = 0;
            // 
            // btnSaveDB
            // 
            this.btnSaveDB.Location = new System.Drawing.Point(657, 568);
            this.btnSaveDB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSaveDB.Name = "btnSaveDB";
            this.btnSaveDB.Size = new System.Drawing.Size(113, 43);
            this.btnSaveDB.TabIndex = 4;
            this.btnSaveDB.Text = "Save";
            this.btnSaveDB.UseVisualStyleBackColor = true;
            this.btnSaveDB.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(826, 568);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(94, 43);
            this.buttonReturn.TabIndex = 5;
            this.buttonReturn.Text = "Return";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // DBAdder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 631);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.btnSaveDB);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DBAdder";
            this.Text = "DataBase Adder";
            this.Load += new System.EventHandler(this.DBAdder_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar connectProgress;
        private System.Windows.Forms.TextBox passWord;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button connectToDB;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ServerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSaveDB;
        private System.Windows.Forms.CheckedListBox DatabaseCheckList;
        private System.Windows.Forms.CheckedListBox SavedDBChecklist;
        private System.Windows.Forms.CheckBox ConnectionIntregatedSecurity;
        private System.Windows.Forms.Button buttonReturn;
        //private System.Windows.Forms.CheckedListBox dataBaseListCheckBox;
    }
}