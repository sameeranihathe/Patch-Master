
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
            this.DeleteProcess_btn = new System.Windows.Forms.Button();
            this.button_SaveProcess = new System.Windows.Forms.Button();
            this.SubProcesses_btn = new System.Windows.Forms.Button();
            this.groupBoxMainProcess = new System.Windows.Forms.GroupBox();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.buttonModifyMP = new System.Windows.Forms.Button();
            this.textBoxMPCreatedDate = new System.Windows.Forms.TextBox();
            this.textBoxMPCreatedUser = new System.Windows.Forms.TextBox();
            this.textBoxMPDesc = new System.Windows.Forms.TextBox();
            this.textBoxMPName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SubProcess_panel = new System.Windows.Forms.GroupBox();
            this.buttonModifySP = new System.Windows.Forms.Button();
            this.textBoxSPCreatedDate = new System.Windows.Forms.TextBox();
            this.textBoxSPCreatedUser = new System.Windows.Forms.TextBox();
            this.textBoxSPDescription = new System.Windows.Forms.TextBox();
            this.textBoxSPName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_subProcessDone = new System.Windows.Forms.Button();
            this.btn_DeleteSubProcess = new System.Windows.Forms.Button();
            this.btn_AddSubProcess = new System.Windows.Forms.Button();
            this.dataGridView_SubProcesses = new System.Windows.Forms.DataGridView();
            this.lbl_processName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Processws)).BeginInit();
            this.groupBoxMainProcess.SuspendLayout();
            this.SubProcess_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SubProcesses)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Processws
            // 
            this.dataGridView_Processws.AllowUserToDeleteRows = false;
            this.dataGridView_Processws.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Processws.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Processws.Location = new System.Drawing.Point(6, 23);
            this.dataGridView_Processws.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView_Processws.Name = "dataGridView_Processws";
            this.dataGridView_Processws.ReadOnly = true;
            this.dataGridView_Processws.RowHeadersWidth = 51;
            this.dataGridView_Processws.RowTemplate.Height = 25;
            this.dataGridView_Processws.Size = new System.Drawing.Size(627, 317);
            this.dataGridView_Processws.TabIndex = 0;
            this.dataGridView_Processws.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_Processws_RowHeaderMouseClick);
            // 
            // DeleteProcess_btn
            // 
            this.DeleteProcess_btn.Location = new System.Drawing.Point(239, 577);
            this.DeleteProcess_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DeleteProcess_btn.Name = "DeleteProcess_btn";
            this.DeleteProcess_btn.Size = new System.Drawing.Size(119, 43);
            this.DeleteProcess_btn.TabIndex = 2;
            this.DeleteProcess_btn.Text = "Delete Process";
            this.DeleteProcess_btn.UseVisualStyleBackColor = true;
            this.DeleteProcess_btn.Visible = false;
            this.DeleteProcess_btn.Click += new System.EventHandler(this.DeleteProcess_btn_Click);
            // 
            // button_SaveProcess
            // 
            this.button_SaveProcess.Location = new System.Drawing.Point(10, 577);
            this.button_SaveProcess.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_SaveProcess.Name = "button_SaveProcess";
            this.button_SaveProcess.Size = new System.Drawing.Size(98, 43);
            this.button_SaveProcess.TabIndex = 4;
            this.button_SaveProcess.Text = "Add Process";
            this.button_SaveProcess.UseVisualStyleBackColor = true;
            this.button_SaveProcess.Visible = false;
            this.button_SaveProcess.Click += new System.EventHandler(this.button_SaveProcess_Click);
            // 
            // SubProcesses_btn
            // 
            this.SubProcesses_btn.Location = new System.Drawing.Point(364, 577);
            this.SubProcesses_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SubProcesses_btn.Name = "SubProcesses_btn";
            this.SubProcesses_btn.Size = new System.Drawing.Size(119, 43);
            this.SubProcesses_btn.TabIndex = 4;
            this.SubProcesses_btn.Text = "Sub Processes";
            this.SubProcesses_btn.UseVisualStyleBackColor = true;
            this.SubProcesses_btn.Visible = false;
            this.SubProcesses_btn.Click += new System.EventHandler(this.SubProcesses_btn_Click);
            // 
            // groupBoxMainProcess
            // 
            this.groupBoxMainProcess.Controls.Add(this.buttonReturn);
            this.groupBoxMainProcess.Controls.Add(this.buttonModifyMP);
            this.groupBoxMainProcess.Controls.Add(this.textBoxMPCreatedDate);
            this.groupBoxMainProcess.Controls.Add(this.textBoxMPCreatedUser);
            this.groupBoxMainProcess.Controls.Add(this.textBoxMPDesc);
            this.groupBoxMainProcess.Controls.Add(this.textBoxMPName);
            this.groupBoxMainProcess.Controls.Add(this.label5);
            this.groupBoxMainProcess.Controls.Add(this.button_SaveProcess);
            this.groupBoxMainProcess.Controls.Add(this.label4);
            this.groupBoxMainProcess.Controls.Add(this.label3);
            this.groupBoxMainProcess.Controls.Add(this.label2);
            this.groupBoxMainProcess.Controls.Add(this.dataGridView_Processws);
            this.groupBoxMainProcess.Controls.Add(this.DeleteProcess_btn);
            this.groupBoxMainProcess.Controls.Add(this.SubProcesses_btn);
            this.groupBoxMainProcess.Location = new System.Drawing.Point(12, 12);
            this.groupBoxMainProcess.Name = "groupBoxMainProcess";
            this.groupBoxMainProcess.Size = new System.Drawing.Size(639, 632);
            this.groupBoxMainProcess.TabIndex = 6;
            this.groupBoxMainProcess.TabStop = false;
            this.groupBoxMainProcess.Text = "Main Processors";
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(502, 577);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(109, 43);
            this.buttonReturn.TabIndex = 14;
            this.buttonReturn.Text = "Return";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // buttonModifyMP
            // 
            this.buttonModifyMP.Location = new System.Drawing.Point(114, 577);
            this.buttonModifyMP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonModifyMP.Name = "buttonModifyMP";
            this.buttonModifyMP.Size = new System.Drawing.Size(119, 43);
            this.buttonModifyMP.TabIndex = 13;
            this.buttonModifyMP.Text = "Modify Process";
            this.buttonModifyMP.UseVisualStyleBackColor = true;
            this.buttonModifyMP.Visible = false;
            this.buttonModifyMP.Click += new System.EventHandler(this.buttonModifyMP_Click);
            // 
            // textBoxMPCreatedDate
            // 
            this.textBoxMPCreatedDate.Location = new System.Drawing.Point(173, 519);
            this.textBoxMPCreatedDate.Name = "textBoxMPCreatedDate";
            this.textBoxMPCreatedDate.ReadOnly = true;
            this.textBoxMPCreatedDate.Size = new System.Drawing.Size(125, 27);
            this.textBoxMPCreatedDate.TabIndex = 12;
            // 
            // textBoxMPCreatedUser
            // 
            this.textBoxMPCreatedUser.Location = new System.Drawing.Point(173, 485);
            this.textBoxMPCreatedUser.Name = "textBoxMPCreatedUser";
            this.textBoxMPCreatedUser.ReadOnly = true;
            this.textBoxMPCreatedUser.Size = new System.Drawing.Size(125, 27);
            this.textBoxMPCreatedUser.TabIndex = 11;
            // 
            // textBoxMPDesc
            // 
            this.textBoxMPDesc.Location = new System.Drawing.Point(173, 405);
            this.textBoxMPDesc.Multiline = true;
            this.textBoxMPDesc.Name = "textBoxMPDesc";
            this.textBoxMPDesc.Size = new System.Drawing.Size(391, 62);
            this.textBoxMPDesc.TabIndex = 10;
            // 
            // textBoxMPName
            // 
            this.textBoxMPName.Location = new System.Drawing.Point(173, 361);
            this.textBoxMPName.Name = "textBoxMPName";
            this.textBoxMPName.Size = new System.Drawing.Size(237, 27);
            this.textBoxMPName.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 519);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Created Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 492);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Created User";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 408);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Process Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Process Name";
            // 
            // SubProcess_panel
            // 
            this.SubProcess_panel.Controls.Add(this.buttonModifySP);
            this.SubProcess_panel.Controls.Add(this.textBoxSPCreatedDate);
            this.SubProcess_panel.Controls.Add(this.textBoxSPCreatedUser);
            this.SubProcess_panel.Controls.Add(this.textBoxSPDescription);
            this.SubProcess_panel.Controls.Add(this.textBoxSPName);
            this.SubProcess_panel.Controls.Add(this.label6);
            this.SubProcess_panel.Controls.Add(this.label7);
            this.SubProcess_panel.Controls.Add(this.label8);
            this.SubProcess_panel.Controls.Add(this.label9);
            this.SubProcess_panel.Controls.Add(this.btn_subProcessDone);
            this.SubProcess_panel.Controls.Add(this.btn_DeleteSubProcess);
            this.SubProcess_panel.Controls.Add(this.btn_AddSubProcess);
            this.SubProcess_panel.Controls.Add(this.dataGridView_SubProcesses);
            this.SubProcess_panel.Controls.Add(this.lbl_processName);
            this.SubProcess_panel.Controls.Add(this.label1);
            this.SubProcess_panel.Location = new System.Drawing.Point(657, 12);
            this.SubProcess_panel.Name = "SubProcess_panel";
            this.SubProcess_panel.Size = new System.Drawing.Size(672, 632);
            this.SubProcess_panel.TabIndex = 7;
            this.SubProcess_panel.TabStop = false;
            this.SubProcess_panel.Text = "Sub Processors ";
            this.SubProcess_panel.Visible = false;
            // 
            // buttonModifySP
            // 
            this.buttonModifySP.Location = new System.Drawing.Point(146, 577);
            this.buttonModifySP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonModifySP.Name = "buttonModifySP";
            this.buttonModifySP.Size = new System.Drawing.Size(119, 43);
            this.buttonModifySP.TabIndex = 21;
            this.buttonModifySP.Text = "Modify Process";
            this.buttonModifySP.UseVisualStyleBackColor = true;
            this.buttonModifySP.Visible = false;
            this.buttonModifySP.Click += new System.EventHandler(this.buttonModifySP_Click);
            // 
            // textBoxSPCreatedDate
            // 
            this.textBoxSPCreatedDate.Location = new System.Drawing.Point(196, 516);
            this.textBoxSPCreatedDate.Name = "textBoxSPCreatedDate";
            this.textBoxSPCreatedDate.ReadOnly = true;
            this.textBoxSPCreatedDate.Size = new System.Drawing.Size(125, 27);
            this.textBoxSPCreatedDate.TabIndex = 20;
            // 
            // textBoxSPCreatedUser
            // 
            this.textBoxSPCreatedUser.Location = new System.Drawing.Point(196, 482);
            this.textBoxSPCreatedUser.Name = "textBoxSPCreatedUser";
            this.textBoxSPCreatedUser.ReadOnly = true;
            this.textBoxSPCreatedUser.Size = new System.Drawing.Size(125, 27);
            this.textBoxSPCreatedUser.TabIndex = 19;
            // 
            // textBoxSPDescription
            // 
            this.textBoxSPDescription.Location = new System.Drawing.Point(196, 402);
            this.textBoxSPDescription.Multiline = true;
            this.textBoxSPDescription.Name = "textBoxSPDescription";
            this.textBoxSPDescription.Size = new System.Drawing.Size(391, 62);
            this.textBoxSPDescription.TabIndex = 18;
            // 
            // textBoxSPName
            // 
            this.textBoxSPName.Location = new System.Drawing.Point(196, 358);
            this.textBoxSPName.Name = "textBoxSPName";
            this.textBoxSPName.Size = new System.Drawing.Size(302, 27);
            this.textBoxSPName.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 516);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Created Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 489);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Created User";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 405);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Process Description";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 358);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "Process Name";
            // 
            // btn_subProcessDone
            // 
            this.btn_subProcessDone.Location = new System.Drawing.Point(546, 577);
            this.btn_subProcessDone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_subProcessDone.Name = "btn_subProcessDone";
            this.btn_subProcessDone.Size = new System.Drawing.Size(86, 43);
            this.btn_subProcessDone.TabIndex = 12;
            this.btn_subProcessDone.Text = "Done";
            this.btn_subProcessDone.UseVisualStyleBackColor = true;
            this.btn_subProcessDone.Click += new System.EventHandler(this.btn_subProcessDone_Click_1);
            // 
            // btn_DeleteSubProcess
            // 
            this.btn_DeleteSubProcess.Location = new System.Drawing.Point(369, 577);
            this.btn_DeleteSubProcess.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_DeleteSubProcess.Name = "btn_DeleteSubProcess";
            this.btn_DeleteSubProcess.Size = new System.Drawing.Size(129, 43);
            this.btn_DeleteSubProcess.TabIndex = 11;
            this.btn_DeleteSubProcess.Text = "Delete Process";
            this.btn_DeleteSubProcess.UseVisualStyleBackColor = true;
            this.btn_DeleteSubProcess.Visible = false;
            // 
            // btn_AddSubProcess
            // 
            this.btn_AddSubProcess.Location = new System.Drawing.Point(19, 577);
            this.btn_AddSubProcess.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_AddSubProcess.Name = "btn_AddSubProcess";
            this.btn_AddSubProcess.Size = new System.Drawing.Size(112, 43);
            this.btn_AddSubProcess.TabIndex = 10;
            this.btn_AddSubProcess.Text = "Add Process";
            this.btn_AddSubProcess.UseVisualStyleBackColor = true;
            this.btn_AddSubProcess.Visible = false;
            this.btn_AddSubProcess.Click += new System.EventHandler(this.btn_AddSubProcess_Click_1);
            // 
            // dataGridView_SubProcesses
            // 
            this.dataGridView_SubProcesses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_SubProcesses.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_SubProcesses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_SubProcesses.Location = new System.Drawing.Point(6, 27);
            this.dataGridView_SubProcesses.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView_SubProcesses.Name = "dataGridView_SubProcesses";
            this.dataGridView_SubProcesses.RowHeadersWidth = 51;
            this.dataGridView_SubProcesses.RowTemplate.Height = 25;
            this.dataGridView_SubProcesses.Size = new System.Drawing.Size(660, 313);
            this.dataGridView_SubProcesses.TabIndex = 9;
            this.dataGridView_SubProcesses.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_SubProcesses_RowHeaderMouseClick);
            // 
            // lbl_processName
            // 
            this.lbl_processName.AutoSize = true;
            this.lbl_processName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_processName.Location = new System.Drawing.Point(239, -35);
            this.lbl_processName.Name = "lbl_processName";
            this.lbl_processName.Size = new System.Drawing.Size(57, 28);
            this.lbl_processName.TabIndex = 8;
            this.lbl_processName.Text = "xxxxx";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(77, -35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "Process Name";
            // 
            // Processes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 661);
            this.Controls.Add(this.SubProcess_panel);
            this.Controls.Add(this.groupBoxMainProcess);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Processes";
            this.Text = "Processes";
            this.Load += new System.EventHandler(this.Processes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Processws)).EndInit();
            this.groupBoxMainProcess.ResumeLayout(false);
            this.groupBoxMainProcess.PerformLayout();
            this.SubProcess_panel.ResumeLayout(false);
            this.SubProcess_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SubProcesses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Processws;
        private System.Windows.Forms.Button DeleteProcess_btn;
        private System.Windows.Forms.Button button_SaveProcess;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button SubProcesses_btn;
        private System.Windows.Forms.GroupBox groupBoxMainProcess;
        private System.Windows.Forms.TextBox textBoxMPCreatedDate;
        private System.Windows.Forms.TextBox textBoxMPCreatedUser;
        private System.Windows.Forms.TextBox textBoxMPDesc;
        private System.Windows.Forms.TextBox textBoxMPName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonModifyMP;
        private System.Windows.Forms.GroupBox SubProcess_panel;
        private System.Windows.Forms.Button btn_subProcessDone;
        private System.Windows.Forms.Button btn_DeleteSubProcess;
        private System.Windows.Forms.Button btn_AddSubProcess;
        private System.Windows.Forms.DataGridView dataGridView_SubProcesses;
        private System.Windows.Forms.Label lbl_processName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonModifySP;
        private System.Windows.Forms.TextBox textBoxSPCreatedDate;
        private System.Windows.Forms.TextBox textBoxSPCreatedUser;
        private System.Windows.Forms.TextBox textBoxSPDescription;
        private System.Windows.Forms.TextBox textBoxSPName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonReturn;
    }
}