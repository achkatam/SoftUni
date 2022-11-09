namespace PlayCatch
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            int exceptionCnt = 0;

            //string command = Console.ReadLine();

            while (exceptionCnt != 3)
            {
                var tokens = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string cmd = tokens[0];

                try
                {
                    switch (cmd)
                    {
                        case "Replace":
                            int indexToReplace = int.Parse(tokens[1]);
                            int element = int.Parse(tokens[2]);

                            nums[indexToReplace] = element;
                            break;

                        case "Print":
                            int startIndex = int.Parse(tokens[1]);
                            int endIndex = int.Parse(tokens[2]);

                            var myList = new List<int>();

                            for (int i = startIndex; i <= endIndex; i++)
                            {
                                myList.Add(nums[i]);
                            }

                            Console.WriteLine(String.Join(", ", myList));

                            break;
                        case "Show":
                            int index = int.Parse(tokens[1]);

                            Console.WriteLine(nums[index]);
                            break;
                    }


                }
                catch (IndexOutOfRangeException)
                {
                    exceptionCnt++;
                    Console.WriteLine("The index does not exist!");
                }
                catch (FormatException)
                {
                    exceptionCnt++;
                    Console.WriteLine("The variable is not in the correct format!");
                }
            }

            Console.WriteLine(String.Join(", ", nums));
        }

        //private static void Show(int index, int[] nums)
        //{
        //    Console.WriteLine(nums[index]);
        //}

        //private static void Print(int startIndex, int endIndex, int[] nums)
        //{
        //    List<int> numbersToShow = new List<int>();

        //    if (startIndex < 0 || endIndex < 0
        //        || startIndex > nums.Length || endIndex > nums.Length)
        //        throw new IndexOutOfRangeException();

        //    for (int i = startIndex; i <= endIndex; i++)
        //    {
        //        numbersToShow.Add(nums[i]);
        //    }

        //    Console.WriteLine(String.Join(" ", numbersToShow));
        //}


        //private bool ValidIndex(int startIndex, int endIndex, int[] nums)
        //{
        //    return startIndex >= 0 && startIndex < nums.Length - 1
        //        && endIndex >= 0 && endIndex < nums.Length - 1;
        //}
    }
}
