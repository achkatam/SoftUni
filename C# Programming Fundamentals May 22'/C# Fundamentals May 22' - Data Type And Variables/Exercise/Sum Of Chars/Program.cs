using System;

namespace Sum_Of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program, which sums the ASCII codes of n characters and prints the sum on the console.
            //Input
            //•	On the first line, you will receive n – the number of lines, which will follow
            //•	On the next n lines – you will receive letters from the Latin alphabet

            //input
            //char letter = 'A';
            //int numOfChar = (int)(letter);
            //Console.WriteLine(numOfChar);

            //inputs
            int count = int.Parse(Console.ReadLine());

            //add-ons
            int totalSum = 0;

            //Attempt solution
            for (int i = 0; i < count; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                int valueOfLetter = (int)(letter);
                totalSum += valueOfLetter;
            }
            Console.WriteLine($"The sum equals: {totalSum}");
        }
    }
}
