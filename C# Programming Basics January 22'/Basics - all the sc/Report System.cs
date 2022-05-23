using System;

namespace Report_System
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            int expectedSum = int.Parse(Console.ReadLine());

            double cashSum = 0;
            double cardSum = 0;
            int cashCounter = 0;
            int cardCounter = 0;
            int transactioncCoun = 0;
            string command = string.Empty;
            double totalSum = 0;

            while (totalSum <= expectedSum)
            {
                command = Console.ReadLine();
                transactioncCoun++;
                if (command == "End")
                {
                    if (expectedSum > totalSum)
                    {
                        Console.WriteLine($"Failed to collect required money for charity.");
                        break;
                    }
                }
                double amountMoney = double.Parse(command);
                if (transactioncCoun % 2 == 0) //card
                {
                    if (amountMoney < 10)
                    {
                        Console.WriteLine($"Error transaction!");
                    }
                    else
                    {
                        cardCounter++;
                        cardSum +=(int)amountMoney;
                    }
                }
                else
                {
                    if (amountMoney > 100)
                    {
                        Console.WriteLine($"Error transaction!");
                    }
                    else
                    {
                        cashCounter++;
                        cashSum += (int)amountMoney;
                    }
                }
                totalSum =(int) cashSum + cardSum;
                if (totalSum >= expectedSum)
                {
                    Console.WriteLine($"Average CS: {cashSum / cashCounter:f2}");
                    Console.WriteLine($"Average CC: {cardSum/ cashCounter:f2}");
                    break;
                }

            }

        }
    }
}
