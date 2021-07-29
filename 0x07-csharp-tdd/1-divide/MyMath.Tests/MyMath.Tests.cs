using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    /// <summary> Tests for MyMath divide </summary>
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            int a = 10;
            int b = 5;
            int res = Operations.Divide(a, b);
            Assert.AreEqual(2, res);
        }
    }
}