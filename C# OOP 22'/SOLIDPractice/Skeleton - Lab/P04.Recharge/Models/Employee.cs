namespace P04.Recharge
{
    using System;

    using P04.Recharge.Models;
    using P04.Recharge.Models.Contracts;

    public class Employee : Worker, ISleeper
    {
        public Employee(string id) : base(id)
        {
        }

        public  void Sleep()
        {
            // sleep...
            Console.WriteLine("Going for a deep sleeeeeep !!");
        }

    }
}
