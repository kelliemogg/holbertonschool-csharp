using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    /// <summary> Tests for MyMath divide </summary>
    public class Tests
    {
        [Test]
        public void TestNull()
        {
            int[,] mat = null;
            int[,] res = Matrix.Divide(mat, 10);
            Assert.AreEqual(null, res);
        }
    }
}