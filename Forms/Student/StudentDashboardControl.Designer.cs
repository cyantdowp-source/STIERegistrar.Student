namespace STIERegistrar.Forms
{
    partial class StudentDashboardControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.lblPortalTag = new System.Windows.Forms.Label();
            this.lblGreeting = new System.Windows.Forms.Label();
            this.lblSub = new System.Windows.Forms.Label();
            this.btnNewRequest = new System.Windows.Forms.Button();
            this.pnlCardActive = new System.Windows.Forms.Panel();
            this.pnlStripActive = new System.Windows.Forms.Panel();
            this.lblActiveTitle = new System.Windows.Forms.Label();
            this.lblActiveCount = new System.Windows.Forms.Label();
            this.lblActiveSub = new System.Windows.Forms.Label();
            this.pnlCardReady = new System.Windows.Forms.Panel();
            this.pnlStripReady = new System.Windows.Forms.Panel();
            this.lblReadyTitle = new System.Windows.Forms.Label();
            this.lblReadyCount = new System.Windows.Forms.Label();
            this.lblReadySub = new System.Windows.Forms.Label();
            this.pnlCardDone = new System.Windows.Forms.Panel();
            this.pnlStripDone = new System.Windows.Forms.Panel();
            this.lblDoneTitle = new System.Windows.Forms.Label();
            this.lblCompletedCount = new System.Windows.Forms.Label();
            this.lblDoneSub = new System.Windows.Forms.Label();
            this.pnlTrack = new System.Windows.Forms.Panel();
            this.lblTrackTitle = new System.Windows.Forms.Label();
            this.lblTrackSub = new System.Windows.Forms.Label();
            this.txtTrackingNo = new System.Windows.Forms.TextBox();
            this.btnTrack = new System.Windows.Forms.Button();
            this.lblMyRequests = new System.Windows.Forms.Label();
            this.lnkViewAll = new System.Windows.Forms.LinkLabel();
            this.dgvMyRequests = new System.Windows.Forms.DataGridView();
            this.colTracking = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDocument = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlProgress = new System.Windows.Forms.Panel();
            this.lblProgTracking = new System.Windows.Forms.Label();
            this.lblProgRush = new System.Windows.Forms.Label();
            this.lblProgDetail = new System.Windows.Forms.Label();
            this.stepper = new STIERegistrar.Forms.StatusStepper();
            this.pnlCardActive.SuspendLayout();
            this.pnlCardReady.SuspendLayout();
            this.pnlCardDone.SuspendLayout();
            this.pnlTrack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyRequests)).BeginInit();
            this.pnlProgress.SuspendLayout();
            this.SuspendLayout();
            //
            // lblPortalTag
            //
            this.lblPortalTag.AutoSize = true;
            this.lblPortalTag.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblPortalTag.ForeColor = System.Drawing.Color.FromArgb(26, 92, 219);
            this.lblPortalTag.Location = new System.Drawing.Point(32, 24);
            this.lblPortalTag.Name = "lblPortalTag";
            this.lblPortalTag.Text = "YOUR STUDENT PORTAL";
            //
            // lblGreeting
            //
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblGreeting.ForeColor = System.Drawing.Color.FromArgb(20, 40, 75);
            this.lblGreeting.Location = new System.Drawing.Point(28, 42);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Text = "Good morning";
            //
            // lblSub
            //
            this.lblSub.AutoSize = true;
            this.lblSub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSub.ForeColor = System.Drawing.Color.FromArgb(107, 122, 153);
            this.lblSub.Location = new System.Drawing.Point(32, 92);
            this.lblSub.Name = "lblSub";
            this.lblSub.Text = "Your official documents, without the guesswork.";
            //
            // btnNewRequest
            //
            this.btnNewRequest.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.btnNewRequest.Location = new System.Drawing.Point(790, 36);
            this.btnNewRequest.Name = "btnNewRequest";
            this.btnNewRequest.Size = new System.Drawing.Size(150, 42);
            this.btnNewRequest.TabIndex = 0;
            this.btnNewRequest.Text = "+  New request";
            this.btnNewRequest.Click += new System.EventHandler(this.btnNewRequest_Click);
            //
            // pnlCardActive
            //
            this.pnlCardActive.BackColor = System.Drawing.Color.White;
            this.pnlCardActive.Controls.Add(this.lblActiveSub);
            this.pnlCardActive.Controls.Add(this.lblActiveCount);
            this.pnlCardActive.Controls.Add(this.lblActiveTitle);
            this.pnlCardActive.Controls.Add(this.pnlStripActive);
            this.pnlCardActive.Location = new System.Drawing.Point(30, 130);
            this.pnlCardActive.Name = "pnlCardActive";
            this.pnlCardActive.Size = new System.Drawing.Size(290, 96);
            //
            // pnlStripActive
            //
            this.pnlStripActive.BackColor = System.Drawing.Color.FromArgb(26, 92, 219);
            this.pnlStripActive.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlStripActive.Name = "pnlStripActive";
            this.pnlStripActive.Size = new System.Drawing.Size(4, 96);
            //
            // lblActiveTitle
            //
            this.lblActiveTitle.AutoSize = true;
            this.lblActiveTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblActiveTitle.ForeColor = System.Drawing.Color.FromArgb(107, 122, 153);
            this.lblActiveTitle.Location = new System.Drawing.Point(18, 14);
            this.lblActiveTitle.Name = "lblActiveTitle";
            this.lblActiveTitle.Text = "Active requests";
            //
            // lblActiveCount
            //
            this.lblActiveCount.AutoSize = true;
            this.lblActiveCount.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblActiveCount.ForeColor = System.Drawing.Color.FromArgb(20, 40, 75);
            this.lblActiveCount.Location = new System.Drawing.Point(14, 34);
            this.lblActiveCount.Name = "lblActiveCount";
            this.lblActiveCount.Text = "00";
            //
            // lblActiveSub
            //
            this.lblActiveSub.AutoSize = true;
            this.lblActiveSub.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblActiveSub.ForeColor = System.Drawing.Color.FromArgb(107, 122, 153);
            this.lblActiveSub.Location = new System.Drawing.Point(90, 56);
            this.lblActiveSub.Name = "lblActiveSub";
            this.lblActiveSub.Text = "In progress";
            //
            // pnlCardReady
            //
            this.pnlCardReady.BackColor = System.Drawing.Color.White;
            this.pnlCardReady.Controls.Add(this.lblReadySub);
            this.pnlCardReady.Controls.Add(this.lblReadyCount);
            this.pnlCardReady.Controls.Add(this.lblReadyTitle);
            this.pnlCardReady.Controls.Add(this.pnlStripReady);
            this.pnlCardReady.Location = new System.Drawing.Point(340, 130);
            this.pnlCardReady.Name = "pnlCardReady";
            this.pnlCardReady.Size = new System.Drawing.Size(290, 96);
            //
            // pnlStripReady
            //
            this.pnlStripReady.BackColor = System.Drawing.Color.FromArgb(255, 213, 74);
            this.pnlStripReady.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlStripReady.Name = "pnlStripReady";
            this.pnlStripReady.Size = new System.Drawing.Size(4, 96);
            //
            // lblReadyTitle
            //
            this.lblReadyTitle.AutoSize = true;
            this.lblReadyTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblReadyTitle.ForeColor = System.Drawing.Color.FromArgb(107, 122, 153);
            this.lblReadyTitle.Location = new System.Drawing.Point(18, 14);
            this.lblReadyTitle.Name = "lblReadyTitle";
            this.lblReadyTitle.Text = "Ready for Pick-up";
            //
            // lblReadyCount
            //
            this.lblReadyCount.AutoSize = true;
            this.lblReadyCount.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblReadyCount.ForeColor = System.Drawing.Color.FromArgb(20, 40, 75);
            this.lblReadyCount.Location = new System.Drawing.Point(14, 34);
            this.lblReadyCount.Name = "lblReadyCount";
            this.lblReadyCount.Text = "00";
            //
            // lblReadySub
            //
            this.lblReadySub.AutoSize = true;
            this.lblReadySub.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblReadySub.ForeColor = System.Drawing.Color.FromArgb(107, 122, 153);
            this.lblReadySub.Location = new System.Drawing.Point(90, 56);
            this.lblReadySub.Name = "lblReadySub";
            this.lblReadySub.Text = "Visit the registrar";
            //
            // pnlCardDone
            //
            this.pnlCardDone.BackColor = System.Drawing.Color.White;
            this.pnlCardDone.Controls.Add(this.lblDoneSub);
            this.pnlCardDone.Controls.Add(this.lblCompletedCount);
            this.pnlCardDone.Controls.Add(this.lblDoneTitle);
            this.pnlCardDone.Controls.Add(this.pnlStripDone);
            this.pnlCardDone.Location = new System.Drawing.Point(650, 130);
            this.pnlCardDone.Name = "pnlCardDone";
            this.pnlCardDone.Size = new System.Drawing.Size(290, 96);
            //
            // pnlStripDone
            //
            this.pnlStripDone.BackColor = System.Drawing.Color.FromArgb(26, 92, 219);
            this.pnlStripDone.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlStripDone.Name = "pnlStripDone";
            this.pnlStripDone.Size = new System.Drawing.Size(4, 96);
            //
            // lblDoneTitle
            //
            this.lblDoneTitle.AutoSize = true;
            this.lblDoneTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblDoneTitle.ForeColor = System.Drawing.Color.FromArgb(107, 122, 153);
            this.lblDoneTitle.Location = new System.Drawing.Point(18, 14);
            this.lblDoneTitle.Name = "lblDoneTitle";
            this.lblDoneTitle.Text = "Completed";
            //
            // lblCompletedCount
            //
            this.lblCompletedCount.AutoSize = true;
            this.lblCompletedCount.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblCompletedCount.ForeColor = System.Drawing.Color.FromArgb(20, 40, 75);
            this.lblCompletedCount.Location = new System.Drawing.Point(14, 34);
            this.lblCompletedCount.Name = "lblCompletedCount";
            this.lblCompletedCount.Text = "00";
            //
            // lblDoneSub
            //
            this.lblDoneSub.AutoSize = true;
            this.lblDoneSub.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblDoneSub.ForeColor = System.Drawing.Color.FromArgb(107, 122, 153);
            this.lblDoneSub.Location = new System.Drawing.Point(90, 56);
            this.lblDoneSub.Name = "lblDoneSub";
            this.lblDoneSub.Text = "Documents released";
            //
            // pnlTrack
            //
            this.pnlTrack.BackColor = System.Drawing.Color.FromArgb(15, 52, 120);
            this.pnlTrack.Controls.Add(this.btnTrack);
            this.pnlTrack.Controls.Add(this.txtTrackingNo);
            this.pnlTrack.Controls.Add(this.lblTrackSub);
            this.pnlTrack.Controls.Add(this.lblTrackTitle);
            this.pnlTrack.Location = new System.Drawing.Point(30, 246);
            this.pnlTrack.Name = "pnlTrack";
            this.pnlTrack.Size = new System.Drawing.Size(910, 90);
            //
            // lblTrackTitle
            //
            this.lblTrackTitle.AutoSize = true;
            this.lblTrackTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTrackTitle.ForeColor = System.Drawing.Color.White;
            this.lblTrackTitle.Location = new System.Drawing.Point(20, 18);
            this.lblTrackTitle.Name = "lblTrackTitle";
            this.lblTrackTitle.Text = "Where is my document?";
            //
            // lblTrackSub
            //
            this.lblTrackSub.AutoSize = true;
            this.lblTrackSub.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblTrackSub.ForeColor = System.Drawing.Color.White;
            this.lblTrackSub.Location = new System.Drawing.Point(22, 50);
            this.lblTrackSub.Name = "lblTrackSub";
            this.lblTrackSub.Text = "Enter your tracking number for the latest update.";
            //
            // txtTrackingNo
            //
            this.txtTrackingNo.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.txtTrackingNo.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtTrackingNo.Location = new System.Drawing.Point(520, 26);
            this.txtTrackingNo.MaxLength = 20;
            this.txtTrackingNo.Name = "txtTrackingNo";
            this.txtTrackingNo.PlaceholderText = "OSDR-2026-00001";
            this.txtTrackingNo.Size = new System.Drawing.Size(270, 27);
            this.txtTrackingNo.TabIndex = 1;
            //
            // btnTrack
            //
            this.btnTrack.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.btnTrack.Location = new System.Drawing.Point(800, 24);
            this.btnTrack.Name = "btnTrack";
            this.btnTrack.Size = new System.Drawing.Size(90, 34);
            this.btnTrack.TabIndex = 2;
            this.btnTrack.Text = "Track";
            this.btnTrack.Click += new System.EventHandler(this.btnTrack_Click);
            //
            // lblMyRequests
            //
            this.lblMyRequests.AutoSize = true;
            this.lblMyRequests.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblMyRequests.ForeColor = System.Drawing.Color.FromArgb(20, 40, 75);
            this.lblMyRequests.Location = new System.Drawing.Point(30, 352);
            this.lblMyRequests.Name = "lblMyRequests";
            this.lblMyRequests.Text = "My requests";
            //
            // lnkViewAll
            //
            this.lnkViewAll.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.lnkViewAll.AutoSize = true;
            this.lnkViewAll.Location = new System.Drawing.Point(830, 358);
            this.lnkViewAll.Name = "lnkViewAll";
            this.lnkViewAll.TabStop = true;
            this.lnkViewAll.Text = "View all requests →";
            this.lnkViewAll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkViewAll_LinkClicked);
            //
            // dgvMyRequests
            //
            this.dgvMyRequests.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.dgvMyRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMyRequests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colTracking, this.colDocument, this.colDate, this.colStatus, this.colAmount });
            this.dgvMyRequests.Location = new System.Drawing.Point(30, 390);
            this.dgvMyRequests.Name = "dgvMyRequests";
            this.dgvMyRequests.Size = new System.Drawing.Size(910, 150);
            this.dgvMyRequests.TabIndex = 3;
            this.dgvMyRequests.SelectionChanged += new System.EventHandler(this.dgvMyRequests_SelectionChanged);
            //
            // colTracking
            //
            this.colTracking.HeaderText = "TRACKING NUMBER";
            this.colTracking.Name = "colTracking";
            //
            // colDocument
            //
            this.colDocument.HeaderText = "DOCUMENT";
            this.colDocument.Name = "colDocument";
            //
            // colDate
            //
            this.colDate.HeaderText = "DATE REQUESTED";
            this.colDate.Name = "colDate";
            //
            // colStatus
            //
            this.colStatus.HeaderText = "STATUS";
            this.colStatus.Name = "colStatus";
            //
            // colAmount
            //
            this.colAmount.HeaderText = "AMOUNT";
            this.colAmount.Name = "colAmount";
            //
            // pnlProgress
            //
            this.pnlProgress.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.pnlProgress.BackColor = System.Drawing.Color.White;
            this.pnlProgress.Controls.Add(this.stepper);
            this.pnlProgress.Controls.Add(this.lblProgDetail);
            this.pnlProgress.Controls.Add(this.lblProgRush);
            this.pnlProgress.Controls.Add(this.lblProgTracking);
            this.pnlProgress.Location = new System.Drawing.Point(30, 556);
            this.pnlProgress.Name = "pnlProgress";
            this.pnlProgress.Size = new System.Drawing.Size(910, 120);
            //
            // lblProgTracking
            //
            this.lblProgTracking.AutoSize = true;
            this.lblProgTracking.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblProgTracking.ForeColor = System.Drawing.Color.FromArgb(20, 40, 75);
            this.lblProgTracking.Location = new System.Drawing.Point(18, 12);
            this.lblProgTracking.Name = "lblProgTracking";
            this.lblProgTracking.Text = "";
            //
            // lblProgRush
            //
            this.lblProgRush.AutoSize = true;
            this.lblProgRush.BackColor = System.Drawing.Color.FromArgb(255, 244, 199);
            this.lblProgRush.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblProgRush.ForeColor = System.Drawing.Color.FromArgb(20, 40, 75);
            this.lblProgRush.Location = new System.Drawing.Point(190, 14);
            this.lblProgRush.Name = "lblProgRush";
            this.lblProgRush.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.lblProgRush.Text = "RUSH";
            this.lblProgRush.Visible = false;
            //
            // lblProgDetail
            //
            this.lblProgDetail.AutoSize = true;
            this.lblProgDetail.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblProgDetail.ForeColor = System.Drawing.Color.FromArgb(107, 122, 153);
            this.lblProgDetail.Location = new System.Drawing.Point(20, 38);
            this.lblProgDetail.Name = "lblProgDetail";
            this.lblProgDetail.Text = "";
            //
            // stepper
            //
            this.stepper.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.stepper.Location = new System.Drawing.Point(10, 56);
            this.stepper.Name = "stepper";
            this.stepper.Size = new System.Drawing.Size(890, 60);
            //
            // StudentDashboardControl
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(242, 245, 250);
            this.Controls.Add(this.pnlProgress);
            this.Controls.Add(this.dgvMyRequests);
            this.Controls.Add(this.lnkViewAll);
            this.Controls.Add(this.lblMyRequests);
            this.Controls.Add(this.pnlTrack);
            this.Controls.Add(this.pnlCardDone);
            this.Controls.Add(this.pnlCardReady);
            this.Controls.Add(this.pnlCardActive);
            this.Controls.Add(this.btnNewRequest);
            this.Controls.Add(this.lblSub);
            this.Controls.Add(this.lblGreeting);
            this.Controls.Add(this.lblPortalTag);
            this.Name = "StudentDashboardControl";
            this.Size = new System.Drawing.Size(970, 692);
            this.Load += new System.EventHandler(this.StudentDashboardControl_Load);
            this.pnlCardActive.ResumeLayout(false);
            this.pnlCardActive.PerformLayout();
            this.pnlCardReady.ResumeLayout(false);
            this.pnlCardReady.PerformLayout();
            this.pnlCardDone.ResumeLayout(false);
            this.pnlCardDone.PerformLayout();
            this.pnlTrack.ResumeLayout(false);
            this.pnlTrack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyRequests)).EndInit();
            this.pnlProgress.ResumeLayout(false);
            this.pnlProgress.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblPortalTag;
        private System.Windows.Forms.Label lblGreeting;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.Button btnNewRequest;
        private System.Windows.Forms.Panel pnlCardActive;
        private System.Windows.Forms.Panel pnlStripActive;
        private System.Windows.Forms.Label lblActiveTitle;
        private System.Windows.Forms.Label lblActiveCount;
        private System.Windows.Forms.Label lblActiveSub;
        private System.Windows.Forms.Panel pnlCardReady;
        private System.Windows.Forms.Panel pnlStripReady;
        private System.Windows.Forms.Label lblReadyTitle;
        private System.Windows.Forms.Label lblReadyCount;
        private System.Windows.Forms.Label lblReadySub;
        private System.Windows.Forms.Panel pnlCardDone;
        private System.Windows.Forms.Panel pnlStripDone;
        private System.Windows.Forms.Label lblDoneTitle;
        private System.Windows.Forms.Label lblCompletedCount;
        private System.Windows.Forms.Label lblDoneSub;
        private System.Windows.Forms.Panel pnlTrack;
        private System.Windows.Forms.Label lblTrackTitle;
        private System.Windows.Forms.Label lblTrackSub;
        private System.Windows.Forms.TextBox txtTrackingNo;
        private System.Windows.Forms.Button btnTrack;
        private System.Windows.Forms.Label lblMyRequests;
        private System.Windows.Forms.LinkLabel lnkViewAll;
        private System.Windows.Forms.DataGridView dgvMyRequests;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTracking;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDocument;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.Panel pnlProgress;
        private System.Windows.Forms.Label lblProgTracking;
        private System.Windows.Forms.Label lblProgRush;
        private System.Windows.Forms.Label lblProgDetail;
        private STIERegistrar.Forms.StatusStepper stepper;
    }
}
