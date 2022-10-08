using _01._Box;
using System;
using System.Collections.Generic;

namespace BoxOfT
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //Create a class Box<> that can store anything. It should have two public methods:
            Box<int> box = new Box<int>();
            box.Add(1);
            box.Add(2);
            box.Add(3);

            Console.WriteLine(box.Remove());
            box.Add(4);
            box.Add(5);
            Console.WriteLine(box.Remove());

        }
    }
}
