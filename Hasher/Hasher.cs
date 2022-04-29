using System;
using System.Security.Cryptography;


namespace Hash
{
    public class Hasher
    {

        public static string Md5(string input)
        {
            var sb = new System.Text.StringBuilder();
            using (MD5 hasher = new MD5CryptoServiceProvider())
            {
                byte[] bytes = System.Text.Encoding.UTF8.GetBytes(input);
                byte[] hash = hasher.ComputeHash(bytes);

                foreach (var b in hash)
                {
                    sb.Append(b.ToString("X2"));
                }
            }
            
            return sb.ToString();
        }

        public static string Sha1(string input)
        {
            var sb = new System.Text.StringBuilder();
            
            using (SHA1 hasher = SHA1.Create())
            {
                byte[] bytes = System.Text.Encoding.UTF8.GetBytes(input);
                byte[] hash = hasher.ComputeHash(bytes);

                foreach (var b in hash)
                {
                    sb.Append(b.ToString("X2"));
                }
            }

            return sb.ToString();
        }

        public static string Sha2(string input)
        {
            var sb = new System.Text.StringBuilder();

            using (SHA256 hasher = SHA256.Create())
            {
                byte[] bytes = System.Text.Encoding.UTF8.GetBytes(input);
                byte[] hash = hasher.ComputeHash(bytes);

                foreach (var b in hash)
                {
                    sb.Append(b.ToString("X2"));
                }
            }

            return sb.ToString();
        }



    }
}
