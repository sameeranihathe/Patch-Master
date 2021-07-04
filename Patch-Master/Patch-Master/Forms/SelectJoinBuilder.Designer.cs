
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
            this.SuspendLayout();
            // 
            // JoinBuilder_panel
            // 
            this.JoinBuilder_panel.AutoScroll = true;
            this.JoinBuilder_panel.Location = new System.Drawing.Point(12, 43);
            this.JoinBuilder_panel.Name = "JoinBuilder_panel";
            this.JoinBuilder_panel.Size = new System.Drawing.Size(776, 254);
            this.JoinBuilder_panel.TabIndex = 0;
            // 
            // SelectJoinBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.JoinBuilder_panel);
            this.Name = "SelectJoinBuilder";
            this.Text = "SelectJoinBuilder";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel JoinBuilder_panel;
    }
}