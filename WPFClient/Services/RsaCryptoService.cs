using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WPFClient.Services
{
    internal class RsaCryptoService
    {
        public string EncryptRsa(string textToEncrypt)
        {
            var bytesConverter = new UnicodeEncoding();
            var bytesToEncrypt = bytesConverter.GetBytes(textToEncrypt);

            RSACryptoServiceProvider cryptoServiceProvider = new();

            var encryptBytes = cryptoServiceProvider.Encrypt(bytesToEncrypt, true);

            return Convert.ToBase64String(encryptBytes);
        }
        public string DecryptRsa(string textToEncrypt)
        {
            var bytesToDecrypt = Encoding.UTF8.GetBytes(textToEncrypt);

            RSACryptoServiceProvider cryptoServiceProvider = new(2048);

            var decryptBytes = cryptoServiceProvider.Decrypt(bytesToDecrypt, true);

            return Convert.ToBase64String(decryptBytes);
        }
    }
}
