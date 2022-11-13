namespace OpenClosedPrinciple.SortingStrategies
{
using System;
    using System.Collections.Generic;

    public class BubbleSorter : ISortingStrategy
    {
        public IEnumerable<int> Sort(IEnumerable<int> data)
        {
            Console.WriteLine("Performing Bubble Sort!");

            return data;
        }
    }
}
