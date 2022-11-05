namespace CollectionHierarchy.Models
{
    using System;
    using System.Collections.Generic;

    using CollectionHierarchy.IO.Interfaces;
    using CollectionHierarchy.Models.Interfaces;
    

    public class AddCollection : IAddCollection, IPrintable
    {
        private List<string> collection;
        private readonly IWriter writer;

        public AddCollection()
        {
            this.collection = new List<string>();
            this.CollectionOfIndexes = new List<int>();
        }

        public List<int> CollectionOfIndexes { get;private set; }

        public virtual int Add(string text)
        {
            //adds an item to the end of the collection
            collection.Add(text);
            CollectionOfIndexes.Add(collection.Count - 1);

            return collection.Count - 1;
        }

        public void Print()
        {
            Console.WriteLine(string.Join(" ", this.CollectionOfIndexes));
        }
    }
}
