using System;

namespace _03._Floating_Equality
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that safely compares floating - point numbers(double) with precision eps = 0.000001.Note that we cannot directly compare two floating - point numbers a and b by a== b because of the nature of the floating - point arithmetic.Therefore, we assume two numbers are equal if they are more close to each other than some fixed constant eps. 
            //You will receive two lines, each containing a floating-point number.Your task is to compare the values of the two numbers.

            //input
            const double precision = 0.000001;
            
            double numA = double.Parse(Console.ReadLine());
            double numB = double.Parse(Console.ReadLine());

            //add-ons
            double result = Math.Abs(numA - numB);
            bool isValid = precision > result;
            //Attempt solution

            string result1 = precision > result ? "True" : "False";
            Console.WriteLine(result1);

        }
    }
}
