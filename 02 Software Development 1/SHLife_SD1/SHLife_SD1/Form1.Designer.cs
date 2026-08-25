namespace SHLife_SD1 {
    partial class Form1 {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelWindowBar = new System.Windows.Forms.Panel();
            this.lbWindowTitle = new System.Windows.Forms.Label();
            this.btnWindowMin = new System.Windows.Forms.Button();
            this.btnWindowMax = new System.Windows.Forms.Button();
            this.btnWindowClose = new System.Windows.Forms.Button();
            this.panelWindow = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelStatus = new System.Windows.Forms.Panel();
            this.lbTime = new System.Windows.Forms.Label();
            this.btnLogInOut = new System.Windows.Forms.Button();
            this.lbNameRole = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelWindowBar.SuspendLayout();
            this.panelWindow.SuspendLayout();
            this.panelStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelWindowBar
            // 
            this.panelWindowBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(26)))), ((int)(((byte)(73)))));
            this.panelWindowBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelWindowBar.Controls.Add(this.lbWindowTitle);
            this.panelWindowBar.Controls.Add(this.btnWindowMin);
            this.panelWindowBar.Controls.Add(this.btnWindowMax);
            this.panelWindowBar.Controls.Add(this.btnWindowClose);
            this.panelWindowBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelWindowBar.Location = new System.Drawing.Point(0, 0);
            this.panelWindowBar.Name = "panelWindowBar";
            this.panelWindowBar.Size = new System.Drawing.Size(1166, 30);
            this.panelWindowBar.TabIndex = 0;
            // 
            // lbWindowTitle
            // 
            this.lbWindowTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbWindowTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWindowTitle.ForeColor = System.Drawing.Color.White;
            this.lbWindowTitle.Location = new System.Drawing.Point(0, 0);
            this.lbWindowTitle.Name = "lbWindowTitle";
            this.lbWindowTitle.Size = new System.Drawing.Size(1044, 28);
            this.lbWindowTitle.TabIndex = 0;
            this.lbWindowTitle.Text = "SHLife Operation Management System";
            this.lbWindowTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbWindowTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbWindowTitle_MouseDown);
            this.lbWindowTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbWindowTitle_MouseMove);
            this.lbWindowTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lbWindowTitle_MouseUp);
            // 
            // btnWindowMin
            // 
            this.btnWindowMin.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnWindowMin.FlatAppearance.BorderSize = 0;
            this.btnWindowMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWindowMin.ForeColor = System.Drawing.Color.White;
            this.btnWindowMin.Location = new System.Drawing.Point(1044, 0);
            this.btnWindowMin.Name = "btnWindowMin";
            this.btnWindowMin.Size = new System.Drawing.Size(40, 28);
            this.btnWindowMin.TabIndex = 3;
            this.btnWindowMin.Text = "—";
            this.btnWindowMin.UseVisualStyleBackColor = true;
            this.btnWindowMin.Click += new System.EventHandler(this.btnWindowMin_Click);
            // 
            // btnWindowMax
            // 
            this.btnWindowMax.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnWindowMax.FlatAppearance.BorderSize = 0;
            this.btnWindowMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWindowMax.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWindowMax.ForeColor = System.Drawing.Color.White;
            this.btnWindowMax.Location = new System.Drawing.Point(1084, 0);
            this.btnWindowMax.Name = "btnWindowMax";
            this.btnWindowMax.Size = new System.Drawing.Size(40, 28);
            this.btnWindowMax.TabIndex = 2;
            this.btnWindowMax.Text = "□";
            this.btnWindowMax.UseVisualStyleBackColor = true;
            this.btnWindowMax.Click += new System.EventHandler(this.btnWindowMax_Click);
            // 
            // btnWindowClose
            // 
            this.btnWindowClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnWindowClose.FlatAppearance.BorderSize = 0;
            this.btnWindowClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnWindowClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWindowClose.ForeColor = System.Drawing.Color.White;
            this.btnWindowClose.Location = new System.Drawing.Point(1124, 0);
            this.btnWindowClose.Name = "btnWindowClose";
            this.btnWindowClose.Size = new System.Drawing.Size(40, 28);
            this.btnWindowClose.TabIndex = 1;
            this.btnWindowClose.Text = "X";
            this.btnWindowClose.UseVisualStyleBackColor = true;
            this.btnWindowClose.Click += new System.EventHandler(this.btnWindowClose_Click);
            // 
            // panelWindow
            // 
            this.panelWindow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelWindow.Controls.Add(this.panelMain);
            this.panelWindow.Controls.Add(this.panelStatus);
            this.panelWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWindow.Location = new System.Drawing.Point(0, 30);
            this.panelWindow.Name = "panelWindow";
            this.panelWindow.Size = new System.Drawing.Size(1166, 656);
            this.panelWindow.TabIndex = 1;
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 57);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1164, 597);
            this.panelMain.TabIndex = 1;
            // 
            // panelStatus
            // 
            this.panelStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelStatus.Controls.Add(this.lbTime);
            this.panelStatus.Controls.Add(this.btnLogInOut);
            this.panelStatus.Controls.Add(this.lbNameRole);
            this.panelStatus.Controls.Add(this.label3);
            this.panelStatus.Controls.Add(this.label2);
            this.panelStatus.Controls.Add(this.label1);
            this.panelStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStatus.Location = new System.Drawing.Point(0, 0);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(1164, 57);
            this.panelStatus.TabIndex = 0;
            // 
            // lbTime
            // 
            this.lbTime.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(958, 35);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(198, 18);
            this.lbTime.TabIndex = 5;
            this.lbTime.Text = "Time: 2026-07-30 13:10:00";
            this.lbTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogInOut
            // 
            this.btnLogInOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogInOut.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogInOut.Location = new System.Drawing.Point(975, 4);
            this.btnLogInOut.Name = "btnLogInOut";
            this.btnLogInOut.Size = new System.Drawing.Size(163, 28);
            this.btnLogInOut.TabIndex = 4;
            this.btnLogInOut.Text = "Login";
            this.btnLogInOut.UseVisualStyleBackColor = true;
            this.btnLogInOut.Click += new System.EventHandler(this.btnLogInOut_Click);
            // 
            // lbNameRole
            // 
            this.lbNameRole.Location = new System.Drawing.Point(331, 7);
            this.lbNameRole.Name = "lbNameRole";
            this.lbNameRole.Size = new System.Drawing.Size(497, 40);
            this.lbNameRole.TabIndex = 3;
            this.lbNameRole.Text = "Currently Login: Anonymous";
            this.lbNameRole.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Site Endpoint: http://localhost:5000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Connecting...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Site Status:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 686);
            this.Controls.Add(this.panelWindow);
            this.Controls.Add(this.panelWindowBar);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "SHLife Operation Management System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelWindowBar.ResumeLayout(false);
            this.panelWindow.ResumeLayout(false);
            this.panelStatus.ResumeLayout(false);
            this.panelStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelWindowBar;
        private System.Windows.Forms.Label lbWindowTitle;
        private System.Windows.Forms.Button btnWindowClose;
        private System.Windows.Forms.Button btnWindowMin;
        private System.Windows.Forms.Button btnWindowMax;
        private System.Windows.Forms.Panel panelWindow;
        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbNameRole;
        private System.Windows.Forms.Button btnLogInOut;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Panel panelMain;
    }
}

