using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _01._Extract_Person_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program that reads N lines of strings and extracts the name and age of a given person. The name of the person will be between '@' and '|'. The person’s age will be between '#' and '*'. 
            //Example: "Hello my name is @Peter| and I am #20* years old."
            //For each found name and age print a line in the following format "{name} is {age} years old."

            int numOfPpl = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfPpl; i++)
            {
                var personData = Console.ReadLine();

                string name, age;

                GetNameAndAge(personData, out name, out age);

                Console.WriteLine($"{name} is {age} years old.");

            }

        }

        public static void GetNameAndAge(string personData, out string name, out string age)
        {
            int startIndexName = personData.IndexOf('@');
            int endIndexName = personData.IndexOf('|');
            name = personData.Substring(startIndexName + 1, endIndexName - startIndexName - 1);

            int startIndexAge = personData.IndexOf('#');
            int endIndexAge = personData.IndexOf('*');
            age = personData.Substring(startIndexAge + 1, endIndexAge - startIndexAge - 1);
        }
    }
}
