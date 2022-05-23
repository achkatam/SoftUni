using System;

namespace While_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //W H I L E L O O P S
            int index = 1;
            while (index <= 5)
            {
                Console.WriteLine(index);
                index++;
            }
            Console.WriteLine();
            do
            {
                Console.WriteLine(index);
                index++;
            } while (index <= 5);

        }
    }
}
