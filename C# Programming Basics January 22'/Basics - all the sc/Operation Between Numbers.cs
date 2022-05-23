using System;

namespace Operation_Between_Numbers_Vol_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            int N1 = int.Parse(Console.ReadLine());
            int N2 = int.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());
            string everOrOdd = "even";
            double result = 0;

            if (operation == '+' || operation == '-' || operation == '*')
            {
                if (operation == '+')
                {
                    result = N1 + N2;                    
                }
                else if (operation == '-')
                {
                    result = N1 - N2;
                }
                else
                {
                    result = N1 * N2;
                }
                if (result % 2 == 0)
                {
                   
                    Console.WriteLine($"{N1} {operation} {N2} = {result} - {everOrOdd}");
                }
                else
                {
                    everOrOdd = "odd";
                    Console.WriteLine($"{N1} {operation} {N2} = {result} - {everOrOdd}");
                }
            }
            else if (operation == '/' || operation=='%')
            {
                if (operation == '/')
                {
                    result = 1.0 * N1 / N2;
                    if (N2 == '0')
                    {
                        Console.WriteLine($"Cannot divide {N1} by zero");
                    }
                    else
                    {                       
                        Console.WriteLine($"{N1} {operation} {N2} = {result:f2}");

                    }
                }
                else
                {
                    result = N1 % N2;
                    Console.WriteLine($"{N1} {operation} {N2} = {result}");
                }
            }


        }
    }
}
