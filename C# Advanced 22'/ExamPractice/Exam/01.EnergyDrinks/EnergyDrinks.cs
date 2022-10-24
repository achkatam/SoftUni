using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem1
{
    public class EnergyDrinks
    {
        static void Main(string[] args)
        {
            //stack of mgr
            var caffeines = new Stack<int>(Console.ReadLine()
                .Split(",", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray());

            //queue of energy drink
            var ergDrinks = new Queue<int>(Console.ReadLine()
                .Split(",", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray());

            //total amount of caffeeine Stamat has consumed
            int total = 0;
            //his max amount is 300 mgr

            while (caffeines.Any() && ergDrinks.Any())
            {
                int caffeeine = caffeines.Pop();
                int ergDrink = ergDrinks.Dequeue();

                int sum = caffeeine * ergDrink;

                if (total + sum <= 300)
                {
                    total += sum;
                }
                else
                {
                    //var myList = new List<int>(ergDrinks);
                    //myList.Insert(myList.Count - 1, ergDrink);

                    //foreach (var drink in myList)
                    //{
                    //    ergDrinks.Enqueue(drink);
                    //}
                    ergDrinks.Reverse();

                    ergDrinks.Enqueue(ergDrink);
                    ergDrinks.Reverse();

                    total -= 30;
                }

                if (total < 0)
                {
                    total = 0;
                }
                //Console.WriteLine(String.Join(",", ergDrinks));
                //Console.WriteLine(String.Join(",", caffeines));

            }

            Console.WriteLine(ergDrinks.Any() ? $"Drinks left: {String.Join(", ", ergDrinks)}" : $"At least Stamat wasn't exceeding the maximum caffeine.");
            Console.WriteLine($"Stamat is going to sleep with {total} mg caffeine.");

        }
    }
}
