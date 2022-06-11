using System;

namespace Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            string input = Console.ReadLine();
            while (input != "END")
            {
                bool isIntegerPlindrome = IsNumberPalindrome(input);
                Console.WriteLine(isIntegerPlindrome.ToString().ToLower());
                input = Console.ReadLine();
            }
        }

        private static bool IsNumberPalindrome(string input)
        {
            int number = int.Parse(input);

            if (number >= 0 && number <= 9)
            {
                return true;
            }

            //Compare the input[0](first digit of the array) with the last digit input[input.Length-1](last digit of the array)
            if (input[0] == input[input.Length - 1]) return true;

            //for (int i = 0; i < input.Length / 2; i++)
            //{
            //    if (input[i] == input[input.Length - 1])
            //    {
            //        return true;
            //    }
            //}

            return false;
        }
    }
}
