using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;
using System.Linq;

namespace B01._World_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            //On the first line, you will be given a string containing all of your stops. Until you receive the command "Travel", you will be given some commands to manipulate that initial string. The commands can be:
            string inputStops = Console.ReadLine();

            string command = Console.ReadLine();
            while (command != "Travel")
            {
                string[] tokens = command.Split(":",
                    StringSplitOptions.RemoveEmptyEntries);
                string cmd = tokens[0];

                switch (cmd)
                {
                    //•	"Add Stop:{index}:{string}":
                    //o Insert the given string at that index only if the index is valid
                    case "Add Stop":
                        {
                            int index = int.Parse(tokens[1]);
                            string value = tokens[2];
                            if (IsValidIndex(index, inputStops))
                            {
                                inputStops = inputStops.Insert(index, value);
                            }
                            break;
                        }
                    //•	"Remove Stop:{start_index}:{end_index}":
                    //o Remove the elements of the string from the starting index to the end index(inclusive) if both indices are valid
                    case "Remove Stop":
                        {
                            int startIndex = int.Parse(tokens[1]);
                            int endIndex = int.Parse(tokens[2]);
                            if (IsValidIndex(startIndex, inputStops) && IsValidIndex(endIndex, inputStops))
                            {
                                inputStops = inputStops.Remove(startIndex, endIndex - startIndex + 1);
                            }
                            break;
                        }
                    //•	"Switch:{old_string}:{new_string}":
                    //o If the old string is in the initial string, replace it with the new one(all occurrences)
                    case "Switch":
                        {
                            string oldString = tokens[1];
                            string newString = tokens[2];
                            inputStops = inputStops.Replace(oldString, newString);
                            break;
                        }
                }
                Console.WriteLine(inputStops);

                command = Console.ReadLine();
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {inputStops}");
        }
        static bool IsValidIndex(int index, string inputStops) => index >= 0 && index < inputStops.Length;
    }
}
