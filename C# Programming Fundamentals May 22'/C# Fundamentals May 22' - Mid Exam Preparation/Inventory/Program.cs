using System;
using System.Collections.Generic;
using System.Linq;

namespace Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            //You will receive a journal with some collecting items, separated with a comma and a space(", ").After that, until receiving "Craft!" you will be receiving different commands split by " - ":

            var items = Console.ReadLine().Split(", ").ToList();

            string command = Console.ReadLine();

            while (command != "Craft!")
            {
                string[] tokens = command.Split(" - ",StringSplitOptions.RemoveEmptyEntries);
                string cmd = tokens[0];

                switch (cmd)
                {
                    /*•	"Collect - {item}" */
                    case "Collect":
                        Collect(items, tokens[1]);
                        break;
                    /*•	"Drop - {item}" */
                    case "Drop":
                        Drop(items, tokens[1]);
                        break;
                    /*•	"Combine Items - {old_item}:{new_item}"*/
                    case "Combine Items":
                        string[] cmdd = tokens[1].Split(":");
                        string oldItem = cmdd[0];
                        string newItem = cmdd[1];
                        if (items.Contains(oldItem))
                        {
                            int index = items.IndexOf(oldItem);
                            items.Insert(index + 1, newItem);
                        }
                        break;
                    /*•	"Renew – {item}"*/
                    case "Renew":
                        Renew(items, tokens[1]);
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", items));
        }

        private static void Renew(List<string> items, string staff)
        {
            /*•	"Renew – {item}" – if the given item exists, you should change its position and put it last in your inventory.*/
            if (items.Contains(staff))
            {
                items.Remove(staff);
                items.Add(staff);
            }
        }
        private static void Drop(List<string> items, string staff)
        {
            /*•	"Drop - {item}" - you should remove the item from your inventory if it exists.*/
            if (items.Contains(staff)) items.Remove(staff);
        }

        private static void Collect(List<string> items, string item)
        {
            /*•	"Collect - {item}" - you should add the given item to your inventory. If the item already exists, you should skip this line.*/
            if (!items.Contains(item)) items.Add(item);
        }
    }
}
