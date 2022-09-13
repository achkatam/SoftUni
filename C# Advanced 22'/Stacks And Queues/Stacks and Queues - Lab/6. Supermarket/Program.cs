using System;
using System.Linq;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;


namespace _6._Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //You are given a sequence of input strings, each staying on a separate line. Each input string holds either a customer name, or the command “Paid” or the command “End”. Your task is to read and process the input:
            //•	When you receive a customer name, add it to the queue.
            //•	When you receive the "Paid" command, print the customer names from the queue (each at separate line), then empty the queue.
            //•	When you receive the "End" command, print the count of the remaining customers from the queue in the format: "{count} people remaining." and stop processing the commands(see the examples below).


            //Create a queue
            var customers = new Queue<string>();

            string input = Console.ReadLine();

            while (input != "End")
            {
                if (input != "Paid")
                {
                    customers.Enqueue(input);
                }

                if (input == "Paid")
                {
                    while (customers.Count > 0)
                    {
                        Console.WriteLine(customers.Dequeue());
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"{customers.Count} people remaining.");
        }
    }
}
