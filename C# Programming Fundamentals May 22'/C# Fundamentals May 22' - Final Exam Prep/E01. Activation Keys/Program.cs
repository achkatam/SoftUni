using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace E01._Activation_Keys
{
    class Program
    {
        static void Main(string[] args)
        {
            //After that, until the "Generate" command is given, you will be receiving strings with instructions for different operations that need to be performed upon the raw activation key.
            //There are several types of instructions, split by ">>>":

            string input = Console.ReadLine();

            string command = Console.ReadLine();

            while (command != "Generate")
            {
                string[] tokens = command.Split(">>>"
                    , StringSplitOptions.RemoveEmptyEntries);
                string cmd = tokens[0];

                switch (cmd)
                {
                    case "Contains":
                        {
                            if (input.Contains(tokens[1]))
                            {
                                Console.WriteLine($"{input} contains {tokens[1]}");
                                break;
                            }

                            Console.WriteLine($"Substring not found!");
                        }
                        break;
                    case "Flip":
                        {
                            int startIndex = int.Parse(tokens[2]);
                            int endIndex = int.Parse(tokens[3]);
                            string substring = input.Substring(startIndex, endIndex - startIndex);

                            if (tokens[1] == "Upper")
                            {
                                input = input.Replace(substring, substring.ToUpper());

                            }
                            else if (tokens[1] == "Lower")
                            {
                                input = input.Replace(substring, substring.ToLower());
                            }

                            Console.WriteLine(input);
                        }
                        break;
                    case "Slice":
                        {
                            input = input.Remove(int.Parse(tokens[1]), int.Parse(tokens[2]) - int.Parse(tokens[1]));

                            Console.WriteLine(input);
                        }
                        break;
                }

                command = Console.ReadLine();
            }
            Console.WriteLine($"Your activation key is: {input}");
        }
    }
}
