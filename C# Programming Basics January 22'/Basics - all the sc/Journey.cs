using System;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            /* Бюджета определя дестинацията, а сезона определя колко от бюджета ще изхарчи. Ако е лято ще почива на къмпинг, а зимата в хотел. Ако е в Европа, независимо от сезона ще почива в хотел. Всеки къмпинг или хотел, според дестинацията, има собствена цена която отговаря на даден процент от бюджета: 
            	При 100лв. или по-малко – някъде в България
            	Лято – 30% от бюджета
            	Зима – 70% от бюджета
            	При 1000лв. или по малко – някъде на Балканите
            	Лято – 40% от бюджета
            	Зима – 80% от бюджета
            	При повече от 1000лв. – някъде из Европа
            	При пътуване из Европа, независимо от сезона ще похарчи 90% от бюджета. */
            string location = string.Empty;
            string stay = string.Empty;
            double price = 0;
            switch (season)
            {
                case "summer":
                    if (budget <= 100)
                    {
                        location = "Bulgaria";
                        stay = "Camp";
                         price= budget  -  (budget * 0.3);
                    }                    
                    else if (budget <= 1000)
                    {
                        location = "Balkans";
                        stay = "Camp";
                        price = budget - (budget * 0.4);
                    }
                    else if ( budget > 1000)
                    {
                        location = "Europe";
                        stay = "Hotel";
                        price = budget - (budget * 0.9);
                    }
                    break;
                case "winter":
                    if (budget <= 100)
                    {
                        location = "Bulgaria";
                        stay = "Hotel";
                        price = budget - (budget * 0.7);
                    }
                    else if (budget <= 1000)
                    {
                        location = "Balkans";
                        stay = "Hotel";
                        price = budget - (budget * 0.8);
                    }
                    else if (budget > 1000)
                    {
                        location = "Europe";
                        stay = "Hotel";
                        price = budget - (budget * 0.9);
                    }
                    break;
            }
            //output
            Console.WriteLine($"Somewhere in {location}");
            Console.WriteLine($"{stay} - {budget - price:f2}");
        }
    }
}
