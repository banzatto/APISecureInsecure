using System.Collections.Concurrent;

namespace SecureAPI.Services
{
    // Simple in-memory user store for demo purposes
    public record UserRecord(string Username, string Password, string Role);

    public class MockUserStore
    {
        private readonly ConcurrentDictionary<string, UserRecord> _users = new();

        public MockUserStore()
        {
            // Weak demo passwords. DO NOT use in production.
            _users["admin"] = new UserRecord("admin", "admin123", "Admin");
            _users["alice"] = new UserRecord("alice", "password", "User");
        }

        public UserRecord? Validate(string username, string password)
        {
            if (_users.TryGetValue(username, out var u) && u.Password == password)
                return u;
            return null;
        }
    }
}
