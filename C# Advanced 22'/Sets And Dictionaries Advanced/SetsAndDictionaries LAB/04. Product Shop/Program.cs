using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stores = new List<Store>();

            string command = Console.ReadLine();

            while (command != "Revision")
            {
                var tokens = command.Split(", "
                    , StringSplitOptions.RemoveEmptyEntries);

                var store = tokens[0];
                var product = tokens[1];
                var price = double.Parse(tokens[2]);

                if (!stores.Any(x => x.StoreName == store))
                {
                    stores.Add(new Store(store));
                }
                Store thisStore = stores.Find(x => x.StoreName == store);

                if (!thisStore.Products.Any(x => x.Name == product))
                {
                    thisStore.Products.Add(new Product(product, price));
                }
                Product thisProduct = thisStore.Products.Find(x => x.Name == product);

                command = Console.ReadLine();
            }

            PrintOutput(stores);

            //fantastico->
            //Product: apple, Price: 1.2
            //Product: grape, Price: 2.2
            //kaufland->
            //Product: banana, Price: 1.1
            //lidl->
            //Product: juice, Price: 2.3


        }

        static void PrintOutput(List<Store> stores)
        {
            foreach (var store in stores.OrderBy(s => s.StoreName))
            {
                Console.WriteLine($"{store.StoreName}->");
                foreach (var item in store.Products)
                {
                    Console.WriteLine($"{item}");
                }
            }
        }
    }
    class Store
    {
        public Store(string storeName)
        {
            StoreName = storeName;
            Products = new List<Product>();
        }
        public string StoreName { get; set; }
        public List<Product> Products { get; set; }
    }

    class Product
    {
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }
        public double Price { get; set; }
        public override string ToString() => $"Product: {Name}, Price: {Price}";

    }
}
