using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputNums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] inputElements = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int toEnqueue = inputNums[0];
            int toDequeue = inputNums[1];
            int specialNumber = inputNums[2];

            //Stack<int> stack = new Stack<int>();
            Queue<int> queue = new Queue<int>();

            //Enqeue
            for (int i = 0; i < toEnqueue; i++)
            {
                queue.Enqueue(inputElements[i]);
            }

            //Dequeue
            for (int i = 0; i < toDequeue; i++)
            {
                queue.Dequeue();
            }

            if (queue.Contains(specialNumber))
            {
                Console.WriteLine("true");
            }
            else if (queue.Count > 0)
            {
                Console.WriteLine(queue.Min());
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
