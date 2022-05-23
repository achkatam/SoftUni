using System;

namespace Rent_A_Car
{
    class Program
    {
        static void Main(string[] args)
        {
            /* if budget<= 100
             * string class - economy
             * case summer - cabrio 35% budget
             * case winter - jeep 65% budget*/

            /* if budget >100 && <= 500
             * string class - compact
             * case summer - cabrio 45% budget
             * case winter jeep 80% budget*/

            /*if budget > 500
             * string class - luxury class
             * case summer jeep 90% budget
             * case winter jeep 90% bydget*/

            /* console.writeline(class)
             * console.writeline("{type of car}" - {budget%:f2}"*/

            //input
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double price = 0;
            string clasS1 = "Economy class";
            string clasS2 = "Compact class";
            string clasS3 = "Luxury class";
            string typeOfCar1 = "Cabrio";
            string typeOfCar2 = "Jeep";

            switch(season)
            {
                
                case "Summer":
                    if (budget <= 100)                        
                    {
                        string clasS = clasS1;
                        string typeOfCar = typeOfCar1;
                        price = budget * 0.35;
                        Console.WriteLine(clasS);
                        Console.WriteLine($"{typeOfCar} - {price:f2}");
                    }
                    else if (budget > 100 && budget <= 500)
                    {
                        string clasS = clasS2;
                        string typeOfCar = typeOfCar1;
                        price = budget * 0.45;
                        Console.WriteLine(clasS);
                        Console.WriteLine($"{typeOfCar} - {price:f2}");
                    }
                    else if ( budget > 500)
                    {
                        string clasS = clasS3;
                        string typeOfCar = typeOfCar2;
                        price = budget * 0.9;
                        Console.WriteLine(clasS);
                        Console.WriteLine($"{typeOfCar} - {price:f2}");
                    }
                    break;
                case "Winter":
                    if (budget <= 100)
                    {
                        string clasS = clasS1;
                        string typeOfCar = typeOfCar2;
                        price = budget * 0.65;
                        Console.WriteLine(clasS);
                        Console.WriteLine($"{typeOfCar} - {price:f2}");
                    }
                    else if (budget >100 && budget <= 500)
                    {
                        string clasS = clasS2;
                        string typeOfCar = typeOfCar2;
                        price = budget * 0.80;
                        Console.WriteLine(clasS);
                        Console.WriteLine($"{typeOfCar} - {price:f2}");
                    }
                    else if (budget > 500)
                    {
                        string clasS = clasS3;
                        string typeOfCar = typeOfCar2;
                        price = budget * 0.9;
                        Console.WriteLine(clasS);
                        Console.WriteLine($"{typeOfCar} - {price:f2}");
                    }
                    break;                   
            }                         
        }
    }
}

