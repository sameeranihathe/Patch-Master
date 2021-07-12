using Patch_Master.CustomElements;
using System.Windows.Forms;

namespace Patch_Master.Forms
{
    partial class SelectConditionBuilder
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ConditionGroup_1 = new Patch_Master.CustomElements.customGroupBox();
            this.cmbTable_1 = new System.Windows.Forms.ComboBox();
            this.DeleteCondition_1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.AddTableColumn1_1 = new System.Windows.Forms.Button();
            this.cmbCloseBracket_1 = new System.Windows.Forms.ComboBox();
            this.CmbOpenBracket_1 = new System.Windows.Forms.ComboBox();
            this.AddTablecolumn2_1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddCondition_1 = new System.Windows.Forms.Button();
            this.txtValue_1 = new System.Windows.Forms.TextBox();
            this.CmbComparer_1 = new System.Windows.Forms.ComboBox();
            this.CmbColumn_1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.OperatorPanel = new Patch_Master.CustomElements.CustomPanel();
            this.BtnAND = new System.Windows.Forms.Button();
            this.BtnOR = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ConditionContainerPanel = new System.Windows.Forms.Panel();
            this.ConditionGroup_1.SuspendLayout();
            this.OperatorPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(304, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Build your single select condition here";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(31, 113);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 27);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Table1\r\n";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Table name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "AA",
            "BB",
            "CC",
            "DD",
            "EE",
            "FF",
            "GG",
            "HH"});
            this.listBox1.Location = new System.Drawing.Point(31, 204);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(141, 484);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Column names";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // ConditionGroup_1
            // 
            this.ConditionGroup_1.Controls.Add(this.cmbTable_1);
            this.ConditionGroup_1.Controls.Add(this.DeleteCondition_1);
            this.ConditionGroup_1.Controls.Add(this.label10);
            this.ConditionGroup_1.Controls.Add(this.label9);
            this.ConditionGroup_1.Controls.Add(this.label8);
            this.ConditionGroup_1.Controls.Add(this.AddTableColumn1_1);
            this.ConditionGroup_1.Controls.Add(this.cmbCloseBracket_1);
            this.ConditionGroup_1.Controls.Add(this.CmbOpenBracket_1);
            this.ConditionGroup_1.Controls.Add(this.AddTablecolumn2_1);
            this.ConditionGroup_1.Controls.Add(this.label6);
            this.ConditionGroup_1.Controls.Add(this.label5);
            this.ConditionGroup_1.Controls.Add(this.label4);
            this.ConditionGroup_1.Controls.Add(this.btnAddCondition_1);
            this.ConditionGroup_1.Controls.Add(this.txtValue_1);
            this.ConditionGroup_1.Controls.Add(this.CmbComparer_1);
            this.ConditionGroup_1.Controls.Add(this.CmbColumn_1);
            this.ConditionGroup_1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConditionGroup_1.Location = new System.Drawing.Point(209, 84);
            this.ConditionGroup_1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConditionGroup_1.Name = "ConditionGroup_1";
            this.ConditionGroup_1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConditionGroup_1.Size = new System.Drawing.Size(1153, 112);
            this.ConditionGroup_1.TabIndex = 5;
            this.ConditionGroup_1.TabStop = false;
            this.ConditionGroup_1.Text = "Condition group";
            // 
            // cmbTable_1
            // 
            this.cmbTable_1.FormattingEnabled = true;
            this.cmbTable_1.Items.AddRange(new object[] {
            "AA",
            "BB",
            "CC",
            "DD",
            "EE",
            "FF",
            "GG",
            "HH"});
            this.cmbTable_1.Location = new System.Drawing.Point(135, 60);
            this.cmbTable_1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbTable_1.Name = "cmbTable_1";
            this.cmbTable_1.Size = new System.Drawing.Size(145, 28);
            this.cmbTable_1.TabIndex = 0;
            this.cmbTable_1.SelectedIndexChanged += new System.EventHandler(this.cmbTable_1_SelectedIndexChanged);
            // 
            // DeleteCondition_1
            // 
            this.DeleteCondition_1.Enabled = false;
            this.DeleteCondition_1.Location = new System.Drawing.Point(1071, 63);
            this.DeleteCondition_1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DeleteCondition_1.Name = "DeleteCondition_1";
            this.DeleteCondition_1.Size = new System.Drawing.Size(64, 31);
            this.DeleteCondition_1.TabIndex = 14;
            this.DeleteCondition_1.Text = "Delete";
            this.DeleteCondition_1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(138, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 20);
            this.label10.TabIndex = 4;
            this.label10.Text = "Table";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(845, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "Close Bracket";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Open Bracket";
            // 
            // AddTableColumn1_1
            // 
            this.AddTableColumn1_1.Location = new System.Drawing.Point(451, 60);
            this.AddTableColumn1_1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddTableColumn1_1.Name = "AddTableColumn1_1";
            this.AddTableColumn1_1.Size = new System.Drawing.Size(31, 31);
            this.AddTableColumn1_1.TabIndex = 12;
            this.AddTableColumn1_1.Text = "...";
            this.AddTableColumn1_1.UseVisualStyleBackColor = true;
            this.AddTableColumn1_1.Click += new System.EventHandler(this.AddTableColumn1_Click);
            // 
            // cmbCloseBracket_1
            // 
            this.cmbCloseBracket_1.FormattingEnabled = true;
            this.cmbCloseBracket_1.Items.AddRange(new object[] {
            ")",
            "))",
            ")))",
            "))))",
            "Add More"});
            this.cmbCloseBracket_1.Location = new System.Drawing.Point(845, 61);
            this.cmbCloseBracket_1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbCloseBracket_1.Name = "cmbCloseBracket_1";
            this.cmbCloseBracket_1.Size = new System.Drawing.Size(92, 28);
            this.cmbCloseBracket_1.TabIndex = 11;
            // 
            // CmbOpenBracket_1
            // 
            this.CmbOpenBracket_1.FormattingEnabled = true;
            this.CmbOpenBracket_1.Items.AddRange(new object[] {
            "(",
            "((",
            "(((",
            "((((",
            "Add More"});
            this.CmbOpenBracket_1.Location = new System.Drawing.Point(19, 61);
            this.CmbOpenBracket_1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CmbOpenBracket_1.Name = "CmbOpenBracket_1";
            this.CmbOpenBracket_1.Size = new System.Drawing.Size(93, 28);
            this.CmbOpenBracket_1.TabIndex = 10;
            // 
            // AddTablecolumn2_1
            // 
            this.AddTablecolumn2_1.Location = new System.Drawing.Point(797, 60);
            this.AddTablecolumn2_1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddTablecolumn2_1.Name = "AddTablecolumn2_1";
            this.AddTablecolumn2_1.Size = new System.Drawing.Size(31, 31);
            this.AddTablecolumn2_1.TabIndex = 9;
            this.AddTablecolumn2_1.Text = "...";
            this.AddTablecolumn2_1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddTablecolumn2_1.UseVisualStyleBackColor = true;
            this.AddTablecolumn2_1.Click += new System.EventHandler(this.AddTablecolumn2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(635, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Column/Value";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(501, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Comparer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(291, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Column";
            // 
            // btnAddCondition_1
            // 
            this.btnAddCondition_1.Location = new System.Drawing.Point(957, 63);
            this.btnAddCondition_1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddCondition_1.Name = "btnAddCondition_1";
            this.btnAddCondition_1.Size = new System.Drawing.Size(86, 31);
            this.btnAddCondition_1.TabIndex = 3;
            this.btnAddCondition_1.Text = "+";
            this.btnAddCondition_1.UseVisualStyleBackColor = true;
            this.btnAddCondition_1.Click += new System.EventHandler(this.btnAddCondition_Click);
            // 
            // txtValue_1
            // 
            this.txtValue_1.Location = new System.Drawing.Point(632, 60);
            this.txtValue_1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtValue_1.Multiline = true;
            this.txtValue_1.Name = "txtValue_1";
            this.txtValue_1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtValue_1.Size = new System.Drawing.Size(165, 29);
            this.txtValue_1.TabIndex = 2;
            this.txtValue_1.TextChanged += new System.EventHandler(this.txtValue_TextChanged);
            // 
            // CmbComparer_1
            // 
            this.CmbComparer_1.FormattingEnabled = true;
            this.CmbComparer_1.Items.AddRange(new object[] {
            "=",
            ">",
            "<",
            ">=",
            "<=",
            "betweeen"});
            this.CmbComparer_1.Location = new System.Drawing.Point(498, 60);
            this.CmbComparer_1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CmbComparer_1.Name = "CmbComparer_1";
            this.CmbComparer_1.Size = new System.Drawing.Size(108, 28);
            this.CmbComparer_1.TabIndex = 1;
            // 
            // CmbColumn_1
            // 
            this.CmbColumn_1.FormattingEnabled = true;
            this.CmbColumn_1.Items.AddRange(new object[] {
            "AA",
            "BB",
            "CC",
            "DD",
            "EE",
            "FF",
            "GG",
            "HH"});
            this.CmbColumn_1.Location = new System.Drawing.Point(287, 60);
            this.CmbColumn_1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CmbColumn_1.Name = "CmbColumn_1";
            this.CmbColumn_1.Size = new System.Drawing.Size(165, 28);
            this.CmbColumn_1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1266, 711);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 31);
            this.button2.TabIndex = 6;
            this.button2.Text = "Save Condition";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // OperatorPanel
            // 
            this.OperatorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OperatorPanel.Controls.Add(this.BtnAND);
            this.OperatorPanel.Controls.Add(this.BtnOR);
            this.OperatorPanel.Location = new System.Drawing.Point(1163, 52);
            this.OperatorPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OperatorPanel.Name = "OperatorPanel";
            this.OperatorPanel.Size = new System.Drawing.Size(89, 87);
            this.OperatorPanel.TabIndex = 7;
            this.OperatorPanel.Visible = false;
            // 
            // BtnAND
            // 
            this.BtnAND.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAND.Location = new System.Drawing.Point(1, 7);
            this.BtnAND.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnAND.Name = "BtnAND";
            this.BtnAND.Size = new System.Drawing.Size(85, 31);
            this.BtnAND.TabIndex = 1;
            this.BtnAND.Text = "AND";
            this.BtnAND.UseVisualStyleBackColor = true;
            this.BtnAND.Click += new System.EventHandler(this.BtnAND_Click);
            // 
            // BtnOR
            // 
            this.BtnOR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOR.Location = new System.Drawing.Point(1, 48);
            this.BtnOR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnOR.Name = "BtnOR";
            this.BtnOR.Size = new System.Drawing.Size(85, 31);
            this.BtnOR.TabIndex = 0;
            this.BtnOR.Text = "OR";
            this.BtnOR.UseVisualStyleBackColor = true;
            this.BtnOR.Click += new System.EventHandler(this.BtnOR_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(195, 563);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1191, 127);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(238, 525);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Condition view on text";
            // 
            // ConditionContainerPanel
            // 
            this.ConditionContainerPanel.Location = new System.Drawing.Point(195, 60);
            this.ConditionContainerPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConditionContainerPanel.Name = "ConditionContainerPanel";
            this.ConditionContainerPanel.Size = new System.Drawing.Size(1192, 449);
            this.ConditionContainerPanel.TabIndex = 10;
            // 
            // SelectConditionBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 757);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.OperatorPanel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ConditionGroup_1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConditionContainerPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SelectConditionBuilder";
            this.Text = "SelectConditionBuilder";
            this.Load += new System.EventHandler(this.SelectConditionBuilder_Load);
            this.ConditionGroup_1.ResumeLayout(false);
            this.ConditionGroup_1.PerformLayout();
            this.OperatorPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddCondition_1;
        private System.Windows.Forms.TextBox txtValue_1;
        private System.Windows.Forms.ComboBox CmbComparer_1;
        private System.Windows.Forms.ComboBox CmbColumn_1;
        private System.Windows.Forms.Button button2;
        private CustomPanel OperatorPanel;
        private System.Windows.Forms.Button BtnAND;
        private System.Windows.Forms.Button BtnOR;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button AddTablecolumn2_1;
        private System.Windows.Forms.Button AddTableColumn1_1;
        private System.Windows.Forms.ComboBox cmbCloseBracket_1;
        private System.Windows.Forms.ComboBox CmbOpenBracket_1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button DeleteCondition;
        private ComboBox cmbTable;
        private customGroupBox ConditionGroup_1;
        private Button AddTableColumn1;
        private ComboBox cmbTable_1;
        private Button DeleteCondition_1;
        private Panel panel1;
        private Panel ConditionContainerPanel;
    }
}