// formDAL/UserRepository.cs
using System.Data.SqlClient;

namespace formDAL
{
    public class UserRepository
    {
        // IMPORTANT: Replace this with your actual database connection string!
        // This string tells ADO.NET how to find your SQL Server database.
        private readonly string _connectionString = "Data Source=BLEEP\\SQLEXPRESS;Initial Catalog=testsys;Integrated Security=True;";

        /// <summary>
        /// Retrieves a user record from the database based on the username using pure ADO.NET.
        /// </summary>
        public User GetUserByUsername(string username)
        {
            // SQL command to fetch all relevant fields for authentication
            const string sql = "SELECT UserID, Username, PasswordHash, Role FROM Users WHERE Username = @Username";

            using (var connection = new SqlConnection(_connectionString))
            {
                using (var command = new SqlCommand(sql, connection))
                {
                    // 1. Add the parameter securely to prevent SQL injection
                    command.Parameters.AddWithValue("@Username", username);

                    try
                    {
                        connection.Open();
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // 2. Manually map the result set to the User object
                                return new User
                                {
                                    UserID = reader.GetInt32(reader.GetOrdinal("UserID")),
                                    Username = reader.GetString(reader.GetOrdinal("Username")),
                                    PasswordHash = reader.GetString(reader.GetOrdinal("PasswordHash")),
                                    Role = reader.GetString(reader.GetOrdinal("Role"))
                                };
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        // In a production app, log this error instead of showing a generic message
                        System.Diagnostics.Debug.WriteLine($"Database Error fetching user: {ex.Message}");
                        return null;
                    }
                }
            }
            return null; // User not found or error occurred
        }

        /// <summary>
        /// Admin-only method to create a new user using pure ADO.NET.
        /// </summary>
        public void CreateUser(User user)
        {
            const string sql = "INSERT INTO Users (Username, PasswordHash, Role) VALUES (@Username, @PasswordHash, @Role)";

            using (var connection = new SqlConnection(_connectionString))
            {
                using (var command = new SqlCommand(sql, connection))
                {
                    // Add parameters securely
                    command.Parameters.AddWithValue("@Username", user.Username);
                    command.Parameters.AddWithValue("@PasswordHash", user.PasswordHash);
                    command.Parameters.AddWithValue("@Role", user.Role);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery(); // Execute the insert command
                    }
                    catch (SqlException ex)
                    {
                        System.Diagnostics.Debug.WriteLine($"Database Error creating user: {ex.Message}");
                        // Handle error (e.g., username already exists)
                    }
                }
            }
        }
    }
}