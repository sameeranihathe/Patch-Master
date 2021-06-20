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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Colomn1");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Column2");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Column3");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Table1", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Table2");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Database01", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Table21");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Table22");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Table22", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8});
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btnSingleSelectCondition = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(353, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Build your select query";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(282, 312);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(532, 155);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(23, 150);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Column1";
            treeNode1.Text = "Colomn1";
            treeNode2.Name = "Column2";
            treeNode2.Text = "Column2";
            treeNode3.Name = "Column3";
            treeNode3.Text = "Column3";
            treeNode4.Name = "Table1";
            treeNode4.Text = "Table1";
            treeNode5.Name = "Table2";
            treeNode5.Text = "Table2";
            treeNode6.Name = "Database01";
            treeNode6.Text = "Database01";
            treeNode7.Name = "Table21";
            treeNode7.Text = "Table21";
            treeNode8.Name = "Table22";
            treeNode8.Text = "Table22";
            treeNode9.Name = "Table22";
            treeNode9.Text = "Table22";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode9});
            this.treeView1.Size = new System.Drawing.Size(197, 322);
            this.treeView1.TabIndex = 2;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Database01"});
            this.comboBox1.Location = new System.Drawing.Point(23, 65);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(197, 23);
            this.comboBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(90, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Connect to database";
            this.button1.UseVisualStyleBackColor = true;
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
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Table1",
            "Table2",
            "Table3",
            "Table4",
            "Table5"});
            this.comboBox2.Location = new System.Drawing.Point(282, 94);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(149, 23);
            this.comboBox2.TabIndex = 8;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Column1",
            "Column2",
            "Column3",
            "Column4",
            "Column5",
            "Column6"});
            this.checkedListBox1.Location = new System.Drawing.Point(474, 95);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 184);
            this.checkedListBox1.TabIndex = 9;
            // 
            // btnSingleSelectCondition
            // 
            this.btnSingleSelectCondition.Location = new System.Drawing.Point(615, 95);
            this.btnSingleSelectCondition.Name = "btnSingleSelectCondition";
            this.btnSingleSelectCondition.Size = new System.Drawing.Size(100, 23);
            this.btnSingleSelectCondition.TabIndex = 11;
            this.btnSingleSelectCondition.Text = "Add Conditions";
            this.btnSingleSelectCondition.UseVisualStyleBackColor = true;
            this.btnSingleSelectCondition.Click += new System.EventHandler(this.btnSingleSelectCondition_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(728, 95);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(86, 23);
            this.button5.TabIndex = 12;
            this.button5.Text = "Build Query";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(288, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Select table";
            // 
            // SelectQueryBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 511);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnSingleSelectCondition);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Name = "SelectQueryBuilder";
            this.Text = "SelectQueryBuilder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button btnSingleSelectCondition;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label4;
    }
}