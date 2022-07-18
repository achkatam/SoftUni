using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Guess_The_Number;

namespace Guess_The_Number.GuessGame
{
    namespace Guess_The_Number
    {
        class Program
        {
            static void Main(string[] args)
            {
                //Console.BackgroundColor = ConsoleColor.DarkBlue;

                Console.WriteLine("*****************************");
                //Console.BackgroundColor = ConsoleColor.DarkBlue;

                //Introduce the game's rules

                Console.WriteLine($"You have 10 tries to guess a number between 1 and 100.");
                Console.WriteLine($"In case you type in 10 wrong inputs you lose the game.");
                Console.WriteLine("*****************************");

                StartTheGame start = new StartTheGame();
                start.RunTheGame();

            }
        }
    }
}