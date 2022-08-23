using System;

namespace Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program, which calculates the volume of n beer kegs. You will receive in total 3 * n lines.Every three lines will hold information for a single keg.First up is the model of the keg, after that is the radius of the keg, and lastly is the height of the keg.
            //Calculate the volume using the following formula: π* r^2 * h.
            //In the end, print the model of the biggest keg.

            //input
            int nLine = int.Parse(Console.ReadLine());
            double biggestKeg = double.MinValue;

            string largestKeg = "";

            //Attempt solution
            for (int i = 0; i < nLine; i++)
            {
                string model = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volume = Math.PI * Math.Pow(radius, 2) * height;

                if(volume > biggestKeg)
                {
                    biggestKeg = volume;
                    largestKeg = model;
                }
            }
            Console.WriteLine(largestKeg);
        }
    }
}
