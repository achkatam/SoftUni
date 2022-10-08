using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace _01._Meal_Plan
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Input for mealsInfo
            var mealsnInfo = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            // create Queue<string> of meals
            Queue<string> meals = new Queue<string>(mealsnInfo);

            //Input for caloriesInfo
            var caloriesInfo = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            // create Stack<int> of cals
            Stack<int> calories = new Stack<int>(caloriesInfo);

            //salad	350
            //soup    490
            //pasta   680
            //steak   790


            //Create dictionary<meal, cals>
            Dictionary<string, int> mealsDict = new Dictionary<string, int>()
            {
                {"salad", 350 },
                {"soup", 490 },
                {"pasta", 680 },
                {"steak", 790 },
            };

            //counter for eaten meals, will need it for the output
            int eatenMeals = 0;

            while (meals.Any() && calories.Any())
            {
                //take the first meal’s calories and the last element in the sequence of calorie intake for a day
                int dailyCals = calories.Pop();

                //, the calories intake for the current day should be decreased by the calories of the given meal, and the current meal should be removed 
                while (meals.Any() && dailyCals > 0)
                {
                    string currMeal = meals.Dequeue();
                    dailyCals -= mealsDict[currMeal];
                    eatenMeals++;
                }

                //When the calories intake for the given day goes to zero, remove them from the collection
                if (dailyCals == 0)
                {
                    dailyCals = 0;
                }
                else if (dailyCals < 0)
                {
                    //given day go below zero, take as many calories as possible from the meal, so the current daily calories intake reaches zero
                    if (calories.Any())
                    {
                        var nextDayCals = calories.Pop() + dailyCals;

                        calories.Push(nextDayCals);
                    }
                }

                //if there is no meals for the day but there is still calories left, push them in the stack of cals
                if (!meals.Any() && dailyCals > 0)
                {
                    calories.Push(dailyCals);
                }
            }


            PrintOutput(calories, meals, eatenMeals);

        }

        public static void PrintOutput(Stack<int> calories, Queue<string> meals, int eatenMeals)
        {
            //o	If John manage to eat all the given meals print:
            if (!meals.Any())
            {
                Console.WriteLine($"John had {eatenMeals} meals.");
                Console.WriteLine($"For the next few days, he can eat {string.Join(", ", calories)} calories.");
            }
            else
            {
                Console.WriteLine($"John ate enough, he had {eatenMeals} meals.");
                Console.WriteLine($"Meals left: {string.Join(", ", meals)}.");
            }
            //            "John had {number of meals} meals."
            //"For the next few days, he can eat {dailyCalories1, dailyCalories2, etc.} calories."
            //Separate the daily calories intake by comma and space(", ").
            //o If John could not eat every meal:
            //"John ate enough, he had {number of meals} meals."
            //"Meals left: {meal1, meal2, etc.}."

        }
    }
}
