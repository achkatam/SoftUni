namespace CollectionHierarchy.Core
{
    using System;

    using CollectionHierarchy.Core.Interfaces;
    using CollectionHierarchy.IO.Interfaces;
    using CollectionHierarchy.Models;

    public class Engine : IEngine
    {
        private readonly IReader reader;
        private readonly IWriter writer;
        private readonly AddCollection addCollection;
        private readonly AddRemoveCollection addRemoveCollection;
        private readonly MyList myList;

        private Engine()
        {
            this.addCollection = new AddCollection();
            this.addRemoveCollection = new AddRemoveCollection();
            this.myList = new MyList();
        }

        public Engine(IReader reader, IWriter writer) : this()
        {
            this.reader = reader;
            this.writer = writer;
        }


        public void Run()
        {
            var products = this.reader.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var item in products)
            {
                this.addCollection.Add(item);
                this.addRemoveCollection.Add(item);
                this.myList.Add(item);
            }

            //counter of items about ot be removed
            int counter = int.Parse(this.reader.ReadLine());

            for (int i = 0; i < counter; i++)
            {
                this.addRemoveCollection.Remove();
                this.myList.Remove();
            }
            //this.writer.WriteLine(String.Join(" ", this.addCollection.CollectionOfIndexes));
            //this.writer.WriteLine(String.Join(" ", this.addRemoveCollection.CollectionOfIndexes));
            //this.writer.WriteLine(String.Join(" ", this.myList.CollectionOfIndexes));
            //this.writer.WriteLine(String.Join(" ", this.addRemoveCollection.RemovedItems));
            //this.writer.WriteLine(String.Join(" ", this.myList.RemovedItems));

            this.addCollection.Print();
            this.addRemoveCollection.Print();
            this.myList.Print();
            this.addRemoveCollection.PrintRemovedItems();
            this.myList.PrintRemovedItems();
        }
    }
}
