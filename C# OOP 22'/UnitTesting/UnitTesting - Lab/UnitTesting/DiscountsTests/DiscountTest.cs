namespace DiscountsTests
{
    using NUnit.Framework;
    using System;

    public class Tests
    {
        private Discounts discount;
        [SetUp]
        public void Setup()
        {
            discount = new Discounts();
        }

        [Test]
        public void TestDiscountShouldReturn10()
        {
            var result = discount.GetDiscount(new DateTime(2022,11,19));

            Assert.AreEqual(40, result);
        }
    }
}