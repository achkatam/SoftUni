using System;
using System.Collections.Generic;
using System.Linq;


namespace _02._Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program, which reads a name of a student and his/her grades and adds them to the student record, then prints the students' names with their grades and their average grade.

            //Dictionary of students = name, List<grades>
            var students = new Dictionary<string, List<decimal>>();

            //number of students
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var studentInput = Console.ReadLine().Split().ToArray();
                var studentName = studentInput[0];
                var studentGrade = decimal.Parse(studentInput[1]);

                if (!students.ContainsKey(studentName))
                {
                    students[studentName] = new List<decimal>();
                }
                students[studentName].Add(studentGrade);
            }

            foreach (var student in students)
            {
                decimal avgGrade = student.Value.Average();

                string allGrades = string.Join(" ", student.Value.Select(g => g.ToString("f2")));

                Console.WriteLine($"{student.Key} -> {allGrades} (avg: {avgGrade:f2})");
            }
        }
    }
}
