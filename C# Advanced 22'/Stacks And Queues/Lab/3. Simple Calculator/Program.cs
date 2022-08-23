using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' '
                ,StringSplitOptions.RemoveEmptyEntries).Reverse().ToArray();

            Stack<string> stack = new Stack<string>(input);

            while (stack.Count > 1)
            {
                int result = 0;
                int firstDigit = int.Parse(stack.Pop());
                string operation = stack.Pop();
                int secDigit = int.Parse(stack.Pop());

                switch (operation)
                {
                    case "-":
                        result = firstDigit - secDigit;
                        break;
                    case "+":
                        result = firstDigit + secDigit;
                        break;
                }

                stack.Push(result.ToString());
            }

            Console.WriteLine(stack.Pop().ToString());
        }
    }
}
