using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace _01._The_Imitation_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            //On the first line of the input, you will receive the encrypted message. After that, until the "Decode" command is given, you will be receiving strings with instructions for different operations that need to be performed upon the concealed message to interpret it and reveal its true content. There are several types of instructions, split by '|'




            string message = Console.ReadLine();

            string command = Console.ReadLine();

            while (command != "Decode")
            {
                var tokens = command.Split('|'
                    , StringSplitOptions.RemoveEmptyEntries).ToArray();
                string cmd = tokens[0];

                switch (cmd)
                {
                    case "Move":
                        message = Move(message, tokens);
                        break;
                    case "Insert":
                        message = Insert(message, tokens);
                        break;
                    case "ChangeAll":
                        message = ChangeAll(message, tokens);
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"The decrypted message is: {message}");
        }

        static string ChangeAll(string message, string[] tokens)
        {
            //•	"ChangeAll {substring} {replacement}":
            //o Changes all occurrences of the given substring with the replacement text
            string substring = tokens[1];
            string replacement = tokens[2];
            message = message.Replace(substring, replacement);

            return message;
        }

        static string Insert(string message, string[] tokens)
        {
            //•	"Insert {index} {value}":
            //o Inserts the given value before the given index in the string
            int givenIndex = int.Parse(tokens[1]);
            string value = tokens[2];
            message = message.Insert(givenIndex, value);

            return message;
        }

        static string Move(string message, string[] tokens)
        {
            int numOfLetters = int.Parse(tokens[1]);
            string lettersToRemove = message.Substring(0, numOfLetters);
            message = message.Remove(0, numOfLetters);
            message += lettersToRemove;

            return message;
        }
    }
}
