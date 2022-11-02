using System;

namespace AbstractClass
{
    public class Program
    {
        static void Main(string[] args)
        {
            Printer printer3D = new _3DPrinter();
            printer3D.Print();

            Printer paperPrinter = new PaperPrinter();

            paperPrinter.Print();
        }
    }
}
