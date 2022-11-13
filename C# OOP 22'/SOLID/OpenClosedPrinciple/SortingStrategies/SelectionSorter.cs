namespace OpenClosedPrinciple.SortingStrategies
{
    using System;
    using System.Collections.Generic;

    public class SelectionSorter : ISortingStrategy
    {
        public IEnumerable<int> Sort(IEnumerable<int> data)
        {
            Console.WriteLine("Performing Selection Sort!");

            return data;
        }
    }
}
