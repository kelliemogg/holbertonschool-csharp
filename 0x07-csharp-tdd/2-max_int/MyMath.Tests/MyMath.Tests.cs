using NUnit.Framework;

namespace MyMath.Tests
{
    [TestClass]
    /// <summary> Tests for max_int </summary>
    public class OperationsTests
    {
        [TestMethod]
        public void Max()
        {
            List<int> testList = new List<int>();
            testList.AddRange(Enumerable.Range(1, 10));
            int results = Operations.Max(testList);

            Assert.AreEqual(10, output);
        }
    }
}