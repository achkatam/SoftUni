using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;

namespace _04._Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program that prints information about food shops in Sofia and the products they store. Until the "Revision" command is received, you will be receiving input in the format: "{shop}, {product}, {price}".  Keep in mind that if you receive a shop you already have received, you must collect its product information.
            //Your output must be ordered by shop name and must be in the format:
            //"{shop}->
            //Product: { product}, Price: { price}
            //            "
            //Note: The price should not be rounded or formatted.

            var stores = new Dictionary<string, Dictionary<string, double>>();



            string command = Console.ReadLine();

            while (command != "Revision")
            {
                var tokens = command
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
                string store = tokens[0];
                string product = tokens[1];
                double price = double.Parse(tokens[2]);

                AddStore(stores, store, product, price);

                command = Console.ReadLine();
            }

            foreach (var store in stores.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{store.Key}->");

                foreach (var item in store.Value)
                {
                    Console.WriteLine($"Product: {item.Key}, Price: {item.Value}");
                }
            }

        }

        static void AddStore(Dictionary<string, Dictionary<string, double>> stores, string store, string product, double price)
        {
            if (!stores.ContainsKey(store))
            {
                stores.Add(store, new Dictionary<string, double>());
            }

            stores[store].Add(product, price);
        }
    }
}
