using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace STIERegistrar.Models
{
    /// <summary>A person who can log in. Role is Student, Registrar, or Admin.</summary>
    public class User
    {
        [BsonId]
        public ObjectId Id { get; set; }

        public string FullName { get; set; }

        /// <summary>Staff log in with email. Students may also have one.</summary>
        public string Email { get; set; }

        /// <summary>Students log in with their student number.</summary>
        public string StudentNumber { get; set; }

        /// <summary>BCrypt hash. The plain password is never stored.</summary>
        public string PasswordHash { get; set; }

        public string Role { get; set; }

        /// <summary>Link to the Students collection (only for Student users).</summary>
        public ObjectId? StudentId { get; set; }

        public bool IsActive { get; set; } = true;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
