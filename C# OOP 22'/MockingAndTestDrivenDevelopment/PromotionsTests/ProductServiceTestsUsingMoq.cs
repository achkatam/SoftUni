namespace PromotionsTests
{
    using Moq;
    using NUnit.Framework;
    using Promotions;
    using Promotions.Contracts;
    
    using System.Collections.Generic;
    using System.Linq;

    public class ProductServiceTestsMoq
    {
        private ProductService service;
        private Mock<IProductsDatabase> mockDb;
        private Mock<IPromotionService> mockPromotions;

        [SetUp]
        public void Setup()
        {
            mockDb = new Mock<IProductsDatabase>();
            mockPromotions = new Mock<IPromotionService>();

            mockDb.Setup(db => db.GetAll()).Returns(new List<Product>());
            service = new ProductService(mockDb.Object, mockPromotions.Object);
        }
        [Test]
        public void TEST_ADDPRODUCT_METHOD()
        {
            service.AddProduct(new Product(1, "TestProduct", 5));

            Assert.AreEqual(1, service.Products.Count);

            mockDb.Verify(db => db.Save(It.IsAny<List<Product>>()), Times.Once);

          
        }
        [Test]
        public void TEST_ADDMULTIPLEPRODUCTs_METHOD()
        {
            service.AddProduct(new Product(1, "TestProduct", 5));
            service.AddProduct(new Product(6, "TestProduct2", 5));
            service.AddProduct(new Product(11, "TestProduct3", 5));
            service.AddProduct(new Product(2, "TestProduct4", 5));

            Assert.AreEqual(4, service.Products.Count);
            mockDb.Verify(db => db.Save(It.IsAny<List<Product>>()), Times.Exactly(4));

        }

        [Test]
        public void TEST_DELETEPRODUCT_METHOD()
        {
            service.AddProduct(new Product(4, "TestProduct", 15));
            service.Delete(4);

            Assert.AreEqual(0, service.Products.Count);

            Assert.AreEqual(false, service.Products.Any(x => x.Id == 4));
        }

        [Test]
        public void TEST_GETALLPRODUCTSFORTHURSDAY_RETURNS_MINUS_20PERCENT()
        {
            service.AddProduct(new Product(4, "TestProduct", 100));

            List<Product> products = service.GetAllProductsForToday();

            Assert.AreEqual(80, products[0].Price);
        }

        [Test]
        public void TEST_GETALLPRODUCTSFOR_SUNDAY_RETURNS_MINUS_20PERCENT()
        {
            service.AddProduct(new Product(4, "TestProduct", 100));

            mockPromotions.Setup(pr => pr.GetPromotion(It.IsAny<Product>())).Returns(20);

            List<Product> products = service.GetAllProductsForToday();

            Assert.AreEqual(20, products[0].Price);
        }
    }
}
