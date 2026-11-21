namespace STIERegistrar.Forms
{
    partial class StudentMainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblBrandSub = new System.Windows.Forms.Label();
            this.pnlBrandLine = new System.Windows.Forms.Panel();
            this.lblSection = new System.Windows.Forms.Label();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnNewRequest = new System.Windows.Forms.Button();
            this.btnTrack = new System.Windows.Forms.Button();
            this.pnlHelp = new System.Windows.Forms.Panel();
            this.lblHelpTitle = new System.Windows.Forms.Label();
            this.lblHelpText = new System.Windows.Forms.Label();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblPortalTitle = new System.Windows.Forms.Label();
            this.lblAcademicYear = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblUserRole = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlSidebar.SuspendLayout();
            this.pnlHelp.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            //
            // pnlSidebar
            //
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(15, 52, 120);
            this.pnlSidebar.Controls.Add(this.btnSignOut);
            this.pnlSidebar.Controls.Add(this.pnlHelp);
            this.pnlSidebar.Controls.Add(this.btnTrack);
            this.pnlSidebar.Controls.Add(this.btnNewRequest);
            this.pnlSidebar.Controls.Add(this.btnDashboard);
            this.pnlSidebar.Controls.Add(this.lblSection);
            this.pnlSidebar.Controls.Add(this.pnlBrandLine);
            this.pnlSidebar.Controls.Add(this.lblBrandSub);
            this.pnlSidebar.Controls.Add(this.lblBrand);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(230, 760);
            this.pnlSidebar.TabIndex = 2;
            //
            // lblBrand
            //
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblBrand.ForeColor = System.Drawing.Color.White;
            this.lblBrand.Location = new System.Drawing.Point(24, 24);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Text = "STI E-Registrar";
            //
            // lblBrandSub
            //
            this.lblBrandSub.AutoSize = true;
            this.lblBrandSub.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.lblBrandSub.ForeColor = System.Drawing.Color.White;
            this.lblBrandSub.Location = new System.Drawing.Point(26, 60);
            this.lblBrandSub.Name = "lblBrandSub";
            this.lblBrandSub.Text = "STUDENT DOCUMENTS";
            //
            // pnlBrandLine
            //
            this.pnlBrandLine.BackColor = System.Drawing.Color.FromArgb(255, 213, 74);
            this.pnlBrandLine.Location = new System.Drawing.Point(26, 82);
            this.pnlBrandLine.Name = "pnlBrandLine";
            this.pnlBrandLine.Size = new System.Drawing.Size(28, 3);
            //
            // lblSection
            //
            this.lblSection.AutoSize = true;
            this.lblSection.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.lblSection.ForeColor = System.Drawing.Color.FromArgb(200, 210, 230);
            this.lblSection.Location = new System.Drawing.Point(26, 116);
            this.lblSection.Name = "lblSection";
            this.lblSection.Text = "STUDENT SERVICES";
            //
            // btnDashboard
            //
            this.btnDashboard.Location = new System.Drawing.Point(12, 140);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(206, 42);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            //
            // btnNewRequest
            //
            this.btnNewRequest.Location = new System.Drawing.Point(12, 188);
            this.btnNewRequest.Name = "btnNewRequest";
            this.btnNewRequest.Size = new System.Drawing.Size(206, 42);
            this.btnNewRequest.TabIndex = 1;
            this.btnNewRequest.Text = "New request";
            this.btnNewRequest.Click += new System.EventHandler(this.btnNewRequest_Click);
            //
            // btnTrack
            //
            this.btnTrack.Location = new System.Drawing.Point(12, 236);
            this.btnTrack.Name = "btnTrack";
            this.btnTrack.Size = new System.Drawing.Size(206, 42);
            this.btnTrack.TabIndex = 2;
            this.btnTrack.Text = "Track a request";
            this.btnTrack.Click += new System.EventHandler(this.btnTrack_Click);
            //
            // pnlHelp
            //
            this.pnlHelp.BackColor = System.Drawing.Color.FromArgb(34, 73, 140);
            this.pnlHelp.Controls.Add(this.lblHelpText);
            this.pnlHelp.Controls.Add(this.lblHelpTitle);
            this.pnlHelp.Location = new System.Drawing.Point(12, 610);
            this.pnlHelp.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            this.pnlHelp.Name = "pnlHelp";
            this.pnlHelp.Size = new System.Drawing.Size(206, 80);
            //
            // lblHelpTitle
            //
            this.lblHelpTitle.AutoSize = true;
            this.lblHelpTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblHelpTitle.ForeColor = System.Drawing.Color.White;
            this.lblHelpTitle.Location = new System.Drawing.Point(12, 10);
            this.lblHelpTitle.Name = "lblHelpTitle";
            this.lblHelpTitle.Text = "Need a hand?";
            //
            // lblHelpText
            //
            this.lblHelpText.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblHelpText.ForeColor = System.Drawing.Color.White;
            this.lblHelpText.Location = new System.Drawing.Point(12, 32);
            this.lblHelpText.Name = "lblHelpText";
            this.lblHelpText.Size = new System.Drawing.Size(182, 36);
            this.lblHelpText.Text = "Contact the registrar\r\nMon–Fri, 8 AM–5 PM";
            //
            // btnSignOut
            //
            this.btnSignOut.Location = new System.Drawing.Point(12, 705);
            this.btnSignOut.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(206, 38);
            this.btnSignOut.TabIndex = 3;
            this.btnSignOut.Text = "Sign out";
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            //
            // pnlHeader
            //
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblUserRole);
            this.pnlHeader.Controls.Add(this.lblUserName);
            this.pnlHeader.Controls.Add(this.lblAcademicYear);
            this.pnlHeader.Controls.Add(this.lblPortalTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(970, 68);
            this.pnlHeader.TabIndex = 1;
            //
            // lblPortalTitle
            //
            this.lblPortalTitle.AutoSize = true;
            this.lblPortalTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPortalTitle.ForeColor = System.Drawing.Color.FromArgb(20, 40, 75);
            this.lblPortalTitle.Location = new System.Drawing.Point(30, 24);
            this.lblPortalTitle.Name = "lblPortalTitle";
            this.lblPortalTitle.Text = "Student portal";
            //
            // lblAcademicYear
            //
            this.lblAcademicYear.AutoSize = true;
            this.lblAcademicYear.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblAcademicYear.ForeColor = System.Drawing.Color.FromArgb(107, 122, 153);
            this.lblAcademicYear.Location = new System.Drawing.Point(300, 26);
            this.lblAcademicYear.Name = "lblAcademicYear";
            this.lblAcademicYear.Text = "Academic year 2026–2027";
            //
            // lblUserName
            //
            this.lblUserName.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblUserName.ForeColor = System.Drawing.Color.FromArgb(20, 40, 75);
            this.lblUserName.Location = new System.Drawing.Point(730, 14);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(210, 22);
            this.lblUserName.Text = "Name";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // lblUserRole
            //
            this.lblUserRole.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.lblUserRole.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblUserRole.ForeColor = System.Drawing.Color.FromArgb(107, 122, 153);
            this.lblUserRole.Location = new System.Drawing.Point(730, 36);
            this.lblUserRole.Name = "lblUserRole";
            this.lblUserRole.Size = new System.Drawing.Size(210, 20);
            this.lblUserRole.Text = "Student account";
            this.lblUserRole.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // pnlContent
            //
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(242, 245, 250);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.TabIndex = 0;
            //
            // StudentMainForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 760);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlSidebar);
            this.MinimumSize = new System.Drawing.Size(1240, 700);
            this.Name = "StudentMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STI E-Registrar - Student portal";
            this.Load += new System.EventHandler(this.StudentMainForm_Load);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            this.pnlHelp.ResumeLayout(false);
            this.pnlHelp.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblBrandSub;
        private System.Windows.Forms.Panel pnlBrandLine;
        private System.Windows.Forms.Label lblSection;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnNewRequest;
        private System.Windows.Forms.Button btnTrack;
        private System.Windows.Forms.Panel pnlHelp;
        private System.Windows.Forms.Label lblHelpTitle;
        private System.Windows.Forms.Label lblHelpText;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblPortalTitle;
        private System.Windows.Forms.Label lblAcademicYear;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblUserRole;
        private System.Windows.Forms.Panel pnlContent;
    }
}
