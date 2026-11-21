using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace STIERegistrar.Models
{
    public class Request
    {
        [BsonId]
        public ObjectId Id { get; set; }

        public string TrackingNumber { get; set; }

        public ObjectId StudentId { get; set; }
        public string StudentName { get; set; }   // copied for fast lists

        public ObjectId DocumentId { get; set; }
        public string DocumentName { get; set; }  // copied for fast lists

        public int Copies { get; set; } = 1;
        public string Purpose { get; set; }
        public bool IsRush { get; set; }

        // Fees are copied, so later fee changes do not affect old requests.
        public decimal DocumentFee { get; set; }
        public decimal RushFee { get; set; }
        public decimal TotalAmount { get; set; }

        public string Status { get; set; } = RequestStatus.Pending;
        public string Delivery { get; set; } = "Pick-up at Registrar's Office";

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        /// <summary>TotalAmount = (DocumentFee x Copies) + RushFee (if rush).</summary>
        public static decimal ComputeTotal(decimal documentFee, int copies, bool isRush, decimal rushFee)
        {
            return (documentFee * copies) + (isRush ? rushFee : 0m);
        }
    }
}
