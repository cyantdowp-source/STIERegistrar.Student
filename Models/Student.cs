using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace STIERegistrar.Models
{
    public class Student
    {
        [BsonId]
        public ObjectId Id { get; set; }

        public string StudentNumber { get; set; }
        public string FullName { get; set; }
        public string Program { get; set; }
        public int YearLevel { get; set; }
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        /// <summary>Shown in combo boxes.</summary>
        public override string ToString()
        {
            return StudentNumber + " - " + FullName;
        }
    }
}
