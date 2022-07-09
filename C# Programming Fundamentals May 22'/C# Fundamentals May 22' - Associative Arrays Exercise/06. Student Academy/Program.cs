using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program that keeps the information about students and their grades. 
            // You will receive n pair of rows.First, you will receive the student's name, after that, you will receive their grade. Check if the student already exists and if not, add him. Keep track of all grades for each student.
            //When you finish reading the data, keep the students with an average grade higher than or equal to 4.50.
            //Print the students and their average grade in the following format:
            //"{name} –> {averageGrade}"
            //Format the average grade to the 2nd decimal place.

            //Create dictionary of students and list of their grades
            var students = new Dictionary<string, List<double>>();
            // const avgGrade
            const double AVG_GRADE = 4.5;
            //variables for the count of all students
            int coundOfStudents = int.Parse(Console.ReadLine());

            //for loop to iterate thru each student
            for (int i = 0; i < coundOfStudents; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!students.ContainsKey(name))
                {
                    students[name] = new List<double>();
                }
                //Add the student and his/her grade to the list of grades
                students[name].Add(grade);
            }

            PrintResult(students);

        }

        private static void PrintResult(Dictionary<string, List<double>> students)
        {
            const double AVG_GRADE = 4.5;

            foreach (var student in students.Where(s => s.Value.Average() >= AVG_GRADE))
            {
                Console.WriteLine($"{student.Key} -> {student.Value.Average():f2}");
            }
        }
    }
}
