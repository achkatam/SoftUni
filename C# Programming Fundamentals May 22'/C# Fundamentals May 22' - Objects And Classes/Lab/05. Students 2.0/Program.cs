using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Students_2._0
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

                //Check for existing student
                if (IsExistingStudent(students, command[0], command[1]))
                {
                    //If exist just overwrite data
                    var student = students.Find(student => student.FirstName == command[0] && student.LastName == command[1]);
                    student.Age = int.Parse(command[2]);
                    student.HomeTown = command[3];
                }
                else
                {
                    //If doesn't exist create a new one and add to the list
                    var student = new Student(command[0], command[1], int.Parse(command[2]), command[3]);
                    students.Add(student);
                }
            }
            //.After that, you will receive a city name.
            string city = Console.ReadLine();

            foreach (var student in students.Where(c => c.HomeTown == city))
            {
                Console.WriteLine(student);
            }
        }

        private static Student GetStudent(List<Student> students, string firstName, string lastName)
        {
            Student existingStudent = null;

            foreach (var student in students.Where(x => x.FirstName == firstName && x.LastName == lastName)) existingStudent = student;

            return existingStudent;
        }

        private static bool IsExistingStudent(List<Student> students, string firstName, string lastName)
        {
            foreach (var student in students.Where(x => x.FirstName == firstName && x.LastName == lastName))
            {
                return true;
            }

            return false;
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
