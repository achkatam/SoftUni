using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalQunty = int.Parse(Console.ReadLine());

            //orders
            int[] inputOrders = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Console.WriteLine(inputOrders.Max());

            Queue<int> queueOfOrders = new Queue<int>(inputOrders);

            while (queueOfOrders.Any() && totalQunty >= 0)
            {
                int currOrder = queueOfOrders.Peek();

                if (totalQunty - currOrder < 0)
                {
                    break;
                }

                totalQunty -= currOrder;
                queueOfOrders.Dequeue();

            }
            if (queueOfOrders.Count > 0)
            {
                Console.WriteLine($"Orders left: {string.Join(" ", queueOfOrders)}");
            }
            else
            {
                Console.WriteLine($"Orders complete");
            }

        }
    }
}
