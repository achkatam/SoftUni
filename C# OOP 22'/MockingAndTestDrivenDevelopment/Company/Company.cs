namespace Company
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Company
    {
        private List<Employee> employees = new List<Employee>();
        public void Add(Employee employee)
        {
            employees.Add(employee);
        }

        public void GiveSalary()
        {
            foreach (var employee in employees)
            {
                employee.EarnedSalary += employee.Salary;
            }
        }

        public void ReiseSalary(decimal percentageRaise)
        {
            foreach (var employee in employees)
            {
                employee.Salary += employee.Salary * percentageRaise / 100;
            }
        }
    }
}
