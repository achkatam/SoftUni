using System;

namespace _01._Programming_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            double printingPagePrice = double.Parse(Console.ReadLine());
            double printingCoverPrice = double.Parse(Console.ReadLine());
            double discountPerc = double.Parse(Console.ReadLine()) /100;
            double designerSalary = double.Parse(Console.ReadLine());
            double percPaidByStaff = double.Parse(Console.ReadLine())/100;

            //calculations
            double printingPrice = printingPagePrice * 899 + printingCoverPrice * 2;
           
            printingPrice -= printingPrice * discountPerc;
            printingPrice += designerSalary;
            printingPrice -= printingPrice * percPaidByStaff;

            //output
            Console.WriteLine($"Avtonom should pay {printingPrice:f2} BGN.");

        }
    }
}
