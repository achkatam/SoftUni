namespace Promotions
{
    using Promotions.Contracts;
    using System;
    using System.Collections.Generic;

    public class Program
    {
        static void Main(string[] args)
        {
            IProductsDatabase db = new TextProductDatabase("../../../products.txt");

            List<Product> products = new List<Product>() 
            {
                new Product(1, "SunflowerOil", 4.5m),
                new Product(2, "OliveOil", 10),
                new Product(3, "Tomatoes", 2.1m)
            };

            db.Save(products);

            ProductService service = new ProductService(db, new PromotionService(DateTime.Now));

            foreach (var product in service.GetAllProductsForToday())
            {
                Console.WriteLine(product);
            }
        }
    }
}
