namespace SHLife_SD1.Mainpage {
    partial class MainPage {
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
            this.panelSide = new System.Windows.Forms.Panel();
            this.btnGoReview = new System.Windows.Forms.Button();
            this.btnGoBrowse = new System.Windows.Forms.Button();
            this.btnGoPost = new System.Windows.Forms.Button();
            this.btnGoVerification = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelSide.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSide
            // 
            this.panelSide.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSide.Controls.Add(this.btnGoVerification);
            this.panelSide.Controls.Add(this.btnGoPost);
            this.panelSide.Controls.Add(this.btnGoBrowse);
            this.panelSide.Controls.Add(this.btnGoReview);
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSide.Location = new System.Drawing.Point(0, 0);
            this.panelSide.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(220, 597);
            this.panelSide.TabIndex = 0;
            // 
            // btnGoReview
            // 
            this.btnGoReview.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGoReview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoReview.Location = new System.Drawing.Point(0, 0);
            this.btnGoReview.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGoReview.Name = "btnGoReview";
            this.btnGoReview.Size = new System.Drawing.Size(218, 45);
            this.btnGoReview.TabIndex = 0;
            this.btnGoReview.Text = "Official Account Review";
            this.btnGoReview.UseVisualStyleBackColor = true;
            this.btnGoReview.Click += new System.EventHandler(this.btnGoReview_Click);
            // 
            // btnGoBrowse
            // 
            this.btnGoBrowse.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGoBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoBrowse.Location = new System.Drawing.Point(0, 45);
            this.btnGoBrowse.Margin = new System.Windows.Forms.Padding(2);
            this.btnGoBrowse.Name = "btnGoBrowse";
            this.btnGoBrowse.Size = new System.Drawing.Size(218, 45);
            this.btnGoBrowse.TabIndex = 1;
            this.btnGoBrowse.Text = "Browse Official Account";
            this.btnGoBrowse.UseVisualStyleBackColor = true;
            this.btnGoBrowse.Click += new System.EventHandler(this.btnGoBrowse_Click);
            // 
            // btnGoPost
            // 
            this.btnGoPost.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGoPost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoPost.Location = new System.Drawing.Point(0, 90);
            this.btnGoPost.Margin = new System.Windows.Forms.Padding(2);
            this.btnGoPost.Name = "btnGoPost";
            this.btnGoPost.Size = new System.Drawing.Size(218, 45);
            this.btnGoPost.TabIndex = 2;
            this.btnGoPost.Text = "Post Monitor";
            this.btnGoPost.UseVisualStyleBackColor = true;
            this.btnGoPost.Click += new System.EventHandler(this.btnGoPost_Click);
            // 
            // btnGoVerification
            // 
            this.btnGoVerification.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGoVerification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoVerification.Location = new System.Drawing.Point(0, 135);
            this.btnGoVerification.Margin = new System.Windows.Forms.Padding(2);
            this.btnGoVerification.Name = "btnGoVerification";
            this.btnGoVerification.Size = new System.Drawing.Size(218, 45);
            this.btnGoVerification.TabIndex = 3;
            this.btnGoVerification.Text = "Automatic Verification";
            this.btnGoVerification.UseVisualStyleBackColor = true;
            this.btnGoVerification.Click += new System.EventHandler(this.btnGoVerification_Click);
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(220, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(944, 597);
            this.panelMain.TabIndex = 1;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelSide);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "MainPage";
            this.Size = new System.Drawing.Size(1164, 597);
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.panelSide.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Button btnGoReview;
        private System.Windows.Forms.Button btnGoVerification;
        private System.Windows.Forms.Button btnGoPost;
        private System.Windows.Forms.Button btnGoBrowse;
        private System.Windows.Forms.Panel panelMain;
    }
}
