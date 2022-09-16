using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _02._Basic_Queue_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Play around with a queue. You will be given an integer N representing the number of elements to enqueue (add), an integer S representing the number of elements to dequeue (remove) from the queue, and finally an integer X, an element that you should look for in the queue. If it is, print true on the console. If it’s not printed the smallest element is currently present in the queue. If there are no elements in the sequence, print 0 on the console.

            //create variables 
            int[] queueArgs = Console.ReadLine()
                .Split().Select(int.Parse).ToArray();

            //nums to Enqueue
            int toEnqueue = queueArgs[0];
            //nums to Dequeue
            int toDequeue = queueArgs[1];
            //nums to Peek
            int toPeek = queueArgs[2];

            //Create the queue
            var queue = new Queue<int>();

            //int[] elements to be enqueue
            int[] elements = Console.ReadLine().Split()
                .Select(int.Parse).ToArray();

            //var queue = new Queue<int>(elements);

            foreach (var el in elements)
            {
                queue.Enqueue(el);
            }

            //Dequeue elements
            for (int i = 0; i < toDequeue; i++)
            {
                queue.Dequeue();
            }

            if (queue.Contains(toPeek))
            {
                Console.WriteLine("true");
            }
            else if (queue.Count == 0)
            {
                Console.WriteLine(queue.Count);
            }
            else
            {
                Console.WriteLine(queue.Min());
            }

        }
    }
}
