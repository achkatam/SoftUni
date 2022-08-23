using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {

            //input
            int pplCnt = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string day = Console.ReadLine();

            //add-ons
            double price = 0;

            if (groupType == "Students")
            {
                if (day == "Friday")
                {
                    price = pplCnt * 8.45;
                }
                else if (day == "Saturday")
                {
                    price = pplCnt * 9.8;
                }
                else if (day == "Sunday")
                {
                    price = pplCnt * 10.46;
                }
                if (pplCnt >= 30)
                {
                    price -= price * 0.15;
                }

            }
            else if (groupType == "Business")
            {
                if (day == "Friday")
                {
                    price = pplCnt * 10.9;
                }
                else if (day == "Saturday")
                {
                    price = pplCnt * 15.6;
                }
                else if (day == "Sunday")
                {
                    price = pplCnt * 16;
                }
                if (pplCnt >= 100)
                {
                    price -= price / pplCnt * 10;
                }

            }
            else if (groupType == "Regular")
            {
                if (day == "Friday")
                {
                    price = pplCnt * 15;
                }
                else if (day == "Saturday")
                {
                    price = pplCnt * 20;
                }
                else if (day == "Sunday")
                {
                    price = pplCnt * 22.50;
                }
                if (pplCnt >= 10 && pplCnt <= 20)
                {
                    price -= price * 0.05;
                }

            }
            Console.WriteLine($"Total price: {price:f2}");

        }
    }
}
