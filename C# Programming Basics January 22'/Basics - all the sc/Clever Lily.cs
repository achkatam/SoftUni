using System;

namespace _04._Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            //input

            int age = int.Parse(Console.ReadLine());
            double loundry = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());


            //когато i %2 ==0 => money = i * 5-1; 2г->10лв//4г->20 лв//6г->30лв..усреднено i*5 !!!!!!!
            //когато i %2 !==0 получава играчка на стойност toyPrice
            //data
            double money = 0;
            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    money += (i * 5) - 1;
                }
                else
                {
                    money += toyPrice;
                }

            }
            if (money >= loundry)
            {
                Console.WriteLine($"Yes! {money - loundry:f2}");
            }
            else
            {
                Console.WriteLine($"No! {loundry - money:f2}");
            }

        }
    }
}
