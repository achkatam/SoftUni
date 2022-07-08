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


            var students = new Dictionary<string, List<double>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string studentName = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!students.ContainsKey(studentName))
                {
                    students[studentName] = new List<double>();
                }
                students[studentName].Add(grade);


            }

            foreach (var student in students)
            {
                string studentName = student.Key;
                double avgGrade = student.Value.Average();
                if (avgGrade >= 4.5)
                {
                    Console.WriteLine($"{student.Key} -> {avgGrade:f2}");
                }
            }
        }
    }
}
