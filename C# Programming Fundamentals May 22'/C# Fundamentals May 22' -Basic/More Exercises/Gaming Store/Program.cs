using System;

namespace Gaming_Store_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            double currBalance = double.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            //add-ons
            double gamePrice = 0;
            double spentMoney = 0;

            while (command != "Game Time")
            {

                switch (command)
                {
                    case "OutFall 4":
                        gamePrice = 39.99;
                        break;
                    case "CS: OG":
                        gamePrice = 15.99;
                        break;
                    case "Zplinter Zell":
                        gamePrice = 19.99;
                        break;
                    case "Honored 2":
                        gamePrice = 59.99;
                        break;
                    case "RoverWatch":
                        gamePrice = 29.99;
                        break;
                    case "RoverWatch Origins Edition":
                        gamePrice = 39.99;
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        break;
                }

                if (currBalance - gamePrice < 0)
                {
                    Console.WriteLine("Too Expensive");
                }
                else
                {
                    currBalance -= gamePrice;
                    spentMoney += gamePrice;
                    Console.WriteLine($"Bought {command}");
                }

                if (currBalance == 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Total spent: ${spentMoney:f2}. Remaining: ${currBalance:f2}");
        }
    }
}
