using _05._Comparing_Objects;
using System;
using System.Collections.Generic;

namespace _06._Equality_Logic
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            HashSet<Person> hashSet = new HashSet<Person>();
            SortedSet<Person> sortedSet = new SortedSet<Person>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var personData = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Person person = new Person()
                {
                    Name = personData[0],
                    Age = int.Parse(personData[1])
                };

                hashSet.Add(person);
                sortedSet.Add(person);

            }

            Console.WriteLine(hashSet.Count);
            Console.WriteLine(sortedSet.Count);
        }
    }
}
