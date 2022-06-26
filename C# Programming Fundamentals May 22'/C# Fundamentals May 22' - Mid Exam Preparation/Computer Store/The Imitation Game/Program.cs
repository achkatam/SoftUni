using System;
using System.Collections.Generic;
using System.Linq;

namespace The_Imitation_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            //On the first line of the input, you will receive the encrypted message. After that, until the "Decode" command is given, you will be receiving strings with instructions for different operations that need to be performed upon the concealed message to interpret it and reveal its true content.There are several types of instructions, split by '|'


            //Create the list of message
            var message = Console.ReadLine().Split().ToList();

            //variable for command
            string command = Console.ReadLine();
            //While loop until receive "Decode
            while (command != "Decode")
            {
                string[] tokens = command.Split('|');
                string cmd = tokens[0];
                //Switch case to check the variaty of commands:
                switch (cmd)
                {
                    case "Move":
                        //"Move {number of letters}":
                        //o Moves the first n letters to the back of the string
                        Move(message, int.Parse(tokens[1]));
                        break;
                    //•	"Insert {index} {value}":
                    //o   Inserts the given value before the given index in the string
                    case "Insert":
                        Insert(message, int.Parse(tokens[1]), tokens[2]);
                        break;
                    //•	"ChangeAll {substring} {replacement}":
                    //o   Changes all occurrences of the given substring with the replacement text
                    case "ChangeAll":
                        Change(message, tokens[1], tokens[2]);
                        break;

                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"The decrypted message is: {message}");
        }

        private static void Change(List<string> message, string substring, string replacement)
        {
            //•	"ChangeAll {substring} {replacement}":
            //o   Changes all occurrences of the given substring with the replacement text

            int index = message.IndexOf(substring);
            message.RemoveAt(index);
            message.Insert(index, replacement);
        }

        private static void Insert(List<string> message, int index, string value)
        {

            //•	"Insert {index} {value}":
            //o   Inserts the given value before the given index in the string
            message.Insert(index - 1, value);
        }

        private static void Move(List<string> message, int numberOfLetters)
        {
            //"Move {number of letters}":
            //o Moves the first n letters to the back of the string
            //For loop to iterate thru to list
            for (int i = 0; i < numberOfLetters; i++)
            {
                message[i] = message[message.Count - 1];
            }

        }
    }
}