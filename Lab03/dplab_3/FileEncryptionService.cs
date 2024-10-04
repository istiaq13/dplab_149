using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace dplab_3
{
    public class FileEncryptionService
    {
        private readonly EncryptionContext _encryptionContext;

        public FileEncryptionService(EncryptionContext encryptionContext)
        {
            _encryptionContext = encryptionContext;
        }

        public void EncryptFile(string inputFilePath, string outputFilePath)
        {
            string content = File.ReadAllText(inputFilePath);
            string encryptedContent = _encryptionContext.Encrypt(content);
            File.WriteAllText(outputFilePath, encryptedContent);
        }

        public void DecryptFile(string inputFilePath, string outputFilePath)
        {
            string encryptedContent = File.ReadAllText(inputFilePath);
            string decryptedContent = _encryptionContext.Decrypt(encryptedContent);
            File.WriteAllText(outputFilePath, decryptedContent);
        }
    }

}