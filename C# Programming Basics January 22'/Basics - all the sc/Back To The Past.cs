using System;

namespace _01._Back_To_The_Past
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            double heritage = double.Parse(Console.ReadLine());
            int yearToLive = int.Parse(Console.ReadLine());

            int age = 18;



            for (int i = 1800; i <= yearToLive; i++)
            {


                if (i % 2 == 0)
                {

                    heritage -= 12000;

                }
                else
                {
                    heritage -= 12000 + (50 * age);
                }
                age += 1;
            }
            if (heritage >= 0)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {heritage:f2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {Math.Abs(heritage):f2} dollars to survive.");
            }


        }
    }
}
