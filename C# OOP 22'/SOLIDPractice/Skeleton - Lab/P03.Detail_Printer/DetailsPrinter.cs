namespace P03.DetailPrinter
{
    using System;
    using System.Collections.Generic;

    using P03.Detail_Printer.Contracts;

    public class DetailsPrinter
    {
        private List<IEmployee> employees;

        public DetailsPrinter(List<IEmployee> employees)
        {
            this.employees = employees;
        }

        public DetailsPrinter()
        {
            this.employees = new List<IEmployee>();
        }

        public void PrintDetails()
        {
            foreach (var employee in employees)
            {
                Console.WriteLine(employee.PrintEmployee());
            }
        }
    }
}
