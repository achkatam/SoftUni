using System;
using System.Linq;

namespace _03._Stack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();

            
            string command = Console.ReadLine();

            while (command != "END")
            {
                var tokens = command
                    .Split(new string[] { " ", ", " }, StringSplitOptions.RemoveEmptyEntries);
                string cmd = tokens[0];

                switch (cmd)
                {
                    case "Push":
                        string[] input = tokens.Skip(1).ToArray();
                        foreach (var item in input)
                        {
                            stack.Push(item);
                        }
                        break;

                    case "Pop":
                        try
                        {
                            stack.Pop();
                        }
                        catch (InvalidOperationException exception)
                        {
                            Console.WriteLine(exception.Message);
                        }
                        break;
                }

                command = Console.ReadLine();
            }
            
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
