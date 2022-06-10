using System;

namespace Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            switch (type)
            {
                case "int":
                    int first = int.Parse(Console.ReadLine());
                    int second = int.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(first, second));
                    break;
                case "char":
                    char firstChar = char.Parse(Console.ReadLine());
                    char secondChar = char.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(firstChar, secondChar));
                    break;
                case "string":
                    string firstStr = Console.ReadLine();
                    string secStr = Console.ReadLine();
                    Console.WriteLine(GetMax(firstStr,secStr));
                    break;
            }
        }
        //Create methods for int, char and string. We have to compare the values and print the greater one
        //OVERLOADING METHOD - methods with the same names have different sigranturrs(the name of the method, method parameters if existing)
        static int GetMax(int first, int second)
        {
            return Math.Max(first, second);
        }
        static char GetMax(char first, char second)
        {
            if (first > second)
            {
                return first;
            }
            return second;
        }
        static string GetMax(string first, string second)
        {
            int result = first.CompareTo(second);
            if (result > 0)
            {
                return first;
            }
            return second;
        }

    }
}
