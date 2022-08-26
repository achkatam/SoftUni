using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program that helps you decide what clothes to wear from your wardrobe. You will receive the clothes, which are currently in your wardrobe, sorted by their color in the following format:
            //"{color} -> {item1},{item2},{item3}…"
            //If you receive a certain color, which already exists in your wardrobe, just add the clothes to its records. You can also receive repeating items for a certain color and you have to keep their count.
            //In the end, you will receive a color and a piece of clothing, which you will look for in the wardrobe, separated by a space in the following format:

            //new dictionary<color, <clothes, counts of occurencies>>():
            var wardrobe = new Dictionary<string, Dictionary<string, int>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                string color = input.Split(" -> ")[0];

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }

                Dictionary<string, int> clothes = wardrobe[color];

                string[] inputClothes = input.Split(" -> ")[1].Split(",");

                foreach (var cloth in inputClothes)
                {
                    if (!clothes.ContainsKey(cloth))
                    {
                        clothes.Add(cloth, 1);
                    }
                    //Check without else
                    else
                    {
                        clothes[cloth]++;
                    }
                }
            }
            //variable for the cloth we are looking for
            string wantedClothes = Console.ReadLine();//Blue dress

            var wantedColor = wantedClothes.Split(" "
                ,StringSplitOptions.RemoveEmptyEntries)[0];
            var wantedCloth = wantedClothes.Split(" "
                ,StringSplitOptions.RemoveEmptyEntries)[1];

            foreach (var color in wardrobe)
            {
                Console.WriteLine($"{color.Key} clothes:");

                //new Dictionary<cloth, occurencies>
                Dictionary<string, int> clothes = color.Value;
                
                foreach (var cloth in clothes)
                {
                    if (cloth.Key == wantedCloth && color.Key == wantedColor)
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value}");
                    }
                }
            }

        }
    }
}
