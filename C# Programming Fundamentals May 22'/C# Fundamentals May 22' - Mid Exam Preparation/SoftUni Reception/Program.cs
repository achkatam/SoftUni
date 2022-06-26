using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni_Reception
{
    class Program
    {
        static void Main(string[] args)
        {
            //Three employees are working on the reception all day.Each of them can handle a different number of students per hour. Your task is to calculate how much time it will take to answer all the questions of a given number of students.
            //First, you will receive 3 lines with integers, representing the number of students that each employee can help per hour. On the following line, you will receive students count as a single integer. 
            //Every fourth hour, all employees have a break, so they don't work for an hour. 

            //variables for how many students each employee can handle
            int firstEmployee = int.Parse(Console.ReadLine());
            int secondEmployee = int.Parse(Console.ReadLine());
            int thirdEmployee = int.Parse(Console.ReadLine());
            //variable for - how many students are there ?
            int students = int.Parse(Console.ReadLine());

            //
            int timeCounter = 0;

            while (students > 0)
            {
                //Full capability of the employees per hour
                int answeredStudentsPerHour = firstEmployee + secondEmployee + thirdEmployee;
                timeCounter++;

                students -= answeredStudentsPerHour;

                if (timeCounter % 4 == 0) timeCounter++;

            }
            Console.WriteLine($"Time needed: {timeCounter}h.");

        }
    }
}
