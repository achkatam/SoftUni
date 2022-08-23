using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> stack = new Stack<int>(numbers);

            string command = Console.ReadLine().ToLower();

            while (command != "end")
            {
                var tokens = command.Split();

                switch (tokens[0])
                {
                    case "add":
                        int first = int.Parse(tokens[1]);
                        int second = int.Parse(tokens[2]);

                        stack.Push(first);
                        stack.Push(second);

                        break;
                    case "remove":
                        int count = int.Parse(tokens[1]);

                        if (count <= stack.Count)
                        {
                            for (int i = 0; i < count; i++)
                            {
                                stack.Pop();
                            }
                        }
                        break;
                }

                command = Console.ReadLine().ToLower();
            }
            int sum = 0;

            while (stack.Count > 0)
            {
                sum += stack.Pop();
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
