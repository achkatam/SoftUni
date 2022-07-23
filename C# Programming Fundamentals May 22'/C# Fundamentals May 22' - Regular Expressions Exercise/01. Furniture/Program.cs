using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;
using System.Linq;

namespace _01._Furniture
{
    class Program
    {
        static void Main(string[] args)
        {

            //Create a program to calculate the total cost of different types of furniture. You will be given some lines of input until you receive the line "Purchase". For the line to be valid it should be in the following format:
            //">>{furniture name}<<{price}!{quantity}"
            //The price can be a floating-point number or a whole number.Store the names of the furniture and the total price. At the end print each bought furniture on a separate line in the format:
            //"Bought furniture:
            //{ 1st name}
            //{ 2nd name}
            //…"
            //And on the last line print, the following: "Total money spend: {spend money}" formatted to the second decimal point.

            string pattern = @">>(?<name>[A-Za-z]+)<<(?<price>[0-9]+.?[0-9]*?)!(?<quantity>[0-9]+)";

            //Create a list for furniteres - name 
            var furnitures = new List<string>();

            //variable for total price 
            double totalPrice = 0;

            string command = Console.ReadLine();

            while (command != "Purchase")
            {

                Match match = Regex.Match(command, pattern);

                if (match.Success)
                {
                    string name = match.Groups["name"].Value;
                    double price = double.Parse(match.Groups["price"].Value);
                    int quantity = int.Parse(match.Groups["quantity"].Value);

                    furnitures.Add(name);
                    totalPrice += price * quantity;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Bought furniture:");
            foreach (var furniture in furnitures)
            {
                Console.WriteLine($"{furniture}");
            }
            Console.WriteLine($"Total money spend: {totalPrice:f2}");
        }
    }
}
