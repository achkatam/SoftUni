using System;

namespace Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create four method for each math operation, invoke method depending on received command
            string operation = Console.ReadLine();
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            switch (operation)
            {
                case "add":
                    Add(firstNum, secondNum);
                    break;
                case "multiply":
                    Multiplication(firstNum, secondNum);
                    break;
                case "subtract":
                    Subtract(firstNum, secondNum);
                    break;
                case "divide":
                    Division(firstNum, secondNum);
                    break;
            }

        }

        static void Add(int num1, int num2)
        {
            Console.WriteLine(num1 + num2);
        }
        static void Subtract(int num1, int num2)
        {
            Console.WriteLine(num1 - num2);
        }
        static void Multiplication(int num1, int num2)
        {
            Console.WriteLine(num1 * num2);
        }
        static void Division(int num1, int num2)
        {
            Console.WriteLine(num1 / num2);
        }
    }
}
