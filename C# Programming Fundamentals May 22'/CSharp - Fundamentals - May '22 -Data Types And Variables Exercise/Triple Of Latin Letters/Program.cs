using System;

namespace Triple_Of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            int lettersCount = int.Parse(Console.ReadLine());

            //Attempt solution
            for (int i = 0; i < lettersCount; i++)
            {
                char firstChar = (char)('a' + i);
                for (int j = 0; j < lettersCount; j++)
                {
                    char secondChar = (char)('a' + j);
                    for (int k = 0; k < lettersCount; k++)
                    {
                        char thirdChar = (char)('a' + k);
                        Console.WriteLine($"{firstChar}{secondChar}{thirdChar}");
                    }
                }
            }

        }
    }
}
