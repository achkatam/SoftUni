using System;

namespace ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            string[] elements = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
            //Solution 
            Array.Reverse(elements);

            foreach(var element in elements)
            {
                Console.Write($"{element} ");
            }
        }
    }
}
