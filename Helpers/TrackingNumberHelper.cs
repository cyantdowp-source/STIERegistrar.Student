namespace STIERegistrar.Helpers
{
    /// <summary>Tracking numbers look like OSDR-2026-01842.</summary>
    public static class TrackingNumberHelper
    {
        /// <summary>Checks the format before searching the database.</summary>
        public static bool IsValidFormat(string text)
        {
            return !string.IsNullOrWhiteSpace(text)
                && System.Text.RegularExpressions.Regex.IsMatch(text.Trim().ToUpper(), @"^OSDR-\d{4}-\d{5}$");
        }
    }
}
