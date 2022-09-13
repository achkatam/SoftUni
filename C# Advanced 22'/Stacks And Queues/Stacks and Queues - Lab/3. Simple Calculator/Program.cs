using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string[] expression = Console.ReadLine().Split(" ",
                StringSplitOptions.RemoveEmptyEntries);

            Stack<string> stack = new Stack<string>();

            for (int i = 0; i < expression.Length; i++)
            {
                stack.Push(expression[i]);

                if (stack.Count == 3)
                {
                    int firstChar = int.Parse(stack.Pop());
                    var sign = stack.Pop();
                    int secChar = int.Parse(stack.Pop());

                    int result = 0;
                    if (sign == "+")
                    {
                        result = firstChar + secChar;
                    }
                    else
                    {
                        result = secChar - firstChar;
                    }

                    stack.Push(result.ToString());
                }
            }

            Console.WriteLine(stack.Pop());
        }
    }
}
