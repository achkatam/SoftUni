using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kids = Console.ReadLine().Split();

            Queue<string> queue = new Queue<string>(kids);

            int turns = int.Parse(Console.ReadLine());
            int currTosses = 1;

            while (queue.Count > 1)
            {
                var kid = queue.Dequeue();
                if (currTosses != turns)
                {
                    queue.Enqueue(kid);
                    currTosses++;
                }
                else
                {
                    Console.WriteLine($"Removed {kid}");
                    currTosses = 1;
                }
            }
                Console.WriteLine($"Last is {queue.Dequeue()}");

        }
    }
}
