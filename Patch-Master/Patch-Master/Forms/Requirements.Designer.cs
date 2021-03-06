
using System;

namespace Patch_Master.Forms
{
    partial class Requirements
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
            this.Requirements_groupBox = new System.Windows.Forms.GroupBox();
            this.comboBoxDatabase = new System.Windows.Forms.ComboBox();
            this.labelDatabase = new System.Windows.Forms.Label();
            this.ViewRequirement_button = new System.Windows.Forms.Button();
            this.SubProcess_comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Process_comboBox = new System.Windows.Forms.ComboBox();
            this.Process_label = new System.Windows.Forms.Label();
            this.DisplayRequirement_comboBox = new System.Windows.Forms.GroupBox();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.checkBoxQueryformulated = new System.Windows.Forms.CheckBox();
            this.textBoxCreatedDate = new System.Windows.Forms.TextBox();
            this.textBoxCreatedUser = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonModifyReq = new System.Windows.Forms.Button();
            this.ButtonNewReq = new System.Windows.Forms.Button();
            this.buttonViewQueries = new System.Windows.Forms.Button();
            this.ClearRequirement_button = new System.Windows.Forms.Button();
            this.DeleteRequiremet_button = new System.Windows.Forms.Button();
            this.Databases_comboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.RequirementObjective_richTextBox = new System.Windows.Forms.RichTextBox();
            this.Objective_label = new System.Windows.Forms.Label();
            this.RequirementDescription_richTextBox = new System.Windows.Forms.RichTextBox();
            this.Description_label = new System.Windows.Forms.Label();
            this.RequirementName_textBox = new System.Windows.Forms.TextBox();
            this.Requirement_label = new System.Windows.Forms.Label();
            this.Requirements_dataGridView = new System.Windows.Forms.DataGridView();
            this.richTextBoxObjective = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddRequirement_button = new System.Windows.Forms.Button();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxReqName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.RequirementDetails_groupBox = new System.Windows.Forms.GroupBox();
            this.RequirementDescriptionView_richTextBox = new System.Windows.Forms.RichTextBox();
            this.RequirementNameView_textBox = new System.Windows.Forms.TextBox();
            this.RequiremetDescriptionView_label = new System.Windows.Forms.Label();
            this.RequirementName_label = new System.Windows.Forms.Label();
            this.AddReqGroupBox = new System.Windows.Forms.GroupBox();
            this.Requirements_groupBox.SuspendLayout();
            this.DisplayRequirement_comboBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Requirements_dataGridView)).BeginInit();
            this.RequirementDetails_groupBox.SuspendLayout();
            this.AddReqGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Requirements_groupBox
            // 
            this.Requirements_groupBox.Controls.Add(this.comboBoxDatabase);
            this.Requirements_groupBox.Controls.Add(this.labelDatabase);
            this.Requirements_groupBox.Controls.Add(this.ViewRequirement_button);
            this.Requirements_groupBox.Controls.Add(this.SubProcess_comboBox);
            this.Requirements_groupBox.Controls.Add(this.label1);
            this.Requirements_groupBox.Controls.Add(this.Process_comboBox);
            this.Requirements_groupBox.Controls.Add(this.Process_label);
            this.Requirements_groupBox.Location = new System.Drawing.Point(14, 16);
            this.Requirements_groupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Requirements_groupBox.Name = "Requirements_groupBox";
            this.Requirements_groupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Requirements_groupBox.Size = new System.Drawing.Size(368, 231);
            this.Requirements_groupBox.TabIndex = 0;
            this.Requirements_groupBox.TabStop = false;
            this.Requirements_groupBox.Text = "Inquire Requirement";
            // 
            // comboBoxDatabase
            // 
            this.comboBoxDatabase.FormattingEnabled = true;
            this.comboBoxDatabase.Location = new System.Drawing.Point(117, 117);
            this.comboBoxDatabase.Name = "comboBoxDatabase";
            this.comboBoxDatabase.Size = new System.Drawing.Size(231, 28);
            this.comboBoxDatabase.TabIndex = 9;
            this.comboBoxDatabase.SelectedIndexChanged += new System.EventHandler(this.Database_comboBox_SelectedIndexChanged);
            // 
            // labelDatabase
            // 
            this.labelDatabase.AutoSize = true;
            this.labelDatabase.Location = new System.Drawing.Point(7, 117);
            this.labelDatabase.Name = "labelDatabase";
            this.labelDatabase.Size = new System.Drawing.Size(72, 20);
            this.labelDatabase.TabIndex = 8;
            this.labelDatabase.Text = "Database";
            // 
            // ViewRequirement_button
            // 
            this.ViewRequirement_button.Location = new System.Drawing.Point(262, 192);
            this.ViewRequirement_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ViewRequirement_button.Name = "ViewRequirement_button";
            this.ViewRequirement_button.Size = new System.Drawing.Size(86, 31);
            this.ViewRequirement_button.TabIndex = 5;
            this.ViewRequirement_button.Text = "View";
            this.ViewRequirement_button.UseVisualStyleBackColor = true;
            this.ViewRequirement_button.Click += new System.EventHandler(this.ViewRequirement_button_Click);
            // 
            // SubProcess_comboBox
            // 
            this.SubProcess_comboBox.FormattingEnabled = true;
            this.SubProcess_comboBox.Location = new System.Drawing.Point(117, 71);
            this.SubProcess_comboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SubProcess_comboBox.Name = "SubProcess_comboBox";
            this.SubProcess_comboBox.Size = new System.Drawing.Size(231, 28);
            this.SubProcess_comboBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sub Processes";
            // 
            // Process_comboBox
            // 
            this.Process_comboBox.FormattingEnabled = true;
            this.Process_comboBox.Location = new System.Drawing.Point(117, 35);
            this.Process_comboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Process_comboBox.Name = "Process_comboBox";
            this.Process_comboBox.Size = new System.Drawing.Size(231, 28);
            this.Process_comboBox.TabIndex = 2;
            this.Process_comboBox.SelectedIndexChanged += new System.EventHandler(this.Process_comboBox_SelectedIndexChanged);
            // 
            // Process_label
            // 
            this.Process_label.AutoSize = true;
            this.Process_label.Location = new System.Drawing.Point(7, 45);
            this.Process_label.Name = "Process_label";
            this.Process_label.Size = new System.Drawing.Size(72, 20);
            this.Process_label.TabIndex = 1;
            this.Process_label.Text = "Processes";
            // 
            // DisplayRequirement_comboBox
            // 
            this.DisplayRequirement_comboBox.Controls.Add(this.buttonReturn);
            this.DisplayRequirement_comboBox.Controls.Add(this.checkBoxQueryformulated);
            this.DisplayRequirement_comboBox.Controls.Add(this.textBoxCreatedDate);
            this.DisplayRequirement_comboBox.Controls.Add(this.textBoxCreatedUser);
            this.DisplayRequirement_comboBox.Controls.Add(this.label7);
            this.DisplayRequirement_comboBox.Controls.Add(this.label2);
            this.DisplayRequirement_comboBox.Controls.Add(this.buttonModifyReq);
            this.DisplayRequirement_comboBox.Controls.Add(this.ButtonNewReq);
            this.DisplayRequirement_comboBox.Controls.Add(this.buttonViewQueries);
            this.DisplayRequirement_comboBox.Controls.Add(this.ClearRequirement_button);
            this.DisplayRequirement_comboBox.Controls.Add(this.DeleteRequiremet_button);
            this.DisplayRequirement_comboBox.Controls.Add(this.Databases_comboBox);
            this.DisplayRequirement_comboBox.Controls.Add(this.label5);
            this.DisplayRequirement_comboBox.Controls.Add(this.RequirementObjective_richTextBox);
            this.DisplayRequirement_comboBox.Controls.Add(this.Objective_label);
            this.DisplayRequirement_comboBox.Controls.Add(this.RequirementDescription_richTextBox);
            this.DisplayRequirement_comboBox.Controls.Add(this.Description_label);
            this.DisplayRequirement_comboBox.Controls.Add(this.RequirementName_textBox);
            this.DisplayRequirement_comboBox.Controls.Add(this.Requirement_label);
            this.DisplayRequirement_comboBox.Controls.Add(this.Requirements_dataGridView);
            this.DisplayRequirement_comboBox.Location = new System.Drawing.Point(424, 31);
            this.DisplayRequirement_comboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DisplayRequirement_comboBox.Name = "DisplayRequirement_comboBox";
            this.DisplayRequirement_comboBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DisplayRequirement_comboBox.Size = new System.Drawing.Size(875, 688);
            this.DisplayRequirement_comboBox.TabIndex = 1;
            this.DisplayRequirement_comboBox.TabStop = false;
            this.DisplayRequirement_comboBox.Text = "Display Requirements";
            this.DisplayRequirement_comboBox.Visible = false;
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(754, 649);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(102, 28);
            this.buttonReturn.TabIndex = 21;
            this.buttonReturn.Text = "Return";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // checkBoxQueryformulated
            // 
            this.checkBoxQueryformulated.AutoSize = true;
            this.checkBoxQueryformulated.Location = new System.Drawing.Point(683, 395);
            this.checkBoxQueryformulated.Name = "checkBoxQueryformulated";
            this.checkBoxQueryformulated.Size = new System.Drawing.Size(150, 24);
            this.checkBoxQueryformulated.TabIndex = 20;
            this.checkBoxQueryformulated.Text = "Query Formulated";
            this.checkBoxQueryformulated.UseVisualStyleBackColor = true;
            // 
            // textBoxCreatedDate
            // 
            this.textBoxCreatedDate.Location = new System.Drawing.Point(683, 354);
            this.textBoxCreatedDate.Name = "textBoxCreatedDate";
            this.textBoxCreatedDate.ReadOnly = true;
            this.textBoxCreatedDate.Size = new System.Drawing.Size(143, 27);
            this.textBoxCreatedDate.TabIndex = 19;
            // 
            // textBoxCreatedUser
            // 
            this.textBoxCreatedUser.Location = new System.Drawing.Point(683, 319);
            this.textBoxCreatedUser.Name = "textBoxCreatedUser";
            this.textBoxCreatedUser.ReadOnly = true;
            this.textBoxCreatedUser.Size = new System.Drawing.Size(143, 27);
            this.textBoxCreatedUser.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(583, 357);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Created Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(583, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Created User";
            // 
            // buttonModifyReq
            // 
            this.buttonModifyReq.Location = new System.Drawing.Point(137, 650);
            this.buttonModifyReq.Name = "buttonModifyReq";
            this.buttonModifyReq.Size = new System.Drawing.Size(127, 29);
            this.buttonModifyReq.TabIndex = 15;
            this.buttonModifyReq.Text = "Modify Req";
            this.buttonModifyReq.UseVisualStyleBackColor = true;
            this.buttonModifyReq.Visible = false;
            this.buttonModifyReq.Click += new System.EventHandler(this.buttonModifyReq_Click);
            // 
            // ButtonNewReq
            // 
            this.ButtonNewReq.Location = new System.Drawing.Point(12, 649);
            this.ButtonNewReq.Name = "ButtonNewReq";
            this.ButtonNewReq.Size = new System.Drawing.Size(119, 29);
            this.ButtonNewReq.TabIndex = 14;
            this.ButtonNewReq.Text = "New Req";
            this.ButtonNewReq.UseVisualStyleBackColor = true;
            this.ButtonNewReq.Visible = false;
            this.ButtonNewReq.Click += new System.EventHandler(this.ButtonNewReq_Click);
            // 
            // buttonViewQueries
            // 
            this.buttonViewQueries.Location = new System.Drawing.Point(583, 647);
            this.buttonViewQueries.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonViewQueries.Name = "buttonViewQueries";
            this.buttonViewQueries.Size = new System.Drawing.Size(122, 31);
            this.buttonViewQueries.TabIndex = 13;
            this.buttonViewQueries.Text = "View Queries";
            this.buttonViewQueries.UseVisualStyleBackColor = true;
            this.buttonViewQueries.Visible = false;
            this.buttonViewQueries.Click += new System.EventHandler(this.ViewQueries_button_Click);
            // 
            // ClearRequirement_button
            // 
            this.ClearRequirement_button.Location = new System.Drawing.Point(480, 648);
            this.ClearRequirement_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ClearRequirement_button.Name = "ClearRequirement_button";
            this.ClearRequirement_button.Size = new System.Drawing.Size(86, 31);
            this.ClearRequirement_button.TabIndex = 12;
            this.ClearRequirement_button.Text = "Clear";
            this.ClearRequirement_button.UseVisualStyleBackColor = true;
            this.ClearRequirement_button.Visible = false;
            this.ClearRequirement_button.Click += new System.EventHandler(this.ClearRequirement_button_Click);
            // 
            // DeleteRequiremet_button
            // 
            this.DeleteRequiremet_button.Location = new System.Drawing.Point(270, 647);
            this.DeleteRequiremet_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DeleteRequiremet_button.Name = "DeleteRequiremet_button";
            this.DeleteRequiremet_button.Size = new System.Drawing.Size(100, 31);
            this.DeleteRequiremet_button.TabIndex = 11;
            this.DeleteRequiremet_button.Text = "Delete Req";
            this.DeleteRequiremet_button.UseVisualStyleBackColor = true;
            this.DeleteRequiremet_button.Visible = false;
            this.DeleteRequiremet_button.Click += new System.EventHandler(this.DeleteRequiremet_button_Click);
            // 
            // Databases_comboBox
            // 
            this.Databases_comboBox.Enabled = false;
            this.Databases_comboBox.FormattingEnabled = true;
            this.Databases_comboBox.Location = new System.Drawing.Point(99, 357);
            this.Databases_comboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Databases_comboBox.Name = "Databases_comboBox";
            this.Databases_comboBox.Size = new System.Drawing.Size(165, 28);
            this.Databases_comboBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Database";
            // 
            // RequirementObjective_richTextBox
            // 
            this.RequirementObjective_richTextBox.Location = new System.Drawing.Point(99, 393);
            this.RequirementObjective_richTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RequirementObjective_richTextBox.Name = "RequirementObjective_richTextBox";
            this.RequirementObjective_richTextBox.Size = new System.Drawing.Size(443, 122);
            this.RequirementObjective_richTextBox.TabIndex = 6;
            this.RequirementObjective_richTextBox.Text = "";
            // 
            // Objective_label
            // 
            this.Objective_label.AutoSize = true;
            this.Objective_label.Location = new System.Drawing.Point(18, 428);
            this.Objective_label.Name = "Objective_label";
            this.Objective_label.Size = new System.Drawing.Size(72, 20);
            this.Objective_label.TabIndex = 5;
            this.Objective_label.Text = "Objective";
            // 
            // RequirementDescription_richTextBox
            // 
            this.RequirementDescription_richTextBox.Location = new System.Drawing.Point(99, 523);
            this.RequirementDescription_richTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RequirementDescription_richTextBox.Name = "RequirementDescription_richTextBox";
            this.RequirementDescription_richTextBox.Size = new System.Drawing.Size(443, 118);
            this.RequirementDescription_richTextBox.TabIndex = 4;
            this.RequirementDescription_richTextBox.Text = "";
            // 
            // Description_label
            // 
            this.Description_label.AutoSize = true;
            this.Description_label.Location = new System.Drawing.Point(17, 536);
            this.Description_label.Name = "Description_label";
            this.Description_label.Size = new System.Drawing.Size(85, 20);
            this.Description_label.TabIndex = 3;
            this.Description_label.Text = "Description";
            // 
            // RequirementName_textBox
            // 
            this.RequirementName_textBox.Location = new System.Drawing.Point(99, 322);
            this.RequirementName_textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RequirementName_textBox.Name = "RequirementName_textBox";
            this.RequirementName_textBox.ReadOnly = true;
            this.RequirementName_textBox.Size = new System.Drawing.Size(165, 27);
            this.RequirementName_textBox.TabIndex = 2;
            // 
            // Requirement_label
            // 
            this.Requirement_label.AutoSize = true;
            this.Requirement_label.Location = new System.Drawing.Point(17, 322);
            this.Requirement_label.Name = "Requirement_label";
            this.Requirement_label.Size = new System.Drawing.Size(49, 20);
            this.Requirement_label.TabIndex = 1;
            this.Requirement_label.Text = "Name";
            // 
            // Requirements_dataGridView
            // 
            this.Requirements_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Requirements_dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.Requirements_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Requirements_dataGridView.Location = new System.Drawing.Point(17, 28);
            this.Requirements_dataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Requirements_dataGridView.Name = "Requirements_dataGridView";
            this.Requirements_dataGridView.RowHeadersWidth = 51;
            this.Requirements_dataGridView.RowTemplate.Height = 25;
            this.Requirements_dataGridView.Size = new System.Drawing.Size(852, 267);
            this.Requirements_dataGridView.TabIndex = 0;
            this.Requirements_dataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Requirements_dataGridView_RowHeaderMouseClick);
            // 
            // richTextBoxObjective
            // 
            this.richTextBoxObjective.Location = new System.Drawing.Point(111, 59);
            this.richTextBoxObjective.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextBoxObjective.Name = "richTextBoxObjective";
            this.richTextBoxObjective.Size = new System.Drawing.Size(443, 122);
            this.richTextBoxObjective.TabIndex = 15;
            this.richTextBoxObjective.Text = "";
            this.richTextBoxObjective.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Objective";
            this.label3.UseWaitCursor = true;
            // 
            // AddRequirement_button
            // 
            this.AddRequirement_button.Location = new System.Drawing.Point(262, 330);
            this.AddRequirement_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddRequirement_button.Name = "AddRequirement_button";
            this.AddRequirement_button.Size = new System.Drawing.Size(86, 31);
            this.AddRequirement_button.TabIndex = 10;
            this.AddRequirement_button.Text = "Add";
            this.AddRequirement_button.UseVisualStyleBackColor = true;
            this.AddRequirement_button.UseWaitCursor = true;
            this.AddRequirement_button.Click += new System.EventHandler(this.AddRequirement_button_Click);
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Location = new System.Drawing.Point(111, 189);
            this.richTextBoxDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(443, 118);
            this.richTextBoxDescription.TabIndex = 13;
            this.richTextBoxDescription.Text = "";
            this.richTextBoxDescription.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Description";
            this.label4.UseWaitCursor = true;
            // 
            // textBoxReqName
            // 
            this.textBoxReqName.Location = new System.Drawing.Point(111, 24);
            this.textBoxReqName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxReqName.Name = "textBoxReqName";
            this.textBoxReqName.Size = new System.Drawing.Size(165, 27);
            this.textBoxReqName.TabIndex = 11;
            this.textBoxReqName.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Name";
            this.label6.UseWaitCursor = true;
            // 
            // RequirementDetails_groupBox
            // 
            this.RequirementDetails_groupBox.Controls.Add(this.RequirementDescriptionView_richTextBox);
            this.RequirementDetails_groupBox.Controls.Add(this.RequirementNameView_textBox);
            this.RequirementDetails_groupBox.Controls.Add(this.RequiremetDescriptionView_label);
            this.RequirementDetails_groupBox.Controls.Add(this.RequirementName_label);
            this.RequirementDetails_groupBox.Location = new System.Drawing.Point(14, 255);
            this.RequirementDetails_groupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RequirementDetails_groupBox.Name = "RequirementDetails_groupBox";
            this.RequirementDetails_groupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RequirementDetails_groupBox.Size = new System.Drawing.Size(368, 347);
            this.RequirementDetails_groupBox.TabIndex = 2;
            this.RequirementDetails_groupBox.TabStop = false;
            this.RequirementDetails_groupBox.Text = "Requirement Details";
            this.RequirementDetails_groupBox.Visible = false;
            // 
            // RequirementDescriptionView_richTextBox
            // 
            this.RequirementDescriptionView_richTextBox.Location = new System.Drawing.Point(117, 101);
            this.RequirementDescriptionView_richTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RequirementDescriptionView_richTextBox.Name = "RequirementDescriptionView_richTextBox";
            this.RequirementDescriptionView_richTextBox.ReadOnly = true;
            this.RequirementDescriptionView_richTextBox.Size = new System.Drawing.Size(230, 117);
            this.RequirementDescriptionView_richTextBox.TabIndex = 7;
            this.RequirementDescriptionView_richTextBox.Text = "";
            // 
            // RequirementNameView_textBox
            // 
            this.RequirementNameView_textBox.Location = new System.Drawing.Point(117, 45);
            this.RequirementNameView_textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RequirementNameView_textBox.Name = "RequirementNameView_textBox";
            this.RequirementNameView_textBox.ReadOnly = true;
            this.RequirementNameView_textBox.Size = new System.Drawing.Size(230, 27);
            this.RequirementNameView_textBox.TabIndex = 6;
            // 
            // RequiremetDescriptionView_label
            // 
            this.RequiremetDescriptionView_label.AutoSize = true;
            this.RequiremetDescriptionView_label.Location = new System.Drawing.Point(7, 101);
            this.RequiremetDescriptionView_label.Name = "RequiremetDescriptionView_label";
            this.RequiremetDescriptionView_label.Size = new System.Drawing.Size(85, 20);
            this.RequiremetDescriptionView_label.TabIndex = 3;
            this.RequiremetDescriptionView_label.Text = "Description";
            // 
            // RequirementName_label
            // 
            this.RequirementName_label.AutoSize = true;
            this.RequirementName_label.Location = new System.Drawing.Point(7, 45);
            this.RequirementName_label.Name = "RequirementName_label";
            this.RequirementName_label.Size = new System.Drawing.Size(94, 20);
            this.RequirementName_label.TabIndex = 1;
            this.RequirementName_label.Text = "Requirement";
            // 
            // AddReqGroupBox
            // 
            this.AddReqGroupBox.Controls.Add(this.label6);
            this.AddReqGroupBox.Controls.Add(this.textBoxReqName);
            this.AddReqGroupBox.Controls.Add(this.richTextBoxObjective);
            this.AddReqGroupBox.Controls.Add(this.label4);
            this.AddReqGroupBox.Controls.Add(this.label3);
            this.AddReqGroupBox.Controls.Add(this.richTextBoxDescription);
            this.AddReqGroupBox.Controls.Add(this.AddRequirement_button);
            this.AddReqGroupBox.Location = new System.Drawing.Point(436, 12);
            this.AddReqGroupBox.Name = "AddReqGroupBox";
            this.AddReqGroupBox.Size = new System.Drawing.Size(621, 405);
            this.AddReqGroupBox.TabIndex = 19;
            this.AddReqGroupBox.TabStop = false;
            this.AddReqGroupBox.Text = "Add Requirments";
            this.AddReqGroupBox.Visible = false;
            // 
            // Requirements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 787);
            this.Controls.Add(this.AddReqGroupBox);
            this.Controls.Add(this.RequirementDetails_groupBox);
            this.Controls.Add(this.DisplayRequirement_comboBox);
            this.Controls.Add(this.Requirements_groupBox);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Requirements";
            this.Text = "Requirements";
            this.Load += new System.EventHandler(this.Requirements_Load);
            this.Requirements_groupBox.ResumeLayout(false);
            this.Requirements_groupBox.PerformLayout();
            this.DisplayRequirement_comboBox.ResumeLayout(false);
            this.DisplayRequirement_comboBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Requirements_dataGridView)).EndInit();
            this.RequirementDetails_groupBox.ResumeLayout(false);
            this.RequirementDetails_groupBox.PerformLayout();
            this.AddReqGroupBox.ResumeLayout(false);
            this.AddReqGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Requirements_groupBox;
        private System.Windows.Forms.Label Process_label;
        private System.Windows.Forms.ComboBox SubProcess_comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Process_comboBox;
        private System.Windows.Forms.Button ViewRequirement_button;
        private System.Windows.Forms.GroupBox DisplayRequirement_comboBox;
        private System.Windows.Forms.DataGridView Requirements_dataGridView;
        private System.Windows.Forms.Button ClearRequirement_button;
        private System.Windows.Forms.Button DeleteRequiremet_button;
        private System.Windows.Forms.Button AddRequirement_button;
        private System.Windows.Forms.ComboBox Databases_comboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox RequirementObjective_richTextBox;
        private System.Windows.Forms.Label Objective_label;
        private System.Windows.Forms.RichTextBox RequirementDescription_richTextBox;
        private System.Windows.Forms.Label Description_label;
        private System.Windows.Forms.TextBox RequirementName_textBox;
        private System.Windows.Forms.Label Requirement_label;
        private System.Windows.Forms.Button buttonViewQueries;
        private System.Windows.Forms.GroupBox RequirementDetails_groupBox;
        private System.Windows.Forms.RichTextBox RequirementDescriptionView_richTextBox;
        private System.Windows.Forms.TextBox RequirementNameView_textBox;
        private System.Windows.Forms.Label RequiremetDescriptionView_label;
        private System.Windows.Forms.Label RequirementName_label;
        private System.Windows.Forms.ComboBox comboBoxDatabase;
        private System.Windows.Forms.Label labelDatabase;
        private System.Windows.Forms.RichTextBox richTextBoxObjective;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxReqName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ButtonNewReq;
        private System.Windows.Forms.GroupBox AddReqGroupBox;
        private System.Windows.Forms.Button buttonModifyReq;
        private System.Windows.Forms.TextBox textBoxCreatedDate;
        private System.Windows.Forms.TextBox textBoxCreatedUser;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxQueryformulated;
        private System.Windows.Forms.Button buttonReturn;
    }
}