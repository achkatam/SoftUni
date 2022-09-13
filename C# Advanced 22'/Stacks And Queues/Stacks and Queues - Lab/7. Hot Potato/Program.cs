using System;
using System.Linq;
using System.Collections.Generic;

namespace _7._Hot_Potato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] kids = Console.ReadLine().Split();

            int count = int.Parse(Console.ReadLine());

            Queue<string> queue = new Queue<string>(kids);

            int passes = 1;

            while (queue.Count > 1)
            {
                string currentKid = queue.Dequeue();
                if (passes == count)
                {
                    Console.WriteLine($"Removed {currentKid}");
                    passes = 1;
                    continue;

                }

                passes++;
                queue.Enqueue(currentKid);
            }

            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}
