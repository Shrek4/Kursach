using NUnit.Framework;
using WpfShrek.some_support;

namespace WpfShrek_Testing
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void RightEncrypt()
        {
            if (Cryptograph.Encrypt("��������������������������������", "���") == "��������������������������������")
                Assert.Pass();
        }

        [Test]
        public void RightDecrypt()
        {
            if(Cryptograph.Decrypt("��������������������������������", "���")== "��������������������������������")
            Assert.Pass();
        }
    }
}