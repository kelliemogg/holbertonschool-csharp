using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    /// <summary> Tests for MyMath add </summary>
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            int a = 2;
            int b = 2;

            int output = Operations.Add(a, b);
            Assert.AreEqual(4, output);
        }
    }
}