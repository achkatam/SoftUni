using System;
using System.Linq;
using System.Collections.Generic;

namespace Encrypt__Sort_And_Print_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads a sequence of strings from the console. Encrypt every string by summing:
            //•	The code of each vowel multiplied by the string length
            //•	The code of each consonant divided by the string length
            //Sort the number sequence in ascending order and print it on the console.

            //Start with creating lists for vowels and consonant letter/chars
            List<char> vowel = new List<char>
            {
                'a', 'A',
                'e', 'E',
                'i', 'I',
                'o', 'O',
                'u', 'U'
            };

            int n = int.Parse(Console.ReadLine());
            double[] sumOfChars = new double[n];

            //Let's create for loop and add names
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                int sum = 0;
                //One more for loop to check if the name's characters are vowels or consonants
                for (int j = 0; j < name.Length; j++)
                {
                    if (vowel.Contains(name[j]))
                    {
                        sum += name[j] * name.Length;
                    }
                    else
                    {
                        sum += name[j] / name.Length;
                    }
                }
                //Sum up all the chars
                sumOfChars[i] = sum;
            }
            //Put sumOfChars into a list:
            var listOfSums = sumOfChars.ToList();
            //Order listOfSums by ascending order - by default
            var ascendingOrder = listOfSums.OrderBy(x => x);//This orders the array to ascending order by default

            //Output
            foreach (var chars in ascendingOrder)
            {
                Console.WriteLine(chars);
            }
            //Second solution
            //Declare variables and arrays
            //int n = int.Parse(Console.ReadLine()); // the end the for loop
            //int[] numbers = new int[n]; // the length of the array will be n - symbols

            ////Solution
            //for (int i = 0; i < n; i++)
            //{
            //    string name = Console.ReadLine();
            //    int sum = 0;

            //    for (int j = 0; j < name.Length; j++)
            //    {
            //        char ch = name[j];
            //        switch (ch)
            //        {
            //            case 'a':
            //            case 'A':
            //            case 'e':
            //            case 'E':
            //            case 'i':
            //            case 'I':
            //            case 'o':
            //            case 'O':
            //            case 'u':
            //            case 'U':
            //                sum += ch * name.Length;
            //                break;
            //            default:
            //                sum += ch / name.Length;
            //                break;
            //        }
            //    }
            //    numbers[i] = sum;
            //}
            //Array.Sort(numbers);

            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
