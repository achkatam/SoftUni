using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Store_Boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Until you receive "end", you will be receiving data in the following format: "{Serial Number} {Item Name} {Item Quantity} {itemPrice}"
            //The Price of one box has to be calculated: itemQuantity* itemPrice.
            //Print all the boxes, ordered descending by price for a box, in the following format: 
            //{ boxSerialNumber}
            //-- {boxItemName
            //    } – ${boxItemPrice
            //}: { boxItemQuantity}
            //-- ${ boxPrice}
            //The price should be formatted to the 2nd digit after the decimal separator.
            List<Box> boxes = new List<Box>();

            string command = Console.ReadLine();

            while (command !="end")
            {
                string[] tokens = command.Split();

                Box box = new Box
                {
                    SerialNumber = tokens[0],
                    //using the constructor
                    Item = new Item(tokens[1], decimal.Parse(tokens[3])),
                    ItemQuantity = int.Parse(tokens[2])
                    
                };
                boxes.Add(box);

                command = Console.ReadLine();
            }
            List<Box> orderedBoxes = boxes.OrderByDescending(box => box.PriceForABox).ToList();

            foreach (Box box in orderedBoxes)
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- { box.Item.Name} - ${ box.Item.Price:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PriceForABox:f2}");
            }
        }
    }
    //Define a class Item, which contains these properties: Name and Price.

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
    //Define a class Box, which contains these properties: Serial Number, Item, Item Quantity, and Price for a Box.
    class Box
    {
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public decimal PriceForABox
        {
            get
            {
                return this.ItemQuantity * this.Item.Price;
            }
        }

    }
}
