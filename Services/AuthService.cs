using MongoDB.Driver;
using STIERegistrar.Helpers;
using STIERegistrar.Models;

namespace STIERegistrar.Services
{
    public class AuthService
    {
        private readonly MongoDbContext _db = MongoDbContext.Instance;

        /// <summary>
        /// Checks the student login. Returns the User if correct, or null if not.
        /// Students use their student number or email.
        /// </summary>
        public async Task<User> LoginAsync(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrEmpty(password))
                return null;

            username = username.Trim();

            var filter = Builders<User>.Filter.And(
                Builders<User>.Filter.Eq(u => u.Role, "Student"),
                Builders<User>.Filter.Or(
                    Builders<User>.Filter.Eq(u => u.Email, username.ToLower()),
                    Builders<User>.Filter.Eq(u => u.StudentNumber, username)));

            User user = await _db.Users.Find(filter).FirstOrDefaultAsync();
            if (user == null || !user.IsActive) return null;

            // Compare the typed password with the saved hash.
            if (!PasswordHelper.Verify(password, user.PasswordHash)) return null;

            Session.Login(user);

            // Load the student record.
            if (user.StudentId.HasValue)
            {
                Session.CurrentStudent = await _db.Students
                    .Find(s => s.Id == user.StudentId.Value).FirstOrDefaultAsync();
            }

            return user;
        }
    }
}
