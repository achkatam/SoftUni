using System;
using System.Collections.Generic;
using System.Linq;


namespace _4._List_of_Products
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create list of product 
            List<string> products = new List<string>();

            // Variable for how many we will input
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string product = Console.ReadLine();
                products.Add(product);
            }
            products.Sort();
            int counter = 1;

            foreach (var product in products)
            {
                Console.WriteLine($"{counter}.{product}");
                counter++;
            }

        }
    }
}
