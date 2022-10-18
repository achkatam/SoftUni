using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Set_Cover
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•	Universe -  an array of integers separated by space and comma (", ") .
            //•	Numbers of sets – a single integer representing the numbers of rows of the array.
            //•	Multidimensional(jagged) array of integers separated by space and comma(", ").

            var universe = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            int numbersOfSets = int.Parse(Console.ReadLine());

            var sets = GetJaggedArray(numbersOfSets);

            List<int[]> selectedSets = ChooseSets(sets.ToList(), universe.ToList()); ;


            Console.WriteLine($"Sets to take ({selectedSets.Count()}):");

            foreach (var set in selectedSets)
            {
                Console.WriteLine("{ " + string.Join(", ", set) + " }");
            }
        }

        public static List<int[]> ChooseSets(List<int[]> sets, List<int> universe)
        {
            var selectedSets = new List<int[]>();

            while (universe.Count > 0)
            {
                int[] longestSet = sets.OrderByDescending(s => s.Count(x => universe.Contains(x)))
                    .FirstOrDefault();

                if (!selectedSets.Contains(longestSet))
                {
                    selectedSets.Add(longestSet);
                }

                sets.Remove(longestSet);

                foreach (var set in longestSet)
                {
                    if (universe.Contains(set))
                    {
                        universe.Remove(set);
                    }
                }
            }

            return selectedSets;
        }

        public static int[][] GetJaggedArray(int numbersOfSets)
        {
            var arr = new int[numbersOfSets][];

            for (int row = 0; row < arr.Length; row++)
            {
                var rowData = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

                arr[row] = rowData;
            }

            return arr;
        }
    }
}
