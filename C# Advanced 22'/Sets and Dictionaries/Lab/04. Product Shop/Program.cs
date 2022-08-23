using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            //dicinary with storeName, dic,product, price>>
            var prices = new Dictionary<string, Dictionary<string, double>>();

            string command = Console.ReadLine();

            while (command != "Revision")
            {
                string[] tokens = command.Split(", ",
                    StringSplitOptions.RemoveEmptyEntries).ToArray();
                string store = tokens[0];
                string product = tokens[1];
                double price = double.Parse(tokens[2]);

                AddProduct(store, product, price, prices);

                command = Console.ReadLine();
            }

                PrintPrices(prices);
        }

        static void AddProduct(string store, string product, double price, Dictionary<string, Dictionary<string, double>> prices)
        {
            if (!prices.ContainsKey(store))
            {
                prices[store] = new Dictionary<string, double>();
            }

            prices[store][product] = price;
        }

        static void PrintPrices(Dictionary<string, Dictionary<string, double>> prices)
        {
            foreach (var storeAndProducts in prices.OrderBy(x =>x.Key))
            {
                string storeName = storeAndProducts.Key;
                Console.WriteLine(storeName + "->");
                var products = storeAndProducts.Value;

                foreach (var productAndPrice in products)
                {
                    Console.WriteLine($"Product: {productAndPrice.Key}, Price: {productAndPrice.Value}");
                }

            }
        }
    }
}
