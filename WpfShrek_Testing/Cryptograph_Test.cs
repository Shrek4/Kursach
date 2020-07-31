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
            if (Cryptograph.Encrypt("אבגדהו¸זחטיךכלםמןנסעףפץצקרשתûü‎‏ÿ", "ךוך") == "ך¸לםטןנכעףמץצסרשפûüק‏ÿתבג‎הואזחדי")
                Assert.Pass();
        }

        [Test]
        public void RightDecrypt()
        {
            if(Cryptograph.Decrypt("אבגדהו¸זחטיךכלםמןנסעףפץצקרשתûü‎‏ÿ", "ךוך")== "ץüקרÿתûג‎‏ואבחדהך¸זםטינכלףמןצסעשפ")
            Assert.Pass();
        }
    }
}