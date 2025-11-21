// formDAL/User.cs

namespace formDAL
{
    public class User
    {
        public int UserID { get; set; }
        public string Username { get; set; }

        // This holds the Salt@Hash string
        public string PasswordHash { get; set; }

        public string Role { get; set; } // Stores "Admin" or "Employee"
    }
}