namespace P03.DetailPrinter
{
    using P03.Detail_Printer.Contracts;
    using System;
    using System.Collections.Generic;

    class Program
    {
        private readonly IReadOnlyCollection<string> documents;
        private readonly ICollection<IEmployee> employees;

        public Program(IReadOnlyCollection<string> documents)
        {
            this.documents = documents;
            this.employees = new List<IEmployee>();
        }

        static void Main()
        {
            IEmployee juniorProgrammer = new Employee("John");
            IEmployee midProgrammer = new Employee("Jammie");
            IEmployee seniorProgrammer = new Employee("Steven");

            List<string> documents = new List<string>() { "CVs", "Vacation requests" };

            IManager productManager = new Manager("Joseph", documents);
            
            List<IEmployee> employees = new List<IEmployee>() { juniorProgrammer, midProgrammer, seniorProgrammer, productManager };

            DetailsPrinter printer = new DetailsPrinter(employees);

            printer.PrintDetails();
        }
    }
}
