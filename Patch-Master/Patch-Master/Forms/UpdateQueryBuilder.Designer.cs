namespace Patch_Master.Forms
{
    partial class UpdateQueryBuilder
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnAddTableColumnValue_1 = new System.Windows.Forms.Button();
            this.textColumnValue_1 = new System.Windows.Forms.TextBox();
            this.textColumnName_1 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.CmbTable = new System.Windows.Forms.ComboBox();
            this.BtnValue = new System.Windows.Forms.Button();
            this.BtnCondition = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SelectTableLBL = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TabletreeView = new System.Windows.Forms.TreeView();
            this.CheckListBoxTable = new System.Windows.Forms.CheckedListBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.checkedListBox1);
            this.panel1.Location = new System.Drawing.Point(209, 113);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 219);
            this.panel1.TabIndex = 0;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(15, 19);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(170, 184);
            this.checkedListBox1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.BtnAddTableColumnValue_1);
            this.panel2.Controls.Add(this.textColumnValue_1);
            this.panel2.Controls.Add(this.textColumnName_1);
            this.panel2.Location = new System.Drawing.Point(433, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(342, 219);
            this.panel2.TabIndex = 0;
            // 
            // BtnAddTableColumnValue_1
            // 
            this.BtnAddTableColumnValue_1.Location = new System.Drawing.Point(304, 18);
            this.BtnAddTableColumnValue_1.Name = "BtnAddTableColumnValue_1";
            this.BtnAddTableColumnValue_1.Size = new System.Drawing.Size(26, 25);
            this.BtnAddTableColumnValue_1.TabIndex = 1;
            this.BtnAddTableColumnValue_1.Text = "...";
            this.BtnAddTableColumnValue_1.UseVisualStyleBackColor = true;
            this.BtnAddTableColumnValue_1.Visible = false;
            this.BtnAddTableColumnValue_1.Click += new System.EventHandler(this.BtnAddTableColumnValue_1_Click);
            // 
            // textColumnValue_1
            // 
            this.textColumnValue_1.Location = new System.Drawing.Point(163, 19);
            this.textColumnValue_1.Name = "textColumnValue_1";
            this.textColumnValue_1.Size = new System.Drawing.Size(138, 23);
            this.textColumnValue_1.TabIndex = 0;
            this.textColumnValue_1.Visible = false;
            // 
            // textColumnName_1
            // 
            this.textColumnName_1.Location = new System.Drawing.Point(12, 19);
            this.textColumnName_1.Name = "textColumnName_1";
            this.textColumnName_1.Size = new System.Drawing.Size(145, 23);
            this.textColumnName_1.TabIndex = 0;
            this.textColumnName_1.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.richTextBox2);
            this.panel3.Location = new System.Drawing.Point(791, 113);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 219);
            this.panel3.TabIndex = 0;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(17, 19);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(165, 183);
            this.richTextBox2.TabIndex = 0;
            this.richTextBox2.Text = "";
            // 
            // CmbTable
            // 
            this.CmbTable.FormattingEnabled = true;
            this.CmbTable.Location = new System.Drawing.Point(209, 70);
            this.CmbTable.Name = "CmbTable";
            this.CmbTable.Size = new System.Drawing.Size(200, 23);
            this.CmbTable.TabIndex = 1;
            this.CmbTable.SelectedIndexChanged += new System.EventHandler(this.CmbTable_SelectedIndexChanged);
            // 
            // BtnValue
            // 
            this.BtnValue.Location = new System.Drawing.Point(433, 70);
            this.BtnValue.Name = "BtnValue";
            this.BtnValue.Size = new System.Drawing.Size(342, 23);
            this.BtnValue.TabIndex = 2;
            this.BtnValue.Text = "Add Values";
            this.BtnValue.UseVisualStyleBackColor = true;
            this.BtnValue.Click += new System.EventHandler(this.BtnValue_Click);
            // 
            // BtnCondition
            // 
            this.BtnCondition.Location = new System.Drawing.Point(788, 69);
            this.BtnCondition.Name = "BtnCondition";
            this.BtnCondition.Size = new System.Drawing.Size(200, 23);
            this.BtnCondition.TabIndex = 3;
            this.BtnCondition.Text = "Condition";
            this.BtnCondition.UseVisualStyleBackColor = true;
            this.BtnCondition.Click += new System.EventHandler(this.BtnCondition_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(208, 372);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(783, 117);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(890, 340);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Build Query";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // SelectTableLBL
            // 
            this.SelectTableLBL.AutoSize = true;
            this.SelectTableLBL.Location = new System.Drawing.Point(209, 52);
            this.SelectTableLBL.Name = "SelectTableLBL";
            this.SelectTableLBL.Size = new System.Drawing.Size(191, 15);
            this.SelectTableLBL.TabIndex = 6;
            this.SelectTableLBL.Text = "SelectTable and check the columns";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(436, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Add update values";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(788, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Add Condition";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(36, 106);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(147, 382);
            this.richTextBox3.TabIndex = 9;
            this.richTextBox3.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Table List";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(451, -2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Update Query Builder";
            // 
            // TabletreeView
            // 
            this.TabletreeView.Location = new System.Drawing.Point(36, 106);
            this.TabletreeView.Name = "TabletreeView";
            this.TabletreeView.Size = new System.Drawing.Size(147, 382);
            this.TabletreeView.TabIndex = 12;
            // 
            // CheckListBoxTable
            // 
            this.CheckListBoxTable.FormattingEnabled = true;
            this.CheckListBoxTable.Location = new System.Drawing.Point(45, 113);
            this.CheckListBoxTable.Name = "CheckListBoxTable";
            this.CheckListBoxTable.Size = new System.Drawing.Size(128, 364);
            this.CheckListBoxTable.TabIndex = 13;
            // 
            // UpdateQueryBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 543);
            this.Controls.Add(this.CheckListBoxTable);
            this.Controls.Add(this.TabletreeView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SelectTableLBL);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.BtnCondition);
            this.Controls.Add(this.BtnValue);
            this.Controls.Add(this.CmbTable);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "UpdateQueryBuilder";
            this.Text = "UpdateQueryBuilder";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textColumnValue_1;
        private System.Windows.Forms.TextBox textColumnName_1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RichTextBox richTextBox2;
        public System.Windows.Forms.ComboBox CmbTable;
        private System.Windows.Forms.Button BtnValue;
        private System.Windows.Forms.Button BtnCondition;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label SelectTableLBL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TreeView TabletreeView;
        private System.Windows.Forms.CheckedListBox CheckListBoxTable;
        private System.Windows.Forms.Button BtnAddTableColumnValue_1;
    }
}