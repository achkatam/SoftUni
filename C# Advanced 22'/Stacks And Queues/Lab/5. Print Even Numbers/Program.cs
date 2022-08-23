using System;
using System.Collections.Generic;
using System.Linq;


namespace _5._Print_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputNums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var numbers = new Queue<int>();

            foreach (var num in inputNums)
            {
                numbers.Enqueue(num);
            }

            var evenNums = new List<int>();

            while (numbers.Count > 0)
            {
                if (numbers.Peek() % 2 == 0)
                {
                    evenNums.Add(numbers.Dequeue());
                }
                else
                {
                    numbers.Dequeue();
                }
            }

            Console.WriteLine(string.Join(", ",evenNums));
        }
    }
}
