using NUnit.Framework;

namespace TestProject
{
    [TestFixture]
    public class TestCaculate
    {
        Calculate obj = null;
        [SetUp]
        public void Setup()
        {
            obj = new Calculate();
        }

        [Test]
        public void TestAdd()
        {
            int actual = obj.Add(6, 8);
            int expected = 14;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        [Description("Test Greet Method")]
        public void GreetTest()
        {
            string result = obj.Greet("ganesh");
            Assert.NotNull(result);
            Assert.AreEqual("Hello ganesh", result);
        }
    }
}