using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Order_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            //You will receive an unknown number of lines. On each line, you will receive an array with 3 elements:
            //•	The first element is a string -the name of the person
            //•	The second element a string -the ID of the person
            //•	The third element is an integer - the age of the person
            //If you get a person whose ID you have already received before, update the name and age for that ID with that of the new person.When you receive the command "End", print all the people, ordered by age.

            string[] commands = Console.ReadLine().Split();
            List<Person> personList = new List<Person>();

            while (commands[0] != "End")
            {
                var person = new Person(commands[0], commands[1], int.Parse(commands[2]));

                personList.Add(person);
                commands = Console.ReadLine().Split();
            }

            //Output
            personList.OrderBy(person => person.Age).ToList().ForEach(person => Console.WriteLine(person));

            //foreach (var person in personList.OrderBy(person =>person.Age))
            //{
            //    Console.WriteLine($"{person}");
            //}

        }
    }
    class Person
    {
        public Person(string name, string id, int age)
        {
            Name = name;
            ID = id;
            Age = age;
        }
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
        public override string ToString() => $"{Name} with ID: {ID} is {Age} years old.";
        
    }
}
