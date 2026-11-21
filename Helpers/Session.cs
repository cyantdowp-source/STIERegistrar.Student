using MongoDB.Bson;
using STIERegistrar.Models;

namespace STIERegistrar.Helpers
{
    /// <summary>Remembers who is logged in. Static, so every form can read it.</summary>
    public static class Session
    {
        public static User CurrentUser { get; private set; }

        /// <summary>The Students record of the logged-in student (null for staff).</summary>
        public static Student CurrentStudent { get; set; }

        public static bool IsLoggedIn { get { return CurrentUser != null; } }
        public static string Role { get { return CurrentUser?.Role; } }
        public static string UserName { get { return CurrentUser?.FullName; } }
        public static ObjectId UserId { get { return CurrentUser?.Id ?? ObjectId.Empty; } }

        public static bool IsStudent { get { return Role == "Student"; } }

        public static void Login(User user)
        {
            CurrentUser = user;
            CurrentStudent = null;
        }

        public static void Logout()
        {
            CurrentUser = null;
            CurrentStudent = null;
        }
    }
}
