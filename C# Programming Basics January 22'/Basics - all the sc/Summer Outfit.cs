using System;

namespace Summer_outfit
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Лято е с много променливо време и Виктор има нужда от вашата помощ.Напишете програма която спрямо времето от денонощието и градусите да препоръча на Виктор какви дрехи да си облече. Вашия приятел има различни планове за всеки етап от деня, които изискват и различен външен вид, тях може да видите от таблицата.
 От конзолата се четат точно два реда:
 •	Градусите - цяло число в интервала[10…42]
 •	Текст, време от денонощието - с възможности - "Morning", "Afternoon", "Evening"
 Време от денонощието / градуси
 Мorning
 Afternoon
 Evening
 10 <= градуси <= 18 Outfit = Sweatshirt
 Shoes = Sneakers    Outfit = Shirt
 Shoes = Moccasins   Outfit = Shirt
 Shoes = Moccasins
 18 < градуси <= 24  Outfit = Shirt
 Shoes = Moccasins   Outfit = T - Shirt
 Shoes = Sandals Outfit = Shirt
 Shoes = Moccasins
 градуси >= 25   Outfit = T - Shirt
 Shoes = Sandals Outfit = Swim Suit
 Shoes = Barefoot    Outfit = Shirt
 Shoes = Moccasins
 Да се отпечата на конзолата на един ред: "It's {градуси} degrees, get your {облекло} and {обувки}." */

            int temp = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();
            string Outfit = string.Empty;
            string Shoes = string.Empty;
            switch (time)
            {
                case "Morning":
                    if (temp >= 10 && temp <= 18)
                    {
                        Outfit = "Sweatshirt";
                        Shoes = "Sneakers";
                    }
                    else if (temp > 18 && temp <= 24)
                    {
                        Outfit = "Shirt";
                        Shoes = "Moccasins";
                    }
                    else
                    {
                        Outfit = "T-shirt";
                        Shoes = "Sandals";
                    }
                    break;
                case "Afternoon":
                    if (temp >= 10 && temp <= 18)
                    {
                        Outfit = "Shirt";
                        Shoes = "Moccasins";
                    }
                    else if (temp > 18 && temp <= 24)
                    {
                        Outfit = "T-Shirt";
                        Shoes = "Sandals";
                    }
                    else
                    {
                        Outfit = "Swim suit";
                        Shoes = "Barefoot";
                    }
                    break;
                case "Evening":
                    Outfit = "Shirt";
                    Shoes = "Moccasins";
                    break;

            }
            Console.WriteLine($"It's {temp} degrees, get your {Outfit} and {Shoes}.");
        }
    }
}
