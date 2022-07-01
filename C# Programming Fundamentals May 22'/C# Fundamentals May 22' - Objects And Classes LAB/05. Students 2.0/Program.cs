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

            while (command != "end")
            {
                string[] tokens = command.Split();

                //Check if the student exist if not add to the list
                if (IsStudentExisting(tokens[0], tokens[1], students))
                {
                    Student student = students.Find(student => student.FirstName == tokens[0] && student.LastName == tokens[1]);
                    student.Age = int.Parse(tokens[2]);
                    student.HomeTown = tokens[3];
                }
                else
                {
                    Student student = new Student(tokens[0], tokens[1], int.Parse(tokens[2]), tokens[3]);
                    //Add the student to the LIst<Student> students
                    students.Add(student);
                }
                command = Console.ReadLine();
            }
            //Finally, we have to overwrite the information.

            string city = Console.ReadLine();
            List<Student> filteredStudents = students.Where(c => c.HomeTown == city).ToList();

            foreach (var student in filteredStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }

        }

        public static bool IsStudentExisting(string firstName, string lastName, List<Student> students)
        {
            foreach (var student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName) return true;
                
            }

            return false;
        }
    }
    class Student
    {
        
        public Student(string firstName, string lastName, int age, string homeTown)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.HomeTown = homeTown;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
    }
}
