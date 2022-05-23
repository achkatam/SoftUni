using System;

namespace _03._Computer_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Март до Май Юни до Август
            // Ден    10.50 лв / ч  12.60 лв / ч
            // Нощ    8.40 лв / ч   10.20 лв / ч
            //Предлагат се и следните отстъпки в следната последователност:
            //•	За група от четирима или повече човека, цената на човек се намаля с 10 %
            //•	За 5 или повече часа прекарани, цената на човек се намаля с 50 %
            //Да се напише програма, която изчислява цената на човек за час и общата сума.

            //input
            string month = Console.ReadLine();
            int hoursSpent = int.Parse(Console.ReadLine());
            int pplCount = int.Parse(Console.ReadLine());
            string timeOfTheDay = Console.ReadLine();

            double price = 0;
            switch (month)
            {
                case "march":
                case "april":
                case "may":
                    switch (timeOfTheDay)
                    {
                        case "day":
                            price = 10.50;
                            break;
                        case "night":
                            price = 8.40;
                            break;
                    }
                    break;
                case "june":
                case "july":
                case "august":
                    switch (timeOfTheDay)
                    {
                        case "day":
                            price = 12.60;
                            break;
                        case "night":
                            price = 10.20;
                            break;
                    }
                    break;
            }
            if (pplCount >= 4)
            {
                price -= price * 0.1;
            }
            if (hoursSpent >= 5)
            {
                price -= (price * 0.5) ;
            }
            double finalPrice = (price * pplCount) * hoursSpent;

            Console.WriteLine($"Price per person for one hour: {price:f2}");
            Console.WriteLine($"Total cost of the visit: {finalPrice:f2}");
        }
    }
}
