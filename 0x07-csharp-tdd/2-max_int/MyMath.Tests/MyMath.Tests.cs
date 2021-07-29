using NUnit.Framework;
using System.Collections.Generic;

namespace MyMath.Tests
{
    [TestFixture]
    /// <summary> Tests for max_int </summary>
    public class Tests
    {
        [Test]
        public void Testend()
        {
            List<int> testList = new List<int>();
            testList.Add(5);
            testList.Add(7);
            testList.Add(9);
    
            int results = Operations.Max(testList);

            Assert.AreEqual(9, results);
        }
        [Test]
        public void Testbeginning()
        {
            List<int> testList = new List<int>();
            testList.Add(9);
            testList.Add(7);
            testList.Add(5);

            int results = Operations.Max(testList);

            Assert.AreEqual(9, results);
        }
        [Test]
        public void Testmiddle()
        {
            List<int> testList = new List<int>();
            testList.Add(5);
            testList.Add(9);
            testList.Add(7);

            int results = Operations.Max(testList);

            Assert.AreEqual(9, results);
        }
        [Test]
        public void Testnegative()
        {
            List<int> testList = new List<int>();
            testList.Add(-5);
            testList.Add(-7);
            testList.Add(-9);

            int results = Operations.Max(testList);

            Assert.AreEqual(-5, results);
        }
        [Test]
        public void Testempty()
        {
            List<int> testList = new List<int>();
            
            int results = Operations.Max(testList);

            Assert.AreEqual(0, results);
        }
    }
}