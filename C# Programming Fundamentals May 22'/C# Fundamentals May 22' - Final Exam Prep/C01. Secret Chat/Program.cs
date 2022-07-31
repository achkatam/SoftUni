using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;
using System.Linq;

namespace C01._Secret_Chat
{
    class Program
    {
        static void Main(string[] args)
        {
            //On the first line of the input, you will receive the concealed message. After that, until the "Reveal" command is given, you will receive strings with instructions for different operations that need to be performed upon the concealed message to interpret it and reveal its actual content. There are several types of instructions, split by ":|:"

            string message = Console.ReadLine();

            string command = Console.ReadLine();
            while (command != "Reveal")
            {
                string[] tokens = command.Split(":|:",
                    StringSplitOptions.RemoveEmptyEntries);
                string cmd = tokens[0];

                switch (cmd)
                {
                    case "InsertSpace":
                        //•	"InsertSpace:|:{index}":
                        //o Inserts a single space at the given index.The given index will always be valid.
                        message = message.Insert(int.Parse(tokens[1]), " ");
                        break;
                    case "Reverse":
                        //•	"Reverse:|:{substring}":
                        //o If the message contains the given substring, cut it out, reverse it and add it at the end of the message.
                        //o If not, print "error".
                        //o This operation should replace only the first occurrence of the given substring if there are two or more occurrences.
                        if (message.Contains(tokens[1]))
                        {
                            int index = message.IndexOf(tokens[1]);
                            string reversed = string.Join("", tokens[1].Reverse());
                            message = message.Remove(index, tokens[1].Length);
                            message += reversed;
                        }
                        else
                        {
                            Console.WriteLine("error");
                            command = Console.ReadLine();

                            continue;
                        }
                        break;
                    case "ChangeAll":
                        //•	"ChangeAll:|:{substring}:|:{replacement}":
                        //o Changes all occurrences of the given substring with the replacement text.
                        message = message.Replace(tokens[1], tokens[2]);
                        break;
                }
                Console.WriteLine(message);

                command = Console.ReadLine();
            }
            //"You have a new text message: {message}"
            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}
