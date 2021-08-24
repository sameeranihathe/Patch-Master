
namespace Patch_Master.Forms
{
    partial class RequestedQueryConditions
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
            this.panelRequestedConditions = new System.Windows.Forms.Panel();
            this.LabelCondition = new System.Windows.Forms.Label();
            this.labelOpendBracket = new System.Windows.Forms.Label();
            this.LbTablecolumn = new System.Windows.Forms.Label();
            this.labelCloseBracket = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelValue = new System.Windows.Forms.Label();
            this.richTextBoxCondition = new System.Windows.Forms.RichTextBox();
            this.buttonGenarate = new System.Windows.Forms.Button();
            this.buttonDone = new System.Windows.Forms.Button();
            this.panelRequestedConditions.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelRequestedConditions
            // 
            this.panelRequestedConditions.AutoScroll = true;
            this.panelRequestedConditions.Controls.Add(this.LabelCondition);
            this.panelRequestedConditions.Controls.Add(this.labelOpendBracket);
            this.panelRequestedConditions.Controls.Add(this.LbTablecolumn);
            this.panelRequestedConditions.Controls.Add(this.labelCloseBracket);
            this.panelRequestedConditions.Controls.Add(this.label4);
            this.panelRequestedConditions.Controls.Add(this.labelValue);
            this.panelRequestedConditions.Location = new System.Drawing.Point(23, 12);
            this.panelRequestedConditions.Name = "panelRequestedConditions";
            this.panelRequestedConditions.Size = new System.Drawing.Size(1265, 329);
            this.panelRequestedConditions.TabIndex = 0;
            // 
            // LabelCondition
            // 
            this.LabelCondition.AutoSize = true;
            this.LabelCondition.Location = new System.Drawing.Point(1042, 17);
            this.LabelCondition.Name = "LabelCondition";
            this.LabelCondition.Size = new System.Drawing.Size(74, 20);
            this.LabelCondition.TabIndex = 16;
            this.LabelCondition.Text = "Condition";
            // 
            // labelOpendBracket
            // 
            this.labelOpendBracket.AutoSize = true;
            this.labelOpendBracket.Location = new System.Drawing.Point(15, 17);
            this.labelOpendBracket.Name = "labelOpendBracket";
            this.labelOpendBracket.Size = new System.Drawing.Size(98, 20);
            this.labelOpendBracket.TabIndex = 4;
            this.labelOpendBracket.Text = "Open Bracket";
            // 
            // LbTablecolumn
            // 
            this.LbTablecolumn.AutoSize = true;
            this.LbTablecolumn.Location = new System.Drawing.Point(139, 17);
            this.LbTablecolumn.Name = "LbTablecolumn";
            this.LbTablecolumn.Size = new System.Drawing.Size(98, 20);
            this.LbTablecolumn.TabIndex = 8;
            this.LbTablecolumn.Text = "Table.Column";
            this.LbTablecolumn.Visible = false;
            // 
            // labelCloseBracket
            // 
            this.labelCloseBracket.AutoSize = true;
            this.labelCloseBracket.Location = new System.Drawing.Point(923, 17);
            this.labelCloseBracket.Name = "labelCloseBracket";
            this.labelCloseBracket.Size = new System.Drawing.Size(98, 20);
            this.labelCloseBracket.TabIndex = 14;
            this.labelCloseBracket.Text = "Close Bracket";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(473, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Comparer";
            // 
            // labelValue
            // 
            this.labelValue.AutoSize = true;
            this.labelValue.Location = new System.Drawing.Point(604, 16);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(144, 20);
            this.labelValue.TabIndex = 12;
            this.labelValue.Text = "Table.Column/ Value";
            // 
            // richTextBoxCondition
            // 
            this.richTextBoxCondition.Location = new System.Drawing.Point(34, 392);
            this.richTextBoxCondition.Name = "richTextBoxCondition";
            this.richTextBoxCondition.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBoxCondition.Size = new System.Drawing.Size(1254, 96);
            this.richTextBoxCondition.TabIndex = 1;
            this.richTextBoxCondition.Text = "";
            // 
            // buttonGenarate
            // 
            this.buttonGenarate.Location = new System.Drawing.Point(1183, 357);
            this.buttonGenarate.Name = "buttonGenarate";
            this.buttonGenarate.Size = new System.Drawing.Size(94, 29);
            this.buttonGenarate.TabIndex = 2;
            this.buttonGenarate.Text = "Generate";
            this.buttonGenarate.UseVisualStyleBackColor = true;
            this.buttonGenarate.Click += new System.EventHandler(this.buttonGenarate_Click);
            // 
            // buttonDone
            // 
            this.buttonDone.Location = new System.Drawing.Point(1183, 494);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(94, 32);
            this.buttonDone.TabIndex = 3;
            this.buttonDone.Text = "Done";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // RequestedQueryConditions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 534);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.buttonGenarate);
            this.Controls.Add(this.richTextBoxCondition);
            this.Controls.Add(this.panelRequestedConditions);
            this.Name = "RequestedQueryConditions";
            this.Text = "RequestedQueryConditions";
            this.panelRequestedConditions.ResumeLayout(false);
            this.panelRequestedConditions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelRequestedConditions;
        private System.Windows.Forms.GroupBox groupBoxConditionRow;
        private System.Windows.Forms.TextBox textBoxOpenBrakets;
        private System.Windows.Forms.Label labelOpendBracket;
        private System.Windows.Forms.TextBox textBoxTableColunm;
        private System.Windows.Forms.Label LbTablecolumn;
        private System.Windows.Forms.ComboBox comboBoxComparer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelValue;
        private System.Windows.Forms.TextBox textBoxCondition;
        private System.Windows.Forms.Label LabelCondition;
        private System.Windows.Forms.TextBox textBoxCloseBrackets;
        private System.Windows.Forms.Label labelCloseBracket;
        private System.Windows.Forms.TextBox textBoxValue;
        private System.Windows.Forms.RichTextBox richTextBoxCondition;
        private System.Windows.Forms.Button buttonGenarate;
        private System.Windows.Forms.Button buttonDone;
    }
}