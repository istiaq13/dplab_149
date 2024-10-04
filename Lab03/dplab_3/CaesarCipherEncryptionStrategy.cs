using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dplab_3
{
    public class CaesarCipherEncryptionStrategy : IEncryptionStrategy
    {
        private readonly int shift;

        public CaesarCipherEncryptionStrategy(int shift)
        {
            this.shift = shift;
        }

        public string Encrypt(string plaintext)
        {
            return new string(plaintext.Select(c => (char)(c + shift)).ToArray());
        }

        public string Decrypt(string ciphertext)
        {
            return new string(ciphertext.Select(c => (char)(c - shift)).ToArray());
        }
    }

}
