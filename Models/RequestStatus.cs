namespace STIERegistrar.Models
{
    /// <summary>
    /// All status names in one place, so nobody mistypes them.
    /// Flow: Pending -> Approved -> Processing -> Ready for Pick-up -> Released (or Rejected)
    /// </summary>
    public static class RequestStatus
    {
        public const string Pending = "Pending";
        public const string Approved = "Approved";
        public const string Processing = "Processing";
        public const string ReadyForPickup = "Ready for Pick-up";
        public const string Released = "Released";
        public const string Rejected = "Rejected";

        /// <summary>The normal path, in order.</summary>
        public static readonly string[] Flow =
        {
            Pending, Approved, Processing, ReadyForPickup, Released
        };

        /// <summary>All statuses, used for filter drop-downs.</summary>
        public static readonly string[] All =
        {
            Pending, Approved, Processing, ReadyForPickup, Released, Rejected
        };

        /// <summary>Returns the next status in the flow, or null if there is none.</summary>
        public static string GetNext(string current)
        {
            int index = Array.IndexOf(Flow, current);
            if (index < 0 || index >= Flow.Length - 1) return null;
            return Flow[index + 1];
        }
    }
}
