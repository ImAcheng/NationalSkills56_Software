namespace SHLife_SD1.Mainpage {
    partial class BrowsePage {
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
            this.tbOfficial = new System.Windows.Forms.TextBox();
            this.ckEnabled = new System.Windows.Forms.CheckBox();
            this.ckVerified = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvOfficials = new System.Windows.Forms.DataGridView();
            this.colOfficialId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOfficialNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOfficialName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOfficialType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEnabled = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVerified = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAvailables = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMembers = new System.Windows.Forms.DataGridView();
            this.colMemberId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMemberNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAvailable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUpdated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeletion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOfficials)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Official Account Name:";
            // 
            // tbOfficial
            // 
            this.tbOfficial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbOfficial.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOfficial.Location = new System.Drawing.Point(187, 14);
            this.tbOfficial.Name = "tbOfficial";
            this.tbOfficial.Size = new System.Drawing.Size(152, 29);
            this.tbOfficial.TabIndex = 1;
            // 
            // ckEnabled
            // 
            this.ckEnabled.AutoSize = true;
            this.ckEnabled.Location = new System.Drawing.Point(383, 18);
            this.ckEnabled.Name = "ckEnabled";
            this.ckEnabled.Size = new System.Drawing.Size(85, 22);
            this.ckEnabled.TabIndex = 2;
            this.ckEnabled.Text = "Enabled";
            this.ckEnabled.UseVisualStyleBackColor = true;
            // 
            // ckVerified
            // 
            this.ckVerified.AutoSize = true;
            this.ckVerified.Location = new System.Drawing.Point(516, 18);
            this.ckVerified.Name = "ckVerified";
            this.ckVerified.Size = new System.Drawing.Size(81, 22);
            this.ckVerified.TabIndex = 3;
            this.ckVerified.Text = "Verified";
            this.ckVerified.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Created Date:";
            // 
            // dtpStart
            // 
            this.dtpStart.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(129, 52);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(200, 29);
            this.dtpStart.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "~";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(358, 52);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(200, 29);
            this.dtpEnd.TabIndex = 7;
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(781, 14);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(145, 67);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvOfficials
            // 
            this.dgvOfficials.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOfficials.BackgroundColor = System.Drawing.Color.White;
            this.dgvOfficials.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(26)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOfficials.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOfficials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOfficials.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOfficialId,
            this.colOfficialNo,
            this.colOfficialName,
            this.colOfficialType,
            this.colDescription,
            this.colEnabled,
            this.colVerified,
            this.colAvailables,
            this.colCreateTime});
            this.dgvOfficials.EnableHeadersVisualStyles = false;
            this.dgvOfficials.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvOfficials.Location = new System.Drawing.Point(19, 98);
            this.dgvOfficials.Name = "dgvOfficials";
            this.dgvOfficials.RowHeadersVisible = false;
            this.dgvOfficials.RowTemplate.Height = 24;
            this.dgvOfficials.Size = new System.Drawing.Size(907, 162);
            this.dgvOfficials.TabIndex = 12;
            this.dgvOfficials.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOfficials_CellClick);
            // 
            // colOfficialId
            // 
            this.colOfficialId.DataPropertyName = "colOfficialId";
            this.colOfficialId.HeaderText = "OfficialId";
            this.colOfficialId.Name = "colOfficialId";
            this.colOfficialId.Visible = false;
            // 
            // colOfficialNo
            // 
            this.colOfficialNo.DataPropertyName = "colOfficialNo";
            this.colOfficialNo.FillWeight = 30F;
            this.colOfficialNo.HeaderText = "No";
            this.colOfficialNo.Name = "colOfficialNo";
            // 
            // colOfficialName
            // 
            this.colOfficialName.DataPropertyName = "colOfficialName";
            this.colOfficialName.FillWeight = 80F;
            this.colOfficialName.HeaderText = "Name";
            this.colOfficialName.Name = "colOfficialName";
            // 
            // colOfficialType
            // 
            this.colOfficialType.DataPropertyName = "colOfficialType";
            this.colOfficialType.FillWeight = 70F;
            this.colOfficialType.HeaderText = "Type";
            this.colOfficialType.Name = "colOfficialType";
            // 
            // colDescription
            // 
            this.colDescription.DataPropertyName = "colDescription";
            this.colDescription.FillWeight = 160F;
            this.colDescription.HeaderText = "Description";
            this.colDescription.Name = "colDescription";
            // 
            // colEnabled
            // 
            this.colEnabled.DataPropertyName = "colEnabled";
            this.colEnabled.FillWeight = 60F;
            this.colEnabled.HeaderText = "Enabled";
            this.colEnabled.Name = "colEnabled";
            // 
            // colVerified
            // 
            this.colVerified.DataPropertyName = "colVerified";
            this.colVerified.FillWeight = 60F;
            this.colVerified.HeaderText = "Verified";
            this.colVerified.Name = "colVerified";
            // 
            // colAvailables
            // 
            this.colAvailables.DataPropertyName = "colAvailables";
            this.colAvailables.HeaderText = "Available Members";
            this.colAvailables.Name = "colAvailables";
            // 
            // colCreateTime
            // 
            this.colCreateTime.DataPropertyName = "colCreateTime";
            this.colCreateTime.FillWeight = 120F;
            this.colCreateTime.HeaderText = "Creation";
            this.colCreateTime.Name = "colCreateTime";
            // 
            // dgvMembers
            // 
            this.dgvMembers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMembers.BackgroundColor = System.Drawing.Color.White;
            this.dgvMembers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(26)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMembers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMembers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMemberId,
            this.colMemberNo,
            this.colAccount,
            this.colEmail,
            this.colRole,
            this.colAvailable,
            this.colUpdated,
            this.colDeletion});
            this.dgvMembers.EnableHeadersVisualStyles = false;
            this.dgvMembers.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvMembers.Location = new System.Drawing.Point(19, 275);
            this.dgvMembers.Name = "dgvMembers";
            this.dgvMembers.RowHeadersVisible = false;
            this.dgvMembers.RowTemplate.Height = 24;
            this.dgvMembers.Size = new System.Drawing.Size(907, 301);
            this.dgvMembers.TabIndex = 13;
            // 
            // colMemberId
            // 
            this.colMemberId.DataPropertyName = "colMemberId";
            this.colMemberId.HeaderText = "MemberId";
            this.colMemberId.Name = "colMemberId";
            this.colMemberId.Visible = false;
            // 
            // colMemberNo
            // 
            this.colMemberNo.DataPropertyName = "colMemberNo";
            this.colMemberNo.FillWeight = 30F;
            this.colMemberNo.HeaderText = "No";
            this.colMemberNo.Name = "colMemberNo";
            // 
            // colAccount
            // 
            this.colAccount.DataPropertyName = "colAccount";
            this.colAccount.HeaderText = "Account";
            this.colAccount.Name = "colAccount";
            // 
            // colEmail
            // 
            this.colEmail.DataPropertyName = "colEmail";
            this.colEmail.HeaderText = "Email";
            this.colEmail.Name = "colEmail";
            // 
            // colRole
            // 
            this.colRole.DataPropertyName = "colRole";
            this.colRole.FillWeight = 60F;
            this.colRole.HeaderText = "Role";
            this.colRole.Name = "colRole";
            // 
            // colAvailable
            // 
            this.colAvailable.DataPropertyName = "colAvailable";
            this.colAvailable.HeaderText = "Available";
            this.colAvailable.Name = "colAvailable";
            // 
            // colUpdated
            // 
            this.colUpdated.DataPropertyName = "colUpdated";
            this.colUpdated.HeaderText = "Updated";
            this.colUpdated.Name = "colUpdated";
            // 
            // colDeletion
            // 
            this.colDeletion.DataPropertyName = "colDeletion";
            this.colDeletion.HeaderText = "Deleted";
            this.colDeletion.Name = "colDeletion";
            // 
            // BrowsePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvMembers);
            this.Controls.Add(this.dgvOfficials);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ckVerified);
            this.Controls.Add(this.ckEnabled);
            this.Controls.Add(this.tbOfficial);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BrowsePage";
            this.Size = new System.Drawing.Size(944, 597);
            this.Load += new System.EventHandler(this.BrowsePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOfficials)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbOfficial;
        private System.Windows.Forms.CheckBox ckEnabled;
        private System.Windows.Forms.CheckBox ckVerified;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvOfficials;
        private System.Windows.Forms.DataGridView dgvMembers;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOfficialId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOfficialNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOfficialName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOfficialType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEnabled;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVerified;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAvailables;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemberId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemberNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAvailable;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUpdated;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeletion;
    }
}
