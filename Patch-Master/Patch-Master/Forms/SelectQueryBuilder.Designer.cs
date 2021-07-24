namespace Patch_Master.Forms
{
    partial class SelectQueryBuilder
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
            this.Query_richTextBox = new System.Windows.Forms.RichTextBox();
            this.TableList_treeView = new System.Windows.Forms.TreeView();
            this.label2 = new System.Windows.Forms.Label();
            this.SaveQuery_button = new System.Windows.Forms.Button();
            this.btnSingleSelectCondition = new System.Windows.Forms.Button();
            this.BuildQuery_button = new System.Windows.Forms.Button();
            this.TableView_panel = new System.Windows.Forms.Panel();
            this.Clear_button = new System.Windows.Forms.Button();
            this.AddJoins_button = new System.Windows.Forms.Button();
            this.Validate_button = new System.Windows.Forms.Button();
            this.ValidateQuery_button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(322, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Build your select query";
            // 
            // Query_richTextBox
            // 
            this.Query_richTextBox.Location = new System.Drawing.Point(427, 460);
            this.Query_richTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Query_richTextBox.Name = "Query_richTextBox";
            this.Query_richTextBox.Size = new System.Drawing.Size(878, 152);
            this.Query_richTextBox.TabIndex = 1;
            this.Query_richTextBox.Text = "";
            // 
            // TableList_treeView
            // 
            this.TableList_treeView.Location = new System.Drawing.Point(26, 152);
            this.TableList_treeView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TableList_treeView.Name = "TableList_treeView";
            this.TableList_treeView.Size = new System.Drawing.Size(319, 476);
            this.TableList_treeView.TabIndex = 2;
            this.TableList_treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Database view";
            // 
            // SaveQuery_button
            // 
            this.SaveQuery_button.Location = new System.Drawing.Point(953, 635);
            this.SaveQuery_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SaveQuery_button.Name = "SaveQuery_button";
            this.SaveQuery_button.Size = new System.Drawing.Size(95, 31);
            this.SaveQuery_button.TabIndex = 7;
            this.SaveQuery_button.Text = "Save Query";
            this.SaveQuery_button.UseVisualStyleBackColor = true;
            this.SaveQuery_button.Click += new System.EventHandler(this.SaveQuerybutton_Click);
            // 
            // btnSingleSelectCondition
            // 
            this.btnSingleSelectCondition.Location = new System.Drawing.Point(711, 81);
            this.btnSingleSelectCondition.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSingleSelectCondition.Name = "btnSingleSelectCondition";
            this.btnSingleSelectCondition.Size = new System.Drawing.Size(155, 31);
            this.btnSingleSelectCondition.TabIndex = 11;
            this.btnSingleSelectCondition.Text = "Add Conditions";
            this.btnSingleSelectCondition.UseVisualStyleBackColor = true;
            this.btnSingleSelectCondition.Click += new System.EventHandler(this.btnSingleSelectCondition_Click);
            // 
            // BuildQuery_button
            // 
            this.BuildQuery_button.Location = new System.Drawing.Point(882, 81);
            this.BuildQuery_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BuildQuery_button.Name = "BuildQuery_button";
            this.BuildQuery_button.Size = new System.Drawing.Size(98, 31);
            this.BuildQuery_button.TabIndex = 12;
            this.BuildQuery_button.Text = "Build Query";
            this.BuildQuery_button.UseVisualStyleBackColor = true;
            this.BuildQuery_button.Click += new System.EventHandler(this.BuildQuery_button_Click);
            // 
            // TableView_panel
            // 
            this.TableView_panel.Location = new System.Drawing.Point(427, 152);
            this.TableView_panel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TableView_panel.Name = "TableView_panel";
            this.TableView_panel.Size = new System.Drawing.Size(871, 300);
            this.TableView_panel.TabIndex = 13;
            // 
            // Clear_button
            // 
            this.Clear_button.Location = new System.Drawing.Point(762, 635);
            this.Clear_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Clear_button.Name = "Clear_button";
            this.Clear_button.Size = new System.Drawing.Size(86, 31);
            this.Clear_button.TabIndex = 14;
            this.Clear_button.Text = "Clear";
            this.Clear_button.UseVisualStyleBackColor = true;
            this.Clear_button.Click += new System.EventHandler(this.Clear_button_Click);
            // 
            // AddJoins_button
            // 
            this.AddJoins_button.Enabled = false;
            this.AddJoins_button.Location = new System.Drawing.Point(618, 81);
            this.AddJoins_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddJoins_button.Name = "AddJoins_button";
            this.AddJoins_button.Size = new System.Drawing.Size(86, 31);
            this.AddJoins_button.TabIndex = 15;
            this.AddJoins_button.Text = "Add Joins";
            this.AddJoins_button.UseVisualStyleBackColor = true;
            this.AddJoins_button.Click += new System.EventHandler(this.AddJoins_button_Click);
            // 
            // Validate_button
            // 
            this.Validate_button.Location = new System.Drawing.Point(0, 0);
            this.Validate_button.Name = "Validate_button";
            this.Validate_button.Size = new System.Drawing.Size(75, 23);
            this.Validate_button.TabIndex = 0;
            // 
            // ValidateQuery_button1
            // 
            this.ValidateQuery_button1.Location = new System.Drawing.Point(855, 635);
            this.ValidateQuery_button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ValidateQuery_button1.Name = "ValidateQuery_button1";
            this.ValidateQuery_button1.Size = new System.Drawing.Size(86, 31);
            this.ValidateQuery_button1.TabIndex = 16;
            this.ValidateQuery_button1.Text = "Validate Query";
            this.ValidateQuery_button1.UseVisualStyleBackColor = true;
            this.ValidateQuery_button1.Click += new System.EventHandler(this.ValidateQuery_button1_Click);
            // 
            // SelectQueryBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 681);
            this.Controls.Add(this.ValidateQuery_button1);
            this.Controls.Add(this.AddJoins_button);
            this.Controls.Add(this.Clear_button);
            this.Controls.Add(this.TableView_panel);
            this.Controls.Add(this.BuildQuery_button);
            this.Controls.Add(this.btnSingleSelectCondition);
            this.Controls.Add(this.SaveQuery_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TableList_treeView);
            this.Controls.Add(this.Query_richTextBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SelectQueryBuilder";
            this.Text = "SelectQueryBuilder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TreeView TableList_treeView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SaveQuery_button;
        private System.Windows.Forms.Button btnSingleSelectCondition;
        private System.Windows.Forms.Button BuildQuery_button;
        private System.Windows.Forms.Panel TableView_panel;
        private System.Windows.Forms.RichTextBox Query_richTextBox;
        private System.Windows.Forms.Button Clear_button;
        private System.Windows.Forms.Button AddJoins_button;
        private System.Windows.Forms.Button Validate_button;
        private System.Windows.Forms.Button ValidateQuery_button1;
    }
}