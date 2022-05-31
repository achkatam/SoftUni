using System;

namespace Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {

            //Write a program that accumulates coins. Until the "Start" command is given, you will receive coins, and only the valid ones should be accumulated.Valid coins are:
            //•	0.1, 0.2, 0.5, 1, and 2
            //If an invalid coin is inserted, print "Cannot accept {money}" and continue to the next line.
            //On the next lines, until the "End" command is given you will start receiving products, which a customer wants to buy.The vending machine has only:
            //•	"Nuts" with a price of 2.0
            //•	"Water" with a price of 0.7
            //•	"Crisps" with a price of 1.5
            //•	"Soda" with a price of 0.8
            //•	"Coke" with a price of 1.0
            //If the customer tries to purchase a not existing product print "Invalid product".
            //When a customer has enough money to buy the selected product, print "Purchased {product name}", otherwise print "Sorry, not enough money", and continue to the next line.
            //When the "End" command is given print the reminding balance, formatted to the second decimal point: "Change: {money left}".

            //First Solution - most common
            //input
            //string command = Console.ReadLine();

            //double totalMoneyAccumulated = 0;
            //while (command != "Start")
            //{
            //    double coin = double.Parse(command);
            //    if (coin == 0.1 || coin == 0.2 || coin == 0.5 || coin == 1 || coin == 2)
            //    {
            //        totalMoneyAccumulated += coin;
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Cannot accept {coin}");
            //    }
            //    command = Console.ReadLine();
            //}
            //command = Console.ReadLine();
            //double totalPrice = 0;

            //while (command != "End")
            //{
            //    switch (command)
            //    {
            //        case "Nuts":
            //            totalPrice = 2;
            //            break;
            //        case "Water":
            //            totalPrice = 0.7;
            //            break;
            //        case "Crisps":
            //            totalPrice = 1.5;
            //            break;
            //        case "Soda":
            //            totalPrice = 0.8;
            //            break;
            //        case "Coke":
            //            totalPrice = 1;
            //            break;
            //        default:
            //            Console.WriteLine($"Invalid product");
            //            command = Console.ReadLine();
            //            continue;
            //    }

            //    if (totalMoneyAccumulated >= totalPrice)
            //    {
            //        totalMoneyAccumulated -= totalPrice;
            //        Console.WriteLine($"Purchased {command.ToLower()}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Sorry, not enough money");
            //    }

            //    command = Console.ReadLine();
            //}

            //Console.WriteLine($"Change: {totalMoneyAccumulated:f2}");

            //Second Solution using arrays[]
            //Creating arrays
            string[] products = new string[5] { "Nuts", "Water", "Crisps", "Soda", "Coke" };
            double[] prices = new double[5] { 2, 0.7, 1.5, 0.8, 1 };

            double[] coins = new double[] { 0.1, 0.2, 0.5, 1, 2 };

            double coin = 0;
            double balance = 0;
            //input
            string input = "";
            while ((input = Console.ReadLine()) != "Start")
            {
                coin = double.Parse(input);

                if (coins.Contains(coin))
                {
                    balance += coin;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coin}");
                }
            }

            while ((input = Console.ReadLine()) != "End")
            {
                if (!products.Contains(input))
                {
                    Console.WriteLine("Invalid product");
                    continue;
                }

                for (int productNum = 0; productNum < 5; productNum++)
                {
                    if (input == products[productNum])
                    {
                        if (balance - prices[productNum] < 0)
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        else
                        {
                            Console.WriteLine($"Purchased {input.ToLower()}");
                            balance -= prices[productNum];
                        }
                        break;
                    }
                }

            }
            Console.WriteLine($"Change: {balance:f2}");
        }
    }
}
