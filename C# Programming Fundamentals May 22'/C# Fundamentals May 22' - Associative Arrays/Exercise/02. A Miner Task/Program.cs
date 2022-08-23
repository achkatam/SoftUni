using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            //You will be given a sequence of strings, each on a new line. Every odd line on the console is representing a resource (e.g. Gold, Silver, Copper and so on) and every even - quantity. Your task is to collect the resources and print them each on a new line.
            //Print the resources and their quantities in the following format:
            //"{resource} –> {quantity}"

            //Create the dictionary of resources and quantity
            var items = new Dictionary<string, int>();

            string resources = Console.ReadLine();

            while (resources != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if (!items.ContainsKey(resources))
                {
                    items[resources] = 0;
                }
                items[resources] += quantity;

                resources = Console.ReadLine();
            }

            foreach (var item in items)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}
