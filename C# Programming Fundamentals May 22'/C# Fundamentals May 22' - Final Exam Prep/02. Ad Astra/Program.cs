using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace _02._Ad_Astra
{
    class Program
    {
        static void Main(string[] args)
        {
            //On the first line of the input, you will be given a text string. You must extract the information about the food and calculate the total calories. 
            //First, you must extract the food info. It will always follow the same pattern rules:
            //•	It will be surrounded by "|" or "#"(only one of the two) in the following pattern:
            //#{item name}#{expiration date}#{calories}#   or 
            //|{ item name}|{ expiration date}|{ calories}|
            //•	The item name will contain only lowercase and uppercase letters and whitespace
            //•	The expiration date will always follow the pattern: "{day}/{month}/{year}", where the day, month, and year will be exactly two digits long
            //•	The calories will be an integer between 0 - 10000
            //Calculate the total calories of all food items and then determine how many days you can last with the food you have. Keep in mind that you need 2000kcal a day.

            string pattern = @"([#|])(?<name>[A-Za-z\s]+)\1(?<date>[\d]{2}[\/][\d]{2}[\/][\d]{2})\1(?<calories>[\d]+)\1";

            string input = Console.ReadLine();

            const int MAX_CALORIES = 2000;

            int totalCalories = 0;

            MatchCollection matches = Regex.Matches(input, pattern, RegexOptions.IgnoreCase);


            for (int i = 0; i < matches.Count; i++)
            {
                string name = matches[i].Groups["name"].Value;
                string date = matches[i].Groups["date"].Value;
                int calories = int.Parse(matches[i].Groups["calories"].Value);

                totalCalories += calories;
            }
            int days = totalCalories / MAX_CALORIES;

            //"You have food to last you for: {days} days!"
            Console.WriteLine($"You have food to last you for: {days} days!");
            //•	The output for each food item should look like this:
            //"Item: {item name}, Best before

            Console.WriteLine(string.Join("\n", matches
                .Select(x => $"Item: {x.Groups["name"].Value}, Best before: {x.Groups["date"].Value}, Nutrition: {x.Groups["calories"].Value}")));

        }
    }
}
