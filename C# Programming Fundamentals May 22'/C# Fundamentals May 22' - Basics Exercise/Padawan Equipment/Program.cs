using System;

namespace Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            double budget = double.Parse(Console.ReadLine());

            int studentCnt = int.Parse(Console.ReadLine());
            double saberPrice = double.Parse(Console.ReadLine());
            double robesPrice = double.Parse(Console.ReadLine());
            double beltsPrice = double.Parse(Console.ReadLine());

            double totalCntsOfSabers = Math.Ceiling(studentCnt + studentCnt * 0.1);
            double numbersOfFreeBelts = Math.Floor(studentCnt / 6.0); // that means every 6th belt is free

            double finalSaberPrice = totalCntsOfSabers * saberPrice;
            double finalRobePrice = studentCnt * robesPrice;
            double finalBeltPrice = (studentCnt - numbersOfFreeBelts) * beltsPrice;

            double totalPrice = finalBeltPrice + finalRobePrice + finalSaberPrice;

            if (budget >= totalPrice)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {Math.Abs(budget - totalPrice):f2}lv more.");
            }


        }
    }
}
