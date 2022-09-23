using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Periodic_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that keeps all the unique chemical elements. On the first line, you will be given a number n - the count of input lines that you are going to receive. On the next n lines, you will be receiving chemical compounds, separated by a single space. Your task is to print all the unique ones in ascending order:

            //create HashSet
            var set = new HashSet<string>();

            int n = int.Parse(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {
                string[] elements = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                //set.UnionWith(elements);

                foreach (var element in elements)
                {
                    set.Add(element);
                }
            }

            Console.WriteLine(string.Join(" ", set
                .OrderBy(x => x)));
        }
    }
}
