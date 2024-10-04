using dplab_3;
using System;
using System.Security.Cryptography;
using System.Text;

public class AesEncryptionStrategy : IEncryptionStrategy
{
    private readonly byte[] key;
    private readonly byte[] iv;

    public AesEncryptionStrategy()
    {
        using (Aes aes = Aes.Create())
        {
            key = aes.Key;
            iv = aes.IV;
        }
    }

    public string Encrypt(string plaintext)
    {
        using (Aes aes = Aes.Create())
        {
            aes.Key = key;
            aes.IV = iv;
            ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
            byte[] buffer = Encoding.UTF8.GetBytes(plaintext);
            byte[] encrypted = encryptor.TransformFinalBlock(buffer, 0, buffer.Length);
            return Convert.ToBase64String(encrypted);
        }
    }

    public string Decrypt(string ciphertext)
    {
        using (Aes aes = Aes.Create())
        {
            aes.Key = key;
            aes.IV = iv;
            ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
            byte[] buffer = Convert.FromBase64String(ciphertext);
            byte[] decrypted = decryptor.TransformFinalBlock(buffer, 0, buffer.Length);
            return Encoding.UTF8.GetString(decrypted);
        }
    }
}
