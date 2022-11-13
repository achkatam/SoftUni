namespace LiskovSubtitutionPrinciple
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        static void Main(string[] args)
        {
            //works perfect for new TeamLead
            IWorker worker = new TeamLead();

            worker.Work();

            //will not work.The following methods work only for IEmployee
            //worker.Sleep();
            //worker.GetSalary();

            //DOES NOT WORK because DOES NOT implement all methods of abstraction class/interface 
            IWorker workerRobot = new Robot();

            worker.Work();
            //worker.Sleep();
            //worker.GetSalary();


            //working code

            TeamLead teamLead = new TeamLead();
            Company company = new Company(new List<IWorker>()
            {
                new Robot(),
                teamLead
            },
            new List<IEmployee>()
            {
                teamLead
            });  

            company.ManageWork();
        }
    }
}
