
namespace Patch_Master.Forms
{
    partial class AvailableQueries
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
            this.SavedQueries_dataGridView = new System.Windows.Forms.DataGridView();
            this.AddQuery_button = new System.Windows.Forms.Button();
            this.DeleteQuery_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SavedQueries_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SavedQueries_dataGridView
            // 
            this.SavedQueries_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SavedQueries_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SavedQueries_dataGridView.Location = new System.Drawing.Point(23, 25);
            this.SavedQueries_dataGridView.Name = "SavedQueries_dataGridView";
            this.SavedQueries_dataGridView.RowTemplate.Height = 25;
            this.SavedQueries_dataGridView.Size = new System.Drawing.Size(618, 150);
            this.SavedQueries_dataGridView.TabIndex = 0;
            // 
            // AddQuery_button
            // 
            this.AddQuery_button.Location = new System.Drawing.Point(23, 231);
            this.AddQuery_button.Name = "AddQuery_button";
            this.AddQuery_button.Size = new System.Drawing.Size(75, 23);
            this.AddQuery_button.TabIndex = 1;
            this.AddQuery_button.Text = "Add Query";
            this.AddQuery_button.UseVisualStyleBackColor = true;
            this.AddQuery_button.Click += new System.EventHandler(this.AddQuery_button_Click);
            // 
            // DeleteQuery_button
            // 
            this.DeleteQuery_button.Location = new System.Drawing.Point(140, 231);
            this.DeleteQuery_button.Name = "DeleteQuery_button";
            this.DeleteQuery_button.Size = new System.Drawing.Size(92, 23);
            this.DeleteQuery_button.TabIndex = 2;
            this.DeleteQuery_button.Text = "Delete Query";
            this.DeleteQuery_button.UseVisualStyleBackColor = true;
            // 
            // AvailableQueries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeleteQuery_button);
            this.Controls.Add(this.AddQuery_button);
            this.Controls.Add(this.SavedQueries_dataGridView);
            this.Name = "AvailableQueries";
            this.Text = "AvailableQueries";
            ((System.ComponentModel.ISupportInitialize)(this.SavedQueries_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView SavedQueries_dataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button DeleteQuery_button;
        private System.Windows.Forms.Button AddQuery_button;
    }
}