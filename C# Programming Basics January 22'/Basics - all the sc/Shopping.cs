using System;

namespace Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            double budget = double.Parse(Console.ReadLine());

            int videocardQuantity = int.Parse(Console.ReadLine());
            int processorQuantity = int.Parse(Console.ReadLine());
            int ramMemoryQuantity = int.Parse(Console.ReadLine());

            //prices
            double videocardPrice = videocardQuantity * 250;
            double processorPrice = processorQuantity * (videocardPrice * 0.35);
            double ramMemoryPrice = ramMemoryQuantity * (videocardPrice * 0.10);

            double totalPrice = videocardPrice + processorPrice + ramMemoryPrice;

            //Conditional check
            if (videocardQuantity > processorQuantity)
            {
                totalPrice = totalPrice - (totalPrice * 0.15);
            }

            double difference = budget - totalPrice;

            if (difference >= 0)
            {
                Console.WriteLine($"You have {difference:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(difference):f2} leva more!");
            }
            
            
        }
    }
}

