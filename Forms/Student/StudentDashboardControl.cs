using STIERegistrar.Helpers;
using STIERegistrar.Models;
using STIERegistrar.Services;

namespace STIERegistrar.Forms
{
    /// <summary>Student home page: counts, quick tracking, and the latest requests.</summary>
    public partial class StudentDashboardControl : UserControl
    {
        private readonly StudentMainForm _main;
        private readonly RequestService _requests = new RequestService();
        private List<Request> _list = new List<Request>();

        public StudentDashboardControl(StudentMainForm main)
        {
            _main = main;
            InitializeComponent();
            ResponsiveHelper.Apply(this);   // page resizes with the window

            UiHelper.StyleButton(btnNewRequest, true);
            UiHelper.StyleButton(btnTrack, false);
            btnTrack.BackColor = UiHelper.Yellow;
            btnTrack.ForeColor = UiHelper.TextDark;
            UiHelper.StyleGrid(dgvMyRequests);
        }

        private async void StudentDashboardControl_Load(object sender, EventArgs e)
        {
            lblGreeting.Text = GetGreeting() + ", " + FirstName(Session.UserName);
            await LoadDataAsync();
        }

        private string GetGreeting()
        {
            int hour = DateTime.Now.Hour;
            if (hour < 12) return "Good morning";
            if (hour < 18) return "Good afternoon";
            return "Good evening";
        }

        private string FirstName(string fullName)
        {
            if (string.IsNullOrWhiteSpace(fullName)) return "";
            return fullName.Trim().Split(' ')[0];
        }

        // ---------- Load data ----------
        private async Task LoadDataAsync()
        {
            try
            {
                if (Session.CurrentStudent == null)
                {
                    UiHelper.ShowError("No student record is linked to this account. Ask the admin.");
                    return;
                }

                _list = await _requests.GetByStudentAsync(Session.CurrentStudent.Id);

                // Cards
                int ready = _list.Count(r => r.Status == RequestStatus.ReadyForPickup);
                int done = _list.Count(r => r.Status == RequestStatus.Released);
                int active = _list.Count(r => r.Status == RequestStatus.Pending
                                           || r.Status == RequestStatus.Approved
                                           || r.Status == RequestStatus.Processing);
                lblActiveCount.Text = active.ToString("D2");
                lblReadyCount.Text = ready.ToString("D2");
                lblCompletedCount.Text = done.ToString("D2");

                // Grid: show the 5 newest
                dgvMyRequests.Rows.Clear();
                foreach (Request r in _list.Take(5))
                {
                    int row = dgvMyRequests.Rows.Add(
                        r.TrackingNumber,
                        r.DocumentName,
                        r.CreatedAt.ToLocalTime().ToString("dd MMM yyyy"),
                        r.Status,
                        "₱" + r.TotalAmount.ToString("N2"));
                    dgvMyRequests.Rows[row].Tag = r;
                    ColorStatusCell(dgvMyRequests.Rows[row].Cells["colStatus"], r.Status);
                }

                // Progress panel: the first request that is still open, or the newest.
                Request focus = _list.FirstOrDefault(r => r.Status != RequestStatus.Released
                                                       && r.Status != RequestStatus.Rejected)
                                ?? _list.FirstOrDefault();
                ShowProgress(focus);

                if (dgvMyRequests.Rows.Count > 0) dgvMyRequests.ClearSelection();
            }
            catch (Exception ex)
            {
                UiHelper.ShowError("Could not load your requests.\n" + ex.Message);
            }
        }

        private void ColorStatusCell(DataGridViewCell cell, string status)
        {
            if (status == RequestStatus.ReadyForPickup)
                cell.Style.BackColor = UiHelper.YellowSoft;
            else if (status == RequestStatus.Rejected)
                cell.Style.ForeColor = Color.Firebrick;
        }

        private void ShowProgress(Request r)
        {
            if (r == null)
            {
                pnlProgress.Visible = false;
                return;
            }
            pnlProgress.Visible = true;
            lblProgTracking.Text = r.TrackingNumber;
            lblProgRush.Visible = r.IsRush;
            lblProgRush.Left = lblProgTracking.Right + 12;
            lblProgDetail.Text = r.DocumentName + (r.IsRush ? " · Estimated ready: " + EstimatedReady(r) : "");
            stepper.SetStatus(r.Status);
        }

        /// <summary>Rush = 2 business days, standard = 5. A simple estimate.</summary>
        public static string EstimatedReady(Request r)
        {
            int days = r.IsRush ? 2 : 5;
            DateTime date = r.CreatedAt.ToLocalTime();
            while (days > 0)
            {
                date = date.AddDays(1);
                if (date.DayOfWeek != DayOfWeek.Saturday && date.DayOfWeek != DayOfWeek.Sunday) days--;
            }
            return date.ToString("dd MMM yyyy");
        }

        // ---------- Events ----------
        private void dgvMyRequests_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMyRequests.SelectedRows.Count == 0) return;
            ShowProgress(dgvMyRequests.SelectedRows[0].Tag as Request);
        }

        private void btnNewRequest_Click(object sender, EventArgs e)
        {
            _main.ShowNewRequest();
        }

        private void btnTrack_Click(object sender, EventArgs e)
        {
            string error = Validator.Required(txtTrackingNo.Text, "Tracking number");
            if (error != null) { UiHelper.ShowError(error); return; }

            if (!TrackingNumberHelper.IsValidFormat(txtTrackingNo.Text))
            {
                UiHelper.ShowError("Tracking number looks like OSDR-2026-01842.");
                return;
            }
            _main.ShowTrack(txtTrackingNo.Text.Trim());
        }

        private void lnkViewAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _main.ShowTrack();
        }
    }
}
