using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace D01._Password_Reset
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a password reset program that performs a series of commands upon a predefined string. First, you will receive a string, and afterward, until the command "Done" is given, you will be receiving strings with commands split by a single space. The commands will be the following:

            string input = Console.ReadLine();

            string command = Console.ReadLine();

            while (command != "Done")
            {
                string[] tokens = command.Split(" "
                    , StringSplitOptions.RemoveEmptyEntries);
                string cmd = tokens[0];

                switch (cmd)
                {
                    //•	"TakeOdd"
                    //o Takes only the characters at odd indices and concatenates them to obtain the new raw password and then prints it.
                    case "TakeOdd":
                        string newPassword = string.Empty;
                        for (int i = 0; i < input.Length; i++)
                        {
                            if (i % 2 != 0)
                            {
                                newPassword += input[i];
                            }
                        }
                        input = newPassword;
                        break;
                    case "Cut":
                        //•	"Cut {index} {length}"
                        //o Gets the substring with the given length starting from the given index from the password and removes its first occurrence, then prints the password on the console.
                        //o The given index and the length will always be valid.
                        {
                            input = Cut(input, tokens);
                        }
                        break;
                    case "Substitute":
                        string substring = tokens[1];
                        string substitute = tokens[2];
                        if (!input.Contains(substring))
                        {
                            Console.WriteLine($"Nothing to replace!");

                            command = Console.ReadLine();
                            continue;
                        }
                        else
                        {
                            input = input.Replace(substring, substitute);
                        }
                        //•	"Substitute {substring} {substitute}"
                        //o If the raw password contains the given substring, replaces all of its occurrences with the substitute text given and prints the result.
                        //o If it doesn't, prints "Nothing to replace!".
                        break;
                }
                Console.WriteLine(input);

                command = Console.ReadLine();
            }

            Console.WriteLine($"Your password is: {input}");
        }

      static string Cut(string input, string[] tokens)
        {
            int index = int.Parse(tokens[1]);
            int length = int.Parse(tokens[2]);

            input = input.Remove(index, length);

            return input;
        }
    }
}
