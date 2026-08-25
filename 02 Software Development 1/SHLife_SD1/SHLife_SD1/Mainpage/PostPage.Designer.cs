namespace SHLife_SD1.Mainpage {
    partial class PostPage {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.tbKeyword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvPosts = new System.Windows.Forms.DataGridView();
            this.colPostId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPostNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPostNickname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMessage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbNickname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbMedia = new System.Windows.Forms.ComboBox();
            this.panelDetail = new System.Windows.Forms.Panel();
            this.lbPostNo = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbNickname = new System.Windows.Forms.Label();
            this.lbCreation = new System.Windows.Forms.Label();
            this.llbComments = new System.Windows.Forms.LinkLabel();
            this.llbMedias = new System.Windows.Forms.LinkLabel();
            this.llbOperations = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPostMessage = new System.Windows.Forms.TextBox();
            this.tbAiSummary = new System.Windows.Forms.TextBox();
            this.btnAiSummary = new System.Windows.Forms.Button();
            this.lbAiStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosts)).BeginInit();
            this.panelDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpEnd
            // 
            this.dtpEnd.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(614, 55);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(146, 29);
            this.dtpEnd.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(591, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 18);
            this.label3.TabIndex = 20;
            this.label3.Text = "~";
            // 
            // dtpStart
            // 
            this.dtpStart.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(439, 55);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(146, 29);
            this.dtpStart.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(333, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Posted Date:";
            // 
            // tbKeyword
            // 
            this.tbKeyword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbKeyword.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKeyword.Location = new System.Drawing.Point(96, 17);
            this.tbKeyword.Name = "tbKeyword";
            this.tbKeyword.Size = new System.Drawing.Size(222, 29);
            this.tbKeyword.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Keyword:";
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(782, 17);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(145, 67);
            this.btnSearch.TabIndex = 22;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvPosts
            // 
            this.dgvPosts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPosts.BackgroundColor = System.Drawing.Color.White;
            this.dgvPosts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(26)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPosts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPosts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPosts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPostId,
            this.colPostNo,
            this.colPostNickname,
            this.colMessage,
            this.colCreation});
            this.dgvPosts.EnableHeadersVisualStyles = false;
            this.dgvPosts.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvPosts.Location = new System.Drawing.Point(20, 101);
            this.dgvPosts.Name = "dgvPosts";
            this.dgvPosts.RowHeadersVisible = false;
            this.dgvPosts.RowTemplate.Height = 24;
            this.dgvPosts.Size = new System.Drawing.Size(907, 121);
            this.dgvPosts.TabIndex = 23;
            this.dgvPosts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPosts_CellClick);
            // 
            // colPostId
            // 
            this.colPostId.DataPropertyName = "colPostId";
            this.colPostId.HeaderText = "PostId";
            this.colPostId.Name = "colPostId";
            this.colPostId.Visible = false;
            // 
            // colPostNo
            // 
            this.colPostNo.DataPropertyName = "colPostNo";
            this.colPostNo.FillWeight = 30F;
            this.colPostNo.HeaderText = "Post No";
            this.colPostNo.Name = "colPostNo";
            // 
            // colPostNickname
            // 
            this.colPostNickname.DataPropertyName = "colPostNickname";
            this.colPostNickname.FillWeight = 80F;
            this.colPostNickname.HeaderText = "Post Nickname";
            this.colPostNickname.Name = "colPostNickname";
            // 
            // colMessage
            // 
            this.colMessage.DataPropertyName = "colMessage";
            this.colMessage.FillWeight = 250F;
            this.colMessage.HeaderText = "Message";
            this.colMessage.Name = "colMessage";
            // 
            // colCreation
            // 
            this.colCreation.DataPropertyName = "colCreation";
            this.colCreation.FillWeight = 80F;
            this.colCreation.HeaderText = "Creation";
            this.colCreation.Name = "colCreation";
            // 
            // tbNickname
            // 
            this.tbNickname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNickname.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNickname.Location = new System.Drawing.Point(141, 55);
            this.tbNickname.Name = "tbNickname";
            this.tbNickname.Size = new System.Drawing.Size(177, 29);
            this.tbNickname.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 18);
            this.label4.TabIndex = 24;
            this.label4.Text = "Post Nickname:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(333, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 18);
            this.label5.TabIndex = 26;
            this.label5.Text = "Contains Media:";
            // 
            // cbMedia
            // 
            this.cbMedia.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMedia.FormattingEnabled = true;
            this.cbMedia.Items.AddRange(new object[] {
            "全部",
            "有媒體",
            "無媒體"});
            this.cbMedia.Location = new System.Drawing.Point(461, 17);
            this.cbMedia.Name = "cbMedia";
            this.cbMedia.Size = new System.Drawing.Size(299, 30);
            this.cbMedia.TabIndex = 27;
            // 
            // panelDetail
            // 
            this.panelDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDetail.Controls.Add(this.lbAiStatus);
            this.panelDetail.Controls.Add(this.btnAiSummary);
            this.panelDetail.Controls.Add(this.tbAiSummary);
            this.panelDetail.Controls.Add(this.tbPostMessage);
            this.panelDetail.Controls.Add(this.label6);
            this.panelDetail.Controls.Add(this.llbOperations);
            this.panelDetail.Controls.Add(this.llbMedias);
            this.panelDetail.Controls.Add(this.llbComments);
            this.panelDetail.Controls.Add(this.lbCreation);
            this.panelDetail.Controls.Add(this.lbNickname);
            this.panelDetail.Controls.Add(this.lbEmail);
            this.panelDetail.Controls.Add(this.lbPostNo);
            this.panelDetail.Location = new System.Drawing.Point(20, 237);
            this.panelDetail.Name = "panelDetail";
            this.panelDetail.Size = new System.Drawing.Size(907, 340);
            this.panelDetail.TabIndex = 28;
            // 
            // lbPostNo
            // 
            this.lbPostNo.AutoSize = true;
            this.lbPostNo.Location = new System.Drawing.Point(8, 9);
            this.lbPostNo.Name = "lbPostNo";
            this.lbPostNo.Size = new System.Drawing.Size(72, 18);
            this.lbPostNo.TabIndex = 15;
            this.lbPostNo.Text = "Post No.:";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(362, 9);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(88, 18);
            this.lbEmail.TabIndex = 16;
            this.lbEmail.Text = "Post Email:";
            // 
            // lbNickname
            // 
            this.lbNickname.AutoSize = true;
            this.lbNickname.Location = new System.Drawing.Point(8, 37);
            this.lbNickname.Name = "lbNickname";
            this.lbNickname.Size = new System.Drawing.Size(118, 18);
            this.lbNickname.TabIndex = 17;
            this.lbNickname.Text = "Post Nickname:";
            // 
            // lbCreation
            // 
            this.lbCreation.AutoSize = true;
            this.lbCreation.Location = new System.Drawing.Point(362, 37);
            this.lbCreation.Name = "lbCreation";
            this.lbCreation.Size = new System.Drawing.Size(72, 18);
            this.lbCreation.TabIndex = 18;
            this.lbCreation.Text = "Creation:";
            // 
            // llbComments
            // 
            this.llbComments.AutoSize = true;
            this.llbComments.Location = new System.Drawing.Point(8, 64);
            this.llbComments.Name = "llbComments";
            this.llbComments.Size = new System.Drawing.Size(80, 18);
            this.llbComments.TabIndex = 19;
            this.llbComments.TabStop = true;
            this.llbComments.Text = "Comment:";
            this.llbComments.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbComments_LinkClicked);
            // 
            // llbMedias
            // 
            this.llbMedias.AutoSize = true;
            this.llbMedias.Location = new System.Drawing.Point(195, 64);
            this.llbMedias.Name = "llbMedias";
            this.llbMedias.Size = new System.Drawing.Size(60, 18);
            this.llbMedias.TabIndex = 20;
            this.llbMedias.TabStop = true;
            this.llbMedias.Text = "Media: ";
            this.llbMedias.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbMedias_LinkClicked);
            // 
            // llbOperations
            // 
            this.llbOperations.AutoSize = true;
            this.llbOperations.Location = new System.Drawing.Point(362, 64);
            this.llbOperations.Name = "llbOperations";
            this.llbOperations.Size = new System.Drawing.Size(81, 18);
            this.llbOperations.TabIndex = 21;
            this.llbOperations.TabStop = true;
            this.llbOperations.Text = "Operation:";
            this.llbOperations.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbOperations_LinkClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 18);
            this.label6.TabIndex = 22;
            this.label6.Text = "Message:";
            // 
            // tbPostMessage
            // 
            this.tbPostMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPostMessage.Location = new System.Drawing.Point(91, 96);
            this.tbPostMessage.Multiline = true;
            this.tbPostMessage.Name = "tbPostMessage";
            this.tbPostMessage.Size = new System.Drawing.Size(799, 86);
            this.tbPostMessage.TabIndex = 23;
            // 
            // tbAiSummary
            // 
            this.tbAiSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAiSummary.Location = new System.Drawing.Point(91, 195);
            this.tbAiSummary.Multiline = true;
            this.tbAiSummary.Name = "tbAiSummary";
            this.tbAiSummary.Size = new System.Drawing.Size(799, 86);
            this.tbAiSummary.TabIndex = 24;
            // 
            // btnAiSummary
            // 
            this.btnAiSummary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAiSummary.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAiSummary.Location = new System.Drawing.Point(11, 195);
            this.btnAiSummary.Name = "btnAiSummary";
            this.btnAiSummary.Size = new System.Drawing.Size(77, 86);
            this.btnAiSummary.TabIndex = 25;
            this.btnAiSummary.Text = "AI Summary";
            this.btnAiSummary.UseVisualStyleBackColor = true;
            // 
            // lbAiStatus
            // 
            this.lbAiStatus.AutoSize = true;
            this.lbAiStatus.ForeColor = System.Drawing.Color.Red;
            this.lbAiStatus.Location = new System.Drawing.Point(11, 293);
            this.lbAiStatus.Name = "lbAiStatus";
            this.lbAiStatus.Size = new System.Drawing.Size(130, 18);
            this.lbAiStatus.TabIndex = 26;
            this.lbAiStatus.Text = "(Ai feature status)";
            // 
            // PostPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelDetail);
            this.Controls.Add(this.cbMedia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbNickname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvPosts);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbKeyword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "PostPage";
            this.Size = new System.Drawing.Size(944, 597);
            this.Load += new System.EventHandler(this.PostPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosts)).EndInit();
            this.panelDetail.ResumeLayout(false);
            this.panelDetail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbKeyword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvPosts;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPostId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPostNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPostNickname;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMessage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreation;
        private System.Windows.Forms.TextBox tbNickname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbMedia;
        private System.Windows.Forms.Panel panelDetail;
        private System.Windows.Forms.Label lbPostNo;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbNickname;
        private System.Windows.Forms.Label lbCreation;
        private System.Windows.Forms.LinkLabel llbComments;
        private System.Windows.Forms.LinkLabel llbMedias;
        private System.Windows.Forms.LinkLabel llbOperations;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPostMessage;
        private System.Windows.Forms.TextBox tbAiSummary;
        private System.Windows.Forms.Button btnAiSummary;
        private System.Windows.Forms.Label lbAiStatus;
    }
}
