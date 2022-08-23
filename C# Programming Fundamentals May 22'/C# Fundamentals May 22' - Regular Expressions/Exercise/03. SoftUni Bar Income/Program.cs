using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;
using System.Linq;


namespace _03._SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            //Let's take a break and visit the game bar at SoftUni. It is about time for the people behind the bar to go home and you are the person who has to draw the line and calculate the money from the products that were sold throughout the day. Until you receive a line with the text "end of shift" you will be given lines of input. But before processing that line you have to do some validations first.
            //Each valid order should have a customer, product, count, and a price:
            //•	A valid customer's name should be surrounded by ' % ' and must start with a capital letter, followed by lower-case letters
            //•	A valid product contains any word character and must be surrounded by '<' and '>'
            //•	A valid count is an integer, surrounded by '|'
            //•	A valid price is any real number followed by '$'
            //The parts of a valid order should appear in the order given: customer, product, count, and price.
            //Between each part there can be other symbols, except ('|', '$', '%' and '.')

            //"%(?<name>[A-z][a-z]+)%[^|$%.]*<(?<product>[\w]+)>[^|$%.]*\|(?<quantity>[\d]+)\|[^|$%.]*?(?<price>[\d]+.?[\d+])?\$"

            string pattern = @"%(?<name>[A-z][a-z]+)%[^|$%.]*<(?<product>[\w]+)>[^|$%.]*\|(?<quantity>[\d]+)\|[^|$%.]*?(?<price>[\d]+.?[\d]+)?\$";

            string input = Console.ReadLine();

            double totalIncome = 0;

            while (input != "end of shift")
            {
                Regex regex = new Regex(pattern);

                bool isValid = regex.IsMatch(input);

                if (isValid)
                {
                    string customer = regex.Match(input).Groups["name"].Value;
                    string product = regex.Match(input).Groups["product"].Value;
                    int quantity = int.Parse(regex.Match(input).Groups["quantity"].Value);

                    double price = double.Parse(regex.Match(input).Groups["price"].Value);

                    double totalPrice = price * quantity;
                    totalIncome += totalPrice;
                    Console.WriteLine($"{customer}: {product} - {totalPrice:f2}");
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"Total income: {totalIncome:f2}");

        }
    }
}
