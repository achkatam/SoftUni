using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	On the first line, you will receive a number n - the count of all students
            //•	On the next n lines, you will be receiving information about these students in the following format: "{first name} {second name} {grade}"

            int countOfStudents = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            for (int i = 0; i < countOfStudents; i++)
            {
                string[] currStudent = Console.ReadLine().Split();
                var student = new Student(currStudent[0], currStudent[1], double.Parse(currStudent[2]));

                students.Add(student);
            }
            //Sort by grade
            List<Student> sortedStudents = students.OrderByDescending(s => s.Grade).ToList();

            sortedStudents.ForEach(student => Console.WriteLine(student));

            //foreach (var student in sortedStudents)
            //{
            //    Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:f2}");
            //}

        }
    }
    class Student
    {
        public Student(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }
        public override string ToString() => $"{FirstName} {LastName}: {Grade:f2}";
        
    }
}
