using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program that keeps information about companies and their employees. 
            //You will be receiving a company name and an employee's id, until you receive the "End" command. Add each employee to the given company. Keep in mind that a company cannot have two employees with the same id.

            //Create dictionary of companyname(string) and list of employesID(string)
            var companies = new Dictionary<string, List<string>>();

            while (true)
            {
                string[] inputInfo = Console.ReadLine().Split(" -> "
                    , StringSplitOptions.RemoveEmptyEntries);

                if (inputInfo[0] == "End") break;

                string companyName = inputInfo[0];
                string employeeID = inputInfo[1];

                if (!companies.ContainsKey(companyName))
                {
                    companies[companyName] = new List<string>();
                }
                //Company cannot content same employeeIDs
                if (!companies[companyName].Contains(employeeID))
                {
                    //Add the employee in the list
                    companies[companyName].Add(employeeID);
                }

            }
            PrintResult(companies);

            

        }

        private static void PrintResult(Dictionary<string, List<string>> companies)
        {
            //Foreach to iterate thru each company and one more foreach to iterate thru its employees
            foreach (var company in companies)
            {
                Console.WriteLine($"{company.Key}");
                foreach (var employee in company.Value)
                {
                    Console.WriteLine($"-- {employee}");
                }
            }
        }
    }
}
