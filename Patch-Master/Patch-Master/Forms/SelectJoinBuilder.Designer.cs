
using System;

namespace Patch_Master.Forms
{
    partial class SelectJoinBuilder
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
            this.JoinBuilder_panel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // JoinBuilder_panel
            // 
            this.JoinBuilder_panel.AutoScroll = true;
            this.JoinBuilder_panel.Location = new System.Drawing.Point(14, 57);
            this.JoinBuilder_panel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.JoinBuilder_panel.Name = "JoinBuilder_panel";
            this.JoinBuilder_panel.Size = new System.Drawing.Size(1200, 339);
            this.JoinBuilder_panel.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1005, 429);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1115, 429);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 31);
            this.button2.TabIndex = 2;
            this.button2.Text = "Add Join";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.AddJoins_Click);
            // 
            // SelectJoinBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 474);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.JoinBuilder_panel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SelectJoinBuilder";
            this.Text = "SelectJoinBuilder";
            this.Load += new System.EventHandler(this.SelectJoinBuilder_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel JoinBuilder_panel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}