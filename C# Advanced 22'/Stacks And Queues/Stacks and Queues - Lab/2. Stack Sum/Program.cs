using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create the stack
            Stack<int> stack = new Stack<int>(Console.ReadLine().Split()
                .Select(int.Parse).ToList());

            var command = Console.ReadLine().ToLower();

            while (command != "end")
            {
                var tokens = command.Split();
                if (tokens[0] == "add")
                {
                    int firstNum = int.Parse(tokens[1]);
                    int secNum = int.Parse(tokens[2]);

                    //Push the nums in the stack
                    stack.Push(firstNum);
                    stack.Push(secNum);
                }
                if (tokens[0] == "remove")
                {
                    //count of nums to be removed
                    int count = int.Parse(tokens[1]);

                    if (count <= stack.Count())
                    {
                        for (int i = 0; i < count; i++)
                        {
                            stack.Pop();
                        }
                    }
                }

                command = Console.ReadLine().ToLower();
            }

            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}
