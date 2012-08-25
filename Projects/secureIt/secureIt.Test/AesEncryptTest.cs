using Microsoft.VisualStudio.TestTools.UnitTesting;
using secureIt.Lib;

namespace secureIt.Test
{
    [TestClass]
    public class AesEncryptTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            const string sourceText = "This is a test, indeed.";
            const string encryptionKey = "12345abcde....";

            AESEncryption enc = new AESEncryption(encryptionKey);

            Secret result = enc.Encrypt(sourceText);

            string decResult = enc.Decrypt(result);

            Assert.AreEqual(sourceText, decResult);
        }
    }
}
