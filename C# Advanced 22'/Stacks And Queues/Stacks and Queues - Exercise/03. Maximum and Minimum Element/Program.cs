using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace _03._Maximum_and_Minimum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //You have an empty sequence, and you will be given N queries. Each query is one of these three types:
            //1 x – Push the element x into the stack.
            //2 – Delete the element present at the top of the stack.
            //3 – Print the maximum element in the stack.
            //4 – Print the minimum element in the stack.
            //After you go through all of the queries, print the stack in the following format:
            //"{n}, {n1}, {n2} …, {nn}"



            //variable for queries
            int n = int.Parse(Console.ReadLine());

            //Stack with operations
            var stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split(" ");

                string cmd = tokens[0];

                SwitchCases(stack, tokens, cmd);

            }

            //print output
            Console.WriteLine(String.Join(", ", stack));

        }

        static void SwitchCases(Stack<int> stack, string[] tokens, string cmd)
        {
            switch (cmd)
            {
                case "1":
                    //1 x – Push the element x into the stack.
                    int element = int.Parse(tokens[1]);

                    stack.Push(element);
                    break;
                case "2":
                    //2 – Delete the element present at the top of the stack.
                    if (ValidStack(stack))
                        stack.Pop();
                    break;
                case "3":
                    //3 – Print the maximum element in the stack.
                    if (ValidStack(stack))
                    {
                        Console.WriteLine(stack.Max());
                    }
                    break;
                case "4":
                    //4 – Print the minimum element in the stack.
                    if (ValidStack(stack))
                    {
                        Console.WriteLine(stack.Min());
                    }
                    break;
            }
        }

        static bool ValidStack(Stack<int> stack)
        {
            bool isValid = stack.Count > 0;

            return isValid;
        }
    }
}
