using Microsoft.VisualStudio.TestTools.UnitTesting;
using secureIt.Lib;

namespace secureIt.Test
{
    [TestClass]
    public class AESTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            const string sourceText = "This is a test, indeed.";
            const string encryptionKey = "12345abcde....";

            PublicSecret encResult = AES.Encrypt(sourceText, encryptionKey);
            string originalText = AES.Decrypt(encResult, encryptionKey);

            Assert.AreEqual(sourceText, originalText);
        }
    }
}
