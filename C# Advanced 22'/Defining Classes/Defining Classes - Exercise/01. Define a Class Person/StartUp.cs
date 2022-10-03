using System;
using System.Xml.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //NOTE: You need a StartUp class with the namespace DefiningClasses.
            //Define a class Person with private fields for name and age and public properties Name and Age.

            Person person = new Person();

            person.Name = "Achkata";
            person.Age = 25;


            Console.WriteLine($"{person.Name} {person.Age}");
        }
    }
}
