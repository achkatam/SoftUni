using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program that keeps the information about courses. Each course has a name and registered students.
            //You will be receiving a course name and a student name, until you receive the command "end".Check if such a course already exists, and if not, add the course.Register the user into the course. When you receive the command "end", print the courses with their names and total registered users. For each contest print the registered users.
            //Input
            //•	Until the "end" command is received, you will be receiving input in the format: "{courseName} : {studentName}".
            //•	The product data is always delimited by " : ".
            //Output
            //•	Print the information about each course in the following the format: 
            //"{courseName}: {registeredStudents}"
            //•	Print the information about each student in the following the format:
            //"-- {studentName}"

            //Create dictionary of course name and List<StudentNames>

            var courseInfo = new Dictionary<string, List<string>>();

            string cmd = Console.ReadLine();

            while (cmd != "end")
            {
                string[] tokens = cmd.Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string courseName = tokens[0];
                string studentName = tokens[1];

                if (!courseInfo.ContainsKey(courseName))
                {
                    courseInfo[courseName] = new List<string>();

                }
                courseInfo[courseName].Add(studentName);

                cmd = Console.ReadLine();
            }

            PrintCoursesInfo(courseInfo);
        }

        private static void PrintCoursesInfo(Dictionary<string, List<string>> courseInfo)
        {
            foreach (var kvp in courseInfo)
            {
                string courseName = kvp.Key;
                List<string> students = kvp.Value;
                Console.WriteLine($"{courseName}: {students.Count}");
                foreach (var student in students)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
