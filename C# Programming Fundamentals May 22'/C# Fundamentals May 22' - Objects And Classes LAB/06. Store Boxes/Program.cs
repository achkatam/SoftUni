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
            //Until you receive "end", you will be receiving data in the following format: "{Serial Number} {Item Name} {Item Quantity} {itemPrice}"

            //Create new list for the Box(es)
            List<Box> boxes = new List<Box>();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] tokens = command.Split();
                //Start creating new box and add it to the list of boxes
                Box box = new Box
                {
                    SerialNumber = int.Parse(tokens[0]),
                    //Create new Item using constructor
                    Item = new Item(tokens[1], decimal.Parse(tokens[3])),
                    ItemQuantity = int.Parse(tokens[2])
                };
                //Add the created box in the list boxes
                boxes.Add(box);

                command = Console.ReadLine();
            }
            //Print all the boxes, ordered descending by price for a box, in the following format: 
            //{ boxSerialNumber}
            //-- { boxItemName} – ${ boxItemPrice}: { boxItemQuantity}
            //-- ${ boxPrice}
            //The price should be formatted to the 2nd digit after the decimal separator.

            //Create list of orederedBoxes by descending order
            List<Box> orderedBoxes = boxes.OrderByDescending(p => p.BoxPrice).ToList();

            //Foreach
            foreach (var box in orderedBoxes)
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.Item.Name} - ${ box.Item.Price:f2}: { box.ItemQuantity}");
                Console.WriteLine($"-- ${ box.BoxPrice:f2}");
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
    class Box
    {
        public int SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }

        public decimal BoxPrice
        {
            //The Price of one box has to be calculated: itemQuantity* itemPrice.
            get
            {
                return this.ItemQuantity * this.Item.Price;
            }
        }
    }
}
