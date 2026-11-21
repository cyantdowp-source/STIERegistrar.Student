using MongoDB.Bson;
using MongoDB.Driver;
using STIERegistrar.Helpers;
using STIERegistrar.Models;

namespace STIERegistrar.Services
{
    /// <summary>Request data for the student dashboard.</summary>
    public class RequestService
    {
        private readonly MongoDbContext _db = MongoDbContext.Instance;

        /// <summary>All requests of one student, newest first.</summary>
        public async Task<List<Request>> GetByStudentAsync(ObjectId studentId)
        {
            return await _db.Requests.Find(r => r.StudentId == studentId)
                .SortByDescending(r => r.CreatedAt).ToListAsync();
        }
    }
}
