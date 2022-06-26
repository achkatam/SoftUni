using System;
using System.Collections.Generic;
using System.Linq;

namespace Guinea_Pig
{
    class Program
    {
        static void Main(string[] args)
        {
            //On the first three lines, you will receive the quantity of food, hay and cover, which Merry buys for a month (30 days). On the fourth line, you will receive the guinea pig's weight.
            //.On every third day, Merry puts Puppy cover with a quantity of 1 / 3 of its weight.
            //Calculate whether the quantity of food, hay and cover will be enough for a month.
            //If Merry runs out of food, hay, or cover, stop the program!

            //Initiliaze variables converted to grams 
            double food = double.Parse(Console.ReadLine()) * 1000;
            double hay = double.Parse(Console.ReadLine()) * 1000;
            double cover = double.Parse(Console.ReadLine()) * 1000;
            double pigWeight = double.Parse(Console.ReadLine()) * 1000;

            //for loop to iterate thru days to 30
            for (int i = 1; i <= 30; i++)
            {
                //Every day Puppy eats 300 gr of food
                food -= 300;
                // Every second day Merry first feeds the pet, then gives it a certain amount of hay equal to 5 % of the rest of the food.
                if (i % 2 == 0)
                {
                    hay -= food * 0.05;
                }
                //.On every third day, Merry puts Puppy cover with a quantity of 1 / 3 of its weight.
                if (i % 3 == 0)
                {
                    cover -= pigWeight / 3;
                }
                if (food <= 0 || hay <= 0 || cover <= 0)
                {
                    Console.WriteLine("Merry must go to the pet store!");

                    return;
                }
            }
            //Output converted back to kgs.
            Console.WriteLine($"Everything is fine! Puppy is happy! Food: {(food / 1000):f2}, Hay: {(hay / 1000):f2}, Cover: {(cover / 1000):f2}.");
        }
    }
}
