
namespace Patch_Master.Forms
{
    partial class QueryTypes
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
            this.dataGridViewQueryTypes = new System.Windows.Forms.DataGridView();
            this.buttonAppReq = new System.Windows.Forms.Button();
            this.buttonAppNotReq = new System.Windows.Forms.Button();
            this.buttonRetrun = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQueryTypes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewQueryTypes
            // 
            this.dataGridViewQueryTypes.AllowUserToAddRows = false;
            this.dataGridViewQueryTypes.AllowUserToDeleteRows = false;
            this.dataGridViewQueryTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQueryTypes.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewQueryTypes.Name = "dataGridViewQueryTypes";
            this.dataGridViewQueryTypes.ReadOnly = true;
            this.dataGridViewQueryTypes.RowHeadersWidth = 51;
            this.dataGridViewQueryTypes.RowTemplate.Height = 29;
            this.dataGridViewQueryTypes.Size = new System.Drawing.Size(656, 212);
            this.dataGridViewQueryTypes.TabIndex = 0;
            this.dataGridViewQueryTypes.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewQueryTypes_RowHeaderMouseClick);
            // 
            // buttonAppReq
            // 
            this.buttonAppReq.Location = new System.Drawing.Point(12, 244);
            this.buttonAppReq.Name = "buttonAppReq";
            this.buttonAppReq.Size = new System.Drawing.Size(157, 29);
            this.buttonAppReq.TabIndex = 1;
            this.buttonAppReq.Text = "Approval Required";
            this.buttonAppReq.UseVisualStyleBackColor = true;
            this.buttonAppReq.Visible = false;
            this.buttonAppReq.Click += new System.EventHandler(this.buttonAppReq_Click);
            // 
            // buttonAppNotReq
            // 
            this.buttonAppNotReq.Location = new System.Drawing.Point(12, 244);
            this.buttonAppNotReq.Name = "buttonAppNotReq";
            this.buttonAppNotReq.Size = new System.Drawing.Size(183, 29);
            this.buttonAppNotReq.TabIndex = 2;
            this.buttonAppNotReq.Text = "Approval Not Required";
            this.buttonAppNotReq.UseVisualStyleBackColor = true;
            this.buttonAppNotReq.Visible = false;
            this.buttonAppNotReq.Click += new System.EventHandler(this.buttonAppNotReq_Click);
            // 
            // buttonRetrun
            // 
            this.buttonRetrun.Location = new System.Drawing.Point(557, 247);
            this.buttonRetrun.Name = "buttonRetrun";
            this.buttonRetrun.Size = new System.Drawing.Size(111, 26);
            this.buttonRetrun.TabIndex = 3;
            this.buttonRetrun.Text = "Return";
            this.buttonRetrun.UseVisualStyleBackColor = true;
            this.buttonRetrun.Click += new System.EventHandler(this.buttonRetrun_Click);
            // 
            // QueryTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 300);
            this.Controls.Add(this.buttonRetrun);
            this.Controls.Add(this.buttonAppNotReq);
            this.Controls.Add(this.buttonAppReq);
            this.Controls.Add(this.dataGridViewQueryTypes);
            this.Name = "QueryTypes";
            this.Text = "QueryTypes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQueryTypes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewQueryTypes;
        private System.Windows.Forms.Button buttonAppReq;
        private System.Windows.Forms.Button buttonAppNotReq;
        private System.Windows.Forms.Button buttonRetrun;
    }
}