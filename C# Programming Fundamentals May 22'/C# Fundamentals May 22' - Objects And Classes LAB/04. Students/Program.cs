using System;
using System.Collections.Generic;

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

            List<Student> students = new List<Student>();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] studentProperties = command.Split();
                Student student = new Student
                {
                    FirstName = studentProperties[0],
                    LastName = studentProperties[1],
                    Age = int.Parse(studentProperties[2]),
                    HomeTown = studentProperties[3]
                };

                students.Add(student);

                command = Console.ReadLine();
            }

            string cityName = Console.ReadLine();

            foreach (Student student in students)
            {
                if (student.HomeTown == cityName)
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
}
