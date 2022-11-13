namespace OpenClosedPrinciple.SortingStrategies
{
    using System;
    using System.Collections.Generic;

    public class MergeSorter : ISortingStrategy
    {
        public IEnumerable<int> Sort(IEnumerable<int> data)
        {
            Console.WriteLine("Performing Merge Sort!");

            return data;
        }
    }
}
