using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Store_Boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Define a class Item, which contains these properties: Name and Price.
            //Define a class Box, which contains these properties: Serial Number, Item, Item Quantity, and Price for a Box.
            //The Price of one box has to be calculated: itemQuantity* itemPrice.

            //Start with creating List of boxes
            List<Box> boxes = new List<Box>();
            //Until you receive "end", you will be receiving data in the following format: "{Serial Number} {Item Name} {Item Quantity} {itemPrice}"

            while (true)
            {
                string[] cmds = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (cmds[0] == "end") break;

                //Create a new box which contains an item and add it to the list
                Box box = new Box
                {
                    SerialNumber = int.Parse(cmds[0]),
                    //create the item with name and price
                    Item = new Item(cmds[1], decimal.Parse(cmds[3])),
                    ItemQuantity = int.Parse(cmds[2])
                };
                boxes.Add(box);

            }
            //Print all the boxes, ordered descending by price for a box, in the following format: 
            //Order the list by descending price
            boxes = boxes.OrderByDescending(x => x.BoxPrice).ToList();

            //Output
            foreach (var box in boxes)
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- { box.Item.Name} - ${ box.Item.Price:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${ box.BoxPrice:f2}");
            }

            //{ boxSerialNumber}
            //-- { boxItemName} – ${ boxItemPrice}: { boxItemQuantity}
            //-- ${ boxPrice}
            //The price should be formatted to the 2nd digit after the decimal separator.


        }
    }
    class Box
    {
        public int SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public decimal BoxPrice
        {
            get
            {
                return ItemQuantity * Item.Price;
            }
        }
    }
    class Item
    {
        public Item(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
        public string Name { get; set; }
        public decimal Price { get; set; }

    }
}
