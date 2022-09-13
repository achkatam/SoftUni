using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Reverse_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            //Create the stack
            var stack = new Stack<char>();

            foreach (char item in input)
            {
                stack.Push(item);
            }

            //using while loop
            while (stack.Count > 0)
            {
                Console.Write(stack.Pop());
            }

            //using foreach
            //foreach (var item in stack)
            //{
            //    Console.Write(item);
            //}
        }
    }
}
