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
            //Read information about some students until you receive the "end" command

            //Create a list to store students data
            List<Student> students = new List<Student>();

            string command = Console.ReadLine();

            while (command!="end")
            {
                string[] tokens = command.Split();
                Student student = new Student
                {
                    FirstName = tokens[0],
                    LastName = tokens[1],
                    Age = int.Parse(tokens[2]),
                    HomeTown = tokens[3]
                };

                students.Add(student);

                command = Console.ReadLine();
            }
            //.After that, you will receive a city name.
            string city = Console.ReadLine();

            //Print the students who are from the given city in the following format: "{firstName} {lastName} is {age} years old."

            //Output using LINQ and foreach
            //Create new list of filteredStudents
            List<Student> filteredStudents = students.Where(c => c.HomeTown == city).ToList();

            //foreach
            foreach (var student in filteredStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
            
        }
    }
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
    }
}
