using System;
using System.Text;

namespace secureIt.Lib
{
    public class AES
    {
        private AES()
        {
        }

        #region Public Methods

        public static PublicSecret Encrypt(string plainText, string key)
        {
            AESEncryption encryptor = new AESEncryption(key);
            Secret secret= encryptor.Encrypt(plainText);

            PublicSecret result = new PublicSecret();
            result.IV = Convert.ToBase64String(secret.IV);
            result.Data = Convert.ToBase64String(secret.Data);

            return result;
        }

        public static string Decrypt(PublicSecret secret, string key)
        {
            Secret internalSecret = new Secret() { 
                IV = Convert.FromBase64String(secret.IV),
                Data = Convert.FromBase64String(secret.Data) 
            };

            AESEncryption encryptor = new AESEncryption(key);
            return encryptor.Decrypt(internalSecret);
        }

        //public static string EncryptString(string plainText, string key)
        //{
        //    AES encryptor = new AES(key);

        //    string encryptedText = encryptor.EncryptString(plainText);

        //    if (encryptedText != null)
        //        encryptedText = Convert.ToBase64String(Encoding.ASCII.GetBytes(encryptedText));

        //    return encryptedText;
        //}

        //public static string DecryptString(string encryptedText, string key)
        //{
        //    AES encryptor = new AES(key);
        //    string plainText = encryptor.DecryptString(encryptedText);

        //    return plainText;
        //}

        #endregion
    }
}
