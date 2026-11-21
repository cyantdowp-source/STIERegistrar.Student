using System.Text.RegularExpressions;

namespace STIERegistrar.Helpers
{
    /// <summary>
    /// Simple input checks. Each method returns an error message,
    /// or null when the input is fine.
    /// </summary>
    public static class Validator
    {
        public static string Required(string value, string fieldName)
        {
            if (string.IsNullOrWhiteSpace(value))
                return fieldName + " is required.";
            return null;
        }

        public static string Email(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return "Email is required.";
            if (!Regex.IsMatch(value.Trim(), @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                return "Email format is not valid.";
            return null;
        }

        /// <summary>Student number looks like 2024-01842.</summary>
        public static string StudentNumber(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return "Student number is required.";
            if (!Regex.IsMatch(value.Trim(), @"^\d{4}-\d{5}$"))
                return "Student number must look like 2024-01842.";
            return null;
        }

        public static string Password(string value)
        {
            if (string.IsNullOrEmpty(value))
                return "Password is required.";
            if (value.Length < 6)
                return "Password must be at least 6 characters.";
            return null;
        }

        /// <summary>Returns the first error found, or null if all are fine.</summary>
        public static string FirstError(params string[] errors)
        {
            foreach (string e in errors)
            {
                if (e != null) return e;
            }
            return null;
        }
    }
}
