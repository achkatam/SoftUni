using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace Problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var guestList = new Dictionary<string, Person>();

            string command = Console.ReadLine();

            //counter for unliked meals
            int counter = 0;

            while (command != "Stop")
            {
                string[] input = command.Split("-",
                    StringSplitOptions.RemoveEmptyEntries);

                var cmd = input[0];
                string name = input[1];
                string meal = input[2];


                if (cmd == "Like")
                {
                    if (!guestList.ContainsKey(name))
                    {
                        guestList.Add(name, new Person(name, new List<string>()));
                    }

                    if (!guestList[name].Meal.Contains(meal))
                    {
                        guestList[name].Meal.Add(meal);
                    }

                    // guestList[name].Meal.Add(meal);


                }
                else if (cmd == "Dislike")
                {
                    if (!guestList.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} is not at the party.");
                    }
                    else if (!guestList[name].Meal.Contains(meal))
                    {
                        Console.WriteLine($"{name} doesn't have the {meal} in his/her collection.");

                    }
                    else
                    {
                        guestList[name].Meal.Remove(meal);
                        counter++;
                        Console.WriteLine($"{name} doesn't like the {meal}.");
                    }
                }

                command = Console.ReadLine();
            }

            //Console.WriteLine(string.Join("\n",
            //    guestList.Select(x => $"{x.Key}: {string.Join(", ", x.Value.Meal)}")));

            foreach (var guest in guestList)
            {
                Console.WriteLine($"{guest.Key}: {string.Join(", ", guest.Value.Meal)}");
            }

            Console.WriteLine($"Unliked meals: {counter}");

        }
    }
    class Person
    {
        public Person(string name, List<string> meal)
        {
            Name = name;
            Meal = new List<string>();
        }
        public string Name { get; set; }
        public List<string> Meal { get; set; }
    }
}
