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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OpenBracket = new System.Windows.Forms.Button();
            this.ClosedBracket = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddCondition = new System.Windows.Forms.Button();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.CmbComparer = new System.Windows.Forms.ComboBox();
            this.CmbColumn = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.OperatorPanel = new System.Windows.Forms.Panel();
            this.BtnAND = new System.Windows.Forms.Button();
            this.BtnOR = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.OperatorPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(266, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Build your single select condition here";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(27, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Table1\r\n";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Table name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Items.AddRange(new object[] {
            "AA",
            "BB",
            "CC",
            "DD",
            "EE",
            "FF",
            "GG",
            "HH"});
            this.listBox1.Location = new System.Drawing.Point(27, 153);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(142, 364);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Column names";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OpenBracket);
            this.groupBox1.Controls.Add(this.ClosedBracket);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnAddCondition);
            this.groupBox1.Controls.Add(this.txtValue);
            this.groupBox1.Controls.Add(this.CmbComparer);
            this.groupBox1.Controls.Add(this.CmbColumn);
            this.groupBox1.Location = new System.Drawing.Point(208, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(897, 91);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Condition group";
            // 
            // OpenBracket
            // 
            this.OpenBracket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenBracket.Location = new System.Drawing.Point(19, 52);
            this.OpenBracket.Name = "OpenBracket";
            this.OpenBracket.Size = new System.Drawing.Size(97, 23);
            this.OpenBracket.TabIndex = 8;
            this.OpenBracket.Text = "Open Bracket";
            this.OpenBracket.UseVisualStyleBackColor = true;
            // 
            // ClosedBracket
            // 
            this.ClosedBracket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClosedBracket.Location = new System.Drawing.Point(688, 53);
            this.ClosedBracket.Name = "ClosedBracket";
            this.ClosedBracket.Size = new System.Drawing.Size(93, 23);
            this.ClosedBracket.TabIndex = 7;
            this.ClosedBracket.Text = "Close Bracket";
            this.ClosedBracket.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(479, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Value";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(351, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Comparer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(142, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Column";
            // 
            // btnAddCondition
            // 
            this.btnAddCondition.Location = new System.Drawing.Point(805, 53);
            this.btnAddCondition.Name = "btnAddCondition";
            this.btnAddCondition.Size = new System.Drawing.Size(75, 23);
            this.btnAddCondition.TabIndex = 3;
            this.btnAddCondition.Text = "+";
            this.btnAddCondition.UseVisualStyleBackColor = true;
            this.btnAddCondition.Click += new System.EventHandler(this.btnAddCondition_Click);
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(477, 53);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(192, 23);
            this.txtValue.TabIndex = 2;
            // 
            // CmbComparer
            // 
            this.CmbComparer.FormattingEnabled = true;
            this.CmbComparer.Items.AddRange(new object[] {
            "=",
            ">",
            "<",
            ">=",
            "<=",
            "betweeen"});
            this.CmbComparer.Location = new System.Drawing.Point(351, 53);
            this.CmbComparer.Name = "CmbComparer";
            this.CmbComparer.Size = new System.Drawing.Size(95, 23);
            this.CmbComparer.TabIndex = 1;
            // 
            // CmbColumn
            // 
            this.CmbColumn.FormattingEnabled = true;
            this.CmbColumn.Items.AddRange(new object[] {
            "AA",
            "BB",
            "CC",
            "DD",
            "EE",
            "FF",
            "GG",
            "HH"});
            this.CmbColumn.Location = new System.Drawing.Point(139, 52);
            this.CmbColumn.Name = "CmbColumn";
            this.CmbColumn.Size = new System.Drawing.Size(188, 23);
            this.CmbColumn.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1045, 524);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 23);
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
            this.OperatorPanel.Location = new System.Drawing.Point(1011, 46);
            this.OperatorPanel.Name = "OperatorPanel";
            this.OperatorPanel.Size = new System.Drawing.Size(78, 66);
            this.OperatorPanel.TabIndex = 7;
            this.OperatorPanel.Visible = false;
            // 
            // BtnAND
            // 
            this.BtnAND.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAND.Location = new System.Drawing.Point(1, 5);
            this.BtnAND.Name = "BtnAND";
            this.BtnAND.Size = new System.Drawing.Size(74, 23);
            this.BtnAND.TabIndex = 1;
            this.BtnAND.Text = "AND";
            this.BtnAND.UseVisualStyleBackColor = true;
            // 
            // BtnOR
            // 
            this.BtnOR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOR.Location = new System.Drawing.Point(1, 36);
            this.BtnOR.Name = "BtnOR";
            this.BtnOR.Size = new System.Drawing.Size(74, 23);
            this.BtnOR.TabIndex = 0;
            this.BtnOR.Text = "OR";
            this.BtnOR.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(208, 422);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(897, 96);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(208, 394);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Condition view on text";
            // 
            // SelectConditionBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 568);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.OperatorPanel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "SelectConditionBuilder";
            this.Text = "SelectConditionBuilder";
            this.Load += new System.EventHandler(this.SelectConditionBuilder_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddCondition;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.ComboBox CmbComparer;
        private System.Windows.Forms.ComboBox CmbColumn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button OpenBracket;
        private System.Windows.Forms.Button ClosedBracket;
        private System.Windows.Forms.Panel OperatorPanel;
        private System.Windows.Forms.Button BtnAND;
        private System.Windows.Forms.Button BtnOR;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label7;
    }
}