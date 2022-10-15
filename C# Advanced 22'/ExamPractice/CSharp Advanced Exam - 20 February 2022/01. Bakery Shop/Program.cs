using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Xml.Linq;

namespace _01._Bakery_Shop
{
    public class Program
    {
        static void Main(string[] args)
        {
            //                         pastry, how many were made
            var pastries = new Dictionary<string, int>()
            {
                {"Croissant", 0 },
                {"Muffin", 0 },
                {"Baguette", 0 },
                {"Bagel", 0 },
            };

            //You will be given two sequences of real numbers, representing water and flour. 
            //You should start from the first water and mix it with the last flour

            var waterInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse).ToArray();
            //FIFO - Queue
            var water = new Queue<double>(waterInfo);

            var flourInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
               .Select(double.Parse).ToArray();

            var flour = new Stack<double>(flourInfo);


            while (water.Any() && flour.Any())
            {
                double mixSum = water.Peek() + flour.Peek();

                double waterPerc = (water.Peek() * 100) / mixSum;

                //Console.WriteLine(waterPerc);

                switch (waterPerc)
                {
                    case 50:
                        pastries["Croissant"]++;
                        water.Dequeue();
                        flour.Pop();
                        break;
                    case 40:
                        pastries["Muffin"]++;
                        water.Dequeue();
                        flour.Pop();
                        break;
                    case 30:
                        pastries["Baguette"]++;
                        water.Dequeue();
                        flour.Pop();
                        break;
                    case 20:
                        pastries["Bagel"]++;
                        water.Dequeue();
                        flour.Pop();
                        break;
                    default:
                        var leftover = Math.Abs(water.Dequeue() - flour.Pop());
                        pastries["Croissant"]++;
                        flour.Push(leftover);
                        break;
                }
                //double result` = (80 / 100) * 25

                //•	Croissant – consists of 50% water and 50% flour
                //•	Muffin – consists of 40 % water and 60 % flour
                //•	Baguette – consists of 30 % water and 70 % flour
                //•	Bagel – consists of 20 % water and 80 % flour
            }

            PrintOutput(water, flour, pastries);

        }

        public static void PrintOutput(Queue<double> water, Stack<double> flour, Dictionary<string, int> pastries)
        {
            //            products which were baked successfully and how many of them, ordered by amount baked descending, then by product name alphabetically:
            //"{product name}: {amount baked}
            // { product name}: { amount baked}

            foreach (var pastry in pastries.Where(x => x.Value > 0 ).OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{pastry.Key}: {pastry.Value}");
            }

            //"Water left: None"
            //o If there are water left unused: "Water left: { water1}, { water2}, { water3}, (…)"

            Console.WriteLine(water.Any() ? $"Water left: {string.Join(", ", water)}" : $"Water left: None");

            Console.WriteLine(flour.Any() ? $"Flour left: {string.Join(", ", flour)}" : $"Flour left: None");

        }
    }
}
