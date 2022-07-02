using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            //Define a class called Student, which will hold the following information about some students: 
            //•	first name
            //•	last name
            //•	age
            //•	home town
            //Input / Constraints

            //Create List<Student> of sudents so we can stack them up in there
            List<Student> students = new List<Student>();


            //Read information about some students until you receive the "end" command
            while (true)
            {
                string[] command = Console.ReadLine().Split();
                if (command[0] == "end") break;
                //Create a new student
                var student = new Student(command[0], command[1], int.Parse(command[2]), command[3]);
                //Add the student to the list 
                students.Add(student);
            }
            //.After that, you will receive a city name.
            string city = Console.ReadLine();

            foreach (var student in students.Where(c => c.HomeTown == city))
            {
                Console.WriteLine(student);
            }
        }
    }
    class Student
    {
        public Student(string firstName, string lastName, int age, string homeTown)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            HomeTown = homeTown;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
        public override string ToString() => $"{FirstName} {LastName} is {Age} years old.";
    }
}
