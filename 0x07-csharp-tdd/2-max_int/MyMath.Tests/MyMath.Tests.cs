using NUnit.Framework;
using System.Collections.Generic;

namespace MyMath.Tests
{
    [TestFixture]
    /// <summary> Tests for max_int </summary>
    public class Tests
    {
        [Test]
        public void Max_end()
        {
            List<int> testList = new List<int>();
            testList.Add(5);
            testList.Add(7);
            testList.Add(9);
    
            int results = Operations.Max(testList);

            Assert.AreEqual(9, results);
        }
        [Test]
        public void Max_beginning()
        {
            List<int> testList = new List<int>();
            testList.Add(9);
            testList.Add(7);
            testList.Add(5);

            int results = Operations.Max(testList);

            Assert.AreEqual(9, results);
        }
        [Test]
        public void Max_middle()
        {
            List<int> testList = new List<int>();
            testList.Add(5);
            testList.Add(9);
            testList.Add(7);

            int results = Operations.Max(testList);

            Assert.AreEqual(9, results);
        }
        [Test]
        public void Max_negative()
        {
            List<int> newList = new List<int>();
            testList.Add(-5);
            testList.Add(-7);
            testList.Add(-9);

            int results = Operations.Max(testList);

            Assert.AreEqual(-5, results);
        }
        [Test]
        public void Max_empty()
        {
            List<int> newList = new List<int>();
            
            int results = Operations.Max(testList);

            Assert.AreEqual(0, results);
        }
    }
}