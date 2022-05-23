using System;

namespace Basketball
{
    class Program
    {
        static void Main(string[] args)
        {
            //input 
            int fee = int.Parse(Console.ReadLine());

            //calculations
            double sneakers = fee - (fee * 0.40);
            double jersey = sneakers - (sneakers * 0.20);
            double ball = jersey * 0.25;
            double accessories = ball * 0.20;
            double total = fee + sneakers + jersey + ball + accessories;

            //output
            Console.WriteLine(total);
        }
    }
}
