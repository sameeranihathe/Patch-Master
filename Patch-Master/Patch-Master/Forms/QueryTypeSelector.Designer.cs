using System;

namespace Patch_Master.Forms
{
    partial class QueryTypeSelector
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.Insert = new System.Windows.Forms.RadioButton();
            this.Update = new System.Windows.Forms.RadioButton();
            this.Select = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxExecutionOrder = new System.Windows.Forms.TextBox();
            this.labelExOrder = new System.Windows.Forms.Label();
            this.QueryDecription_richTextBox = new System.Windows.Forms.RichTextBox();
            this.QueryDescription_label = new System.Windows.Forms.Label();
            this.QueryName_textBox = new System.Windows.Forms.TextBox();
            this.QueryName_label = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select  query option you want to execute";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.Insert);
            this.groupBox1.Controls.Add(this.Update);
            this.groupBox1.Controls.Add(this.Select);
            this.groupBox1.Location = new System.Drawing.Point(539, 92);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(250, 417);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select a Query Type";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(32, 240);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(117, 24);
            this.radioButton4.TabIndex = 4;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Delete Query";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.selectQueryType);
            // 
            // Insert
            // 
            this.Insert.AutoSize = true;
            this.Insert.Location = new System.Drawing.Point(32, 97);
            this.Insert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(109, 24);
            this.Insert.TabIndex = 2;
            this.Insert.TabStop = true;
            this.Insert.Text = "Insert Query";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.CheckedChanged += new System.EventHandler(this.selectQueryType);
            // 
            // Update
            // 
            this.Update.AutoSize = true;
            this.Update.Location = new System.Drawing.Point(32, 167);
            this.Update.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(122, 24);
            this.Update.TabIndex = 3;
            this.Update.TabStop = true;
            this.Update.Text = "Update Query";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.CheckedChanged += new System.EventHandler(this.selectQueryType);
            // 
            // Select
            // 
            this.Select.AutoSize = true;
            this.Select.Location = new System.Drawing.Point(32, 31);
            this.Select.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Select.Name = "Select";
            this.Select.Size = new System.Drawing.Size(113, 24);
            this.Select.TabIndex = 1;
            this.Select.TabStop = true;
            this.Select.Text = "Select Query";
            this.Select.UseVisualStyleBackColor = true;
            this.Select.CheckedChanged += new System.EventHandler(this.selectQueryType);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(648, 548);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = "Go to query builder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxExecutionOrder);
            this.groupBox3.Controls.Add(this.labelExOrder);
            this.groupBox3.Controls.Add(this.QueryDecription_richTextBox);
            this.groupBox3.Controls.Add(this.QueryDescription_label);
            this.groupBox3.Controls.Add(this.QueryName_textBox);
            this.groupBox3.Controls.Add(this.QueryName_label);
            this.groupBox3.Location = new System.Drawing.Point(41, 92);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(470, 417);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Query Details";
            // 
            // textBoxExecutionOrder
            // 
            this.textBoxExecutionOrder.Location = new System.Drawing.Point(151, 241);
            this.textBoxExecutionOrder.Name = "textBoxExecutionOrder";
            this.textBoxExecutionOrder.Size = new System.Drawing.Size(125, 27);
            this.textBoxExecutionOrder.TabIndex = 5;
            this.textBoxExecutionOrder.Text = "0";
            // 
            // labelExOrder
            // 
            this.labelExOrder.AutoSize = true;
            this.labelExOrder.Location = new System.Drawing.Point(17, 244);
            this.labelExOrder.Name = "labelExOrder";
            this.labelExOrder.Size = new System.Drawing.Size(111, 20);
            this.labelExOrder.TabIndex = 4;
            this.labelExOrder.Text = "ExecutionOrder";
            // 
            // QueryDecription_richTextBox
            // 
            this.QueryDecription_richTextBox.Location = new System.Drawing.Point(151, 96);
            this.QueryDecription_richTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.QueryDecription_richTextBox.Name = "QueryDecription_richTextBox";
            this.QueryDecription_richTextBox.Size = new System.Drawing.Size(287, 127);
            this.QueryDecription_richTextBox.TabIndex = 3;
            this.QueryDecription_richTextBox.Text = "";
            // 
            // QueryDescription_label
            // 
            this.QueryDescription_label.AutoSize = true;
            this.QueryDescription_label.Location = new System.Drawing.Point(17, 119);
            this.QueryDescription_label.Name = "QueryDescription_label";
            this.QueryDescription_label.Size = new System.Drawing.Size(128, 20);
            this.QueryDescription_label.TabIndex = 2;
            this.QueryDescription_label.Text = "Query Description";
            // 
            // QueryName_textBox
            // 
            this.QueryName_textBox.Location = new System.Drawing.Point(151, 53);
            this.QueryName_textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.QueryName_textBox.Name = "QueryName_textBox";
            this.QueryName_textBox.Size = new System.Drawing.Size(242, 27);
            this.QueryName_textBox.TabIndex = 1;
            // 
            // QueryName_label
            // 
            this.QueryName_label.AutoSize = true;
            this.QueryName_label.Location = new System.Drawing.Point(17, 56);
            this.QueryName_label.Name = "QueryName_label";
            this.QueryName_label.Size = new System.Drawing.Size(92, 20);
            this.QueryName_label.TabIndex = 0;
            this.QueryName_label.Text = "Query Name";
            // 
            // QueryTypeSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 600);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "QueryTypeSelector";
            this.Text = "QueryTypeSelector";
            this.Load += new System.EventHandler(this.QueryTypeSelector_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton Insert;
        private System.Windows.Forms.RadioButton Update;
        private System.Windows.Forms.RadioButton Select;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox QueryDecription_richTextBox;
        private System.Windows.Forms.Label QueryDescription_label;
        private System.Windows.Forms.TextBox QueryName_textBox;
        private System.Windows.Forms.Label QueryName_label;
        private System.Windows.Forms.TextBox textBoxExecutionOrder;
        private System.Windows.Forms.Label labelExOrder;
    }
}