namespace EnterNumbers
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        static void Main(string[] args)
        {
            //Write a method ReadNumber(int start, int end) that enters an integer number in a given range (start…end), excluding the numbers start and end. If an invalid number or a non-number text is entered, the method should throw an exception. Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100. If the user enters an invalid number, continue while there are 10 valid numbers entered. Print the array elements, separated with comma and space “, ”.
            //            Hints
            //•	When the entered input holds a non - integer value, print “Invalid Number!”
            //•	When the entered input holds an integer that is out of range, print "Your number is not in range {currentNumber} - 100!"
            List<int> myList = new List<int>();

            int start = 1;

            while (myList.Count != 10)
            {
                int end = 100;

                try
                {
                    start = ReadNumber(start, end);
                    myList.Add(start);
                }
                catch (FormatException fe)
                {
                    Console.WriteLine(fe.Message);
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
            }

            Console.WriteLine(String.Join(", ", myList));

        }
        private static int ReadNumber(int start, int end)
        {

            string number = Console.ReadLine();

            if (!int.TryParse(number, out int result))
            {
                throw new FormatException("Invalid Number!");
            }

            if (result <= start || result >= end)
            {
                throw new ArgumentException($"Your number is not in range ({start} - 100!)");
            }

            return result;
        }
    }
}
