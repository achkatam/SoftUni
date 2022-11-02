using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    abstract class Printer
    {
        public void Clean()
        {
            Console.WriteLine("Clean up the printer");
        }

        public abstract void Print();


        public int Color { get; set; }

        public int Size { get; set; }
    }
}
