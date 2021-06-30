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
            this.DatabaseList_comboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSingleSelectCondition = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.TableView_panel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(282, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Build your select query";
            // 
            // Query_richTextBox
            // 
            this.Query_richTextBox.Location = new System.Drawing.Point(282, 324);
            this.Query_richTextBox.Name = "Query_richTextBox";
            this.Query_richTextBox.Size = new System.Drawing.Size(532, 143);
            this.Query_richTextBox.TabIndex = 1;
            this.Query_richTextBox.Text = "";
            // 
            // TableList_treeView
            // 
            this.TableList_treeView.Location = new System.Drawing.Point(23, 150);
            this.TableList_treeView.Name = "TableList_treeView";
            this.TableList_treeView.Size = new System.Drawing.Size(197, 322);
            this.TableList_treeView.TabIndex = 2;
            this.TableList_treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // DatabaseList_comboBox
            // 
            this.DatabaseList_comboBox.FormattingEnabled = true;
            this.DatabaseList_comboBox.Items.AddRange(new object[] {
            "Database01"});
            this.DatabaseList_comboBox.Location = new System.Drawing.Point(23, 65);
            this.DatabaseList_comboBox.Name = "DatabaseList_comboBox";
            this.DatabaseList_comboBox.Size = new System.Drawing.Size(197, 23);
            this.DatabaseList_comboBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Database view";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "select  database ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(748, 476);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Save Query";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSingleSelectCondition
            // 
            this.btnSingleSelectCondition.Location = new System.Drawing.Point(616, 61);
            this.btnSingleSelectCondition.Name = "btnSingleSelectCondition";
            this.btnSingleSelectCondition.Size = new System.Drawing.Size(100, 23);
            this.btnSingleSelectCondition.TabIndex = 11;
            this.btnSingleSelectCondition.Text = "Add Conditions";
            this.btnSingleSelectCondition.UseVisualStyleBackColor = true;
            this.btnSingleSelectCondition.Click += new System.EventHandler(this.btnSingleSelectCondition_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(728, 61);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(86, 23);
            this.button5.TabIndex = 12;
            this.button5.Text = "Build Query";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // TableView_panel
            // 
            this.TableView_panel.Location = new System.Drawing.Point(282, 114);
            this.TableView_panel.Name = "TableView_panel";
            this.TableView_panel.Size = new System.Drawing.Size(549, 192);
            this.TableView_panel.TabIndex = 13;
            // 
            // SelectQueryBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 511);
            this.Controls.Add(this.TableView_panel);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnSingleSelectCondition);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DatabaseList_comboBox);
            this.Controls.Add(this.TableList_treeView);
            this.Controls.Add(this.Query_richTextBox);
            this.Controls.Add(this.label1);
            this.Name = "SelectQueryBuilder";
            this.Text = "SelectQueryBuilder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TreeView TableList_treeView;
        private System.Windows.Forms.ComboBox DatabaseList_comboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSingleSelectCondition;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel TableView_panel;
        private System.Windows.Forms.RichTextBox Query_richTextBox;
    }
}