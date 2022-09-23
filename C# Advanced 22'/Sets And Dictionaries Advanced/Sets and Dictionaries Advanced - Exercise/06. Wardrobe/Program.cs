using System;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace _06._Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that helps you decide what clothes to wear from your wardrobe. You will receive the clothes, which are currently in your wardrobe, sorted by their color in the following format:
            //            "{color} -> {item1},{item2},{item3}…"
            //If you receive a certain color, which already exists in your wardrobe, just add the clothes to its records. You can also receive repeating items for a certain color and you have to keep their count.
            //In the end, you will receive a color and a piece of clothing, which you will look for in the wardrobe, separated by a space in the following format:
            //"{color} {clothing}"
            //Your task is to print all the items and their count for each color in the following format: 
            //"{color} clothes:
            //* { item1}
            //            - { count}
            //            * { item2}
            //            - { count}
            //            * { item3}
            //            - { count}
            //…
            //* { itemN}
            //            - { count}
            //            "
            //If you find the item you are looking for, you need to print "(found!)" next to it:
            //"* {itemN} - {count} (found!)"
            //color         <item, occurencies
            var clothes = new Dictionary<string, Dictionary<string, int>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split(new string[] { " -> ", "," }, StringSplitOptions.RemoveEmptyEntries);

                string color = input[0];
                //string cloth = input[1];


                if (!clothes.ContainsKey(color))
                {
                    clothes.Add(color, new Dictionary<string, int>());
                }

                //starts from 1 because 0 would return the color
                for (int j = 1; j < input.Length; j++)
                {
                    string cloth = input[j];

                    if (!clothes[color].ContainsKey(cloth))
                    {
                        clothes[color].Add(cloth, 0);
                    }

                    clothes[color][cloth]++;
                }
            }

            var wantedItem = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var color in clothes)
            {
                Console.WriteLine($"{color.Key} clothes:");

                foreach (var item in color.Value)
                {
                    if (color.Key == wantedItem[0] && item.Key == wantedItem[1])
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value}");
                    }

                }
            }

        }
    }
}
