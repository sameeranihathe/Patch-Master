using Patch_Master.CustomElements;

namespace Patch_Master.Forms
{
    partial class NameConditionBuilder
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
            this.tableList_listBox = new System.Windows.Forms.ListBox();
            this.ConditionBox = new System.Windows.Forms.RichTextBox();
            this.PanelConditionContainer = new System.Windows.Forms.Panel();
            this.GroupConditionRow_1 = new Patch_Master.CustomElements.customGroupBox();
            this.LbTablecolumn_1 = new System.Windows.Forms.Label();
            this.textValue1_1 = new System.Windows.Forms.TextBox();
            this.Delete_1 = new System.Windows.Forms.Button();
            this.butnAddNewRow_1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblColumn_1 = new System.Windows.Forms.Label();
            this.LblTable_1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnTCCondition2_1 = new System.Windows.Forms.Button();
            this.BtnTCCondition1_1 = new System.Windows.Forms.Button();
            this.textValue_1 = new CustomTextBox();
            this.CmbCloseBracket_1 = new System.Windows.Forms.ComboBox();
            this.CmbComparer_1 = new System.Windows.Forms.ComboBox();
            this.CmbColumn_1 = new System.Windows.Forms.ComboBox();
            this.CmbTable_1 = new System.Windows.Forms.ComboBox();
            this.CmbOpenBracket_1 = new System.Windows.Forms.ComboBox();
            this.PanelOperator = new Patch_Master.CustomElements.CustomPanel();
            this.btnConAND = new System.Windows.Forms.Button();
            this.BtnConditionOR = new System.Windows.Forms.Button();
            this.AddCondition = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.Generate = new System.Windows.Forms.Button();
            this.PanelConditionContainer.SuspendLayout();
            this.GroupConditionRow_1.SuspendLayout();
            this.PanelOperator.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableList_listBox
            // 
            this.tableList_listBox.ItemHeight = 20;
            this.tableList_listBox.Location = new System.Drawing.Point(12, 27);
            this.tableList_listBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableList_listBox.Name = "tableList_listBox";
            this.tableList_listBox.Size = new System.Drawing.Size(157, 624);
            this.tableList_listBox.TabIndex = 6;
            this.tableList_listBox.SelectedIndexChanged += new System.EventHandler(this.tableList_listBox_SelectedIndexChanged);
            // 
            // ConditionBox
            // 
            this.ConditionBox.Location = new System.Drawing.Point(183, 540);
            this.ConditionBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConditionBox.Name = "ConditionBox";
            this.ConditionBox.Size = new System.Drawing.Size(1137, 109);
            this.ConditionBox.TabIndex = 2;
            this.ConditionBox.Text = "";
            // 
            // PanelConditionContainer
            // 
            this.PanelConditionContainer.AutoScroll = true;
            this.PanelConditionContainer.Controls.Add(this.GroupConditionRow_1);
            this.PanelConditionContainer.Location = new System.Drawing.Point(183, 41);
            this.PanelConditionContainer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PanelConditionContainer.Name = "PanelConditionContainer";
            this.PanelConditionContainer.Size = new System.Drawing.Size(1137, 450);
            this.PanelConditionContainer.TabIndex = 3;
            // 
            // GroupConditionRow_1
            // 
            this.GroupConditionRow_1.Controls.Add(this.LbTablecolumn_1);
            this.GroupConditionRow_1.Controls.Add(this.textValue1_1);
            this.GroupConditionRow_1.Controls.Add(this.Delete_1);
            this.GroupConditionRow_1.Controls.Add(this.butnAddNewRow_1);
            this.GroupConditionRow_1.Controls.Add(this.label6);
            this.GroupConditionRow_1.Controls.Add(this.label5);
            this.GroupConditionRow_1.Controls.Add(this.label4);
            this.GroupConditionRow_1.Controls.Add(this.LblColumn_1);
            this.GroupConditionRow_1.Controls.Add(this.LblTable_1);
            this.GroupConditionRow_1.Controls.Add(this.label1);
            this.GroupConditionRow_1.Controls.Add(this.BtnTCCondition2_1);
            this.GroupConditionRow_1.Controls.Add(this.BtnTCCondition1_1);
            this.GroupConditionRow_1.Controls.Add(this.textValue_1);
            this.GroupConditionRow_1.Controls.Add(this.CmbCloseBracket_1);
            this.GroupConditionRow_1.Controls.Add(this.CmbComparer_1);
            this.GroupConditionRow_1.Controls.Add(this.CmbColumn_1);
            this.GroupConditionRow_1.Controls.Add(this.CmbTable_1);
            this.GroupConditionRow_1.Controls.Add(this.CmbOpenBracket_1);
            this.GroupConditionRow_1.Location = new System.Drawing.Point(31, 15);
            this.GroupConditionRow_1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupConditionRow_1.Name = "GroupConditionRow_1";
            this.GroupConditionRow_1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupConditionRow_1.Size = new System.Drawing.Size(1089, 109);
            this.GroupConditionRow_1.TabIndex = 0;
            this.GroupConditionRow_1.TabStop = false;
            this.GroupConditionRow_1.Text = "Condition Row";
            // 
            // LbTablecolumn_1
            // 
            this.LbTablecolumn_1.AutoSize = true;
            this.LbTablecolumn_1.Location = new System.Drawing.Point(206, 32);
            this.LbTablecolumn_1.Name = "LbTablecolumn_1";
            this.LbTablecolumn_1.Size = new System.Drawing.Size(101, 20);
            this.LbTablecolumn_1.TabIndex = 7;
            this.LbTablecolumn_1.Text = "Table/Column";
            this.LbTablecolumn_1.Visible = false;
            // 
            // textValue1_1
            // 
            this.textValue1_1.Location = new System.Drawing.Point(120, 56);
            this.textValue1_1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textValue1_1.Name = "textValue1_1";
            this.textValue1_1.Size = new System.Drawing.Size(302, 27);
            this.textValue1_1.TabIndex = 6;
            this.textValue1_1.Visible = false;
            this.textValue1_1.TextChanged += new System.EventHandler(this.textValue1_1_TextChanged);
            // 
            // Delete_1
            // 
            this.Delete_1.Enabled = false;
            this.Delete_1.Location = new System.Drawing.Point(1014, 53);
            this.Delete_1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Delete_1.Name = "Delete_1";
            this.Delete_1.Size = new System.Drawing.Size(61, 31);
            this.Delete_1.TabIndex = 5;
            this.Delete_1.Text = "Delete";
            this.Delete_1.UseVisualStyleBackColor = true;
            this.Delete_1.Click += new System.EventHandler(this.Delete_1_Click);
            // 
            // butnAddNewRow_1
            // 
            this.butnAddNewRow_1.Location = new System.Drawing.Point(909, 54);
            this.butnAddNewRow_1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.butnAddNewRow_1.Name = "butnAddNewRow_1";
            this.butnAddNewRow_1.Size = new System.Drawing.Size(86, 31);
            this.butnAddNewRow_1.TabIndex = 4;
            this.butnAddNewRow_1.Text = "+";
            this.butnAddNewRow_1.UseVisualStyleBackColor = true;
            this.butnAddNewRow_1.Click += new System.EventHandler(this.butnAddNewRow_1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(798, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Close Bracket";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(582, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Table/Column value";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(472, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Comparer";
            // 
            // LblColumn_1
            // 
            this.LblColumn_1.AutoSize = true;
            this.LblColumn_1.Location = new System.Drawing.Point(277, 29);
            this.LblColumn_1.Name = "LblColumn_1";
            this.LblColumn_1.Size = new System.Drawing.Size(60, 20);
            this.LblColumn_1.TabIndex = 3;
            this.LblColumn_1.Text = "Column";
            // 
            // LblTable_1
            // 
            this.LblTable_1.AutoSize = true;
            this.LblTable_1.Location = new System.Drawing.Point(136, 29);
            this.LblTable_1.Name = "LblTable_1";
            this.LblTable_1.Size = new System.Drawing.Size(44, 20);
            this.LblTable_1.TabIndex = 3;
            this.LblTable_1.Text = "Table";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Open Bracket";
            // 
            // BtnTCCondition2_1
            // 
            this.BtnTCCondition2_1.Location = new System.Drawing.Point(746, 56);
            this.BtnTCCondition2_1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnTCCondition2_1.Name = "BtnTCCondition2_1";
            this.BtnTCCondition2_1.Size = new System.Drawing.Size(34, 31);
            this.BtnTCCondition2_1.TabIndex = 2;
            this.BtnTCCondition2_1.Text = "...";
            this.BtnTCCondition2_1.UseVisualStyleBackColor = true;
            this.BtnTCCondition2_1.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnTCCondition1_1
            // 
            this.BtnTCCondition1_1.Location = new System.Drawing.Point(424, 56);
            this.BtnTCCondition1_1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnTCCondition1_1.Name = "BtnTCCondition1_1";
            this.BtnTCCondition1_1.Size = new System.Drawing.Size(34, 31);
            this.BtnTCCondition1_1.TabIndex = 2;
            this.BtnTCCondition1_1.Text = "...";
            this.BtnTCCondition1_1.UseVisualStyleBackColor = true;
            this.BtnTCCondition1_1.Click += new System.EventHandler(this.BtnTCCondition1_1_Click);
            // 
            // textValue_1
            // 
            this.textValue_1.Location = new System.Drawing.Point(553, 56);
            this.textValue_1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textValue_1.Name = "textValue_1";
            this.textValue_1.Size = new System.Drawing.Size(187, 27);
            this.textValue_1.TabIndex = 1;
            // 
            // CmbCloseBracket_1
            // 
            this.CmbCloseBracket_1.FormattingEnabled = true;
            this.CmbCloseBracket_1.Items.AddRange(new object[] {
            ")",
            "))",
            ")))",
            "))))",
            "Add More"});
            this.CmbCloseBracket_1.Location = new System.Drawing.Point(798, 56);
            this.CmbCloseBracket_1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CmbCloseBracket_1.Name = "CmbCloseBracket_1";
            this.CmbCloseBracket_1.Size = new System.Drawing.Size(85, 28);
            this.CmbCloseBracket_1.TabIndex = 0;
            // 
            // CmbComparer_1
            // 
            this.CmbComparer_1.FormattingEnabled = true;
            this.CmbComparer_1.Items.AddRange(new object[] {
            "like",
            "=",
            ">",
            ">=",
            "<",
            "<="});
            this.CmbComparer_1.Location = new System.Drawing.Point(472, 56);
            this.CmbComparer_1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CmbComparer_1.Name = "CmbComparer_1";
            this.CmbComparer_1.Size = new System.Drawing.Size(75, 28);
            this.CmbComparer_1.TabIndex = 0;
            this.CmbComparer_1.Text = "=";
            // 
            // CmbColumn_1
            // 
            this.CmbColumn_1.FormattingEnabled = true;
            this.CmbColumn_1.Items.AddRange(new object[] {
            "ColumnOne",
            "ColumnTwo",
            "ColumnThree",
            "ColumnFour",
            "ColumnFive"});
            this.CmbColumn_1.Location = new System.Drawing.Point(273, 56);
            this.CmbColumn_1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CmbColumn_1.Name = "CmbColumn_1";
            this.CmbColumn_1.Size = new System.Drawing.Size(149, 28);
            this.CmbColumn_1.TabIndex = 0;
            this.CmbColumn_1.SelectedIndexChanged += new System.EventHandler(this.CmbColumn_1_SelectedIndexChanged);
            // 
            // CmbTable_1
            // 
            this.CmbTable_1.FormattingEnabled = true;
            this.CmbTable_1.Items.AddRange(new object[] {
            "TableOne",
            "TableTwo",
            "TableThree",
            "TableFour"});
            this.CmbTable_1.Location = new System.Drawing.Point(120, 56);
            this.CmbTable_1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CmbTable_1.Name = "CmbTable_1";
            this.CmbTable_1.Size = new System.Drawing.Size(151, 28);
            this.CmbTable_1.TabIndex = 0;
            this.CmbTable_1.SelectedIndexChanged += new System.EventHandler(this.CmbTable_1_SelectedIndexChanged);
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
            this.CmbOpenBracket_1.Location = new System.Drawing.Point(29, 56);
            this.CmbOpenBracket_1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CmbOpenBracket_1.Name = "CmbOpenBracket_1";
            this.CmbOpenBracket_1.Size = new System.Drawing.Size(85, 28);
            this.CmbOpenBracket_1.TabIndex = 0;
            // 
            // PanelOperator
            // 
            this.PanelOperator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelOperator.Controls.Add(this.btnConAND);
            this.PanelOperator.Controls.Add(this.BtnConditionOR);
            this.PanelOperator.Location = new System.Drawing.Point(1107, 3);
            this.PanelOperator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PanelOperator.Name = "PanelOperator";
            this.PanelOperator.Size = new System.Drawing.Size(113, 98);
            this.PanelOperator.TabIndex = 4;
            this.PanelOperator.Visible = false;
            // 
            // btnConAND
            // 
            this.btnConAND.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConAND.Location = new System.Drawing.Point(15, 13);
            this.btnConAND.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConAND.Name = "btnConAND";
            this.btnConAND.Size = new System.Drawing.Size(86, 31);
            this.btnConAND.TabIndex = 0;
            this.btnConAND.Text = "AND";
            this.btnConAND.UseVisualStyleBackColor = true;
            this.btnConAND.Click += new System.EventHandler(this.btnConAND_Click);
            // 
            // BtnConditionOR
            // 
            this.BtnConditionOR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConditionOR.Location = new System.Drawing.Point(15, 57);
            this.BtnConditionOR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnConditionOR.Name = "BtnConditionOR";
            this.BtnConditionOR.Size = new System.Drawing.Size(86, 31);
            this.BtnConditionOR.TabIndex = 0;
            this.BtnConditionOR.Text = "OR";
            this.BtnConditionOR.UseVisualStyleBackColor = true;
            this.BtnConditionOR.Click += new System.EventHandler(this.BtnConditionOR_Click);
            // 
            // AddCondition
            // 
            this.AddCondition.Location = new System.Drawing.Point(1178, 659);
            this.AddCondition.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddCondition.Name = "AddCondition";
            this.AddCondition.Size = new System.Drawing.Size(138, 33);
            this.AddCondition.TabIndex = 5;
            this.AddCondition.Text = "Add Condition";
            this.AddCondition.UseVisualStyleBackColor = true;
            this.AddCondition.Click += new System.EventHandler(this.AddCondition_Click);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(1058, 659);
            this.Close.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(114, 33);
            this.Close.TabIndex = 5;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Generate
            // 
            this.Generate.Location = new System.Drawing.Point(1228, 499);
            this.Generate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(88, 33);
            this.Generate.TabIndex = 5;
            this.Generate.Text = "Generate";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // NameConditionBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 698);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.AddCondition);
            this.Controls.Add(this.PanelOperator);
            this.Controls.Add(this.PanelConditionContainer);
            this.Controls.Add(this.ConditionBox);
            this.Controls.Add(this.tableList_listBox);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "NameConditionBuilder";
            this.Text = "ConditionBuilder";
            this.PanelConditionContainer.ResumeLayout(false);
            this.GroupConditionRow_1.ResumeLayout(false);
            this.GroupConditionRow_1.PerformLayout();
            this.PanelOperator.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox tableList_listBox;
        private System.Windows.Forms.RichTextBox ConditionBox;
        private System.Windows.Forms.Panel PanelConditionContainer;
        private customGroupBox GroupConditionRow_1;
        private System.Windows.Forms.Button BtnTCCondition2_1;
        private System.Windows.Forms.Button BtnTCCondition1_1;
        private CustomTextBox textValue_1;
        private System.Windows.Forms.ComboBox CmbCloseBracket_1;
        private System.Windows.Forms.ComboBox CmbComparer_1;
        private System.Windows.Forms.ComboBox CmbTable_1;
        private System.Windows.Forms.ComboBox CmbOpenBracket_1;
        private System.Windows.Forms.Button Delete_1;
        private System.Windows.Forms.Button butnAddNewRow_1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblColumn_1;
        private System.Windows.Forms.Label LblTable_1;
        private System.Windows.Forms.Label label1;
        private CustomPanel PanelOperator;
        private System.Windows.Forms.Button btnConAND;
        private System.Windows.Forms.Button BtnConditionOR;
        private System.Windows.Forms.Button AddCondition;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.TextBox textValue1_1;
        private System.Windows.Forms.ComboBox CmbColumn_1;
        private System.Windows.Forms.Label LbTablecolumn_1;
    }
}