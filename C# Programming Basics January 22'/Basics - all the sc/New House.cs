using System;

namespace New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            string flower = Console.ReadLine();
            int countOfFlower = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double price = 0;

            /*цвете	Роза	Далия	Лале	Нарцис	Гладиола
         Цена на б	5	3.80	2.80	3	2.50*/

            switch (flower)
            {
                case "Roses":
                    price = countOfFlower * 5;
                    if( countOfFlower > 80)
                    {
                        price -= price * 0.1;
                    }
                    break;
                case "Dahlias":
                    price = countOfFlower * 3.8;
                    if (countOfFlower > 90)
                    {
                        price -= price * 0.15;
                    }
                    break;
                case "Tulips":
                    price = countOfFlower * 2.8;
                    if (countOfFlower > 80)
                    {
                        price -= price * 0.15;
                    }
                    break;
                case "Narcissus":
                    price = countOfFlower * 3;
                    if (countOfFlower < 120)
                    {
                        price += price * 0.15;
                    }
                    break;
                case "Gladiolus":
                    price = countOfFlower * 2.5;
                    if(countOfFlower < 80)
                    {
                        price += price * 0.2;
                    }
                    break;
            }
            if( budget >= price)
            {
                Console.WriteLine($"Hey , you have a great garden with {countOfFlower} {flower} and {budget-price:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {price - budget:f2} leva more.");
            }
        }
    }
}
