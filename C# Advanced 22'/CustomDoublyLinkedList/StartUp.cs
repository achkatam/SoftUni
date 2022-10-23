using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomDoublyLinkedList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //Input for the list

            DoublyLinkedList list = new DoublyLinkedList();

            //add elements in the list
            Console.WriteLine("Add elements in the list");
            list.AddFirst(2);
            list.AddFirst(123);
            list.AddFirst(985);
            list.AddFirst(1);
            list.AddFirst(112);

            Console.WriteLine("Print all the elements in the list");
            list.Foreach(x => Console.WriteLine(x));


            Console.WriteLine(new String('*', 25));

            Console.WriteLine("Remove first element");
            list.RemoveFirst();
            list.RemoveFirst();

            Console.WriteLine("Print all the elements in the list");
            list.Foreach(x => Console.WriteLine(x));


            Console.WriteLine(new String('*', 25));

            Console.WriteLine("Add some more as last element");
            list.AddLast(4);
            list.AddLast(42);
            list.AddLast(43);
            Console.WriteLine(new String('*', 25));
            list.Foreach(x => Console.WriteLine(x));


            Console.WriteLine("Remove some of last elements");
            list.RemoveLast();
            list.RemoveLast();
            list.RemoveLast();

            Console.WriteLine("Print all the elements in the list");
            list.Foreach(x => Console.WriteLine(x));


            Console.WriteLine(list.GetType());
            list.ToArray();
            list.Foreach(x => Console.WriteLine(x));

            var arr = list.ToArray();
            //Console.WriteLine(arr.GetType());
            
            //it's time to sort the list
            Console.WriteLine("Sort the elements in ascending order using Quick Sort Algorithm");
            list.QuickSortMethod(arr, 0, arr.Length - 1);

            Console.WriteLine(String.Join(", ", arr));

            //Add Resize


        }
    }
}
