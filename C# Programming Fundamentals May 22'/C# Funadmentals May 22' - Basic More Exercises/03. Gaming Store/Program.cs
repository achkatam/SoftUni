using System;

namespace _03._Gaming_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program, which helps you buy the games. The valid games are the following games in this table:
            //Name        Price
            //OutFall 4   $39.99
            //CS: OG      $15.99
            //Zplinter Zell	$19.99
            //Honored 2   $59.99
            //RoverWatch  $29.99
            //RoverWatch Origins Edition  $39.99
            //On the first line, you will receive your current balance – a floating-point number in the range[0.00…5000.00].
            double currBalance = double.Parse(Console.ReadLine());

            //Until you receive the command "Game Time", you have to keep buying games. When a game is bought, the user’s balance decreases by the price of the game.
            string command = Console.ReadLine();
            //Additionally, the program should obey the following conditions:
            //•	If a game the user is trying to buy is not present in the table above, print "Not Found" and read the next line.
            //•	If at any point, the user has $0 left, print "Out of money!" and end the program.
            //•	Alternatively, if the user is trying to buy a game that they can’t afford, print "Too Expensive" and read the next line.
            //•	If the game exists and the player has the money for it, print "Bought {nameOfGame}"
            //When you receive "Game Time", print the user’s remaining money and total spent on games, rounded to the 2nd decimal place.

            //add-ons
            double spentMoney = 0;
            double gamePrice = 0;

            while (command != "Game Time")
            {

                switch (command)
                {
                    case "OutFall 4":
                        gamePrice = 39.99;
                        if (currBalance > 0 && currBalance >= gamePrice)
                        {
                            spentMoney += gamePrice;
                            currBalance -= gamePrice;
                            Console.WriteLine($"Bought {command}");
                        }
                        else if (currBalance < gamePrice)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        if (currBalance <= 0)
                        {
                            Console.WriteLine("Out of money!");
                            Environment.Exit(0);

                        }
                        break;
                    case "CS: OG":
                        gamePrice = 15.99;
                        if (currBalance > 0 && currBalance >= gamePrice)
                        {
                            spentMoney += gamePrice;

                            currBalance -= gamePrice;
                            Console.WriteLine($"Bought {command}");
                        }
                        else if (currBalance < gamePrice)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        if (currBalance <= 0)
                        {
                            Console.WriteLine("Out of money!");
                            Environment.Exit(0);

                        }
                        break;
                    case "Zplinter Zell":
                        gamePrice = 19.99;
                        if (currBalance > 0 && currBalance >= gamePrice)
                        {
                            spentMoney += gamePrice;

                            currBalance -= gamePrice;
                            Console.WriteLine($"Bought {command}");
                        }
                        else if (currBalance < gamePrice)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        if (currBalance <= 0)
                        {
                            Console.WriteLine("Out of money!");
                            Environment.Exit(0);

                        }
                        break;
                    case "Honored 2":
                        gamePrice = 59.99;
                        if (currBalance > 0 && currBalance >= gamePrice)
                        {
                            spentMoney += gamePrice;

                            currBalance -= gamePrice;
                            Console.WriteLine($"Bought {command}");
                        }
                        else if (currBalance < gamePrice)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        if (currBalance <= 0)
                        {
                            Console.WriteLine("Out of money!");
                            Environment.Exit(0);

                        }
                        break;
                    case "RoverWatch":
                        gamePrice = 29.99;
                        if (currBalance > 0 && currBalance >= gamePrice)
                        {
                            spentMoney += gamePrice;

                            currBalance -= gamePrice;
                            Console.WriteLine($"Bought {command}");
                        }
                        else if (currBalance < gamePrice)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        if (currBalance <= 0)
                        {
                            Console.WriteLine("Out of money!");
                            Environment.Exit(0);

                        }
                        break;
                    case "RoverWatch Origins Edition":
                        gamePrice = 39.99;
                        if (currBalance > 0 && currBalance >= gamePrice)
                        {
                            spentMoney += gamePrice;

                            currBalance -= gamePrice;
                            Console.WriteLine($"Bought {command}");
                        }
                        else if (currBalance < gamePrice)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        if (currBalance <= 0)
                        {
                            Console.WriteLine("Out of money!");
                            Environment.Exit(0);
                        }
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        break;
                        //OutFall 4   $39.99
                        //CS: OG      $15.99
                        //Zplinter Zell	$19.99
                        //Honored 2   $59.99
                        //RoverWatch  $29.99
                        //RoverWatch Origins Edition  $39.99
                }

                command = Console.ReadLine();
            }
            Console.WriteLine($"Total spent: ${spentMoney:f2}. Remaining: ${Math.Abs(currBalance):f2}");
            
        }
    }
}
