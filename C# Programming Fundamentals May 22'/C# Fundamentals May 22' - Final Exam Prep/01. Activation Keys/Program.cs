using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace _01._Activation_Keys
{
    class Program
    {
        static void Main(string[] args)
        {
            //activation key
            string key = Console.ReadLine();

            string command = Console.ReadLine();

            while (command != "Generate")
            {
                var tokens = command.Split(">>>",
                    StringSplitOptions.RemoveEmptyEntries);
                string cmd = tokens[0];

                switch (cmd)
                {
                    case "Contains":
                        if (key.Contains(tokens[1]))
                        {
                            Console.WriteLine($"{key} contains {tokens[1]}");
                        }
                        else
                        {
                            Console.WriteLine($"Substring not found!");
                        }
                        break;
                    case "Flip":
                        int startIndex = int.Parse(tokens[2]);
                        int endIndex = int.Parse(tokens[3]);
                        if (tokens[1] == "Upper")
                        {
                            string upperSubstring = key.Substring(startIndex, endIndex - startIndex);
                            key = key.Replace(upperSubstring, upperSubstring.ToUpper());
                        }
                        else if (tokens[1] == "Lower")
                        {
                            string lowerSubstring = key.Substring(startIndex, endIndex - startIndex);
                            key = key.Replace(lowerSubstring, lowerSubstring.ToLower());
                        }
                        Console.WriteLine(key);
                        break;
                    case "Slice":
                        int starttIndex = int.Parse(tokens[1]);
                        int enndIndex = int.Parse(tokens[2]);
                        key = key.Remove(starttIndex, enndIndex - starttIndex);
                        Console.WriteLine(key);
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Your activation key is: {key}");
            //The first line of the input will be your raw activation key. It will consist of letters and numbers only. 
            //After that, until the "Generate" command is given, you will be receiving strings with instructions for different operations that need to be performed upon the raw activation key.
            //There are several types of instructions, split by ">>>":
            //•	"Contains>>>{substring}":
            //o   If the raw activation key contains the given substring, prints: "{raw activation key} contains {substring}".
            //o   Otherwise, prints: "Substring not found!"
            //•	"Flip>>>Upper/Lower>>>{startIndex}>>>{endIndex}":
            //o   Changes the substring between the given indices(the end index is exclusive) to upper or lower case and then prints the activation key.
            //o   All given indexes will be valid.
            //•	"Slice>>>{startIndex}>>>{endIndex}":
            //o  Deletes the characters between the start and end indices(the end index is exclusive) and prints the activation key.
            //o Both indices will be valid.

        }
    }
}
