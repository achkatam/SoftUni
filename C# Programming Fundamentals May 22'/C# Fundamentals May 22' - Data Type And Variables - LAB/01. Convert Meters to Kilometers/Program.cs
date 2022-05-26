using System;

namespace _01._Convert_Meters_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            //You will be given an integer that will be a distance in meters.Create a program that converts meters to kilometers formatted to the second decimal point.

            //input in meters
            int meters = int.Parse(Console.ReadLine());

            double km = meters * 0.001;
            //output
            Console.WriteLine($"{(km):f2}");

            //another solution 

            //int meters = int.Parse(Console.ReadLine());

            //double kilometers = meters / 1000d;

            //Console.WriteLine($"{kilometers:f2}");



        }
    }
}
