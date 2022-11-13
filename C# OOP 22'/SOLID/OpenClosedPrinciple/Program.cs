namespace OpenClosedPrinciple
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        static void Main(string[] args)
        {
            //Open/Closed pricniple gives us extenisibility - we can easily and quicly add/remove sort strategies 
            Console.WriteLine("What strategy would you like to use?");

            string strategy = Console.ReadLine();

            Sorter sorter = new Sorter(strategy);

            sorter.Sort(new List<int>());
        }
    }
}
