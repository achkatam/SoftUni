using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] inputNums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] inputElements = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int toPush = inputNums[0];
            int toPop = inputNums[1];
            int specialNumber = inputNums[2];

            //Stack<int> stack = new Stack<int>();
            Stack<int> stack = new Stack<int>(inputElements.Take(toPush));

            //Push
            //for (int i = 0; i < toPush; i++)
            //{
            //    stack.Push(inputElements[i]);
            //}

            //Pop
            for (int i = 0; i < toPop; i++)
            {
                stack.Pop();
            }

            if (stack.Contains(specialNumber))
            {
                Console.WriteLine("true");
            }
            else if (stack.Count > 0)
            {
                Console.WriteLine(stack.Min());
            }
            else
            {
                Console.WriteLine(0);
            }

        }
    }
}
