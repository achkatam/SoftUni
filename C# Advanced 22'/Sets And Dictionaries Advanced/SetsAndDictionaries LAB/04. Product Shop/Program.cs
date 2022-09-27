using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stores = new Dictionary<string, List<Product>>();

            string command = Console.ReadLine();

            while (command != "Revision")
            {
                var tokens = command.Split(", "
                    , StringSplitOptions.RemoveEmptyEntries);

                var store = tokens[0];
                var product = tokens[1];
                var price = double.Parse(tokens[2]);

                AddStore(stores, store, product, price);


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

        static void PrintOutput(Dictionary<string, List<Product>> stores)
        {
            foreach (var store in stores.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{store.Key}->");

                foreach (var item in store.Value)
                {
                    Console.WriteLine(item);
                }
            }
        }

        static void AddStore(Dictionary<string, List<Product>> stores, string store, string product, double price)
        {
            if (!stores.ContainsKey(store))
            {
                stores.Add(store, new List<Product>());
            }

            stores[store].Add(new Product(product, price));
        }
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
