using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApp3
{
    internal class Cpher
    {
        private static readonly byte[] Key = Encoding.UTF8.GetBytes("12345678901234567890123456789012"); // 256-bit key
        private static readonly byte[] IV = Encoding.UTF8.GetBytes("1234567890123456"); // 128-bit IV

        public static string Encrypt(string plaintext)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = Key;
                aes.IV = IV;

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                byte[] encryptedData;

                using (var ms = new System.IO.MemoryStream())
                {
                    using (var cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    {
                        byte[] plaintextBytes = Encoding.UTF8.GetBytes(plaintext);
                        cs.Write(plaintextBytes, 0, plaintextBytes.Length);
                    }

                    encryptedData = ms.ToArray();
                }

                string encryptedText = Convert.ToBase64String(encryptedData);
                return encryptedText;
            }
        }

        public static string Decrypt(string encryptedText)
        {
            byte[] encryptedData = Convert.FromBase64String(encryptedText);

            using (Aes aes = Aes.Create())
            {
                aes.Key = Key;
                aes.IV = IV;

                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                byte[] decryptedData;

                using (var ms = new System.IO.MemoryStream(encryptedData))
                {
                    using (var cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                    {
                        using (var reader = new System.IO.StreamReader(cs))
                        {
                            decryptedData = Encoding.UTF8.GetBytes(reader.ReadToEnd());
                        }
                    }
                }

                string decryptedText = Encoding.UTF8.GetString(decryptedData);
                return decryptedText;
            }
        }
    }
}
