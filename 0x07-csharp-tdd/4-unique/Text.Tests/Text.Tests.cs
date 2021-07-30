using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    ///<summary> Test </summary>
    public class Tests
    {
        [Test]
        public void testrandom()
        {
            string test = "zzzap";
            int result = Str.UniqueChar(test);
            Assert.AreEqual(3, result);
        }
        [Test]
        public void testfirst()
        {
            string test = "zaap";
            int result = Str.UniqueChar(test);
            Assert.AreEqual(0, result);
        }
        [Test]
        public void testlast()
        {
            string test = "zzaap";
            int result = Str.UniqueChar(test);
            Assert.AreEqual(4, result);
        }
        [Test]
        public void testnounique()
        {
            string test = "zzaapp";
            int result = Str.UniqueChar(test);
            Assert.AreEqual(-1, result);
        }
        [Test]
        public void testempty()
        {
            string test = "";
            int result = Str.UniqueChar(test);
            Assert.AreEqual(-1, result);
        }
    }
}
