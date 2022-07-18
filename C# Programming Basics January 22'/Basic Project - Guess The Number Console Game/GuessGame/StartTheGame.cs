using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Guess_The_Number;

namespace Guess_The_Number
{
    class StartTheGame
    {
        public void RunTheGame()
        {
            Random random = new Random();
            int number = random.Next(1, 100);

            //Now the guess by the player
            Console.WriteLine($"Type in your number:");
            int guessNumber = int.Parse(Console.ReadLine());

            while (guessNumber != number)
            {
                for (int triesCntr = 9; triesCntr >= 1; triesCntr--)
                {
                    Console.WriteLine($"Your guess was: {guessNumber}");
                    if (guessNumber > number)
                    {
                        Console.WriteLine($"Go lower.");
                    }
                    else if (number > guessNumber)
                    {
                        Console.WriteLine($"Go up.");
                    }
                    else if (guessNumber == number)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"Congrats. You guessed the number.");
                        Console.WriteLine($"YOU WON THE GAME!!!");
                        break;
                    }
                    if (triesCntr == 1)
                    {
                        Console.WriteLine($"You typed in a wrong number. Please try again. This is your last try!!!");
                    }
                    else if (triesCntr > 1)
                    {
                        Console.WriteLine($"You typed in a wrong number. Please try again. You have {triesCntr} tries left.");
                    }
                    else
                    {
                        Console.WriteLine($"You lost. You typed in wrong number too many times.");
                    }
                    guessNumber = int.Parse(Console.ReadLine());

                }

                Restart();
                //Environment.Exit(0);
            }
        }
        public void Restart()
        {
            Console.WriteLine($"Would you like to play again?");
            //Introduce the options
            Console.WriteLine($"Available options are: [Y]es or [N]o !");
            string playerAnswer = Console.ReadLine();
            if (playerAnswer == "Y".ToLower() || playerAnswer == "Yes".ToLower())
            {
                Console.WriteLine($"Thank you for playing again! Better luck this time!");
                RunTheGame();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Thank you for playing !\nI hope you enjoyed the game!");
                Environment.Exit(0);
            }
        }

    }
}
