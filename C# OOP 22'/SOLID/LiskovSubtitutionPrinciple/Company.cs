using System;
using System.Collections.Generic;

namespace LiskovSubtitutionPrinciple
{
    public class Company
    {
        List<IWorker> workers;
        List<IEmployee> employees;

        public Company(List<IWorker> workers, List<IEmployee> employees)
        {
            this.workers = workers;
            this.employees = employees;
        }

        public void ManageWork()
        {
            foreach (IEmployee employee in employees)
            {
                employee.GetSalary();
                employee.Sleep();
            }

            foreach (IWorker worker in workers)
            {
                worker.Work();

                //EXAMPLE FOR CODE SMELL
                //if (!(worker is Robot))
                //{
                //    worker.Sleep();
                //    worker.GetSalary();
                //}
                //in this case just create new interface implementing .Sleep() and .GetSalary()



            }
        }
    }
}
