using System;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            int studentsCounts = int.Parse(Console.ReadLine());

            double badStudent = 0;
            double middleStudent = 0;
            double goodStudent = 0;
            double excellentStudent = 0;
            double totalGrade = 0;
            for (int i = 1; i <= studentsCounts; i++)
            {
                double gradePerStudent = double.Parse(Console.ReadLine());
                totalGrade += gradePerStudent;

                if (gradePerStudent >= 2.00 && gradePerStudent <= 2.99)
                {
                    totalGrade += gradePerStudent;
                    badStudent++;
                }
                else if (gradePerStudent >=3.00 && gradePerStudent <=3.99)
                {
                    totalGrade += gradePerStudent;
                    middleStudent++;
                }
                else if (gradePerStudent >=4.00 && gradePerStudent <=4.99)
                {
                    totalGrade += gradePerStudent;
                    goodStudent++;
                }
                else
                {
                    totalGrade += gradePerStudent;
                    excellentStudent++;
                }

            }
            double totalStudent = badStudent + middleStudent + goodStudent + excellentStudent;
            Console.WriteLine($"Top students: {excellentStudent/totalStudent *100:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {goodStudent/totalStudent * 100:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {middleStudent/totalStudent*100:f2}%");
            Console.WriteLine($"Fail: {badStudent/totalStudent*100:f2}%");
            Console.WriteLine($"Average: {totalGrade/studentsCounts/2:f2}");
            
        }
    }
}
