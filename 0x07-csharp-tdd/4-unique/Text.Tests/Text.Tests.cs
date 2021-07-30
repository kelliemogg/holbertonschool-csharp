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
    }
}
