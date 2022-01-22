using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;


namespace WinFormIOTProject
{
    class EncryptionClass
    {
        
        AesCryptoServiceProvider crypt_provider;

        public Byte symke;
        public EncryptionClass()
        {
            crypt_provider = new AesCryptoServiceProvider();

            crypt_provider.BlockSize = 128;
            crypt_provider.KeySize = 256;
            crypt_provider.GenerateIV();
            
            crypt_provider.Mode = CipherMode.CBC;
            crypt_provider.Padding = PaddingMode.PKCS7;
        }
       
        public string Encrypt(string clear_text)
        {
            ICryptoTransform transform = crypt_provider.CreateEncryptor();

            byte[] encrypted_bytes = transform.TransformFinalBlock(ASCIIEncoding.ASCII.GetBytes(clear_text), 0, clear_text.Length);

            string str = Convert.ToBase64String(encrypted_bytes);

            return str;

        }


        public string Decrypt(string cipher_text)
        {
            ICryptoTransform transform = crypt_provider.CreateDecryptor();

            byte[] enc_bytes = Convert.FromBase64String(cipher_text);

            byte[] decrypted_bytes = transform.TransformFinalBlock(enc_bytes, 0, enc_bytes.Length);

            string str = ASCIIEncoding.ASCII.GetString(decrypted_bytes);

            return str;


        }

    }
}
