using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program that keeps all the unique chemical elements. On the first line, you will be given a number n - the count of input lines that you are going to receive. On the next n lines, you will be receiving chemical compounds, separated by a single space. Your task is to print all the unique ones in ascending order:

            //Create set
            var elements = new HashSet<string>();

            //number of input lines
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string inputs = Console.ReadLine();

                string[] chElements = inputs.Split();
                foreach (var element in chElements)
                {
                    elements.Add(element);
                }
            }

            //print output by ascending order or change the type of the hasset to soreted hashset
            Console.WriteLine(string.Join(" ",
                elements.OrderBy(x => x)));
        }
    }
}
