using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace secureIt.Lib
{
    public class AESEncryption
    {
        #region Members

        private const string PasswordSalt = "lijun.he@lijunhe.com";
        private const int Strengh = 128;

        private byte[] _key;

        #endregion

        public AESEncryption(string key)
        {
            _key = CalculateKey(key);
        }

        #region Public Methods

        public Secret Encrypt(string plainText)
        {
            Secret result = new Secret();

            using (MemoryStream ms = new MemoryStream())
            {
                using (Aes aesAlg = new AesManaged())
                {
                    aesAlg.Key = _key;
                    result.IV = aesAlg.IV;

                    ICryptoTransform encryptor = aesAlg.CreateEncryptor();

                    using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    {
                        byte[] rawPlaintext = Encoding.Unicode.GetBytes(plainText);
                        cs.Write(rawPlaintext, 0, rawPlaintext.Length);
                        cs.FlushFinalBlock();

                        // get the encrypted text
                        ms.Seek(0, SeekOrigin.Begin);
                        byte[] content = new byte[ms.Length];
                        ms.Read(content, 0, content.Length);
                        result.Data = content;
                    }
                }
            }

            return result;
        }

        public string Decrypt(Secret secret)
        {
            string plainText = null;
            using (MemoryStream msDecrypt = new MemoryStream(secret.Data))
            {
                // Create an AesManaged object with the specified key and IV.
                using (Aes aesAlg = new AesManaged())
                {
                    aesAlg.Key = _key;
                    aesAlg.IV = secret.IV;

                    // Create a decrytor to perform the stream transform.
                    ICryptoTransform decryptor = aesAlg.CreateDecryptor();

                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt, Encoding.Unicode))
                        {
                            // Read the decrypted bytes from the decrypting stream
                            // and place them in a string.
                            plainText = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }

            return plainText;
        }

        #endregion

        #region Private Methods

        private byte[] CalculateKey(string key)
        {
            Rfc2898DeriveBytes deriveBytes = new Rfc2898DeriveBytes(key, Encoding.UTF8.GetBytes(PasswordSalt));
            return deriveBytes.GetBytes(Strengh / 8);
        }

        #endregion
    }
}
