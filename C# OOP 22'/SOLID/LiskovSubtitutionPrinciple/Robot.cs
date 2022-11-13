namespace LiskovSubtitutionPrinciple
{
    using System;
    public class Robot : IWorker
    {
        public void GetSalary()
        {
            throw new NotSupportedException();
        }

        public void Sleep()
        {
            throw new NotSupportedException();
        }

        public void Work()
        {
            Console.WriteLine("Non-stop working.");
        }
    }
}
