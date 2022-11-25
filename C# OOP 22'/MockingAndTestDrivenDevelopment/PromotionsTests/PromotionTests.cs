namespace PromotionsTests
{
    using NUnit.Framework;
    using Promotions;
    using System;

    public class Tests
    {
        [TestCase("11/24/2022", 20)]
        [TestCase("11/25/2022", 0)]
        public void Test_Thursday_PromotionShouldReturn20(string date, decimal result)
        {
            DateTime dateToday = DateTime.Parse(date); 
            PromotionService promotion = new PromotionService(dateToday);

            Assert.AreEqual(result, promotion.GetPromotion(new Product(2, "Apple", 2.10m)));
        }
    }
}