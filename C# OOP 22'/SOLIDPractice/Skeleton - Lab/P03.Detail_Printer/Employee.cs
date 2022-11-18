﻿namespace P03.DetailPrinter
{
    using System;

    using P03.Detail_Printer.Contracts;

    public class Employee : IEmployee
    {
        public Employee(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public virtual string PrintEmployee()
            => $"{this.Name}";
    }
}