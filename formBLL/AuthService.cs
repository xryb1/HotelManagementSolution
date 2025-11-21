// formBLL/AuthService.cs
using formDAL; // Allows us to use the User and UserRepository classes

namespace formBLL
{
    public class AuthService
    {
        // AuthService owns an instance of UserRepository to talk to the DB
        private readonly UserRepository _userRepo = new UserRepository();

        /// <summary>
        /// Attempts to authenticate a user. 
        /// Returns a User object on success, or null on failure.
        /// </summary>
        public User Authenticate(string username, string password)
        {
            // 1. Fetch the user record (which contains the stored Salt and Hash) from the DAL.
            User user = _userRepo.GetUserByUsername(username);

            if (user == null)
            {
                return null; // Username doesn't exist
            }

            // 2. Security Check: Use the helper to safely verify the password
            // This is the core logic that checks the role-based access.
            bool isPasswordValid = SecurityHelper.VerifyPassword(password, user.PasswordHash);

            // Return the user object (containing the role) only if the password is valid
            return isPasswordValid ? user : null;
        }

        /// <summary>
        /// Checks the user's role property.
        /// </summary>
        public bool IsAdmin(User user)
        {
            // Case-insensitive check to see if the stored role is "Admin"
            return user != null && user.Role.Equals("Admin", System.StringComparison.OrdinalIgnoreCase);
        }

        // Helper method for admin to create NEW user passwords securely (used for setup)
        public static string GetHashedPasswordForCreation(string password)
        {
            return SecurityHelper.HashPassword(password);
        }
    }
}