
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
            this.ViewRequirement_button = new System.Windows.Forms.Button();
            this.SubProcess_comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Process_comboBox = new System.Windows.Forms.ComboBox();
            this.Process_label = new System.Windows.Forms.Label();
            this.DisplayRequirement_comboBox = new System.Windows.Forms.GroupBox();
            this.DisplayQueries_groupBox = new System.Windows.Forms.GroupBox();
            this.Returm_button = new System.Windows.Forms.Button();
            this.Queries_dataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.ClearRequirement_button = new System.Windows.Forms.Button();
            this.DeleteRequiremet_button = new System.Windows.Forms.Button();
            this.AddRequirement_button = new System.Windows.Forms.Button();
            this.Databases_comboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.RequirementObjective_richTextBox = new System.Windows.Forms.RichTextBox();
            this.Objective_label = new System.Windows.Forms.Label();
            this.RequirementDescription_richTextBox = new System.Windows.Forms.RichTextBox();
            this.Description_label = new System.Windows.Forms.Label();
            this.RequirementName_textBox = new System.Windows.Forms.TextBox();
            this.Requirement_label = new System.Windows.Forms.Label();
            this.Requirements_dataGridView = new System.Windows.Forms.DataGridView();
            this.RequirementDetails_groupBox = new System.Windows.Forms.GroupBox();
            this.RequirementDescriptionView_richTextBox = new System.Windows.Forms.RichTextBox();
            this.RequirementNameView_textBox = new System.Windows.Forms.TextBox();
            this.RequiremetDescriptionView_label = new System.Windows.Forms.Label();
            this.RequirementName_label = new System.Windows.Forms.Label();
            this.Requirements_groupBox.SuspendLayout();
            this.DisplayRequirement_comboBox.SuspendLayout();
            this.DisplayQueries_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Queries_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Requirements_dataGridView)).BeginInit();
            this.RequirementDetails_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Requirements_groupBox
            // 
            this.Requirements_groupBox.Controls.Add(this.ViewRequirement_button);
            this.Requirements_groupBox.Controls.Add(this.SubProcess_comboBox);
            this.Requirements_groupBox.Controls.Add(this.label1);
            this.Requirements_groupBox.Controls.Add(this.Process_comboBox);
            this.Requirements_groupBox.Controls.Add(this.Process_label);
            this.Requirements_groupBox.Location = new System.Drawing.Point(12, 12);
            this.Requirements_groupBox.Name = "Requirements_groupBox";
            this.Requirements_groupBox.Size = new System.Drawing.Size(322, 150);
            this.Requirements_groupBox.TabIndex = 0;
            this.Requirements_groupBox.TabStop = false;
            this.Requirements_groupBox.Text = "Inquire Requirement";
            // 
            // ViewRequirement_button
            // 
            this.ViewRequirement_button.Location = new System.Drawing.Point(229, 109);
            this.ViewRequirement_button.Name = "ViewRequirement_button";
            this.ViewRequirement_button.Size = new System.Drawing.Size(75, 23);
            this.ViewRequirement_button.TabIndex = 5;
            this.ViewRequirement_button.Text = "View";
            this.ViewRequirement_button.UseVisualStyleBackColor = true;
            this.ViewRequirement_button.Click += new System.EventHandler(this.ViewRequirement_button_Click);
            // 
            // SubProcess_comboBox
            // 
            this.SubProcess_comboBox.FormattingEnabled = true;
            this.SubProcess_comboBox.Location = new System.Drawing.Point(102, 68);
            this.SubProcess_comboBox.Name = "SubProcess_comboBox";
            this.SubProcess_comboBox.Size = new System.Drawing.Size(203, 23);
            this.SubProcess_comboBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sub Processes";
            // 
            // Process_comboBox
            // 
            this.Process_comboBox.FormattingEnabled = true;
            this.Process_comboBox.Location = new System.Drawing.Point(102, 26);
            this.Process_comboBox.Name = "Process_comboBox";
            this.Process_comboBox.Size = new System.Drawing.Size(203, 23);
            this.Process_comboBox.TabIndex = 2;
            this.Process_comboBox.SelectedIndexChanged += new System.EventHandler(this.Process_comboBox_SelectedIndexChanged);
            // 
            // Process_label
            // 
            this.Process_label.AutoSize = true;
            this.Process_label.Location = new System.Drawing.Point(6, 34);
            this.Process_label.Name = "Process_label";
            this.Process_label.Size = new System.Drawing.Size(58, 15);
            this.Process_label.TabIndex = 1;
            this.Process_label.Text = "Processes";
            // 
            // DisplayRequirement_comboBox
            // 
            this.DisplayRequirement_comboBox.Controls.Add(this.DisplayQueries_groupBox);
            this.DisplayRequirement_comboBox.Controls.Add(this.button1);
            this.DisplayRequirement_comboBox.Controls.Add(this.ClearRequirement_button);
            this.DisplayRequirement_comboBox.Controls.Add(this.DeleteRequiremet_button);
            this.DisplayRequirement_comboBox.Controls.Add(this.AddRequirement_button);
            this.DisplayRequirement_comboBox.Controls.Add(this.Databases_comboBox);
            this.DisplayRequirement_comboBox.Controls.Add(this.label5);
            this.DisplayRequirement_comboBox.Controls.Add(this.RequirementObjective_richTextBox);
            this.DisplayRequirement_comboBox.Controls.Add(this.Objective_label);
            this.DisplayRequirement_comboBox.Controls.Add(this.RequirementDescription_richTextBox);
            this.DisplayRequirement_comboBox.Controls.Add(this.Description_label);
            this.DisplayRequirement_comboBox.Controls.Add(this.RequirementName_textBox);
            this.DisplayRequirement_comboBox.Controls.Add(this.Requirement_label);
            this.DisplayRequirement_comboBox.Controls.Add(this.Requirements_dataGridView);
            this.DisplayRequirement_comboBox.Location = new System.Drawing.Point(355, 12);
            this.DisplayRequirement_comboBox.Name = "DisplayRequirement_comboBox";
            this.DisplayRequirement_comboBox.Size = new System.Drawing.Size(705, 474);
            this.DisplayRequirement_comboBox.TabIndex = 1;
            this.DisplayRequirement_comboBox.TabStop = false;
            this.DisplayRequirement_comboBox.Text = "Display Requirements";
            this.DisplayRequirement_comboBox.Visible = false;
            // 
            // DisplayQueries_groupBox
            // 
            this.DisplayQueries_groupBox.Controls.Add(this.Returm_button);
            this.DisplayQueries_groupBox.Controls.Add(this.Queries_dataGridView);
            this.DisplayQueries_groupBox.Location = new System.Drawing.Point(0, 0);
            this.DisplayQueries_groupBox.Name = "DisplayQueries_groupBox";
            this.DisplayQueries_groupBox.Size = new System.Drawing.Size(705, 468);
            this.DisplayQueries_groupBox.TabIndex = 3;
            this.DisplayQueries_groupBox.TabStop = false;
            this.DisplayQueries_groupBox.Text = "Display Queries";
            this.DisplayQueries_groupBox.Visible = false;
            // 
            // Returm_button
            // 
            this.Returm_button.Location = new System.Drawing.Point(440, 190);
            this.Returm_button.Name = "Returm_button";
            this.Returm_button.Size = new System.Drawing.Size(75, 23);
            this.Returm_button.TabIndex = 1;
            this.Returm_button.Text = "Returm";
            this.Returm_button.UseVisualStyleBackColor = true;
            this.Returm_button.Click += new System.EventHandler(this.Returm_button_Click);
            // 
            // Queries_dataGridView
            // 
            this.Queries_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Queries_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Queries_dataGridView.Location = new System.Drawing.Point(23, 22);
            this.Queries_dataGridView.Name = "Queries_dataGridView";
            this.Queries_dataGridView.RowTemplate.Height = 25;
            this.Queries_dataGridView.Size = new System.Drawing.Size(492, 124);
            this.Queries_dataGridView.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(613, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "View Queries";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ViewQueries_button_Click);
            // 
            // ClearRequirement_button
            // 
            this.ClearRequirement_button.Location = new System.Drawing.Point(539, 430);
            this.ClearRequirement_button.Name = "ClearRequirement_button";
            this.ClearRequirement_button.Size = new System.Drawing.Size(75, 23);
            this.ClearRequirement_button.TabIndex = 12;
            this.ClearRequirement_button.Text = "Clear";
            this.ClearRequirement_button.UseVisualStyleBackColor = true;
            this.ClearRequirement_button.Click += new System.EventHandler(this.ClearRequirement_button_Click);
            // 
            // DeleteRequiremet_button
            // 
            this.DeleteRequiremet_button.Location = new System.Drawing.Point(447, 430);
            this.DeleteRequiremet_button.Name = "DeleteRequiremet_button";
            this.DeleteRequiremet_button.Size = new System.Drawing.Size(75, 23);
            this.DeleteRequiremet_button.TabIndex = 11;
            this.DeleteRequiremet_button.Text = "Delete";
            this.DeleteRequiremet_button.UseVisualStyleBackColor = true;
            this.DeleteRequiremet_button.Click += new System.EventHandler(this.DeleteRequiremet_button_Click);
            // 
            // AddRequirement_button
            // 
            this.AddRequirement_button.Location = new System.Drawing.Point(356, 430);
            this.AddRequirement_button.Name = "AddRequirement_button";
            this.AddRequirement_button.Size = new System.Drawing.Size(75, 23);
            this.AddRequirement_button.TabIndex = 10;
            this.AddRequirement_button.Text = "Add";
            this.AddRequirement_button.UseVisualStyleBackColor = true;
            this.AddRequirement_button.Click += new System.EventHandler(this.AddRequirement_button_Click);
            // 
            // Databases_comboBox
            // 
            this.Databases_comboBox.FormattingEnabled = true;
            this.Databases_comboBox.Location = new System.Drawing.Point(400, 240);
            this.Databases_comboBox.Name = "Databases_comboBox";
            this.Databases_comboBox.Size = new System.Drawing.Size(145, 23);
            this.Databases_comboBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(324, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Database";
            // 
            // RequirementObjective_richTextBox
            // 
            this.RequirementObjective_richTextBox.Location = new System.Drawing.Point(78, 374);
            this.RequirementObjective_richTextBox.Name = "RequirementObjective_richTextBox";
            this.RequirementObjective_richTextBox.Size = new System.Drawing.Size(204, 79);
            this.RequirementObjective_richTextBox.TabIndex = 6;
            this.RequirementObjective_richTextBox.Text = "";
            // 
            // Objective_label
            // 
            this.Objective_label.AutoSize = true;
            this.Objective_label.Location = new System.Drawing.Point(7, 377);
            this.Objective_label.Name = "Objective_label";
            this.Objective_label.Size = new System.Drawing.Size(57, 15);
            this.Objective_label.TabIndex = 5;
            this.Objective_label.Text = "Objective";
            // 
            // RequirementDescription_richTextBox
            // 
            this.RequirementDescription_richTextBox.Location = new System.Drawing.Point(78, 280);
            this.RequirementDescription_richTextBox.Name = "RequirementDescription_richTextBox";
            this.RequirementDescription_richTextBox.Size = new System.Drawing.Size(204, 79);
            this.RequirementDescription_richTextBox.TabIndex = 4;
            this.RequirementDescription_richTextBox.Text = "";
            // 
            // Description_label
            // 
            this.Description_label.AutoSize = true;
            this.Description_label.Location = new System.Drawing.Point(6, 280);
            this.Description_label.Name = "Description_label";
            this.Description_label.Size = new System.Drawing.Size(67, 15);
            this.Description_label.TabIndex = 3;
            this.Description_label.Text = "Description";
            // 
            // RequirementName_textBox
            // 
            this.RequirementName_textBox.Location = new System.Drawing.Point(78, 240);
            this.RequirementName_textBox.Name = "RequirementName_textBox";
            this.RequirementName_textBox.Size = new System.Drawing.Size(145, 23);
            this.RequirementName_textBox.TabIndex = 2;
            // 
            // Requirement_label
            // 
            this.Requirement_label.AutoSize = true;
            this.Requirement_label.Location = new System.Drawing.Point(6, 240);
            this.Requirement_label.Name = "Requirement_label";
            this.Requirement_label.Size = new System.Drawing.Size(39, 15);
            this.Requirement_label.TabIndex = 1;
            this.Requirement_label.Text = "Name";
            // 
            // Requirements_dataGridView
            // 
            this.Requirements_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Requirements_dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.Requirements_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Requirements_dataGridView.Location = new System.Drawing.Point(6, 26);
            this.Requirements_dataGridView.Name = "Requirements_dataGridView";
            this.Requirements_dataGridView.RowTemplate.Height = 25;
            this.Requirements_dataGridView.Size = new System.Drawing.Size(591, 200);
            this.Requirements_dataGridView.TabIndex = 0;
            // 
            // RequirementDetails_groupBox
            // 
            this.RequirementDetails_groupBox.Controls.Add(this.RequirementDescriptionView_richTextBox);
            this.RequirementDetails_groupBox.Controls.Add(this.RequirementNameView_textBox);
            this.RequirementDetails_groupBox.Controls.Add(this.RequiremetDescriptionView_label);
            this.RequirementDetails_groupBox.Controls.Add(this.RequirementName_label);
            this.RequirementDetails_groupBox.Location = new System.Drawing.Point(12, 191);
            this.RequirementDetails_groupBox.Name = "RequirementDetails_groupBox";
            this.RequirementDetails_groupBox.Size = new System.Drawing.Size(322, 260);
            this.RequirementDetails_groupBox.TabIndex = 2;
            this.RequirementDetails_groupBox.TabStop = false;
            this.RequirementDetails_groupBox.Text = "Requirement Details";
            this.RequirementDetails_groupBox.Visible = false;
            // 
            // RequirementDescriptionView_richTextBox
            // 
            this.RequirementDescriptionView_richTextBox.Location = new System.Drawing.Point(102, 76);
            this.RequirementDescriptionView_richTextBox.Name = "RequirementDescriptionView_richTextBox";
            this.RequirementDescriptionView_richTextBox.ReadOnly = true;
            this.RequirementDescriptionView_richTextBox.Size = new System.Drawing.Size(202, 89);
            this.RequirementDescriptionView_richTextBox.TabIndex = 7;
            this.RequirementDescriptionView_richTextBox.Text = "";
            // 
            // RequirementNameView_textBox
            // 
            this.RequirementNameView_textBox.Location = new System.Drawing.Point(102, 34);
            this.RequirementNameView_textBox.Name = "RequirementNameView_textBox";
            this.RequirementNameView_textBox.ReadOnly = true;
            this.RequirementNameView_textBox.Size = new System.Drawing.Size(202, 23);
            this.RequirementNameView_textBox.TabIndex = 6;
            // 
            // RequiremetDescriptionView_label
            // 
            this.RequiremetDescriptionView_label.AutoSize = true;
            this.RequiremetDescriptionView_label.Location = new System.Drawing.Point(6, 76);
            this.RequiremetDescriptionView_label.Name = "RequiremetDescriptionView_label";
            this.RequiremetDescriptionView_label.Size = new System.Drawing.Size(67, 15);
            this.RequiremetDescriptionView_label.TabIndex = 3;
            this.RequiremetDescriptionView_label.Text = "Description";
            // 
            // RequirementName_label
            // 
            this.RequirementName_label.AutoSize = true;
            this.RequirementName_label.Location = new System.Drawing.Point(6, 34);
            this.RequirementName_label.Name = "RequirementName_label";
            this.RequirementName_label.Size = new System.Drawing.Size(75, 15);
            this.RequirementName_label.TabIndex = 1;
            this.RequirementName_label.Text = "Requirement";
            // 
            // Requirements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 498);
            this.Controls.Add(this.RequirementDetails_groupBox);
            this.Controls.Add(this.DisplayRequirement_comboBox);
            this.Controls.Add(this.Requirements_groupBox);
            this.Name = "Requirements";
            this.Text = "Requirements";
            this.Load += new System.EventHandler(this.Requirements_Load);
            this.Requirements_groupBox.ResumeLayout(false);
            this.Requirements_groupBox.PerformLayout();
            this.DisplayRequirement_comboBox.ResumeLayout(false);
            this.DisplayRequirement_comboBox.PerformLayout();
            this.DisplayQueries_groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Queries_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Requirements_dataGridView)).EndInit();
            this.RequirementDetails_groupBox.ResumeLayout(false);
            this.RequirementDetails_groupBox.PerformLayout();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox RequirementDetails_groupBox;
        private System.Windows.Forms.RichTextBox RequirementDescriptionView_richTextBox;
        private System.Windows.Forms.TextBox RequirementNameView_textBox;
        private System.Windows.Forms.Label RequiremetDescriptionView_label;
        private System.Windows.Forms.Label RequirementName_label;
        private System.Windows.Forms.GroupBox DisplayQueries_groupBox;
        private System.Windows.Forms.DataGridView Queries_dataGridView;
        private System.Windows.Forms.Button Returm_button;
    }
}