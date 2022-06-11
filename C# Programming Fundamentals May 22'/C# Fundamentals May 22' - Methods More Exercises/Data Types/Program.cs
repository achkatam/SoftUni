using System;
using System.Linq;

namespace Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that, depending on the first line of the input, reads an int, double, or string.
            //Print the result on the console.

            //input
            string input = Console.ReadLine();
            //Switch case for different data types
            switch (input)
            {
                case "int":
                    int number = int.Parse(Console.ReadLine());
                    Console.WriteLine(Input(number));
                    break;
                case "real":
                    double num = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{Input(num):f2}");
                    break;
                case "string":
                    string word = Console.ReadLine();
                    Input(word);
                    break;
            }

        }
        static int Input(int number)
        {
            //•	If the data type is int, multiply the number by 2.
            return number * 2;
        }
        static double Input(double number)
        {
            //•	If the data type is real, multiply the number by 1.5 and format it to the second decimal point.
            return number * 1.5;
        }
        static void Input(string input)
        {
            Console.WriteLine($"${input}$");
        }
    }
}
