using System;

namespace Ages
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            int age = int.Parse(Console.ReadLine());

            string result = age <= 2 ? "baby" :
                age > 2 && age <= 13 ? "child" :
                age <= 19 ? "teenager" :
                age <= 65 ? "adult" : "elder";

            Console.WriteLine(result);


            //if (age <= 2)
            //{
            //    Console.WriteLine($"baby");
            //}
            //else if (age <=13)
            //{
            //    Console.WriteLine($"child");
            //}
            //else if (age <= 19)
            //{
            //    Console.WriteLine($"teenager");
            //}
            //else if (age <=65)
            //{
            //    Console.WriteLine($"adult");
            //}
            //else if ( age >=66)
            //{
            //    Console.WriteLine("elder");
            //}

            //switch (age)
            //{
            //    case int num when age >= 0 && age <= 2:
            //        Console.WriteLine("baby");
            //        break;
            //    case int num when age <= 13:
            //        Console.WriteLine($"child");
            //        break;
            //    case int num when age <= 19:
            //        Console.WriteLine($"teenager");
            //        break;
            //    case int num when age <= 65:
            //        Console.WriteLine("adult");
            //        break;
            //    default:
            //        Console.WriteLine("elder");
            //        break;
            // }
            

        }
    }
}
