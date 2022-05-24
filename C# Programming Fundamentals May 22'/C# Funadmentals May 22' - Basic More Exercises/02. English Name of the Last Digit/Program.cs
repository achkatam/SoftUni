using System;
using System.Text;

namespace _02._English_Name_of_the_Last_Digit
{
    class Program
    {
        static void Main()
        {
            //Create a method that returns the English spelling of the last digit of a given number. Write a program that reads an integer and prints the returned value from this method.

            int num = int.Parse(Console.ReadLine());
            string lettersOfDigit = LastDigitFromInteger(num);
            Console.WriteLine(lettersOfDigit);

        }
        static string LastDigitFromInteger(int number)
        {
            int tempNum = number % 10;//creating temporary number just to switch the cases
                                      // n % 10 return the last digit of the inputed number

            switch (tempNum)
            {
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default: return "zero";
            }
        }
    }
}
