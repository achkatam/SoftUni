using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Intrinsics.X86;

namespace _01._Barista_Contest
{
    class Barista
    {
        public Barista(string name, int quantities)
        {
            Name = name;
            Quantities = quantities;
        }

        public string Name { get; set; }
        public int Quantities { get; set; }
        public int AmountMade { get; set; }
    }

    public class Program
    {
        static void Main(string[] args)
        {

            var coffees = new Queue<int>(Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray());

            var milks = new Stack<int>(Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray());


            var barista = new List<Barista>
            {
               new Barista("Cortado", 50   ),
               new Barista( "Espresso", 75 ),
               new Barista("Capuccino", 100 ),
               new Barista("Americano", 150 ),
               new Barista("Latte", 200     )
            };
            //Cortado	50
            //Espresso    75
            //Capuccino   100
            //Americano   150
            //Latte   200

            while (milks.Any() && coffees.Any())
            {
                int milk = milks.Pop();
                int coffee = coffees.Dequeue();

                int sum = milk + coffee;


                Barista drink = barista.FirstOrDefault(x => x.Quantities == sum);

                if (drink != null)
                {
                    drink.AmountMade++;
                }
                else
                {
                    milks.Push(milk - 5);
                }
            }

            if (!milks.Any() && !coffees.Any())
            {
                Console.WriteLine($"Nina is going to win! She used all the coffee and milk!");
            }
            else
            {
                Console.WriteLine($"Nina needs to exercise more! She didn't use all the coffee and milk!");
            }


            Console.WriteLine(coffees.Any() ? $"Coffee left: {string.Join(", ", coffees)}" : $"Coffee left: none");
            Console.WriteLine(milks.Any() ? $"Milk left: {string.Join(", ", milks)}" : $"Milk left: none");


            foreach (var drink in barista.Where(x => x.AmountMade > 0).OrderBy(x => x.AmountMade).ThenByDescending(x => x.Name))
            {
                Console.WriteLine($"{drink.Name}: {drink.AmountMade}");
            }

        }
    }
}
