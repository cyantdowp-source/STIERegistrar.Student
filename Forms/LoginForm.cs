using STIERegistrar.Helpers;
using STIERegistrar.Services;

namespace STIERegistrar.Forms
{
    /// <summary>Login screen for students.</summary>
    public partial class LoginForm : Form
    {
        private readonly AuthService _auth = new AuthService();

        public LoginForm()
        {
            InitializeComponent();
            UiHelper.StyleButton(btnSignIn, true);
        }

        // ---------- Keep the sign-in box in the middle when the window is resized ----------
        private readonly Dictionary<Control, Point> _original = new Dictionary<Control, Point>();
        private Rectangle _box;   // bounding box of all the sign-in controls

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Remember where every control starts.
            foreach (Control c in pnlRight.Controls) _original[c] = c.Location;

            int left = pnlRight.Controls.Cast<Control>().Min(c => c.Left);
            int top = pnlRight.Controls.Cast<Control>().Min(c => c.Top);
            int right = pnlRight.Controls.Cast<Control>().Max(c => c.Right);
            int bottom = pnlRight.Controls.Cast<Control>().Max(c => c.Bottom);
            _box = new Rectangle(left, top, right - left, bottom - top);

            pnlRight.Resize += (s, ev) => CenterSignInBox();
            CenterSignInBox();
            txtUsername.Focus();
        }

        private void CenterSignInBox()
        {
            // Move everything by the same amount, so the box sits in the middle.
            int dx = (pnlRight.ClientSize.Width - _box.Width) / 2 - _box.Left;
            int dy = (pnlRight.ClientSize.Height - _box.Height) / 2 - _box.Top;
            dx = Math.Max(dx, 10 - _box.Left);   // never push it outside the panel
            dy = Math.Max(dy, 10 - _box.Top);

            foreach (var pair in _original)
                pair.Key.Location = new Point(pair.Value.X + dx, pair.Value.Y + dy);
        }

        // ---------- Show / hide password ----------
        private void lnkShowPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;
            lnkShowPassword.Text = txtPassword.UseSystemPasswordChar ? "Show" : "Hide";
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnSignIn_Click(sender, EventArgs.Empty);
            }
        }

        // ---------- Sign in ----------
        private async void btnSignIn_Click(object sender, EventArgs e)
        {
            lblError.Text = "";

            // Validation
            string error = Validator.FirstError(
                Validator.Required(txtUsername.Text, "Email or student number"),
                Validator.Required(txtPassword.Text, "Password"));
            if (error != null)
            {
                lblError.Text = error;
                return;
            }

            btnSignIn.Enabled = false;   // stop double clicks
            try
            {
                var user = await _auth.LoginAsync(txtUsername.Text, txtPassword.Text);
                if (user == null)
                {
                    // Same message for wrong user or wrong password (safer).
                    lblError.Text = "Wrong student number or password.";
                    txtPassword.Clear();
                    return;
                }

                DialogResult = DialogResult.OK;   // Program.cs opens the dashboard
                Close();
            }
            catch (Exception ex)
            {
                lblError.Text = "Cannot sign in. Check the database connection.";
                System.Diagnostics.Debug.WriteLine(ex);
            }
            finally
            {
                btnSignIn.Enabled = true;
            }
        }
    }
}
