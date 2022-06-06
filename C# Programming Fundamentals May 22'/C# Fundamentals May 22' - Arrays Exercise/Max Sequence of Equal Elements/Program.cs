using System;
using System.Linq;

namespace Max_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            //Looking for longest sequence of equal elements in an array. If some of them are equal, print out the leftmost one.
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //add-ons needed
            int sequenceNum = 0;
            int sequenceLength = 0;
            int maxCounter = int.MinValue;
            int lastNum = 0;

            //For loop to checks the elements in the array
            for (int i = 0; i < array.Length; i++)
            {
                int currNum = array[i];//This is how we gonna use the elements 1 by 1
                if (currNum == lastNum)
                {
                    sequenceLength++;//The elements have same value
                }
                else
                {
                    sequenceLength = 1;// Found a new value 
                }

                if (sequenceLength > maxCounter)
                {
                    maxCounter = sequenceLength;//Takes the value from the longest sequence
                    sequenceNum = currNum;
                }
                lastNum = currNum;
            }
            for (int i = 0; i < maxCounter; i++)
            {
                Console.Write($"{sequenceNum} ");
            }
        }
    }
}
