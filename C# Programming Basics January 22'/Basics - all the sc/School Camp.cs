using System;

namespace School_Camp
{
    class Program
    {
        static void Main(string[] args)
        {
            double price = 0;
            //input
            string season = Console.ReadLine();
            string gender = Console.ReadLine();
            int students = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            string girlsWinter = "Gymnastics";
            string girlsSpring = "Athletics";
            string girlsSummer = "Volleyball";
            string boysWinter = "Judo";
            string boysSpring = "Tennis";
            string boysSummer = "Football";
            string mixedWinter = "Ski";
            string mixedSpring = "Cycling";
            string mixedSummer = "Swimming";
            var sport = "";
            switch (season)
            {
                case "Winter":


                    if (gender == "boys")
                    {
                        price = students * 9.60 * nights;
                        sport = boysWinter;                        
                        break;
                    }

                    else if (gender == "girls")
                    {
                        price = students * 9.60 * nights;
                        sport = girlsWinter;
                    }
                    else if (gender == "mixed")
                    {
                        price = students * 10 * nights;
                        sport = mixedWinter;
                    }
                    break;
                case "Spring":
                    if (gender == "boys")
                    {
                        price = students * 7.20 * nights;
                        sport = boysSpring;
                    }
                    else if (gender == "girls")
                    {
                        price = students * 7.20 * nights;
                        sport = girlsSpring;
                    }
                    else if (gender == "mixed")
                    {
                        price = students * 9.50 * nights;
                        sport = mixedSpring;                        
                    }
                    break;
                case "Summer":
                    if (gender == "boys")
                    {
                        price = students * 15 * nights;
                        sport = boysSummer;
                    }
                    else if (gender == "girls")
                    {
                        price = students * 15 * nights;
                        sport = girlsSummer;
                    }
                    else if (gender == "mixed")
                    {
                        price = students * 20 * nights;
                        sport = mixedSummer;
                    }
                    break;

            }
            if (students >= 50)
            {
                price = price * 0.50;
            }
            else if (students >= 20 && students < 50)
            {
                price = price - price * 0.15;
            }
            else if (students >= 10 && students < 20)
            {
                price = price - price * 0.05;
            }
            Console.WriteLine($"{sport} {price:f2} lv.");


        }
    }
}
