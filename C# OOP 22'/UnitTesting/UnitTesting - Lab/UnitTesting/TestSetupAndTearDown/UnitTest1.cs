namespace TestSetupAndTearDown
{
    using NUnit.Framework;

    public class Tests
    {
        private int x = 0;
        //runs before every single test
        [SetUp]
        public void Setup()
        {
            x++;
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual(1,x);
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(3, x);
        }
    }
}