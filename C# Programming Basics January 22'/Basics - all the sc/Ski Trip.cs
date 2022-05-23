using System;

namespace Ski_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            int days = int.Parse(Console.ReadLine()) - 1 ;
            string unitType = Console.ReadLine();
            string grade = Console.ReadLine();

            /* вид помещение	по-малко от 10 дни	между 10 и 15 дни	повече от 15 дни
          room for one person	не ползва намаление	не ползва намаление	не ползва намаление
          apartment          	30% от крайната цена	35% от крайната цена	50% от крайната цена
          president apartment	10% от крайната цена	15% от крайната цена	20% от крайната цена */

            //add-ins
            double price = 0;

            switch (unitType)
            {
                case "room for one person":
                    price = 18 * days;                   
                    break;
                case "apartment":
                    price = 25 * days;
                    if (days < 10)
                    {
                        price -= price * 0.3;
                    }
                    else if ( days >= 10 && days <=15)
                    {
                        price -= price * 0.35;
                    }
                    else
                    {
                        price -= price * 0.5;
                    }
                    break;
                case "president apartment":
                    price = 35 * days;
                    if (days < 10)
                    {
                        price -= price * 0.1;
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        price -= price * 0.15;
                    }
                    else
                    {
                        price -= price * 0.20;
                    }
                    break;
            }
            if (grade == "positive")
            {
                price += price * 0.25;
            }
            else
            {
                price -= price * 0.1;
            }
            Console.WriteLine($"{price:f2}");
        }
    }
}
