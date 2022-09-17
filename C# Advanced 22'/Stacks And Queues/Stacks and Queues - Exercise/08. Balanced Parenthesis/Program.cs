using System;
using System.Linq;
using System.Collections.Generic;

namespace _08._Balanced_Parenthesis
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Given a sequence consisting of parentheses, determine whether the expression is balanced. A sequence of parentheses is balanced if every open parenthesis can be paired uniquely with a closing parenthesis that occurs after the former. Also, the interval between them must be balanced. You will be given three types of parentheses: (, {, and [.
            //{[()]}
            //-This is a balanced parenthesis.
            //{[(])}
            //-This is not a balanced parenthesis.

            string input = Console.ReadLine();

            //boolean if it is balanced
            bool isBalanced = true;

            var brackets = new Stack<char>();


            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(' ||
                    input[i] == '[' ||
                    input[i] == '{')
                {
                    brackets.Push(input[i]);
                }
                else
                {
                    if (!brackets.Any())
                    {
                        isBalanced = false;
                        Console.WriteLine("NO");

                        return;
                    }
                    else if (input[i] == ')' && brackets.Peek() == '(')
                    {
                        brackets.Pop();
                    }
                    else if (input[i] == ']' && brackets.Peek() == '[')
                    {
                        brackets.Pop();
                    }
                    else if (input[i] == '}' && brackets.Peek() == '{')
                    {
                        brackets.Pop();
                    }
                    else
                    {
                        isBalanced = false;
                        Console.WriteLine("NO");

                        return;
                    }
                }
            }

            Console.WriteLine(isBalanced ? "YES" : "NO");
        }
    }
}
