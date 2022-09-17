using System;
using System.Linq;
using System.Collections.Generic;

namespace _05._Fashion_Boutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //You own a fashion boutique and you receive a delivery once a month in a huge box, which is full of clothes. You have to arrange them in your store, so you take the box and start from the last piece of clothing on the top of the pile to the first one at the bottom. Use a stack for this purpose. Each piece of clothing has its value (an integer). You have to sum their values, while you take them out of the box. You will be given an integer representing the capacity of a rack. While the sum of the clothes is less than the capacity, keep summing them. If the sum becomes equal to the capacity you have to take a new rack for the next clothes if there are any left in the box. If it becomes greater than the capacity, don't add the piece of clothing to the current rack and take a new one. In the end, print how many racks you have used to hang all of the clothes.

            //examples                  Output
            //5 4 8 6 3 8 7 7 9       
            //16                         5

            //input for clothes value
            int[] clothesInput = Console.ReadLine().Split().Select(int.Parse).ToArray();

            //variable for rack capacity
            int capacity = int.Parse(Console.ReadLine());

            //stack
            var clothes = new Stack<int>(clothesInput);

            //counter for used racks
            int racks = 1;
            //variable for available space on the rack of clothes
            int space = capacity;

            while (clothes.Count > 0)
            {
                //create variables for easier calculations
                int currClothes = clothes.Peek();

                if (currClothes <= space)
                {
                    clothes.Pop();
                    space -= currClothes;
                }
                else
                {
                    racks++;
                    //we use a new rack, so the available space equals the first received capacity
                    space = capacity;
                }
            }

            Console.WriteLine(racks);
        }
    }
}
