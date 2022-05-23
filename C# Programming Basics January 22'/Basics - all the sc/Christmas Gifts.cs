using System;

namespace _05._Christmas_Gifts
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            int age = 0;
            double toyPrice = 5;
            double sweatersPrice = 15;
            int adultsCounts = 0;
            int kidsCounts = 0;

            string command = Console.ReadLine();
            while (command !="Christmas")
            {
                age = int.Parse(command);
                if (age <= 16)
                {
                    kidsCounts++;

                }
                else
                {
                    adultsCounts++;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Number of adults: {adultsCounts}");
            Console.WriteLine($"Number of kids: {kidsCounts}");
            Console.WriteLine($"Money for toys: {toyPrice*kidsCounts}");
            Console.WriteLine($"Money for sweaters: {sweatersPrice*adultsCounts}");

        }
    }
}
