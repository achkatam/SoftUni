using System;
using System.Linq;
using System.Collections.Generic;

namespace Encrypt__Sort_And_Print_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //Using Lists of vowels and consonants
            //List<char> vowels = new List<char>
            //{
            //    'a', 'A',
            //        'e', 'E',
            //        'i', 'I',
            //        'o', 'O',
            //        'u', 'U'
            //};

            //List<char> consonants = new List<char>
            //{
            //     'B','b','C','c','d','D','F','f','G','g','H','h','J','j','K','k','L','l','M','m','N','n','P','p',
            // 'Q','q','R','r','S','s','T','t','V','v','W','w','X','x','Y','y','z','Z'
            //};

            //int n = int.Parse(Console.ReadLine());
            //double[] sumOfChars = new double[n];

            //for (int i = 0; i < n; i++)
            //{
            //    string name = Console.ReadLine();
            //    int sum = 0;

            //    for (int j = 0; j < name.Length; j++)
            //    {

            //        if (vowels.Contains(name[j]))
            //        {
            //            sum += (name[j] * name.Length);
            //        }
            //        else if (consonants.Contains(name[j]))
            //        {
            //            sum += (name[j] / name.Length);
            //        }
            //    }
            //    //Sum up the chars
            //    sumOfChars[i] = sum;
            //}
            //// Use var - it's more flexible instead of List<double> listOfSum = new List<double>();
            //var listOfSum = sumOfChars.ToList();
            ////Gotta put boundaries of the list, you don't want to have zeros in your list, breaks
            ////when dividing 
            //var zerosRemoved = listOfSum.Where(x => x != 0);
            //// Fix the order of the array - by default you want it be by ascending order
            //var ascendingOrder = zerosRemoved.OrderBy(x => x);

            //// The output will be foreach loop so we represent the chars of the array as a sum of integers we calculated earlier
            //foreach (var chars in ascendingOrder)
            //{
            //    Console.WriteLine(chars);
            //}
            ////Judge gives 60/100

            //Second solution
            //Declare variables and arrays
            int n = int.Parse(Console.ReadLine()); // the end the for loop
            int[] numbers = new int[n]; // the length of the array will be n - symbols

            //Solution
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                int sum = 0;

                for (int j = 0; j < name.Length; j++)
                {
                    char ch = name[j];
                    switch (ch)
                    {
                        case 'a':
                        case 'A':
                        case 'e':
                        case 'E':
                        case 'i':
                        case 'I':
                        case 'o':
                        case 'O':
                        case 'u':
                        case 'U':
                            sum += ch * name.Length;
                            break;
                        default:
                            sum += ch / name.Length;
                            break;
                    }
                }
                numbers[i] = sum;
            }
            Array.Sort(numbers);

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

        }
    }
}
