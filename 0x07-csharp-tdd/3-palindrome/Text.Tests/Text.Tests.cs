using NUnit.Framework;
using System.Collections.Generic;

namespace Text.Tests
{
    [TestFixture]
    /// <summary> Tests for palindrome </summary>
    public class Tests
    {
        [Test]
        public void TestEmpty()
        {
            string test = "";
            bool results = Str.IsPalindrome(test);
            Assert.AreEqual(true, results);
        }
    }
}