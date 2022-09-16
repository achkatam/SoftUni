using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _01._Basic_Stack_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Play around with a stack.You will be given an integer N representing the number of elements to push into the stack, an integer S representing the number of elements to pop from the stack, and finally an integer X, an element that you should look for in the stack.If it’s found, print "true" on the console.If it isn't, print the smallest element currently present in the stack. If there are no elements in the sequence, print 0 on the console.


            //create variables 
            int[] stackArgs = Console.ReadLine()
                .Split().Select(int.Parse).ToArray();

            //nums to push
            int toPush = stackArgs[0];
            //nums to remove
            int toPop = stackArgs[1];
            //nums to Peek()
            int toPeek = stackArgs[2];

            //Create the stack
            Stack<int> stack = new Stack<int>();

            //int[] elements to be pushed
            int[] elements = Console.ReadLine().Split()
                .Select(int.Parse).ToArray();

            foreach (var element in elements)
            {
                stack.Push(element);
            }


            for (int i = 0; i < toPop; i++)
            {
                stack.Pop();
            }


            if (stack.Contains(toPeek))
            {
                Console.WriteLine("true");
            }
            else if (stack.Count == 0)
            {
                Console.WriteLine(stack.Count);
            }
            else
            {
                Console.WriteLine(stack.Min());
            }

        }
    }
}
