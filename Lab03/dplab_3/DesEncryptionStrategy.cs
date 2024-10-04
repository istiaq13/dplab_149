using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Text;

namespace dplab_3
{

    public class DesEncryptionStrategy : IEncryptionStrategy
    {
        private readonly byte[] key;
        private readonly byte[] iv;

        public DesEncryptionStrategy()
        {
            using (DES des = DES.Create())
            {
                key = des.Key;
                iv = des.IV;
            }
        }

        public string Encrypt(string plaintext)
        {
            using (DES des = DES.Create())
            {
                des.Key = key;
                des.IV = iv;
                ICryptoTransform encryptor = des.CreateEncryptor(des.Key, des.IV);
                byte[] buffer = Encoding.UTF8.GetBytes(plaintext);
                byte[] encrypted = encryptor.TransformFinalBlock(buffer, 0, buffer.Length);
                return Convert.ToBase64String(encrypted);
            }
        }

        public string Decrypt(string ciphertext)
        {
            using (DES des = DES.Create())
            {
                des.Key = key;
                des.IV = iv;
                ICryptoTransform decryptor = des.CreateDecryptor(des.Key, des.IV);
                byte[] buffer = Convert.FromBase64String(ciphertext);
                byte[] decrypted = decryptor.TransformFinalBlock(buffer, 0, buffer.Length);
                return Encoding.UTF8.GetString(decrypted);
            }
        }
    }

}
