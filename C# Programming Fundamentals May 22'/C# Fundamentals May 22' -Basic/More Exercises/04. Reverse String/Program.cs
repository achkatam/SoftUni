using System;
using System.Linq;

namespace _04._Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program which reverses a string and print it on the console.

            //input
            //string word = Console.ReadLine();

            //string reversedWord = new string(word.ToCharArray().Reverse().ToArray());

            //Console.WriteLine(reversedWord);

            string username = Console.ReadLine();

            string password = new string(username.ToCharArray().Reverse().ToArray());

            string reversedUsername = Console.ReadLine();
            for (int i = 0; i < 3; i++)
            {

                if (reversedUsername == password)
                {
                    Console.WriteLine("You logged in.");
                }
                else
                {
                    Console.WriteLine($"Wrong password!");
                    reversedUsername = Console.ReadLine();
                }
            }
            Console.WriteLine($"{username} was blocked!");

        }
    }
}
