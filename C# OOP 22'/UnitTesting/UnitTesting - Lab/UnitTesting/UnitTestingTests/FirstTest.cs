namespace UnitTestingTests
{
    using NUnit.Framework;

    public class FirstTest
    {
        [Test]
        public void Test()
        {
           
            int result = 1 + 6;
            Assert.AreEqual(7, result, "1 + 6 should equal 7");

            Assert.AreEqual(9, 9);

            Assert.IsTrue(5 < 6);
        }

        [Test]
        public void Test2()
        {
            int result = 1 + 6;

            Assert.AreEqual(10,result);
        }
    }
}