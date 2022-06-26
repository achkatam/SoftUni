using System;
using System.Collections.Generic;
using System.Linq;

namespace Computer_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that prints you a receipt for your new computer.You will receive the parts' prices (without tax) until you receive what type of customer this is - special or regular. Once you receive the type of customer you should print the receipt.
            //The taxes are 20 % of each part's price you receive. 
            //If the customer is special, he has a 10 % discount on the total price with taxes.
            //If a given price is not a positive number, you should print "Invalid price!" on the console and continue with the next price.
            //If the total price is equal to zero, you should print "Invalid order!" on the console.

            string customer = Console.ReadLine();
            //add-ons
            double totalPrice = 0;
            double totalPriceWOT = 0;
            double taxes = 0;
            //while special or regular
            while (customer != "special" && customer != "regular")
            {
                //input prices
                double prices = double.Parse(customer);
                if (prices < 0)
                {
                    Console.WriteLine("Invalid price!");

                }
                else
                {
                    totalPriceWOT += prices;
                    taxes += prices * 0.2;

                }

                customer = Console.ReadLine();
            }
            totalPrice = totalPriceWOT + taxes;

            if (totalPrice == 0)
            {
                Console.WriteLine("Invalid order!");

                return;
            }
            if (customer == "special")
            {
                totalPrice -= totalPrice * 0.1;
            }

            Console.WriteLine("Congratulations you've just bought a new computer!");
            Console.WriteLine($"Price without taxes: {totalPriceWOT:f2}$");
            Console.WriteLine($"Taxes: {taxes:f2}$");
            Console.WriteLine("-----------");
            Console.WriteLine($"Total price: {totalPrice:f2}$");
        }
    }
}
