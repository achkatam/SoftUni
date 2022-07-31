using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;
using System.Linq;

namespace A02._Ad_Astra
{
    class Program
    {
        static void Main(string[] args)
        {
            //On the first line of the input, you will be given a text string. You must extract the information about the food and calculate the total calories. 
            string input = Console.ReadLine();

            //Calculate the total calories of all food items and then determine how many days you can last with the food you have. Keep in mind that you need 2000kcal a day.

            string pattern = @"(?<sep>\||#)(?<itemName>[A-Za-z\s]+)\1(?<date>\d{2}/\d{2}/\d{2})\1(?<calories>\d+)\1";
            int totalCals = 0;

            MatchCollection products = Regex.Matches(input, pattern);

            foreach (Match match in products)
            {
                string itemName = match.Groups["itemName"].Value;
                string date = match.Groups["date"].Value;
                int calories = int.Parse(match.Groups["calories"].Value);

                totalCals += calories;
            }

            int days = totalCals / 2000;

            //•	First, print the number of days you will be able to last with the food you have:
            Console.WriteLine($"You have food to last you for: {days} days!");

            //"Item: {item name}, Best before: {expiration date}, Nutrition: {calories}"
            Console.WriteLine(string.Join("\n", products
                .Select(x => $"Item: {x.Groups["itemName"].Value}, Best before: {x.Groups["date"].Value}, Nutrition: {x.Groups["calories"].Value}")));

        }
    }
}
