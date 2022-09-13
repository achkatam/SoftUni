using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;

namespace _5._Print_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that:
            //•	Reads an array of integers and adds them to a queue.
            //•	Prints the even numbers separated by ", ".

            int[] inputs = Console.ReadLine().Split(" ",
                StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var queue = new Queue<int>();

            //add the nums in the queue
            foreach (var num in inputs)
            {
                queue.Enqueue(num);
            }

            var evenNums = new List<int>();

            while (queue.Count > 0)
            {
                if (queue.Peek() % 2 == 0)
                {
                    //add it to the list and dequeue
                    evenNums.Add(queue.Dequeue());
                }
                else
                {
                    queue.Dequeue();
                }
            }

            Console.WriteLine(String.Join(", ", evenNums));
        }
    }
}
