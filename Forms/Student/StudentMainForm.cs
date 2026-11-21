using STIERegistrar.Helpers;

namespace STIERegistrar.Forms
{
    /// <summary>
    /// Student window. The sidebar stays. Each page is a UserControl
    /// that we load into pnlContent.
    /// </summary>
    public partial class StudentMainForm : Form
    {
        public StudentMainForm()
        {
            InitializeComponent();
            StyleSidebar();
        }

        private void StudentMainForm_Load(object sender, EventArgs e)
        {
            lblUserName.Text = Session.UserName;
            lblUserRole.Text = "Student account";
            ShowDashboard();
        }

        // ---------- Page loading ----------
        private void LoadPage(UserControl page, Button activeButton)
        {
            pnlContent.Controls.Clear();
            page.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(page);
            HighlightButton(activeButton);
        }

        public void ShowDashboard()
        {
            LoadPage(new StudentDashboardControl(this), btnDashboard);
        }

        // These pages are still being built.
        public void ShowNewRequest()
        {
            UiHelper.ShowInfo("The New request page is coming soon.");
        }

        public void ShowTrack(string trackingNumber = null)
        {
            UiHelper.ShowInfo("The Track a request page is coming soon.");
        }

        // ---------- Sidebar ----------
        private void StyleSidebar()
        {
            foreach (Button b in new[] { btnDashboard, btnNewRequest, btnTrack, btnSignOut })
            {
                b.FlatStyle = FlatStyle.Flat;
                b.FlatAppearance.BorderSize = 0;
                b.Cursor = Cursors.Hand;
                b.TextAlign = ContentAlignment.MiddleLeft;
                b.Padding = new Padding(14, 0, 0, 0);
                b.Font = new Font("Segoe UI", 10f);
                b.ForeColor = Color.White;
                b.BackColor = UiHelper.Navy;
            }
        }

        private void HighlightButton(Button active)
        {
            foreach (Button b in new[] { btnDashboard, btnNewRequest, btnTrack })
            {
                bool on = b == active;
                b.BackColor = on ? UiHelper.Yellow : UiHelper.Navy;
                b.ForeColor = on ? UiHelper.TextDark : Color.White;
                b.Font = new Font("Segoe UI", 10f, on ? FontStyle.Bold : FontStyle.Regular);
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e) { ShowDashboard(); }
        private void btnNewRequest_Click(object sender, EventArgs e) { ShowNewRequest(); }
        private void btnTrack_Click(object sender, EventArgs e) { ShowTrack(); }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            if (!UiHelper.Confirm("Sign out now?")) return;
            Session.Logout();   // Program.cs shows the login again
            Close();
        }
    }
}
