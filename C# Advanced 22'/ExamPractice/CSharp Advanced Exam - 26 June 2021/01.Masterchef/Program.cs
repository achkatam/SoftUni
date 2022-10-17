using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _01.Masterchef
{
    class Meal
    {
        public Meal(string dish, int freshness)
        {
            Dish = dish;
            Freshness = freshness;
        }

        public string Dish { get; set; }
        public int Freshness { get; set; }
        public int DisheshMade { get; set; }

        public int Count { get { return DisheshMade; } }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            //Dipping sauce	150
            //Green salad 250
            //Chocolate cake  300
            //Lobster 400

            var ingredients = new Queue<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray());


            var freshnessLvl = new Stack<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray());


            List<Meal> meals = new List<Meal>
            {
                new Meal("Dipping sauce",150 ),
                new Meal("Green salad", 250 ),
                new Meal("Chocolate cake", 300 ),
                new Meal("Lobster", 400 )
            };

            var allMeals = new Dictionary<string, int>()
            {
                { "Dipping sauce",0} ,
                {"Green salad", 0 },
                {"Chocolate cake", 0 },
                {"Lobster", 0}
            };


            while (ingredients.Any() && freshnessLvl.Any())
            {

                int ingredient = ingredients.Peek();

                if (ingredients.Any())
                {
                    if (ingredient == 0)
                    {
                        ingredients.Dequeue();

                        continue;
                    }
                }

                int totalFreshness = ingredients.Peek() * freshnessLvl.Peek();

                Meal meal = meals.FirstOrDefault(x => x.Freshness == totalFreshness);


                if (meal != null)
                {
                    ingredients.Dequeue();
                    freshnessLvl.Pop();

                    meal.DisheshMade++;

                    if (!allMeals.ContainsKey(meal.Dish))
                    {
                        allMeals.Add(meal.Dish, 0);
                    }

                    allMeals[meal.Dish]++;
                }
                else
                {
                    freshnessLvl.Pop();
                    int toRemove = ingredients.Dequeue();
                    ingredients.Enqueue(toRemove + 5);
                }
            }


            PrintOutput(meals, ingredients, freshnessLvl, allMeals);
        }

        static void PrintOutput(List<Meal> meals, Queue<int> ingredients, Stack<int> freshnessLvl, Dictionary<string, int> allMeals)
        {
            if (!allMeals.Any(x => x.Value == 0))
            {
                Console.WriteLine($"Applause! The judges are fascinated by your dishes!");
            }
            else
            {
                Console.WriteLine($"You were voted off. Better luck next year.");
            }

            if (ingredients.Any())
            {
                Console.WriteLine($"Ingredients left: {ingredients.Sum()}");
            }

            var filtered = allMeals.Where(d => d.Value > 0).OrderBy(d => d.Key);

            foreach (var dish in filtered)
            {

                Console.WriteLine($" # {dish.Key} --> {dish.Value}");

            }
        }
    }
}
