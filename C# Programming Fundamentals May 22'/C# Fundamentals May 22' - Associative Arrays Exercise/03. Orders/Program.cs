using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.Design;

namespace _03._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program that keeps the information about products and their prices. Each product has a name, a price and a quantity. If the product doesn't exist yet, add it with its starting quantity.
            //If you receive a product, which already exists, increase its quantity by the input quantity and if its price is different, replace the price as well.
            //You will receive products' names, prices and quantities on new lines. Until you receive the command "buy", keep adding items. When you do receive the command "buy", print the items with their names and the total price of all the products with that name.
            //Input
            //•	Until you receive "buy", the products will be coming in the format: "{name} {price} {quantity}".
            //•	The product data is always delimited by a single space.
            //Output
            //•	Print information about each product in the following format:
            //"{productName} -> {totalPrice}"
            //•	Format the average grade to the 2nd digit after the decimal separator.

            //Create 2 dictionaries
            var orders = new Dictionary<string, double>();
            var newOrders = new Dictionary<string, int>();

            var input = Console.ReadLine();

            while (input != "buy")
            {
                var cmd = input.Split();

                var productName = cmd[0];
                //price of the product
                double price = double.Parse(cmd[1]);
                int quantity = int.Parse(cmd[2]);

                if (!orders.ContainsKey(productName))
                {
                    orders[productName] = price;
                    newOrders.Add(productName, quantity);
                }
                //re-write the price
                else if(orders.ContainsKey(productName))
                {
                    orders.Remove(productName);
                    orders.Add(productName, price);
                    newOrders[productName] += quantity;
                }
                input = Console.ReadLine();
            }

            foreach (var order in orders)
            {
                foreach (var item in newOrders)
                {
                    if(order.Key == item.Key)
                    {
                        Console.WriteLine($"{order.Key} -> {order.Value * item.Value:f2}");
                    }
                }
            }
        }
    }
}
