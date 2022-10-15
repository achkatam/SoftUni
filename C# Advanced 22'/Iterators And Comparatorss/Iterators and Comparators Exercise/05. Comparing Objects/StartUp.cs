using System;
using System.Collections.Generic;
using System.Drawing;

namespace _05._Comparing_Objects
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            string command = Console.ReadLine();

            while (command != "END")
            {
                var tokens = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Person person = new Person()
                {
                    Name = tokens[0],
                    Age = int.Parse(tokens[1]),
                    Town = tokens[2]
                };

                people.Add(person);

                command = Console.ReadLine();
            }

            int compareIndex = int.Parse(Console.ReadLine()) - 1;

            Person peronsToComapre = people[compareIndex];

            int equalCnt = 0;
            int diffCnt = 0;

            foreach (var person in people)
            {
                if (person.CompareTo(peronsToComapre) == 0)
                {
                    equalCnt++;
                }
                else
                {
                    diffCnt++;
                }
            }

            if (equalCnt == 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{equalCnt} {diffCnt} {people.Count}");
            }
        }
    }
}
