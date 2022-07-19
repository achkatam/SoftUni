using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace _01._Secret_Chat
{
    class Program
    {
        static void Main(string[] args)
        {
            //On the first line of the input, you will receive the concealed message. After that, until the "Reveal" command is given, you will receive strings with instructions for different operations that need to be performed upon the concealed message to interpret it and reveal its actual content. There are several types of instructions, split by ":|:"


            //o This operation should replace only the first occurrence of the given substring if there are two or more occurrences.


            //•	After the "Reveal" command is received, print this message:
            //"You have a new text message: {message}"

            var message = Console.ReadLine();

            string command = Console.ReadLine();


            while (command != "Reveal")
            {
                var token = command.Split(":|:",
                StringSplitOptions.RemoveEmptyEntries);
                string cmd = token[0];

                switch (cmd)
                {
                    //•	"InsertSpace:|:{index}":
                    //o Inserts a single space at the given index.The given index will always be valid.
                    case "InsertSpace":
                        message = InsertSpace(message, token);
                        break;
                    //•	"Reverse:|:{substring}":
                    //o If the message contains the given substring, cut it out, reverse it and add it at the end of the message.
                    //o If not, print "error".
                    case "Reverse":
                        if (message.Contains(token[1]))
                        {
                            int indexToCut = message.IndexOf(token[1]);
                            string reversed = string.Join("", token[1].Reverse());
                            message = message.Remove(indexToCut, token[1].Length);
                            message += reversed;
                        }
                        else
                        {
                            Console.WriteLine("error");
                            command = Console.ReadLine();
                            continue;
                        }
                        break;
                    //•	"ChangeAll:|:{substring}:|:{replacement}":
                    //o Changes all occurrences of the given substring with the replacement text.
                    case "ChangeAll":
                        message = message.Replace(token[1], token[2]);
                        break;
                }
                Console.WriteLine(message);
                command = Console.ReadLine();
            }

            Console.WriteLine($"You have a new text message: {message}");
        }

        public static string InsertSpace(string message, string[] token)
        {
            message = message.Insert(int.Parse(token[1]), " ");
            return message;
        }
    }
}
