using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Balanced_Parenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            bool isBalanced = true;

            var stack = new Stack<char>();

            foreach (var item in input)
            {
                if (item == '{' ||
                    item == '[' ||
                   item == '(')
                {
                    stack.Push(item);
                    continue;
                }

                if (stack.Count == 0)
                {
                    isBalanced = false;
                    break;
                }

                if (item == '}' && stack.Peek() == '{')
                {
                    stack.Pop();
                }
                else if (item ==']' && stack.Peek() == '[')
                {
                    stack.Pop();
                }
                else if (item == ')' && stack.Peek() == '(')
                {
                    stack.Pop();
                }
                else
                {
                    isBalanced = false;
                    break;
                }
            }

            if (!isBalanced || stack.Count > 0)
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }

        }
    }
}
