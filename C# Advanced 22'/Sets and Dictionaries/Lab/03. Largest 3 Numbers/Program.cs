using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(" ",
                StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .OrderByDescending(x => x).ToList().Take(3);

            Console.WriteLine(string.Join(" ", nums));
            //nums = nums.OrderByDescending(num => num).ToList();

            //if (nums.Count > 3)
            //{
            //    Console.WriteLine(string.Join(" ", nums.Take(3)));
            //}
            //else
            //{
            //    Console.WriteLine(string.Join(" ",nums));
            //}
        }
    }
}
