namespace PromotionsTests
{
    using NUnit.Framework;
    using Promotions;
  
    using PromotionsTests.Fakes;
    using System.Linq;

    public class ProductServiceTestsUsingFakes
    {
        private ProductService service;
        private DummyProductsDatabase dummyDb;

        [SetUp]
        public void Setup()
        {
            dummyDb = new DummyProductsDatabase();
            //service = new ProductService(dummyDb);

        }
        [Test]
        public void TEST_ADDPRODUCT_METHOD()
        {
            service.AddProduct(new Product(1, "TestProduct", 5));

            Assert.AreEqual(4, service.Products.Count);
            Assert.AreEqual(1, dummyDb.SaveCallTimes);
        }
        [Test]
        public void TEST_ADDMULTIPLEPRODUCTs_METHOD()
        {
            service.AddProduct(new Product(1, "TestProduct", 5));
            service.AddProduct(new Product(6, "TestProduct2", 5));
            service.AddProduct(new Product(11, "TestProduct3", 5));
            service.AddProduct(new Product(2, "TestProduct4", 5));

            Assert.AreEqual(7, service.Products.Count);
            Assert.AreEqual(4, dummyDb.SaveCallTimes);
        }

        [Test]
        public void TEST_DELETEPRODUCT_METHOD()
        {
            service.AddProduct(new Product(4, "TestProduct", 15));
            service.Delete(4);

            Assert.AreEqual(3, service.Products.Count);

            Assert.AreEqual(false, service.Products.Any(x => x.Id == 4));
        }
    }
}
