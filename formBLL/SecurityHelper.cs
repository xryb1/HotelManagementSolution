// formBLL/SecurityHelper.cs
using System;
using System.Security.Cryptography;
using System.Text;

namespace formBLL
{
    public static class SecurityHelper
    {
        private const int SaltSize = 16; // 16 bytes is standard for salt

        /// <summary>
        /// Creates a unique salt and hashes the password using SHA256.
        /// The format is: [SALT]@[HASH]
        /// </summary>
        public static string HashPassword(string password)
        {
            // 1. Generate a Salt
            byte[] saltBytes = new byte[SaltSize];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(saltBytes);
            }
            string salt = Convert.ToBase64String(saltBytes);

            // 2. Combine password and salt and hash
            string saltedPassword = password + salt;
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(saltedPassword));
                string hash = Convert.ToBase64String(bytes);

                // Store both the salt and the hash, separated by '@'
                return $"{salt}@{hash}";
            }
        }

        /// <summary>
        /// Verifies the input password against the stored salted hash.
        /// </summary>
        public static bool VerifyPassword(string inputPassword, string storedSaltedHash)
        {
            // 1. Separate the stored salt and hash
            string[] parts = storedSaltedHash.Split('@');
            if (parts.Length != 2) return false; // Invalid format

            string storedSalt = parts[0];
            string storedHash = parts[1];

            // 2. Hash the input password using the stored salt
            string inputSaltedPassword = inputPassword + storedSalt;
            string inputHash;

            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(inputSaltedPassword));
                inputHash = Convert.ToBase64String(bytes);
            }

            // 3. Compare the newly generated hash with the stored hash
            return inputHash == storedHash;
        }
    }
}