using System;
using System.Collections.Generic;
using System.Linq;

namespace Oldest_Family_Member
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads the names and ages of N people and adds them to the family. Then print the name and age of the oldest member.
            //Call the family class
            var currFamily = new Family();
            //vriables for number of members
            int numOfMembers = int.Parse(Console.ReadLine());

            //for loop to iterate thru each member
            for (int i = 0; i < numOfMembers; i++)
            {
                var tokens = Console.ReadLine().Split();
                //Add the new member in the family
                currFamily.AddMember(tokens[0], int.Parse(tokens[1]));
            }
            Person theOldestPerson = currFamily.GetOldestMember();
            Console.WriteLine(theOldestPerson);
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
        public int Age{ get; set; }
        public override string ToString() => $"{Name} {Age}";
        
    }
    class Family
    {
        public Family()
        {
            people = new List<Person>();
        }
        //The Family class should have a list of people
        List<Person> people { get; set; }
        //a method for adding members (void AddMember(Person member))
        public void AddMember(string name, int age)
        {
            Person newMember = new Person(name, age);
            people.Add(newMember);
        }
        //and a method, which returns the oldest family member(Person GetOldestMember())
        public Person GetOldestMember()
        {
            //return the first met in the list
            return people.OrderByDescending(age => age.Age).FirstOrDefault();
        }
      
    }
}
