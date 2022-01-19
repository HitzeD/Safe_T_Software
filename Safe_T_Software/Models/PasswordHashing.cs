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
            // Generate Salt
            RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
            byte[] salt = new byte[SALT_SIZE];
            provider.GetBytes(salt);

            // Generate Hash
            Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(input, salt, ITERATIONS);
            return pbkdf2.GetBytes(HASH_SIZE);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="hashed">Previously hashed password that is saved on the DB</param>
        /// <param name="pass">Plain text of user password used for hashing to compare the values</param>
        /// <returns>Returns a boolean value after determining whether the hashes match</returns>
        public static bool MatchHash(byte[] hashed, string pass)
        {
            byte[] verify = CreateHash(pass);

            if (verify == hashed)
            {
                return true;
            } 
            else
            {
                return false;
            }
        }
    }
}
