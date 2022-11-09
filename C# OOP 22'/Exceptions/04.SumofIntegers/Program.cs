namespace SumofIntegers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        static void Main(string[] args)
        {
            var elements = Console.ReadLine()
                 .Split()
                 .ToArray();

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < elements.Length; i++)
            {
                try
                {
                    int number = int.Parse(elements[i]);

                   stack.Push(number);
                }
                catch (FormatException)
                {
                    Console.WriteLine($"The element '{elements[i]}' is in wrong format!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine($"The element '{elements[i]}' is out of range!");
                }
                finally
                {
                    Console.WriteLine($"Element '{elements[i]}' processed - current sum: {stack.Sum()}");
                }
            }

            Console.WriteLine($"The total sum of all integers is: {stack.Sum()}");
        }
    }
}
