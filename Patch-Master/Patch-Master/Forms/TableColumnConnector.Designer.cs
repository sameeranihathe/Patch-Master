namespace Patch_Master.Forms
{
    partial class TableColumnConnector
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
            this.BtnAddCondition = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.GeneratedTCConditionBox = new System.Windows.Forms.RichTextBox();
            this.OperatorPanel = new Patch_Master.CustomElements.CustomPanel();
            this.BtnDev = new System.Windows.Forms.Button();
            this.BtnMul = new System.Windows.Forms.Button();
            this.BtnSub = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.TcGoupBox_1 = new Patch_Master.CustomElements.customGroupBox();
            this.BtnDeleteRow = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnAddOperator_1 = new System.Windows.Forms.Button();
            this.cmbClosedBacket_1 = new System.Windows.Forms.ComboBox();
            this.cmbColumnName_1 = new System.Windows.Forms.ComboBox();
            this.comTableName_1 = new System.Windows.Forms.ComboBox();
            this.cmbOpenBacket_1 = new System.Windows.Forms.ComboBox();
            this.ConditionContainerPanel = new System.Windows.Forms.Panel();
            this.GenerateTCCondition = new System.Windows.Forms.Button();
            this.OperatorPanel.SuspendLayout();
            this.TcGoupBox_1.SuspendLayout();
            this.ConditionContainerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(451, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Table column Adder";
            // 
            // BtnAddCondition
            // 
            this.BtnAddCondition.Location = new System.Drawing.Point(845, 559);
            this.BtnAddCondition.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnAddCondition.Name = "BtnAddCondition";
            this.BtnAddCondition.Size = new System.Drawing.Size(147, 31);
            this.BtnAddCondition.TabIndex = 2;
            this.BtnAddCondition.Text = "Add";
            this.BtnAddCondition.UseVisualStyleBackColor = true;
            this.BtnAddCondition.Click += new System.EventHandler(this.BtnAddCondition_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(654, 557);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(147, 31);
            this.BtnClose.TabIndex = 2;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // GeneratedTCConditionBox
            // 
            this.GeneratedTCConditionBox.Location = new System.Drawing.Point(73, 452);
            this.GeneratedTCConditionBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GeneratedTCConditionBox.Name = "GeneratedTCConditionBox";
            this.GeneratedTCConditionBox.Size = new System.Drawing.Size(919, 97);
            this.GeneratedTCConditionBox.TabIndex = 3;
            this.GeneratedTCConditionBox.Text = "";
            // 
            // OperatorPanel
            // 
            this.OperatorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OperatorPanel.Controls.Add(this.BtnDev);
            this.OperatorPanel.Controls.Add(this.BtnMul);
            this.OperatorPanel.Controls.Add(this.BtnSub);
            this.OperatorPanel.Controls.Add(this.btnAdd);
            this.OperatorPanel.Location = new System.Drawing.Point(751, 16);
            this.OperatorPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OperatorPanel.Name = "OperatorPanel";
            this.OperatorPanel.Size = new System.Drawing.Size(101, 113);
            this.OperatorPanel.TabIndex = 4;
            this.OperatorPanel.Visible = false;
            // 
            // BtnDev
            // 
            this.BtnDev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDev.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnDev.Location = new System.Drawing.Point(8, 81);
            this.BtnDev.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnDev.Name = "BtnDev";
            this.BtnDev.Size = new System.Drawing.Size(86, 28);
            this.BtnDev.TabIndex = 0;
            this.BtnDev.Text = "/";
            this.BtnDev.UseVisualStyleBackColor = true;
            this.BtnDev.Click += new System.EventHandler(this.BtnDev_Click);
            // 
            // BtnMul
            // 
            this.BtnMul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMul.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnMul.Location = new System.Drawing.Point(8, 56);
            this.BtnMul.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnMul.Name = "BtnMul";
            this.BtnMul.Size = new System.Drawing.Size(86, 28);
            this.BtnMul.TabIndex = 0;
            this.BtnMul.Text = "*";
            this.BtnMul.UseVisualStyleBackColor = true;
            this.BtnMul.Click += new System.EventHandler(this.BtnMul_Click);
            // 
            // BtnSub
            // 
            this.BtnSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSub.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSub.Location = new System.Drawing.Point(8, 31);
            this.BtnSub.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnSub.Name = "BtnSub";
            this.BtnSub.Size = new System.Drawing.Size(86, 28);
            this.BtnSub.TabIndex = 0;
            this.BtnSub.Text = "-";
            this.BtnSub.UseVisualStyleBackColor = true;
            this.BtnSub.Click += new System.EventHandler(this.BtnSub_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(8, 5);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(86, 28);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // TcGoupBox_1
            // 
            this.TcGoupBox_1.Controls.Add(this.BtnDeleteRow);
            this.TcGoupBox_1.Controls.Add(this.label5);
            this.TcGoupBox_1.Controls.Add(this.label4);
            this.TcGoupBox_1.Controls.Add(this.label3);
            this.TcGoupBox_1.Controls.Add(this.label2);
            this.TcGoupBox_1.Controls.Add(this.BtnAddOperator_1);
            this.TcGoupBox_1.Controls.Add(this.cmbClosedBacket_1);
            this.TcGoupBox_1.Controls.Add(this.cmbColumnName_1);
            this.TcGoupBox_1.Controls.Add(this.comTableName_1);
            this.TcGoupBox_1.Controls.Add(this.cmbOpenBacket_1);
            this.TcGoupBox_1.Location = new System.Drawing.Point(40, 28);
            this.TcGoupBox_1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TcGoupBox_1.Name = "TcGoupBox_1";
            this.TcGoupBox_1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TcGoupBox_1.Size = new System.Drawing.Size(838, 88);
            this.TcGoupBox_1.TabIndex = 1;
            this.TcGoupBox_1.TabStop = false;
            this.TcGoupBox_1.Text = "Computation Condition";
            this.TcGoupBox_1.Enter += new System.EventHandler(this.TcGoupBox_1_Enter);
            // 
            // BtnDeleteRow
            // 
            this.BtnDeleteRow.Enabled = false;
            this.BtnDeleteRow.Location = new System.Drawing.Point(755, 47);
            this.BtnDeleteRow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnDeleteRow.Name = "BtnDeleteRow";
            this.BtnDeleteRow.Size = new System.Drawing.Size(65, 31);
            this.BtnDeleteRow.TabIndex = 3;
            this.BtnDeleteRow.Text = "Delete";
            this.BtnDeleteRow.UseVisualStyleBackColor = true;
            this.BtnDeleteRow.Click += new System.EventHandler(this.BtnDeleteRow_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(529, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Close Backet";
            this.label5.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(327, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Column Name";
            this.label4.Click += new System.EventHandler(this.label3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Table Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Open Backet";
            // 
            // BtnAddOperator_1
            // 
            this.BtnAddOperator_1.Location = new System.Drawing.Point(648, 48);
            this.BtnAddOperator_1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnAddOperator_1.Name = "BtnAddOperator_1";
            this.BtnAddOperator_1.Size = new System.Drawing.Size(86, 31);
            this.BtnAddOperator_1.TabIndex = 1;
            this.BtnAddOperator_1.Text = "+";
            this.BtnAddOperator_1.UseVisualStyleBackColor = true;
            this.BtnAddOperator_1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbClosedBacket_1
            // 
            this.cmbClosedBacket_1.FormattingEnabled = true;
            this.cmbClosedBacket_1.Items.AddRange(new object[] {
            ")",
            "))",
            ")))",
            "))))",
            "AddMore"});
            this.cmbClosedBacket_1.Location = new System.Drawing.Point(529, 49);
            this.cmbClosedBacket_1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbClosedBacket_1.Name = "cmbClosedBacket_1";
            this.cmbClosedBacket_1.Size = new System.Drawing.Size(92, 28);
            this.cmbClosedBacket_1.TabIndex = 0;
            // 
            // cmbColumnName_1
            // 
            this.cmbColumnName_1.FormattingEnabled = true;
            this.cmbColumnName_1.Items.AddRange(new object[] {
            "Col1",
            "Col2",
            "Col3"});
            this.cmbColumnName_1.Location = new System.Drawing.Point(325, 48);
            this.cmbColumnName_1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbColumnName_1.Name = "cmbColumnName_1";
            this.cmbColumnName_1.Size = new System.Drawing.Size(181, 28);
            this.cmbColumnName_1.TabIndex = 0;
            this.cmbColumnName_1.SelectedIndexChanged += new System.EventHandler(this.cmbColumnName_1_SelectedIndexChanged);
            // 
            // comTableName_1
            // 
            this.comTableName_1.FormattingEnabled = true;
            this.comTableName_1.Items.AddRange(new object[] {
            "Tab1",
            "tab2",
            "tab3",
            "tab4"});
            this.comTableName_1.Location = new System.Drawing.Point(134, 48);
            this.comTableName_1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comTableName_1.Name = "comTableName_1";
            this.comTableName_1.Size = new System.Drawing.Size(183, 28);
            this.comTableName_1.TabIndex = 0;
            this.comTableName_1.SelectedIndexChanged += new System.EventHandler(this.comTableName_1_SelectedIndexChanged);
            // 
            // cmbOpenBacket_1
            // 
            this.cmbOpenBacket_1.FormattingEnabled = true;
            this.cmbOpenBacket_1.Items.AddRange(new object[] {
            "(",
            "((",
            "(((",
            "((((",
            "AddMore"});
            this.cmbOpenBacket_1.Location = new System.Drawing.Point(26, 48);
            this.cmbOpenBacket_1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbOpenBacket_1.Name = "cmbOpenBacket_1";
            this.cmbOpenBacket_1.Size = new System.Drawing.Size(84, 28);
            this.cmbOpenBacket_1.TabIndex = 0;
            // 
            // ConditionContainerPanel
            // 
            this.ConditionContainerPanel.AutoScroll = true;
            this.ConditionContainerPanel.Controls.Add(this.TcGoupBox_1);
            this.ConditionContainerPanel.Location = new System.Drawing.Point(73, 56);
            this.ConditionContainerPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConditionContainerPanel.Name = "ConditionContainerPanel";
            this.ConditionContainerPanel.Size = new System.Drawing.Size(919, 320);
            this.ConditionContainerPanel.TabIndex = 0;
            // 
            // GenerateTCCondition
            // 
            this.GenerateTCCondition.Location = new System.Drawing.Point(845, 399);
            this.GenerateTCCondition.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GenerateTCCondition.Name = "GenerateTCCondition";
            this.GenerateTCCondition.Size = new System.Drawing.Size(147, 45);
            this.GenerateTCCondition.TabIndex = 5;
            this.GenerateTCCondition.Text = "Generate ";
            this.GenerateTCCondition.UseVisualStyleBackColor = true;
            this.GenerateTCCondition.Click += new System.EventHandler(this.GenerateTCCondition_Click);
            // 
            // TableColumnConnector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 621);
            this.Controls.Add(this.GenerateTCCondition);
            this.Controls.Add(this.GeneratedTCConditionBox);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnAddCondition);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OperatorPanel);
            this.Controls.Add(this.ConditionContainerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TableColumnConnector";
            this.Text = "TableColumnConnector";
            this.Load += new System.EventHandler(this.TableColumnConnector_Load);
            this.OperatorPanel.ResumeLayout(false);
            this.TcGoupBox_1.ResumeLayout(false);
            this.TcGoupBox_1.PerformLayout();
            this.ConditionContainerPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnAddOperator;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button BtnAddCondition;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.RichTextBox GeneratedTCConditionBox;
        //private System.Windows.Forms.Panel OperatorPanel;
        private CustomElements.CustomPanel OperatorPanel;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button BtnDev;
        private System.Windows.Forms.Button BtnMul;
        private System.Windows.Forms.Button BtnSub;
        private System.Windows.Forms.Button btnAdd;
        private CustomElements.customGroupBox TcGoupBox_1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnAddOperator_1;
        private System.Windows.Forms.ComboBox cmbClosedBacket_1;
        private System.Windows.Forms.ComboBox cmbColumnName_1;
        private System.Windows.Forms.ComboBox comTableName_1;
        private System.Windows.Forms.ComboBox cmbOpenBacket_1;
        private System.Windows.Forms.Panel ConditionContainerPanel;
        private System.Windows.Forms.Button BtnDeleteRow;
        private System.Windows.Forms.Button GenerateTCCondition;
    }
}