using System;

namespace Books_list
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            int pages = int.Parse(Console.ReadLine());
            int pph = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            //calculation 
            int time = pages / pph;
            int hpd = time / days;
            //output
            Console.WriteLine(hpd);
        }
    }
}
