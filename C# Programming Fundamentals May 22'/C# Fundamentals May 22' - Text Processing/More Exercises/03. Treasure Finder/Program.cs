using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _03._Treasure_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program that decrypts a message by a given key and gathers information about hidden treasure type and its coordinates. On the first line, you will receive a key (sequence of numbers). On the next few lines until you receive "find" you will get lines of strings. You have to loop through every string and decrease the ASCII code of each character with a corresponding number of the key sequence. The way you choose a key number from the sequence is by just looping through it. If the length of the key sequence is less than the string sequence, you start looping from the beginning of the key. For more clarification see the example below. 

            var keys = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string command = Console.ReadLine();

            while (command != "find")
            {
                StringBuilder sb = new StringBuilder(command);

                int key = 0;

                for (int i = 0; i < sb.Length; i++)
                {
                    sb[i] -= (char)keys[key];

                    if (key == keys.Length - 1)
                    {
                        key = 0;
                    }
                    else
                    {
                        key++;
                    }
                }

                string decryptedMessage = sb.ToString();

                string treasure = GetTreasureAndCoordinates(decryptedMessage, '&');
                string coordinates = GetTreasureAndCoordinates(decryptedMessage, '<');

                Console.WriteLine($"Found {treasure} at {coordinates}");

                command = Console.ReadLine();
            }
        }

        static string GetTreasureAndCoordinates(string decryptedMessage, char symbol)
        {
            int startIndex = decryptedMessage.IndexOf(symbol);
            int endIndex = decryptedMessage.LastIndexOf(symbol);

            if (symbol == '<')
            {
                endIndex = decryptedMessage.Length - 1;
            }

            string treasureOrCoordinates = decryptedMessage.Substring(startIndex + 1, endIndex - startIndex - 1);

            return treasureOrCoordinates;
        }
    }
}
