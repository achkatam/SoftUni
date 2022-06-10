using System;

namespace _7._NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            //input number
            int inputNum = int.Parse(Console.ReadLine());
            MatrixCreator(inputNum);

        }

        private static void MatrixCreator(int inputNum)
        {
            for (int rows = 0; rows < inputNum; rows++)
            {
                for (int cols = 0; cols < inputNum; cols++)
                {
                    Console.Write(inputNum + " ");
                }
                Console.WriteLine();//Brings to the next row
            }
            Console.WriteLine();
        }
    }
}
