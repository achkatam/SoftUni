namespace CollectionHierarchy.Models
{
    using System;
    using System.Collections.Generic;

    using CollectionHierarchy.IO.Interfaces;
    using CollectionHierarchy.Models.Interfaces;

    public class MyList : IMyList, IPrintable, IPrintableRemovedItems
    {
        private List<string> collection;
        private readonly IWriter writer;

        public MyList()
        {
            this.collection = new List<string>();
            this.CollectionOfIndexes = new List<int>();
            this.RemovedItems = new List<string>();
        }

        public List<int> CollectionOfIndexes { get; private set; }
        public List<string> RemovedItems { get; private set; }

        //•	A Used property, which displays the number of elements currently in the collection. 
        public int Used => this.collection.Count;

        public int Add(string text)
        {
            //•	An Add method, which adds an item to the start of the collection.
            this.collection.Insert(0, text);
            CollectionOfIndexes.Add(0);

            return 0;
        }

        public string Remove()
        {
            //•	A Remove method, which removes the first element in the collection.
            string removedItem = this.collection[0];
            RemovedItems.Add(removedItem);
            this.collection.RemoveAt(0);

            return removedItem;
        }

        public void Print()
        {
            Console.WriteLine(string.Join(" ", this.CollectionOfIndexes));

        }

        public void PrintRemovedItems()
        {
            Console.WriteLine(string.Join(" ", this.RemovedItems));

        }
    }
}
