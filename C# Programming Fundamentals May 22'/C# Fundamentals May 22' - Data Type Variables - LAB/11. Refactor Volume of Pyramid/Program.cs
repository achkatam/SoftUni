using System;

namespace _11._Refactor_Volume_of_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            // You are given a working code that finds the volume of a pyramid.However, you should consider that the variables exceed their optimum span and have improper naming. Also, search for variables that have multiple purposes.
            // Hints
            //•	Reduce the span of the variables by declaring them at the moment they receive a value, not before
            //•	Rename your variables to represent their real purpose(example: "dul" should become length, etc.)
            //•	Search for variables that have multiple purposes.If you find any, introduce a new variable.
            //Sample Code
            //double dul, sh, V = 0;
            //            Console.WriteLine("Length: ");
            //            dul = double.Parse(Console.ReadLine());
            //            Console.WriteLine("Width: ");
            //            sh = double.Parse(Console.ReadLine());
            //            Console.WriteLine("Heigth: ");
            //            V = double.Parse(Console.ReadLine());
            //            V = (dul + sh + V) / 3;
            //            Console.WriteLine($"Pyramid Volume: {V:f2}");
            
            Console.Write($"Length: ");
            double lenght = double.Parse(Console.ReadLine());
            Console.Write($"Width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write($"Height: ");
            double height = double.Parse(Console.ReadLine());
            double volume = (lenght * width * height) / 3;
            Console.WriteLine($"Pyramid Volume: {volume:f2}");

            /*Explanation of that what was refactored:
             * the variables dul, sh, V were renamed to lenght, width, height and variable double volume was added.
             * Also math operation addition was changed to multiplication, so the formula was incorrect at the beggining.
             */

        }
    }
}
