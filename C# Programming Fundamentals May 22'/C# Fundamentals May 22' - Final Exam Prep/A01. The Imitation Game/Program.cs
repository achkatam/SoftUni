using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;
using System.Linq;

namespace A01._The_Imitation_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            //On the first line of the input, you will receive the encrypted message.

            string encryptedMessage = Console.ReadLine();

            //After that, until the "Decode" command is given, split by '|'
            string command = Console.ReadLine();

            while (command != "Decode")
            {
                string[] tokens = command.Split("|",
                    StringSplitOptions.RemoveEmptyEntries);

                string cmd = tokens[0];
                switch (cmd)
                {
                    case "Move":
                        encryptedMessage = Move(tokens, encryptedMessage);
                        break;
                    case "Insert":
                        encryptedMessage = Insert(tokens, encryptedMessage);
                        break;
                    case "ChangeAll":
                        encryptedMessage = ChangeAll(tokens, encryptedMessage);
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"The decrypted message is: {encryptedMessage}");
        }

        static string ChangeAll(string[] tokens, string encryptedMessage)
        {
            //"ChangeAll {substring} {replacement}":
            //Changes all occurrences of the given substring with the replacement text
            encryptedMessage = encryptedMessage.Replace(tokens[1], tokens[2]);

            return encryptedMessage;
        }

        static string Insert(string[] tokens, string encryptedMessage)
        {
            //"Insert {index} {value}":
            //Inserts the given value before the given index in the string
            encryptedMessage = encryptedMessage.Insert(int.Parse(tokens[1]), tokens[2]);

            return encryptedMessage;
        }

        static string Move(string[] tokens, string encryptedMessage)
        {
            //"Move {number of letters}":
            //Moves the first n letters to the back of the string
            int numOfLetters = int.Parse(tokens[1]);
            string letterToRemove = encryptedMessage.Substring(0, numOfLetters);
            encryptedMessage = encryptedMessage.Remove(0, numOfLetters);
            encryptedMessage += letterToRemove;

            return encryptedMessage;
        }
    }
}
