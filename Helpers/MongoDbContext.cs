using System.Text.Json;
using MongoDB.Bson;
using MongoDB.Driver;
using STIERegistrar.Models;

namespace STIERegistrar.Helpers
{
    /// <summary>
    /// Connects to MongoDB and gives the services their collections.
    /// Forms never use this class. Only Services do.
    /// </summary>
    public class MongoDbContext
    {
        private readonly IMongoDatabase _database;

        public IMongoCollection<User> Users { get; }
        public IMongoCollection<Student> Students { get; }
        public IMongoCollection<Request> Requests { get; }

        // One shared instance for the whole app.
        private static MongoDbContext _instance;
        public static MongoDbContext Instance
        {
            get
            {
                if (_instance == null) _instance = new MongoDbContext();
                return _instance;
            }
        }

        private MongoDbContext()
        {
            // Defaults, used if appsettings.json is missing.
            string connection = "mongodb://localhost:27017";
            string dbName = "STIERegistrar_DB";

            try
            {
                string path = Path.Combine(AppContext.BaseDirectory, "appsettings.json");
                if (File.Exists(path))
                {
                    using JsonDocument json = JsonDocument.Parse(File.ReadAllText(path));
                    if (json.RootElement.TryGetProperty("MongoConnection", out var c))
                        connection = c.GetString();
                    if (json.RootElement.TryGetProperty("DatabaseName", out var d))
                        dbName = d.GetString();
                }
            }
            catch
            {
                // If the file is broken, we keep the defaults.
            }

            var client = new MongoClient(connection);
            _database = client.GetDatabase(dbName);

            Users = _database.GetCollection<User>("Users");
            Students = _database.GetCollection<Student>("Students");
            Requests = _database.GetCollection<Request>("Requests");
        }

        /// <summary>Run once at startup. Makes indexes and adds starter data.</summary>
        public async Task InitializeAsync()
        {
            // Unique student number / email, only for users that have one.
            await Users.Indexes.CreateOneAsync(new CreateIndexModel<User>(
                Builders<User>.IndexKeys.Ascending(u => u.Email),
                new CreateIndexOptions<User>
                {
                    Unique = true,
                    PartialFilterExpression = Builders<User>.Filter.Type(u => u.Email, BsonType.String)
                }));

            await Users.Indexes.CreateOneAsync(new CreateIndexModel<User>(
                Builders<User>.IndexKeys.Ascending(u => u.StudentNumber),
                new CreateIndexOptions<User>
                {
                    Unique = true,
                    PartialFilterExpression = Builders<User>.Filter.Type(u => u.StudentNumber, BsonType.String)
                }));

            await Students.Indexes.CreateOneAsync(new CreateIndexModel<Student>(
                Builders<Student>.IndexKeys.Ascending(s => s.StudentNumber),
                new CreateIndexOptions { Unique = true }));

            await Requests.Indexes.CreateOneAsync(new CreateIndexModel<Request>(
                Builders<Request>.IndexKeys.Ascending(r => r.TrackingNumber),
                new CreateIndexOptions { Unique = true }));

            await SeedAsync();
        }

        /// <summary>Adds a sample student and a few sample requests when the database is empty.</summary>
        private async Task SeedAsync()
        {
            if (await Users.CountDocumentsAsync(FilterDefinition<User>.Empty) > 0) return;

            var student = new Student
            {
                StudentNumber = "2024-01842",
                FullName = "Alyssa Reyes",
                Program = "BSIT",
                YearLevel = 3,
                Email = "alyssa@campus.edu"
            };
            await Students.InsertOneAsync(student);

            await Users.InsertOneAsync(new User
            {
                FullName = "Alyssa Reyes",
                Email = "alyssa@campus.edu",
                StudentNumber = "2024-01842",
                StudentId = student.Id,
                Role = "Student",
                PasswordHash = PasswordHelper.Hash("student123")
            });

            // Sample requests, so the dashboard has something to show.
            await Requests.InsertManyAsync(new[]
            {
                NewSample(student, "OSDR-2026-00001", "Transcript of Records", 250, 1, false, RequestStatus.Processing, 2),
                NewSample(student, "OSDR-2026-00002", "Certificate of Enrollment", 100, 1, true, RequestStatus.ReadyForPickup, 5),
                NewSample(student, "OSDR-2026-00003", "Good Moral Certificate", 100, 2, false, RequestStatus.Released, 20)
            });
        }

        private Request NewSample(Student s, string tracking, string document, decimal fee,
                                  int copies, bool rush, string status, int daysAgo)
        {
            decimal rushFee = rush ? 150m : 0m;
            return new Request
            {
                TrackingNumber = tracking,
                StudentId = s.Id,
                StudentName = s.FullName,
                DocumentId = ObjectId.GenerateNewId(),
                DocumentName = document,
                Copies = copies,
                Purpose = "Sample data",
                IsRush = rush,
                DocumentFee = fee,
                RushFee = rushFee,
                TotalAmount = Request.ComputeTotal(fee, copies, rush, rushFee),
                Status = status,
                CreatedAt = DateTime.UtcNow.AddDays(-daysAgo),
                UpdatedAt = DateTime.UtcNow.AddDays(-daysAgo)
            };
        }
    }
}
