using STIERegistrar.Forms;
using STIERegistrar.Helpers;

namespace STIERegistrar
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Connect to MongoDB, make indexes, add starter data.
            try
            {
                MongoDbContext.Instance.InitializeAsync().GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Cannot connect to MongoDB.\nMake sure MongoDB is running.\n\n" + ex.Message,
                    "STI E-Registrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Login -> student dashboard -> (sign out) -> login again.
            while (true)
            {
                Session.Logout();

                using (var login = new LoginForm())
                {
                    if (login.ShowDialog() != DialogResult.OK) break;  // window closed = exit
                }

                Application.Run(new StudentMainForm());
                // When the window closes without "Sign out", exit the app.
                if (Session.IsLoggedIn) break;
            }
        }
    }
}
