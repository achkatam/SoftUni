using System;
using System.Linq;

namespace Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            string[] array1 = Console.ReadLine().Split(' ');
            string[] array2 = Console.ReadLine().Split(' ');

            //Solution
            foreach (var element in array1)
            {
                for (int i = 0; i < array2.Length; i++)
                {
                    string secondElement = array2[i];

                    if (element == secondElement)
                    {
                        Console.Write($"{element} ");
                        break;//break the for loop once we have matching elements, skips the unnecessary checks
                    }
                }
            }


        }
    }
}
