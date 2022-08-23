using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _02._Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a method that takes two strings as arguments and returns the sum of their character codes multiplied (multiply str1[0] with str2[0] and add to the total sum). Then continue with the next two characters. If one of the strings is longer than the other, add the remaining character codes to the total sum without multiplication.
            
            //Input           Output
            //Peter George    52114
            //123 522         7647
            //a aaaa          9700


            //Create the input as array and order it by its length, that returns the shortest input as first input
            var input = Console.ReadLine().Split().OrderBy(x => x.Length).ToArray();

            StringBuilder firstInput = new StringBuilder(input[0]);
            StringBuilder secondInput = new StringBuilder(input[1]);

            int sum = InputMultiplication(firstInput, secondInput);

            Console.WriteLine(sum);
        }

        static int InputMultiplication(StringBuilder firstInput, StringBuilder secondInput)
        {
            int sum = 0;

            while (firstInput.Length > 0)
            {
                sum += firstInput[0] * secondInput[0];
                //Remove the elements so their count decreases
                firstInput.Remove(0, 1);
                secondInput.Remove(0, 1);
            }

            for (int i = 0; i < secondInput.Length; i++)
            {
                sum += secondInput[i];
            }

            return sum;
        }
    }
}
