using System;
using System.Collections.Generic;
using System.Linq;

namespace Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            //You are going to receive two lists of numbers.Create a list that contains the numbers from both of the lists. The first element should be from the first list, the second from the second list, and so on.If the length of the two lists is not equal, just add the remaining elements at the end of the list.

            //            Hints:
            //•	Read the two lists
            //•	Create a result list
            //•	Start looping through them until you reach the end of the smallest one
            //•	Finally, add the remaining elements(if there are any) to the end of the list

            //Create 2 list
            var firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
            var secondList = Console.ReadLine().Split().Select(int.Parse).ToList();
            //Create result list
            var result = new List<int>();

            //Find the larger one list among the first 2
            int largerList = Math.Max(firstList.Count, secondList.Count);
            //For loop to iterate thru the lists
            for (int i = 0; i < largerList; i++)
            {
                if (firstList.Count > 1) result.Add(firstList[i]);
                if (secondList.Count > i) result.Add(secondList[i]);

            }
                Console.WriteLine(string.Join(' ', result));

        }
    }
}
