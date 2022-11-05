namespace CollectionHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using CollectionHierarchy.IO.Interfaces;
    using CollectionHierarchy.Models.Interfaces;

    public class AddRemoveCollection : IAddRemoveCollection, IPrintable, IPrintableRemovedItems
    {
        private List<string> collection;
        private readonly IWriter writer;

        public AddRemoveCollection()
        {
            this.collection = new List<string>();
            this.CollectionOfIndexes = new List<int>();
            this.RemovedItems = new List<string>();
        }

        public List<int>CollectionOfIndexes { get;private set; }
        public List<string> RemovedItems { get; private set; }

        public int Add(string text)
        {
            //adds an item to the start of the collection
            this.collection.Insert(0, text);
            CollectionOfIndexes.Add(0);

            return 0;
        }

        public string Remove()
        {
            // removes the last item in the collection.
            string removedItem = collection[collection.Count - 1];
            RemovedItems.Add(removedItem);
            this.collection.RemoveAt(collection.Count - 1);

            return removedItem;
        }

        public void Print()
        {
             Console.WriteLine(string.Join(" ", this.CollectionOfIndexes));
            //this.writer.WriteLine(string.Join(" ", this.CollectionOfIndexes));

        }

        public void PrintRemovedItems()
        {
            Console.WriteLine(string.Join(" ", this.RemovedItems));

        }

    }
}
