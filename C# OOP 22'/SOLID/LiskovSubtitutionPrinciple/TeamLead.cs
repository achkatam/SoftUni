namespace LiskovSubtitutionPrinciple
{
    using System;
    public class TeamLead :IEmployee, IWorker
    {
        public void GetSalary()
        {
            Console.WriteLine("Banking the big money!!!");
        }

        public void Sleep()
        {
            Console.WriteLine("The sleep is never enough.");
        }

        public void Work()
        {
            Console.WriteLine("Work smart, not hard!!!");
        }
    }
}
