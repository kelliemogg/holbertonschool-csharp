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
        [Test]
        public void TestSpaces()
        {
            string test = "taco cat";
            bool results = Str.IsPalindrome(test);
            Assert.AreEqual(true, results);
        }
        [Test]
        public void TestPun()
        {
            string test = "what!tahw";
            bool results = Str.IsPalindrome(test);
            Assert.AreEqual(true, results);
        }
        [Test]
        public void TestUpper()
        {
            string test = "Howoh";
            bool results = Str.IsPalindrome(test);
            Assert.AreEqual(true, results);
        }
    }
}