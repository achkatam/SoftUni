using System;

namespace Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rewrite the program from the previous task so it can receive the multiplier from the console. Print the table with the multiplier in the interval from the given number to 10.If the given multiplier is more than 10, print only one row with the integer, the given multiplier, and the product.See the examples below for more information.
            //Output
            //Print every row of the table in the following format:
            //{ theInteger} X { times} = { product}
            //            Constraints
            //•	The integer will be in the interval[1…100]

            int theInteger = int.Parse(Console.ReadLine());
            int times = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine($"{theInteger} X {times} = {theInteger * times}");
                times++;
            }
            while (times <= 10);




        }
    }
}
