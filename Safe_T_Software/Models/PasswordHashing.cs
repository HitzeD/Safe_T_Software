using System;
using System.Security.Cryptography;

namespace Safe_T_Software.Models
{
    public class PasswordHashing
    {
        public const int SALT_SIZE = 24;
        public const int HASH_SIZE = 24;
        public const int ITERATIONS = 100000;

        /// <summary>
        ///     Creates a PBKDF2 protocol hash
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static byte[] CreateHash(string input)
        {
            byte[] salt = GenerateSalt();

            using (var pbkdf2 = new Rfc2898DeriveBytes(input, salt, ITERATIONS))
            {
                return pbkdf2.GetBytes(HASH_SIZE);
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="hashed">Previously hashed password that is saved on the DB</param>
        /// <param name="pass">Plain text of user password used for hashing to compare the values</param>
        /// <returns>Returns a boolean value after determining whether the hashes match</returns>
        public static bool MatchHash(byte[] hashed, string pass)
        {
            return Rfc2898DeriveBytes.Equals(hashed, CreateHash(pass));
        }

        /// <summary>
        ///     Generates a salt for use within the System.Security.Cryptography library
        /// </summary>
        /// <returns>byte[] type which holds the value of the salt</returns>
        private static byte[] GenerateSalt()
        {
            using (var rng = RandomNumberGenerator.Create())
            {
                byte[] salt = new byte[SALT_SIZE];
                rng.GetBytes(salt);
                return salt;
            }
        }
    }
}
