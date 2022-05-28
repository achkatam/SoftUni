using System;

namespace Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            //You have a water tank with a capacity of 255 liters.On the next n lines, you will receive liters of water, which you have to pour into your tank.If the capacity is not enough, print "Insufficient capacity!" and continue reading the next line. On the last line, print the liters in the tank.
            //Input
            //The input will be on two lines:
            //•	On the first line, you will receive n – the number of lines, which will follow
            //•	On the next n lines, you will receive quantities of water, which you have to pour into the tank
            //Output
            //Every time you do not have enough capacity in the tank to pour the given liters, print:
            //Insufficient capacity!
            //On the last line, print only the liters in the tank.

            //input
            //creaeting const for the capacity,its value  won't be changed
            const int CAPACITY = 255;
            int nLines = int.Parse(Console.ReadLine());
            //add-ons
            int totalQuantity = CAPACITY;

            for (int i = 0; i < nLines; i++)
            {
                int currentQuantity = int.Parse(Console.ReadLine());
                if (totalQuantity - currentQuantity >= 0)
                {
                    totalQuantity -= currentQuantity;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            int totalFieldQuantity = CAPACITY - totalQuantity;
            Console.WriteLine(totalFieldQuantity);

        }
    }
}
