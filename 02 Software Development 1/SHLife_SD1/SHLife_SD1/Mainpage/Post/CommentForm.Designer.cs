namespace SHLife_SD1.Mainpage.Post {
    partial class CommentForm {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommentForm));
            this.dgvPosts = new System.Windows.Forms.DataGridView();
            this.sHLife_A07DataSet1 = new SHLife_SD1.SHLife_A07DataSet1();
            this.postCommentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postCommentTableAdapter = new SHLife_SD1.SHLife_A07DataSet1TableAdapters.PostCommentTableAdapter();
            this.postCommentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postCommentNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stickerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.replyPostCommentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createDateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateDateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sHLife_A07DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postCommentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPosts
            // 
            this.dgvPosts.AutoGenerateColumns = false;
            this.dgvPosts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPosts.BackgroundColor = System.Drawing.Color.White;
            this.dgvPosts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(26)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPosts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPosts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPosts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.postCommentIdDataGridViewTextBoxColumn,
            this.postCommentNoDataGridViewTextBoxColumn,
            this.postIdDataGridViewTextBoxColumn,
            this.accountIdDataGridViewTextBoxColumn,
            this.colAccount,
            this.typeDataGridViewTextBoxColumn,
            this.messageDataGridViewTextBoxColumn,
            this.stickerIdDataGridViewTextBoxColumn,
            this.replyPostCommentIdDataGridViewTextBoxColumn,
            this.createDateTimeDataGridViewTextBoxColumn,
            this.updateDateTimeDataGridViewTextBoxColumn});
            this.dgvPosts.DataSource = this.postCommentBindingSource;
            this.dgvPosts.EnableHeadersVisualStyles = false;
            this.dgvPosts.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvPosts.Location = new System.Drawing.Point(12, 12);
            this.dgvPosts.Name = "dgvPosts";
            this.dgvPosts.RowHeadersVisible = false;
            this.dgvPosts.RowTemplate.Height = 24;
            this.dgvPosts.Size = new System.Drawing.Size(797, 425);
            this.dgvPosts.TabIndex = 24;
            // 
            // sHLife_A07DataSet1
            // 
            this.sHLife_A07DataSet1.DataSetName = "SHLife_A07DataSet1";
            this.sHLife_A07DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // postCommentBindingSource
            // 
            this.postCommentBindingSource.DataMember = "PostComment";
            this.postCommentBindingSource.DataSource = this.sHLife_A07DataSet1;
            // 
            // postCommentTableAdapter
            // 
            this.postCommentTableAdapter.ClearBeforeFill = true;
            // 
            // postCommentIdDataGridViewTextBoxColumn
            // 
            this.postCommentIdDataGridViewTextBoxColumn.DataPropertyName = "PostCommentId";
            this.postCommentIdDataGridViewTextBoxColumn.HeaderText = "PostCommentId";
            this.postCommentIdDataGridViewTextBoxColumn.Name = "postCommentIdDataGridViewTextBoxColumn";
            this.postCommentIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // postCommentNoDataGridViewTextBoxColumn
            // 
            this.postCommentNoDataGridViewTextBoxColumn.DataPropertyName = "PostCommentNo";
            this.postCommentNoDataGridViewTextBoxColumn.FillWeight = 40F;
            this.postCommentNoDataGridViewTextBoxColumn.HeaderText = "No";
            this.postCommentNoDataGridViewTextBoxColumn.Name = "postCommentNoDataGridViewTextBoxColumn";
            this.postCommentNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // postIdDataGridViewTextBoxColumn
            // 
            this.postIdDataGridViewTextBoxColumn.DataPropertyName = "PostId";
            this.postIdDataGridViewTextBoxColumn.HeaderText = "PostId";
            this.postIdDataGridViewTextBoxColumn.Name = "postIdDataGridViewTextBoxColumn";
            this.postIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // accountIdDataGridViewTextBoxColumn
            // 
            this.accountIdDataGridViewTextBoxColumn.DataPropertyName = "AccountId";
            this.accountIdDataGridViewTextBoxColumn.HeaderText = "AccountId";
            this.accountIdDataGridViewTextBoxColumn.Name = "accountIdDataGridViewTextBoxColumn";
            this.accountIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // colAccount
            // 
            this.colAccount.DataPropertyName = "colAccount";
            this.colAccount.HeaderText = "Account";
            this.colAccount.Name = "colAccount";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.Visible = false;
            // 
            // messageDataGridViewTextBoxColumn
            // 
            this.messageDataGridViewTextBoxColumn.DataPropertyName = "Message";
            this.messageDataGridViewTextBoxColumn.FillWeight = 250F;
            this.messageDataGridViewTextBoxColumn.HeaderText = "Message";
            this.messageDataGridViewTextBoxColumn.Name = "messageDataGridViewTextBoxColumn";
            // 
            // stickerIdDataGridViewTextBoxColumn
            // 
            this.stickerIdDataGridViewTextBoxColumn.DataPropertyName = "StickerId";
            this.stickerIdDataGridViewTextBoxColumn.HeaderText = "StickerId";
            this.stickerIdDataGridViewTextBoxColumn.Name = "stickerIdDataGridViewTextBoxColumn";
            this.stickerIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // replyPostCommentIdDataGridViewTextBoxColumn
            // 
            this.replyPostCommentIdDataGridViewTextBoxColumn.DataPropertyName = "ReplyPostCommentId";
            this.replyPostCommentIdDataGridViewTextBoxColumn.HeaderText = "ReplyPostCommentId";
            this.replyPostCommentIdDataGridViewTextBoxColumn.Name = "replyPostCommentIdDataGridViewTextBoxColumn";
            this.replyPostCommentIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // createDateTimeDataGridViewTextBoxColumn
            // 
            this.createDateTimeDataGridViewTextBoxColumn.DataPropertyName = "CreateDateTime";
            this.createDateTimeDataGridViewTextBoxColumn.HeaderText = "Creation";
            this.createDateTimeDataGridViewTextBoxColumn.Name = "createDateTimeDataGridViewTextBoxColumn";
            // 
            // updateDateTimeDataGridViewTextBoxColumn
            // 
            this.updateDateTimeDataGridViewTextBoxColumn.DataPropertyName = "UpdateDateTime";
            this.updateDateTimeDataGridViewTextBoxColumn.HeaderText = "UpdateDateTime";
            this.updateDateTimeDataGridViewTextBoxColumn.Name = "updateDateTimeDataGridViewTextBoxColumn";
            this.updateDateTimeDataGridViewTextBoxColumn.Visible = false;
            // 
            // CommentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 449);
            this.Controls.Add(this.dgvPosts);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.Name = "CommentForm";
            this.Text = "SHLife Operation Management System (Loading, please wait.)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CommentForm_FormClosing);
            this.Load += new System.EventHandler(this.CommentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sHLife_A07DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postCommentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPosts;
        private SHLife_A07DataSet1 sHLife_A07DataSet1;
        private System.Windows.Forms.BindingSource postCommentBindingSource;
        private SHLife_A07DataSet1TableAdapters.PostCommentTableAdapter postCommentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn postCommentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postCommentNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn messageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stickerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn replyPostCommentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updateDateTimeDataGridViewTextBoxColumn;
    }
}