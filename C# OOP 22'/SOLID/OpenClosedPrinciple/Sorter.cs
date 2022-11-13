namespace OpenClosedPrinciple
{

    using System;
    using System.Linq;

    using System.Collections.Generic;
    using System.Reflection;

    internal class Sorter
    {
        private ISortingStrategy sortingStrategy;

        public Sorter(string strategy)
        {
            //using reflection
            sortingStrategy = FindStategy(strategy);

            //if (strategy == "Selection")
            //{
            //    sortingStrategy = new SelectionSorter();
            //}
            //else if (strategy == "Bubble")
            //{
            //    sortingStrategy = new BubbleSorter();
            //}
            //else if (strategy == "Merge")
            //{
            //    sortingStrategy = new MergeSorter();
            //}
        }

        public IEnumerable<int> Sort(IEnumerable<int> data)
        {
            if (sortingStrategy== null)
            {
                throw new ArgumentException("Strategy is not valid!");
            }

            Console.WriteLine("Starting to sort");

            return sortingStrategy.Sort(data);
        }

        private ISortingStrategy FindStategy(string strategy)
        {
            //finds the strategy by givenName
            //using reflection
            Type types = Assembly.GetExecutingAssembly()
                 .GetTypes().Where(t => typeof(ISortingStrategy).IsAssignableFrom(t) && t.Name.StartsWith(strategy)).FirstOrDefault();

            return Activator.CreateInstance(types) as ISortingStrategy; 
        }
    }
}
