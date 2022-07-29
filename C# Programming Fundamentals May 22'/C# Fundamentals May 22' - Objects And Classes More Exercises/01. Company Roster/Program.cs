using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Company_Roster
{
    class Program
    {
        private static List<string> department;

        static void Main(string[] args)
        {
            //Define a class Employee that holds the following information: a name, a salary, and a department. 
            //Your task is to write a program, which takes N lines of employees from the console, calculates the department with the highest average salary, and prints for each employee in that department his name and salary – sorted by salary in descending order.The salary should be rounded to two digits after the decimal separator.

            var departments = new Dictionary<string, List<Employee>>();
            //variable for count of employees
            int counter = int.Parse(Console.ReadLine());

            for (int i = 0; i < counter; i++)
            {
                var employeeInfo = Console.ReadLine().Split(" "
                    , StringSplitOptions.RemoveEmptyEntries);

                string employeeName = employeeInfo[0];
                double employeeSalary = double.Parse(employeeInfo[1]);
                string dept = employeeInfo[2];

                var employee = new Employee(employeeName, employeeSalary);

                if (!departments.ContainsKey(dept))
                {
                    departments.Add(dept, new List<Employee>());
                }
                departments[dept].Add(employee);

            }

            //variable for highest paid dept and highesAvgSalary
            double highestSalary = 0;
            string highestAvgDept = string.Empty;

            foreach (var department in departments)
            {
                double avgSum = department.Value.Sum(x => x.Salary / department.Value.Count);

                if (avgSum > highestSalary)
                {
                    highestSalary = avgSum;
                    highestAvgDept = department.Key;
                }
            }
            var bestDept = departments[highestAvgDept]
                .OrderByDescending(x=>x.Salary).ToList();

            //Output
            Console.WriteLine($"Highest Average Salary: {highestAvgDept}");

            foreach (var dept in bestDept)
            {
                Console.WriteLine($"{dept.Name} {dept.Salary:f2}");
            }
        }
    }
    class Employee
    {
        public Employee(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }
        public double Salary { get; set; }

        public string Name { get; set; }
    }
}
