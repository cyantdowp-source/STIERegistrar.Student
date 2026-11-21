namespace STIERegistrar.Helpers
{
    /// <summary>Hashes and checks passwords with BCrypt. Each hash has its own salt.</summary>
    public static class PasswordHelper
    {
        /// <summary>Turns a plain password into a hash. Save the hash, never the password.</summary>
        public static string Hash(string plainPassword)
        {
            return BCrypt.Net.BCrypt.HashPassword(plainPassword);
        }

        /// <summary>Checks if a typed password matches the saved hash.</summary>
        public static bool Verify(string plainPassword, string hash)
        {
            try
            {
                return BCrypt.Net.BCrypt.Verify(plainPassword, hash);
            }
            catch
            {
                // A bad hash format should just mean "not matching".
                return false;
            }
        }
    }
}
