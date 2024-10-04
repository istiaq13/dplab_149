using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dplab_3
{
    public interface IEncryptionStrategy
    {
        string Encrypt(string plaintext);
        string Decrypt(string ciphertext);
    }

}