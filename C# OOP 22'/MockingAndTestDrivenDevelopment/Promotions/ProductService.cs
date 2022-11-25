namespace Promotions
{
    using Promotions.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ProductService
    {
        private IProductsDatabase productsDatabase;
        private IPromotionService promotionService;

        public ProductService(IProductsDatabase db, IPromotionService promotionService)
        {
            this.productsDatabase = db;
            this.promotionService = promotionService;

            Products = db.GetAll();
        }

        public List<Product> Products { get; set; }

        public void AddProduct(Product product)
        {
            Products.Add(product);

            productsDatabase.Save(Products);
        }

        public void Delete(int id)
        {
            Product product = FindById(id);
            if (product == null)
                throw new ArgumentException("Product not found!");

            Products.Remove(product);

            productsDatabase.Save(Products);
        }
         
        public List<Product> GetAllProductsForToday()
        {
            List<Product> productsAfterAppliedDiscount = new List<Product>();

            foreach (var item in Products)
            {
                decimal price = promotionService.GetPromotion(item);
                productsAfterAppliedDiscount.Add(new Product(item.Id, item.Name, price));
            }

            return productsAfterAppliedDiscount;
        }
        private Product FindById(int id) => Products.FirstOrDefault(p => p.Id == id);
    }
}
