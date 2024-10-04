using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dplab_3
{
    public class EncryptionContext
    {
        private IEncryptionStrategy _encryptionStrategy;

        public void SetEncryptionStrategy(IEncryptionStrategy strategy)
        {
            _encryptionStrategy = strategy;
        }

        public string Encrypt(string plaintext)
        {
            return _encryptionStrategy.Encrypt(plaintext);
        }

        public string Decrypt(string ciphertext)
        {
            return _encryptionStrategy.Decrypt(ciphertext);
        }
    }

}
