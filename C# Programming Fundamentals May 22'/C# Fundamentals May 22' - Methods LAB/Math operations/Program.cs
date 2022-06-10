using System;

namespace Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            int firstNum = int.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());
            int secNum = int.Parse(Console.ReadLine());

            //Output
            Console.WriteLine(Calculation(firstNum, operation, secNum));
        }
        //Write a method that receives two numbers and an operator, calculates the result and returns it. You will be given three lines of input. The first will be the first number, the second one will be the operator and the last one will be the second number.
        //Operations are + - *;
        static double Calculation(int firstNum, char operation, int secNum)
        {
            double result = 0;
            switch (operation)
            {
                case '+':
                    return result = firstNum + secNum;
                    break;
                case '-':
                    return result = firstNum - secNum;
                    break;
                case '*':
                    return result = firstNum * secNum;
                    break;
                case '/':
                    return result = Math.Abs(firstNum / secNum);
                    break;
            }
            return result;
        }
    }
}
