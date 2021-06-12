
namespace Patch_Master.Forms
{
    partial class Processes
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
            this.dataGridView_Processws = new System.Windows.Forms.DataGridView();
            this.ProcessId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProcessName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProcessDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddProcess_btn = new System.Windows.Forms.Button();
            this.DeleteProcess_btn = new System.Windows.Forms.Button();
            this.AddProcess_panel = new System.Windows.Forms.Panel();
            this.button_Done = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_SaveProcess = new System.Windows.Forms.Button();
            this.richTextBox_ProcessDescription = new System.Windows.Forms.RichTextBox();
            this.textBox_ProcessName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_ProcessName = new System.Windows.Forms.Label();
            this.SubProcess_panel = new System.Windows.Forms.Panel();
            this.btn_subProcessDone = new System.Windows.Forms.Button();
            this.btn_DeleteSubProcess = new System.Windows.Forms.Button();
            this.btn_AddSubProcess = new System.Windows.Forms.Button();
            this.dataGridView_SubProcesses = new System.Windows.Forms.DataGridView();
            this.lbl_processName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SubProcesses_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Processws)).BeginInit();
            this.AddProcess_panel.SuspendLayout();
            this.SubProcess_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SubProcesses)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Processws
            // 
            this.dataGridView_Processws.AllowUserToDeleteRows = false;
            this.dataGridView_Processws.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Processws.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Processws.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProcessId,
            this.ProcessName,
            this.ProcessDescription});
            this.dataGridView_Processws.Location = new System.Drawing.Point(28, 38);
            this.dataGridView_Processws.Name = "dataGridView_Processws";
            this.dataGridView_Processws.ReadOnly = true;
            this.dataGridView_Processws.RowTemplate.Height = 25;
            this.dataGridView_Processws.Size = new System.Drawing.Size(488, 121);
            this.dataGridView_Processws.TabIndex = 0;
            // 
            // ProcessId
            // 
            this.ProcessId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ProcessId.HeaderText = "ProcessId";
            this.ProcessId.Name = "ProcessId";
            this.ProcessId.ReadOnly = true;
            this.ProcessId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ProcessId.Width = 82;
            // 
            // ProcessName
            // 
            this.ProcessName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ProcessName.HeaderText = "Process Name";
            this.ProcessName.Name = "ProcessName";
            this.ProcessName.ReadOnly = true;
            this.ProcessName.Width = 107;
            // 
            // ProcessDescription
            // 
            this.ProcessDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ProcessDescription.HeaderText = "Description";
            this.ProcessDescription.MinimumWidth = 100;
            this.ProcessDescription.Name = "ProcessDescription";
            this.ProcessDescription.ReadOnly = true;
            this.ProcessDescription.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ProcessDescription.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // AddProcess_btn
            // 
            this.AddProcess_btn.Location = new System.Drawing.Point(569, 21);
            this.AddProcess_btn.Name = "AddProcess_btn";
            this.AddProcess_btn.Size = new System.Drawing.Size(104, 32);
            this.AddProcess_btn.TabIndex = 1;
            this.AddProcess_btn.Text = "Add Process";
            this.AddProcess_btn.UseVisualStyleBackColor = true;
            this.AddProcess_btn.Click += new System.EventHandler(this.AddProcess_btn_Click);
            // 
            // DeleteProcess_btn
            // 
            this.DeleteProcess_btn.Location = new System.Drawing.Point(569, 59);
            this.DeleteProcess_btn.Name = "DeleteProcess_btn";
            this.DeleteProcess_btn.Size = new System.Drawing.Size(104, 32);
            this.DeleteProcess_btn.TabIndex = 2;
            this.DeleteProcess_btn.Text = "Delete Process";
            this.DeleteProcess_btn.UseVisualStyleBackColor = true;
            this.DeleteProcess_btn.Click += new System.EventHandler(this.DeleteProcess_btn_Click);
            // 
            // AddProcess_panel
            // 
            this.AddProcess_panel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.AddProcess_panel.Controls.Add(this.button_Done);
            this.AddProcess_panel.Controls.Add(this.button_clear);
            this.AddProcess_panel.Controls.Add(this.button_SaveProcess);
            this.AddProcess_panel.Controls.Add(this.richTextBox_ProcessDescription);
            this.AddProcess_panel.Controls.Add(this.textBox_ProcessName);
            this.AddProcess_panel.Controls.Add(this.label2);
            this.AddProcess_panel.Controls.Add(this.label_ProcessName);
            this.AddProcess_panel.Location = new System.Drawing.Point(28, 188);
            this.AddProcess_panel.Name = "AddProcess_panel";
            this.AddProcess_panel.Size = new System.Drawing.Size(488, 301);
            this.AddProcess_panel.TabIndex = 3;
            // 
            // button_Done
            // 
            this.button_Done.Location = new System.Drawing.Point(367, 189);
            this.button_Done.Name = "button_Done";
            this.button_Done.Size = new System.Drawing.Size(79, 24);
            this.button_Done.TabIndex = 6;
            this.button_Done.Text = "Done";
            this.button_Done.UseVisualStyleBackColor = true;
            this.button_Done.Click += new System.EventHandler(this.button_Done_Click);
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(282, 189);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(79, 24);
            this.button_clear.TabIndex = 5;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_SaveProcess
            // 
            this.button_SaveProcess.Location = new System.Drawing.Point(197, 189);
            this.button_SaveProcess.Name = "button_SaveProcess";
            this.button_SaveProcess.Size = new System.Drawing.Size(79, 24);
            this.button_SaveProcess.TabIndex = 4;
            this.button_SaveProcess.Text = "Save";
            this.button_SaveProcess.UseVisualStyleBackColor = true;
            this.button_SaveProcess.Click += new System.EventHandler(this.button_SaveProcess_Click);
            // 
            // richTextBox_ProcessDescription
            // 
            this.richTextBox_ProcessDescription.Location = new System.Drawing.Point(197, 83);
            this.richTextBox_ProcessDescription.Name = "richTextBox_ProcessDescription";
            this.richTextBox_ProcessDescription.Size = new System.Drawing.Size(260, 79);
            this.richTextBox_ProcessDescription.TabIndex = 3;
            this.richTextBox_ProcessDescription.Text = "";
            // 
            // textBox_ProcessName
            // 
            this.textBox_ProcessName.Location = new System.Drawing.Point(197, 31);
            this.textBox_ProcessName.Name = "textBox_ProcessName";
            this.textBox_ProcessName.Size = new System.Drawing.Size(260, 23);
            this.textBox_ProcessName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(25, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Process Description";
            // 
            // label_ProcessName
            // 
            this.label_ProcessName.AutoSize = true;
            this.label_ProcessName.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label_ProcessName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_ProcessName.Location = new System.Drawing.Point(25, 33);
            this.label_ProcessName.Name = "label_ProcessName";
            this.label_ProcessName.Size = new System.Drawing.Size(109, 21);
            this.label_ProcessName.TabIndex = 0;
            this.label_ProcessName.Text = "Process Name";
            // 
            // SubProcess_panel
            // 
            this.SubProcess_panel.Controls.Add(this.btn_subProcessDone);
            this.SubProcess_panel.Controls.Add(this.btn_DeleteSubProcess);
            this.SubProcess_panel.Controls.Add(this.btn_AddSubProcess);
            this.SubProcess_panel.Controls.Add(this.dataGridView_SubProcesses);
            this.SubProcess_panel.Controls.Add(this.lbl_processName);
            this.SubProcess_panel.Controls.Add(this.label1);
            this.SubProcess_panel.Location = new System.Drawing.Point(28, 188);
            this.SubProcess_panel.Name = "SubProcess_panel";
            this.SubProcess_panel.Size = new System.Drawing.Size(816, 301);
            this.SubProcess_panel.TabIndex = 5;
            this.SubProcess_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.SubProcess_panel_Paint);
            // 
            // btn_subProcessDone
            // 
            this.btn_subProcessDone.Location = new System.Drawing.Point(286, 219);
            this.btn_subProcessDone.Name = "btn_subProcessDone";
            this.btn_subProcessDone.Size = new System.Drawing.Size(75, 23);
            this.btn_subProcessDone.TabIndex = 6;
            this.btn_subProcessDone.Text = "Done";
            this.btn_subProcessDone.UseVisualStyleBackColor = true;
            this.btn_subProcessDone.Click += new System.EventHandler(this.btn_subProcessDone_Click);
            // 
            // btn_DeleteSubProcess
            // 
            this.btn_DeleteSubProcess.Location = new System.Drawing.Point(186, 219);
            this.btn_DeleteSubProcess.Name = "btn_DeleteSubProcess";
            this.btn_DeleteSubProcess.Size = new System.Drawing.Size(75, 23);
            this.btn_DeleteSubProcess.TabIndex = 5;
            this.btn_DeleteSubProcess.Text = "Delete";
            this.btn_DeleteSubProcess.UseVisualStyleBackColor = true;
            this.btn_DeleteSubProcess.Click += new System.EventHandler(this.btn_DeleteSubProcess_Click);
            // 
            // btn_AddSubProcess
            // 
            this.btn_AddSubProcess.Location = new System.Drawing.Point(85, 219);
            this.btn_AddSubProcess.Name = "btn_AddSubProcess";
            this.btn_AddSubProcess.Size = new System.Drawing.Size(75, 23);
            this.btn_AddSubProcess.TabIndex = 4;
            this.btn_AddSubProcess.Text = "Add";
            this.btn_AddSubProcess.UseVisualStyleBackColor = true;
            this.btn_AddSubProcess.Click += new System.EventHandler(this.btn_AddSubProcess_Click);
            // 
            // dataGridView_SubProcesses
            // 
            this.dataGridView_SubProcesses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_SubProcesses.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_SubProcesses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_SubProcesses.Location = new System.Drawing.Point(28, 63);
            this.dataGridView_SubProcesses.Name = "dataGridView_SubProcesses";
            this.dataGridView_SubProcesses.RowTemplate.Height = 25;
            this.dataGridView_SubProcesses.Size = new System.Drawing.Size(342, 136);
            this.dataGridView_SubProcesses.TabIndex = 3;
            // 
            // lbl_processName
            // 
            this.lbl_processName.AutoSize = true;
            this.lbl_processName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_processName.Location = new System.Drawing.Point(170, 29);
            this.lbl_processName.Name = "lbl_processName";
            this.lbl_processName.Size = new System.Drawing.Size(45, 21);
            this.lbl_processName.TabIndex = 2;
            this.lbl_processName.Text = "xxxxx";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(28, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Process Name";
            // 
            // SubProcesses_btn
            // 
            this.SubProcesses_btn.Location = new System.Drawing.Point(569, 107);
            this.SubProcesses_btn.Name = "SubProcesses_btn";
            this.SubProcesses_btn.Size = new System.Drawing.Size(104, 32);
            this.SubProcesses_btn.TabIndex = 4;
            this.SubProcesses_btn.Text = "Sub Processes";
            this.SubProcesses_btn.UseVisualStyleBackColor = true;
            this.SubProcesses_btn.Click += new System.EventHandler(this.SubProcesses_btn_Click);
            // 
            // Processes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 568);
            this.Controls.Add(this.SubProcess_panel);
            this.Controls.Add(this.AddProcess_panel);
            this.Controls.Add(this.SubProcesses_btn);
            this.Controls.Add(this.DeleteProcess_btn);
            this.Controls.Add(this.AddProcess_btn);
            this.Controls.Add(this.dataGridView_Processws);
            this.Name = "Processes";
            this.Text = "Processes";
            this.Load += new System.EventHandler(this.Processes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Processws)).EndInit();
            this.AddProcess_panel.ResumeLayout(false);
            this.AddProcess_panel.PerformLayout();
            this.SubProcess_panel.ResumeLayout(false);
            this.SubProcess_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SubProcesses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Processws;
        private System.Windows.Forms.Button AddProcess_btn;
        private System.Windows.Forms.Button DeleteProcess_btn;
        private System.Windows.Forms.Panel AddProcess_panel;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_SaveProcess;
        private System.Windows.Forms.RichTextBox richTextBox_ProcessDescription;
        private System.Windows.Forms.TextBox textBox_ProcessName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_ProcessName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcessId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcessName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcessDescription;
        private System.Windows.Forms.Button button_Done;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button SubProcesses_btn;
        private System.Windows.Forms.Panel SubProcess_panel;
        private System.Windows.Forms.Label lbl_processName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_SubProcesses;
        private System.Windows.Forms.Button btn_subProcessDone;
        private System.Windows.Forms.Button btn_DeleteSubProcess;
        private System.Windows.Forms.Button btn_AddSubProcess;
    }
}