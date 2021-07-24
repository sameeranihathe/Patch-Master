
namespace Patch_Master.Forms
{
    partial class InquireRequest
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBoxSearchRequest = new System.Windows.Forms.GroupBox();
            this.buttonViewRequests = new System.Windows.Forms.Button();
            this.comboBoxSubProcess = new System.Windows.Forms.ComboBox();
            this.comboBoxProcess = new System.Windows.Forms.ComboBox();
            this.SubProcess = new System.Windows.Forms.Label();
            this.Process = new System.Windows.Forms.Label();
            this.comboBoxExecuted = new System.Windows.Forms.ComboBox();
            this.comboBoxApproved = new System.Windows.Forms.ComboBox();
            this.Executed = new System.Windows.Forms.Label();
            this.Approved = new System.Windows.Forms.Label();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.groupBoxRequest = new System.Windows.Forms.GroupBox();
            this.richTextBoxComment = new System.Windows.Forms.RichTextBox();
            this.labelComment = new System.Windows.Forms.Label();
            this.buttonRejectRequest = new System.Windows.Forms.Button();
            this.labelApproval = new System.Windows.Forms.Label();
            this.checkBoxApproved = new System.Windows.Forms.TextBox();
            this.textBoxApprovedDate = new System.Windows.Forms.TextBox();
            this.textBoxApproveUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxExecuted = new System.Windows.Forms.CheckBox();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.buttonRequestedQueries = new System.Windows.Forms.Button();
            this.ButtonApprove = new System.Windows.Forms.Button();
            this.textBoxRequestDate = new System.Windows.Forms.TextBox();
            this.textBoxReqUser = new System.Windows.Forms.TextBox();
            this.textBoxDatabase = new System.Windows.Forms.TextBox();
            this.Database = new System.Windows.Forms.Label();
            this.textBoxRequirmentName = new System.Windows.Forms.TextBox();
            this.RequirmentName = new System.Windows.Forms.Label();
            this.textBoxRequestDescription = new System.Windows.Forms.TextBox();
            this.textBoxRequirmentObjective = new System.Windows.Forms.TextBox();
            this.labelRequestedDate = new System.Windows.Forms.Label();
            this.labelRequestUser = new System.Windows.Forms.Label();
            this.labelReqDescription = new System.Windows.Forms.Label();
            this.labelRequirmentObjective = new System.Windows.Forms.Label();
            this.dataGridViewRequestDetails = new System.Windows.Forms.DataGridView();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.groupBoxSearchByStatus = new System.Windows.Forms.GroupBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.groupBoxSearchRequest.SuspendLayout();
            this.groupBoxRequest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequestDetails)).BeginInit();
            this.groupBoxSearchByStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSearchRequest
            // 
            this.groupBoxSearchRequest.Controls.Add(this.buttonViewRequests);
            this.groupBoxSearchRequest.Controls.Add(this.comboBoxSubProcess);
            this.groupBoxSearchRequest.Controls.Add(this.comboBoxProcess);
            this.groupBoxSearchRequest.Controls.Add(this.SubProcess);
            this.groupBoxSearchRequest.Controls.Add(this.Process);
            this.groupBoxSearchRequest.Location = new System.Drawing.Point(11, 12);
            this.groupBoxSearchRequest.Name = "groupBoxSearchRequest";
            this.groupBoxSearchRequest.Size = new System.Drawing.Size(345, 165);
            this.groupBoxSearchRequest.TabIndex = 0;
            this.groupBoxSearchRequest.TabStop = false;
            this.groupBoxSearchRequest.Text = "Search Request";
            this.groupBoxSearchRequest.Visible = false;
            // 
            // buttonViewRequests
            // 
            this.buttonViewRequests.Location = new System.Drawing.Point(240, 109);
            this.buttonViewRequests.Name = "buttonViewRequests";
            this.buttonViewRequests.Size = new System.Drawing.Size(82, 31);
            this.buttonViewRequests.TabIndex = 1;
            this.buttonViewRequests.Text = "View";
            this.buttonViewRequests.UseVisualStyleBackColor = true;
            this.buttonViewRequests.Click += new System.EventHandler(this.buttonViewRequests_Click);
            // 
            // comboBoxSubProcess
            // 
            this.comboBoxSubProcess.FormattingEnabled = true;
            this.comboBoxSubProcess.Location = new System.Drawing.Point(133, 63);
            this.comboBoxSubProcess.Name = "comboBoxSubProcess";
            this.comboBoxSubProcess.Size = new System.Drawing.Size(189, 28);
            this.comboBoxSubProcess.TabIndex = 1;
            // 
            // comboBoxProcess
            // 
            this.comboBoxProcess.FormattingEnabled = true;
            this.comboBoxProcess.Location = new System.Drawing.Point(133, 29);
            this.comboBoxProcess.Name = "comboBoxProcess";
            this.comboBoxProcess.Size = new System.Drawing.Size(189, 28);
            this.comboBoxProcess.TabIndex = 1;
            this.comboBoxProcess.SelectedIndexChanged += new System.EventHandler(this.comboBoxProcess_SelectedIndexChanged);
            // 
            // SubProcess
            // 
            this.SubProcess.AutoSize = true;
            this.SubProcess.Location = new System.Drawing.Point(19, 63);
            this.SubProcess.Name = "SubProcess";
            this.SubProcess.Size = new System.Drawing.Size(83, 20);
            this.SubProcess.TabIndex = 1;
            this.SubProcess.Text = "SubProcess";
            // 
            // Process
            // 
            this.Process.AutoSize = true;
            this.Process.Location = new System.Drawing.Point(19, 33);
            this.Process.Name = "Process";
            this.Process.Size = new System.Drawing.Size(58, 20);
            this.Process.TabIndex = 1;
            this.Process.Text = "Process";
            // 
            // comboBoxExecuted
            // 
            this.comboBoxExecuted.FormattingEnabled = true;
            this.comboBoxExecuted.Items.AddRange(new object[] {
            "Any",
            "Yes",
            "No"});
            this.comboBoxExecuted.Location = new System.Drawing.Point(362, 45);
            this.comboBoxExecuted.Name = "comboBoxExecuted";
            this.comboBoxExecuted.Size = new System.Drawing.Size(101, 28);
            this.comboBoxExecuted.TabIndex = 1;
            this.comboBoxExecuted.Text = "Any";
            // 
            // comboBoxApproved
            // 
            this.comboBoxApproved.FormattingEnabled = true;
            this.comboBoxApproved.Items.AddRange(new object[] {
            "Any",
            "Pending",
            "Approved",
            "Rejected"});
            this.comboBoxApproved.Location = new System.Drawing.Point(133, 43);
            this.comboBoxApproved.Name = "comboBoxApproved";
            this.comboBoxApproved.Size = new System.Drawing.Size(101, 28);
            this.comboBoxApproved.TabIndex = 1;
            this.comboBoxApproved.Text = "Any";
            // 
            // Executed
            // 
            this.Executed.AutoSize = true;
            this.Executed.Location = new System.Drawing.Point(248, 45);
            this.Executed.Name = "Executed";
            this.Executed.Size = new System.Drawing.Size(69, 20);
            this.Executed.TabIndex = 1;
            this.Executed.Text = "Executed";
            // 
            // Approved
            // 
            this.Approved.AutoSize = true;
            this.Approved.Location = new System.Drawing.Point(19, 43);
            this.Approved.Name = "Approved";
            this.Approved.Size = new System.Drawing.Size(75, 20);
            this.Approved.TabIndex = 1;
            this.Approved.Text = "Approved";
            // 
            // groupBoxRequest
            // 
            this.groupBoxRequest.Controls.Add(this.richTextBoxComment);
            this.groupBoxRequest.Controls.Add(this.labelComment);
            this.groupBoxRequest.Controls.Add(this.buttonRejectRequest);
            this.groupBoxRequest.Controls.Add(this.labelApproval);
            this.groupBoxRequest.Controls.Add(this.checkBoxApproved);
            this.groupBoxRequest.Controls.Add(this.textBoxApprovedDate);
            this.groupBoxRequest.Controls.Add(this.textBoxApproveUser);
            this.groupBoxRequest.Controls.Add(this.label2);
            this.groupBoxRequest.Controls.Add(this.label1);
            this.groupBoxRequest.Controls.Add(this.checkBoxExecuted);
            this.groupBoxRequest.Controls.Add(this.buttonReturn);
            this.groupBoxRequest.Controls.Add(this.buttonRequestedQueries);
            this.groupBoxRequest.Controls.Add(this.ButtonApprove);
            this.groupBoxRequest.Controls.Add(this.textBoxRequestDate);
            this.groupBoxRequest.Controls.Add(this.textBoxReqUser);
            this.groupBoxRequest.Controls.Add(this.textBoxDatabase);
            this.groupBoxRequest.Controls.Add(this.Database);
            this.groupBoxRequest.Controls.Add(this.textBoxRequirmentName);
            this.groupBoxRequest.Controls.Add(this.RequirmentName);
            this.groupBoxRequest.Controls.Add(this.textBoxRequestDescription);
            this.groupBoxRequest.Controls.Add(this.textBoxRequirmentObjective);
            this.groupBoxRequest.Controls.Add(this.labelRequestedDate);
            this.groupBoxRequest.Controls.Add(this.labelRequestUser);
            this.groupBoxRequest.Controls.Add(this.labelReqDescription);
            this.groupBoxRequest.Controls.Add(this.labelRequirmentObjective);
            this.groupBoxRequest.Controls.Add(this.dataGridViewRequestDetails);
            this.groupBoxRequest.Location = new System.Drawing.Point(391, 136);
            this.groupBoxRequest.Name = "groupBoxRequest";
            this.groupBoxRequest.Size = new System.Drawing.Size(851, 702);
            this.groupBoxRequest.TabIndex = 1;
            this.groupBoxRequest.TabStop = false;
            this.groupBoxRequest.Text = "Request Details";
            this.groupBoxRequest.Visible = false;
            // 
            // richTextBoxComment
            // 
            this.richTextBoxComment.Location = new System.Drawing.Point(253, 553);
            this.richTextBoxComment.Name = "richTextBoxComment";
            this.richTextBoxComment.Size = new System.Drawing.Size(440, 63);
            this.richTextBoxComment.TabIndex = 30;
            this.richTextBoxComment.Text = "";
            // 
            // labelComment
            // 
            this.labelComment.AutoSize = true;
            this.labelComment.Location = new System.Drawing.Point(19, 556);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(228, 20);
            this.labelComment.TabIndex = 29;
            this.labelComment.Text = "Comment on Approval/Rejection";
            // 
            // buttonRejectRequest
            // 
            this.buttonRejectRequest.Location = new System.Drawing.Point(213, 649);
            this.buttonRejectRequest.Name = "buttonRejectRequest";
            this.buttonRejectRequest.Size = new System.Drawing.Size(140, 29);
            this.buttonRejectRequest.TabIndex = 28;
            this.buttonRejectRequest.Text = "Reject Request";
            this.buttonRejectRequest.UseVisualStyleBackColor = true;
            this.buttonRejectRequest.Visible = false;
            this.buttonRejectRequest.Click += new System.EventHandler(this.buttonRejectRequest_Click);
            // 
            // labelApproval
            // 
            this.labelApproval.AutoSize = true;
            this.labelApproval.Location = new System.Drawing.Point(391, 439);
            this.labelApproval.Name = "labelApproval";
            this.labelApproval.Size = new System.Drawing.Size(114, 20);
            this.labelApproval.TabIndex = 27;
            this.labelApproval.Text = "Approval Status";
            // 
            // checkBoxApproved
            // 
            this.checkBoxApproved.Location = new System.Drawing.Point(519, 436);
            this.checkBoxApproved.Name = "checkBoxApproved";
            this.checkBoxApproved.ReadOnly = true;
            this.checkBoxApproved.Size = new System.Drawing.Size(125, 27);
            this.checkBoxApproved.TabIndex = 26;
            // 
            // textBoxApprovedDate
            // 
            this.textBoxApprovedDate.Location = new System.Drawing.Point(519, 507);
            this.textBoxApprovedDate.Name = "textBoxApprovedDate";
            this.textBoxApprovedDate.ReadOnly = true;
            this.textBoxApprovedDate.Size = new System.Drawing.Size(125, 27);
            this.textBoxApprovedDate.TabIndex = 25;
            // 
            // textBoxApproveUser
            // 
            this.textBoxApproveUser.Location = new System.Drawing.Point(519, 469);
            this.textBoxApproveUser.Name = "textBoxApproveUser";
            this.textBoxApproveUser.ReadOnly = true;
            this.textBoxApproveUser.Size = new System.Drawing.Size(125, 27);
            this.textBoxApproveUser.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(391, 507);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Approved Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(391, 473);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Approved User";
            // 
            // checkBoxExecuted
            // 
            this.checkBoxExecuted.AutoSize = true;
            this.checkBoxExecuted.Enabled = false;
            this.checkBoxExecuted.Location = new System.Drawing.Point(681, 435);
            this.checkBoxExecuted.Name = "checkBoxExecuted";
            this.checkBoxExecuted.Size = new System.Drawing.Size(91, 24);
            this.checkBoxExecuted.TabIndex = 21;
            this.checkBoxExecuted.Text = "Executed";
            this.checkBoxExecuted.UseVisualStyleBackColor = true;
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(706, 649);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(103, 29);
            this.buttonReturn.TabIndex = 19;
            this.buttonReturn.Text = "Return";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // buttonRequestedQueries
            // 
            this.buttonRequestedQueries.Location = new System.Drawing.Point(507, 649);
            this.buttonRequestedQueries.Name = "buttonRequestedQueries";
            this.buttonRequestedQueries.Size = new System.Drawing.Size(158, 29);
            this.buttonRequestedQueries.TabIndex = 18;
            this.buttonRequestedQueries.Text = "Requested Queries";
            this.buttonRequestedQueries.UseVisualStyleBackColor = true;
            this.buttonRequestedQueries.Visible = false;
            this.buttonRequestedQueries.Click += new System.EventHandler(this.buttonRequestedQueries_Click);
            // 
            // ButtonApprove
            // 
            this.ButtonApprove.Location = new System.Drawing.Point(19, 650);
            this.ButtonApprove.Name = "ButtonApprove";
            this.ButtonApprove.Size = new System.Drawing.Size(142, 29);
            this.ButtonApprove.TabIndex = 17;
            this.ButtonApprove.Text = "Approve Request";
            this.ButtonApprove.UseVisualStyleBackColor = true;
            this.ButtonApprove.Visible = false;
            this.ButtonApprove.Click += new System.EventHandler(this.ButtonApprove_Click);
            // 
            // textBoxRequestDate
            // 
            this.textBoxRequestDate.Location = new System.Drawing.Point(185, 509);
            this.textBoxRequestDate.Name = "textBoxRequestDate";
            this.textBoxRequestDate.ReadOnly = true;
            this.textBoxRequestDate.Size = new System.Drawing.Size(143, 27);
            this.textBoxRequestDate.TabIndex = 14;
            // 
            // textBoxReqUser
            // 
            this.textBoxReqUser.Location = new System.Drawing.Point(185, 467);
            this.textBoxReqUser.Name = "textBoxReqUser";
            this.textBoxReqUser.ReadOnly = true;
            this.textBoxReqUser.Size = new System.Drawing.Size(143, 27);
            this.textBoxReqUser.TabIndex = 13;
            // 
            // textBoxDatabase
            // 
            this.textBoxDatabase.Location = new System.Drawing.Point(185, 291);
            this.textBoxDatabase.Name = "textBoxDatabase";
            this.textBoxDatabase.ReadOnly = true;
            this.textBoxDatabase.Size = new System.Drawing.Size(231, 27);
            this.textBoxDatabase.TabIndex = 12;
            // 
            // Database
            // 
            this.Database.AutoSize = true;
            this.Database.Location = new System.Drawing.Point(17, 291);
            this.Database.Name = "Database";
            this.Database.Size = new System.Drawing.Size(72, 20);
            this.Database.TabIndex = 11;
            this.Database.Text = "Database";
            // 
            // textBoxRequirmentName
            // 
            this.textBoxRequirmentName.Location = new System.Drawing.Point(185, 257);
            this.textBoxRequirmentName.Name = "textBoxRequirmentName";
            this.textBoxRequirmentName.ReadOnly = true;
            this.textBoxRequirmentName.Size = new System.Drawing.Size(231, 27);
            this.textBoxRequirmentName.TabIndex = 10;
            // 
            // RequirmentName
            // 
            this.RequirmentName.AutoSize = true;
            this.RequirmentName.Location = new System.Drawing.Point(17, 257);
            this.RequirmentName.Name = "RequirmentName";
            this.RequirmentName.Size = new System.Drawing.Size(130, 20);
            this.RequirmentName.TabIndex = 9;
            this.RequirmentName.Text = "Requirment Name";
            // 
            // textBoxRequestDescription
            // 
            this.textBoxRequestDescription.Location = new System.Drawing.Point(185, 384);
            this.textBoxRequestDescription.Multiline = true;
            this.textBoxRequestDescription.Name = "textBoxRequestDescription";
            this.textBoxRequestDescription.ReadOnly = true;
            this.textBoxRequestDescription.Size = new System.Drawing.Size(587, 45);
            this.textBoxRequestDescription.TabIndex = 8;
            // 
            // textBoxRequirmentObjective
            // 
            this.textBoxRequirmentObjective.Location = new System.Drawing.Point(185, 324);
            this.textBoxRequirmentObjective.Multiline = true;
            this.textBoxRequirmentObjective.Name = "textBoxRequirmentObjective";
            this.textBoxRequirmentObjective.ReadOnly = true;
            this.textBoxRequirmentObjective.Size = new System.Drawing.Size(587, 45);
            this.textBoxRequirmentObjective.TabIndex = 7;
            // 
            // labelRequestedDate
            // 
            this.labelRequestedDate.AutoSize = true;
            this.labelRequestedDate.Location = new System.Drawing.Point(17, 513);
            this.labelRequestedDate.Name = "labelRequestedDate";
            this.labelRequestedDate.Size = new System.Drawing.Size(115, 20);
            this.labelRequestedDate.TabIndex = 4;
            this.labelRequestedDate.Text = "Requested Date";
            // 
            // labelRequestUser
            // 
            this.labelRequestUser.AutoSize = true;
            this.labelRequestUser.Location = new System.Drawing.Point(17, 473);
            this.labelRequestUser.Name = "labelRequestUser";
            this.labelRequestUser.Size = new System.Drawing.Size(112, 20);
            this.labelRequestUser.TabIndex = 3;
            this.labelRequestUser.Text = "Requested User";
            // 
            // labelReqDescription
            // 
            this.labelReqDescription.AutoSize = true;
            this.labelReqDescription.Location = new System.Drawing.Point(17, 400);
            this.labelReqDescription.Name = "labelReqDescription";
            this.labelReqDescription.Size = new System.Drawing.Size(142, 20);
            this.labelReqDescription.TabIndex = 2;
            this.labelReqDescription.Text = "Request Description";
            // 
            // labelRequirmentObjective
            // 
            this.labelRequirmentObjective.AutoSize = true;
            this.labelRequirmentObjective.Location = new System.Drawing.Point(17, 327);
            this.labelRequirmentObjective.Name = "labelRequirmentObjective";
            this.labelRequirmentObjective.Size = new System.Drawing.Size(153, 20);
            this.labelRequirmentObjective.TabIndex = 1;
            this.labelRequirmentObjective.Text = "Requirment Objective";
            // 
            // dataGridViewRequestDetails
            // 
            this.dataGridViewRequestDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRequestDetails.Location = new System.Drawing.Point(15, 27);
            this.dataGridViewRequestDetails.Name = "dataGridViewRequestDetails";
            this.dataGridViewRequestDetails.RowHeadersWidth = 51;
            this.dataGridViewRequestDetails.Size = new System.Drawing.Size(783, 219);
            this.dataGridViewRequestDetails.TabIndex = 0;
            this.dataGridViewRequestDetails.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewRequestDetails_RowHeaderMouseClick);
            // 
            // groupBoxSearchByStatus
            // 
            this.groupBoxSearchByStatus.Controls.Add(this.buttonSearch);
            this.groupBoxSearchByStatus.Controls.Add(this.comboBoxExecuted);
            this.groupBoxSearchByStatus.Controls.Add(this.comboBoxApproved);
            this.groupBoxSearchByStatus.Controls.Add(this.Approved);
            this.groupBoxSearchByStatus.Controls.Add(this.Executed);
            this.groupBoxSearchByStatus.Location = new System.Drawing.Point(391, 24);
            this.groupBoxSearchByStatus.Name = "groupBoxSearchByStatus";
            this.groupBoxSearchByStatus.Size = new System.Drawing.Size(838, 91);
            this.groupBoxSearchByStatus.TabIndex = 2;
            this.groupBoxSearchByStatus.TabStop = false;
            this.groupBoxSearchByStatus.Text = "Search Request";
            this.groupBoxSearchByStatus.Visible = false;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(507, 43);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(82, 31);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // InquireRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 850);
            this.Controls.Add(this.groupBoxSearchByStatus);
            this.Controls.Add(this.groupBoxRequest);
            this.Controls.Add(this.groupBoxSearchRequest);
            this.Name = "InquireRequest";
            this.Text = "InquireRequest";
            this.Load += new System.EventHandler(this.InquireRequest_Load);
            this.groupBoxSearchRequest.ResumeLayout(false);
            this.groupBoxSearchRequest.PerformLayout();
            this.groupBoxRequest.ResumeLayout(false);
            this.groupBoxRequest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequestDetails)).EndInit();
            this.groupBoxSearchByStatus.ResumeLayout(false);
            this.groupBoxSearchByStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBoxSearchRequest;
        private System.Windows.Forms.Label SubProcess;
        private System.Windows.Forms.Label Process;
        private System.Windows.Forms.Label Executed;
        private System.Windows.Forms.Label Approved;
        private System.Windows.Forms.Button buttonViewRequests;
        private System.Windows.Forms.ComboBox comboBoxExecuted;
        private System.Windows.Forms.ComboBox comboBoxApproved;
        private System.Windows.Forms.ComboBox comboBoxSubProcess;
        private System.Windows.Forms.ComboBox comboBoxProcess;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.DataGridView dataGridViewRequestDetails;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Button buttonRequestedQueries;
        private System.Windows.Forms.Button ButtonApprove;
        private System.Windows.Forms.TextBox textBoxRequestDate;
        private System.Windows.Forms.TextBox textBoxReqUser;
        private System.Windows.Forms.TextBox textBoxDatabase;
        private System.Windows.Forms.Label Database;
        private System.Windows.Forms.TextBox textBoxRequirmentName;
        private System.Windows.Forms.Label RequirmentName;
        private System.Windows.Forms.TextBox textBoxRequestDescription;
        private System.Windows.Forms.TextBox textBoxRequirmentObjective;
        private System.Windows.Forms.Label labelRequestedDate;
        private System.Windows.Forms.Label labelRequestUser;
        private System.Windows.Forms.Label labelReqDescription;
        private System.Windows.Forms.Label labelRequirmentObjective;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.Windows.Forms.Button buttonSearch;
        public System.Windows.Forms.GroupBox groupBoxRequest;
        public System.Windows.Forms.GroupBox groupBoxSearchByStatus;
        private System.Windows.Forms.CheckBox checkBoxExecuted;
        private System.Windows.Forms.TextBox textBoxApprovedDate;
        private System.Windows.Forms.TextBox textBoxApproveUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelApproval;
        private System.Windows.Forms.TextBox checkBoxApproved;
        private System.Windows.Forms.Button buttonRejectRequest;
        private System.Windows.Forms.RichTextBox richTextBoxComment;
        private System.Windows.Forms.Label labelComment;
    }
}