namespace SHLife_SD1.Mainpage {
    partial class ReviewPage {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.tbOfficialName = new System.Windows.Forms.TextBox();
            this.tbApplicantName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvApplications = new System.Windows.Forms.DataGridView();
            this.colApplicationId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApplicationNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOfficialAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApplicant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReviewer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUpdateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelDetail = new System.Windows.Forms.Panel();
            this.dgvDetails = new System.Windows.Forms.DataGridView();
            this.rtbApplicantInfo = new System.Windows.Forms.RichTextBox();
            this.rtbOfficialInfo = new System.Windows.Forms.RichTextBox();
            this.rtbOperationLogs = new System.Windows.Forms.RichTextBox();
            this.colDetailId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetailNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDReviewer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDUpdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBtnOperation = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplications)).BeginInit();
            this.panelDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Official Account Name:";
            // 
            // tbOfficialName
            // 
            this.tbOfficialName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbOfficialName.Location = new System.Drawing.Point(184, 10);
            this.tbOfficialName.Name = "tbOfficialName";
            this.tbOfficialName.Size = new System.Drawing.Size(176, 26);
            this.tbOfficialName.TabIndex = 1;
            // 
            // tbApplicantName
            // 
            this.tbApplicantName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbApplicantName.Location = new System.Drawing.Point(142, 45);
            this.tbApplicantName.Name = "tbApplicantName";
            this.tbApplicantName.Size = new System.Drawing.Size(218, 26);
            this.tbApplicantName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Applicant Name:";
            // 
            // dtpStart
            // 
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(489, 45);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(121, 26);
            this.dtpStart.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(379, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Applied Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(616, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "~";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(639, 45);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(121, 26);
            this.dtpEnd.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(379, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Review Status:";
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "All",
            "Pending",
            "Waiting For Fix",
            "Approved"});
            this.cbStatus.Location = new System.Drawing.Point(496, 10);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(264, 26);
            this.cbStatus.TabIndex = 9;
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(784, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(145, 61);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvApplications
            // 
            this.dgvApplications.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvApplications.BackgroundColor = System.Drawing.Color.White;
            this.dgvApplications.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(26)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvApplications.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvApplications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApplications.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colApplicationId,
            this.colApplicationNo,
            this.colOfficialAccount,
            this.colApplicant,
            this.colStatus,
            this.colReviewer,
            this.colRemark,
            this.colCreateTime,
            this.colUpdateTime});
            this.dgvApplications.EnableHeadersVisualStyles = false;
            this.dgvApplications.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvApplications.Location = new System.Drawing.Point(16, 88);
            this.dgvApplications.Name = "dgvApplications";
            this.dgvApplications.RowHeadersVisible = false;
            this.dgvApplications.RowTemplate.Height = 24;
            this.dgvApplications.Size = new System.Drawing.Size(913, 133);
            this.dgvApplications.TabIndex = 11;
            this.dgvApplications.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvApplications_CellClick);
            // 
            // colApplicationId
            // 
            this.colApplicationId.DataPropertyName = "colApplicationId";
            this.colApplicationId.HeaderText = "ApplicationId";
            this.colApplicationId.Name = "colApplicationId";
            this.colApplicationId.Visible = false;
            // 
            // colApplicationNo
            // 
            this.colApplicationNo.DataPropertyName = "colApplicationNo";
            this.colApplicationNo.FillWeight = 50F;
            this.colApplicationNo.HeaderText = "No";
            this.colApplicationNo.Name = "colApplicationNo";
            // 
            // colOfficialAccount
            // 
            this.colOfficialAccount.DataPropertyName = "colOfficialAccount";
            this.colOfficialAccount.FillWeight = 120F;
            this.colOfficialAccount.HeaderText = "Official Account";
            this.colOfficialAccount.Name = "colOfficialAccount";
            // 
            // colApplicant
            // 
            this.colApplicant.DataPropertyName = "colApplicant";
            this.colApplicant.HeaderText = "Applicant";
            this.colApplicant.Name = "colApplicant";
            // 
            // colStatus
            // 
            this.colStatus.DataPropertyName = "colStatus";
            this.colStatus.FillWeight = 80F;
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            // 
            // colReviewer
            // 
            this.colReviewer.DataPropertyName = "colReviewer";
            this.colReviewer.HeaderText = "Reviewer";
            this.colReviewer.Name = "colReviewer";
            // 
            // colRemark
            // 
            this.colRemark.DataPropertyName = "colRemark";
            this.colRemark.FillWeight = 120F;
            this.colRemark.HeaderText = "Remark";
            this.colRemark.Name = "colRemark";
            // 
            // colCreateTime
            // 
            this.colCreateTime.DataPropertyName = "colCreateTime";
            this.colCreateTime.HeaderText = "Created";
            this.colCreateTime.Name = "colCreateTime";
            // 
            // colUpdateTime
            // 
            this.colUpdateTime.DataPropertyName = "colUpdateTime";
            this.colUpdateTime.HeaderText = "Updated";
            this.colUpdateTime.Name = "colUpdateTime";
            // 
            // panelDetail
            // 
            this.panelDetail.AutoScroll = true;
            this.panelDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDetail.Controls.Add(this.dgvDetails);
            this.panelDetail.Controls.Add(this.rtbApplicantInfo);
            this.panelDetail.Controls.Add(this.rtbOfficialInfo);
            this.panelDetail.Location = new System.Drawing.Point(16, 227);
            this.panelDetail.Name = "panelDetail";
            this.panelDetail.Size = new System.Drawing.Size(913, 253);
            this.panelDetail.TabIndex = 12;
            // 
            // dgvDetails
            // 
            this.dgvDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetails.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(26)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDetailId,
            this.colDetailNo,
            this.colType,
            this.colDReviewer,
            this.colContent,
            this.colDStatus,
            this.colComment,
            this.colDUpdate,
            this.colBtnOperation});
            this.dgvDetails.EnableHeadersVisualStyles = false;
            this.dgvDetails.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvDetails.Location = new System.Drawing.Point(3, 207);
            this.dgvDetails.Name = "dgvDetails";
            this.dgvDetails.RowHeadersVisible = false;
            this.dgvDetails.RowTemplate.Height = 24;
            this.dgvDetails.Size = new System.Drawing.Size(888, 147);
            this.dgvDetails.TabIndex = 16;
            this.dgvDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetails_CellContentClick);
            this.dgvDetails.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvDetails_DataError);
            // 
            // rtbApplicantInfo
            // 
            this.rtbApplicantInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbApplicantInfo.Location = new System.Drawing.Point(3, 105);
            this.rtbApplicantInfo.Name = "rtbApplicantInfo";
            this.rtbApplicantInfo.Size = new System.Drawing.Size(888, 96);
            this.rtbApplicantInfo.TabIndex = 15;
            this.rtbApplicantInfo.Text = "";
            // 
            // rtbOfficialInfo
            // 
            this.rtbOfficialInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbOfficialInfo.Location = new System.Drawing.Point(3, 3);
            this.rtbOfficialInfo.Name = "rtbOfficialInfo";
            this.rtbOfficialInfo.Size = new System.Drawing.Size(888, 96);
            this.rtbOfficialInfo.TabIndex = 14;
            this.rtbOfficialInfo.Text = "";
            // 
            // rtbOperationLogs
            // 
            this.rtbOperationLogs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbOperationLogs.Location = new System.Drawing.Point(16, 486);
            this.rtbOperationLogs.Name = "rtbOperationLogs";
            this.rtbOperationLogs.Size = new System.Drawing.Size(913, 96);
            this.rtbOperationLogs.TabIndex = 13;
            this.rtbOperationLogs.Text = "";
            // 
            // colDetailId
            // 
            this.colDetailId.DataPropertyName = "colDetailId";
            this.colDetailId.HeaderText = "DetailId";
            this.colDetailId.Name = "colDetailId";
            this.colDetailId.Visible = false;
            // 
            // colDetailNo
            // 
            this.colDetailNo.DataPropertyName = "colDetailNo";
            this.colDetailNo.FillWeight = 40F;
            this.colDetailNo.HeaderText = "No";
            this.colDetailNo.Name = "colDetailNo";
            // 
            // colType
            // 
            this.colType.DataPropertyName = "colType";
            this.colType.HeaderText = "Type";
            this.colType.Name = "colType";
            // 
            // colDReviewer
            // 
            this.colDReviewer.DataPropertyName = "colDReviewer";
            this.colDReviewer.FillWeight = 80F;
            this.colDReviewer.HeaderText = "Reviewer";
            this.colDReviewer.Name = "colDReviewer";
            // 
            // colContent
            // 
            this.colContent.DataPropertyName = "colContent";
            this.colContent.HeaderText = "Content";
            this.colContent.Name = "colContent";
            // 
            // colDStatus
            // 
            this.colDStatus.DataPropertyName = "colDStatus";
            this.colDStatus.FillWeight = 60F;
            this.colDStatus.HeaderText = "Status";
            this.colDStatus.Name = "colDStatus";
            // 
            // colComment
            // 
            this.colComment.DataPropertyName = "colComment";
            this.colComment.HeaderText = "Comment";
            this.colComment.Name = "colComment";
            // 
            // colDUpdate
            // 
            this.colDUpdate.DataPropertyName = "colDUpdate";
            this.colDUpdate.FillWeight = 90F;
            this.colDUpdate.HeaderText = "Update";
            this.colDUpdate.Name = "colDUpdate";
            // 
            // colBtnOperation
            // 
            this.colBtnOperation.FillWeight = 90F;
            this.colBtnOperation.HeaderText = "Operation";
            this.colBtnOperation.Name = "colBtnOperation";
            this.colBtnOperation.Text = "Manage";
            this.colBtnOperation.UseColumnTextForButtonValue = true;
            // 
            // ReviewPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rtbOperationLogs);
            this.Controls.Add(this.panelDetail);
            this.Controls.Add(this.dgvApplications);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.tbApplicantName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbOfficialName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReviewPage";
            this.Size = new System.Drawing.Size(944, 597);
            this.Load += new System.EventHandler(this.ReviewPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplications)).EndInit();
            this.panelDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbOfficialName;
        private System.Windows.Forms.TextBox tbApplicantName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvApplications;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApplicationId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApplicationNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOfficialAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApplicant;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReviewer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemark;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUpdateTime;
        private System.Windows.Forms.Panel panelDetail;
        private System.Windows.Forms.RichTextBox rtbOperationLogs;
        private System.Windows.Forms.DataGridView dgvDetails;
        private System.Windows.Forms.RichTextBox rtbApplicantInfo;
        private System.Windows.Forms.RichTextBox rtbOfficialInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDetailId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDetailNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDReviewer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContent;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colComment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDUpdate;
        private System.Windows.Forms.DataGridViewButtonColumn colBtnOperation;
    }
}
