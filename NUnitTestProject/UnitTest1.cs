using NUnit.Framework;
using TrenirovkaSkierDLL;

namespace NUnitTestProject
{
    public class Tests
    {
        private TrenirovkaSkier calculation;
        [SetUp]
        public void Setup()
        {
            calculation = new TrenirovkaSkier();
        }

        [Test]
        [TestCase(1, 1, 1, 3)]
        [TestCase(0, 1, 1, 0)]
        [TestCase(0, 0, 1, 0)]
        [TestCase(1, 10, 1, 3)]
        [TestCase(10, 10, 1, 1)]
        public void Test_Calculation(double x, double y, double z, int expect)
        {
            var d = calculation.Raschet(x, y, z);

            Assert.AreEqual(expect, d);
        }
    }
}