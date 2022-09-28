using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Filter_By_Age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program that receives an integer N on the first line. On the next N lines, read pairs of "[name], [age]". Then read three lines:
            //•	Condition - "younger"(<) or "older"(>=)
            //•	Age threshold -integer
            //•	Format - "name", "age" or "name age"
            //Depending on the condition, print the correct pairs in the correct format.Don't use the built-in functionality from .NET. Create your own methods.

            //Read people and add them in the list
            List<Person> people = ReadPeople();

            //variables for groupAge, ageLimit and output format // read'em from the console
            string groupAge = Console.ReadLine();
            int ageLimit = int.Parse(Console.ReadLine());
            string output = Console.ReadLine();

            Func<Person, bool> filter = CreateFilter(groupAge, ageLimit);
            Action<Person> printer = CreatePrinter(output);
            PrintFilteredPeople(people, filter, printer);
        }

        static void PrintFilteredPeople(List<Person> people, Func<Person, bool> filter, Action<Person> printer)
        {
            foreach (Person person in people.Where(filter))
            {
                printer(person);
            }   
        }

        static Action<Person> CreatePrinter(string output)
        {
            switch (output)
            {
                case "name":
                    return person => Console.WriteLine($"{person.Name}");
                    break;
                case "age":
                    return person => Console.WriteLine($"{person.Age}");
                    break;
                case "name age":
                    return person => Console.WriteLine($"{person.Name} - {person.Age}");
                    break;
            }

            throw new ArgumentException(output);

        }

        static Func<Person, bool> CreateFilter(string groupAge, int ageLimit)
        {
            Func<Person, bool> filter = person => true;

            switch (groupAge)
            {
                case "younger":
                    filter = person => person.Age < ageLimit;
                    break;
                case "older":
                    filter = person => person.Age >= ageLimit;
                    break;
            }

            return filter;
        }

        static List<Person> ReadPeople()
        {
            var people = new List<Person>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string name = tokens[0];
                int age = int.Parse(tokens[1]);

                Person person = new Person(name, age);
                people.Add(person);
            }

            return people;
        }
    }
    class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }
    }
}
