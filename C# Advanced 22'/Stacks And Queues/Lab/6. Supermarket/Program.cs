using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new Queue<string>();

            string input = Console.ReadLine();

            while (input != "End")
            {
                // string name = Console.ReadLine();

                if (input == "Paid")
                {
                    while (names.Count > 0)
                    {
                        Console.WriteLine(names.Dequeue());

                    }
                    //foreach (var person in names)
                    //{
                    //    Console.WriteLine(names.Dequeue());
                    //    //names.Dequeue();
                    //}
                }
                else
                {
                    names.Enqueue(input);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"{names.Count} people remaining.");
        }
    }
}
