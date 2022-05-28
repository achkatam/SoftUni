using System;

namespace Integer_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program that receives four integer numbers.
            //You should perform the following operations:
            //•	Add first to the second.
            //•	Divide(integer) the result of the first operation by the third number.
            //•	Multiply the result of the second operation by the fourth number.
            //Print the result after the last operation.

            //input

            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            int fourthNum = int.Parse(Console.ReadLine());

            //first attempt
            //int sumNum = firstNum + secondNum;
            //int divisionNum = sumNum / thirdNum;
            //int multiplication = divisionNum * fourthNum;

            //output
            //Console.WriteLine(multiplication);

            //second attempt
            int finalResult = (firstNum + secondNum) / thirdNum * fourthNum;
            Console.WriteLine(finalResult);

        }
    }
}
