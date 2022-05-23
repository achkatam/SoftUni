using System;

namespace _11._Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double bananaPr = 0;
            double applePr = 0;
            double orangePr = 0;
            double grapefruitPr = 0;
            double kiwiPr = 0;
            double pineapplePr = 0;
            double grapesPr = 0;

            if (fruit == "banana")
            {
                switch (day)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                        bananaPr = 2.50;
                        break;
                    case "Saturday":
                    case "Sunday":
                        bananaPr = 2.70;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (fruit == "apple")
            {
                switch (day)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                        applePr = 1.20;
                        break;
                    case "Saturday":
                    case "Sunday":
                        applePr = 1.25;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (fruit == "orange")
            {
                switch (day)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                        orangePr = 0.85;
                        break;
                    case "Saturday":
                    case "Sunday":
                        orangePr = 0.90;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (fruit == "grapefruit")
            {
                switch (day)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                        grapefruitPr = 1.45;
                        break;
                    case "Saturday":
                    case "Sunday":
                        grapefruitPr = 1.60;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (fruit == "kiwi")
            {
                switch (day)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                        kiwiPr = 2.70;
                        break;
                    case "Saturday":
                    case "Sunday":
                        kiwiPr = 3.00;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (fruit == "pineapple")
            {
                switch (day)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                        pineapplePr = 5.50;
                        break;
                    case "Saturday":
                    case "Sunday":
                        pineapplePr = 5.60;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (fruit == "grapes")
            {
                switch (day)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                        grapesPr = 3.85;
                        break;
                    case "Saturday":
                    case "Sunday":
                        grapesPr = 4.20;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (fruit != "banana" && fruit != "apple" && fruit != "orange" && fruit != "grapefruit" && fruit != "kiwi" && fruit != "pineapple" && fruit != "grapes")
            {
                Console.WriteLine("error");
            }

            double bananaSum = quantity * bananaPr;
            double appleSum = quantity * applePr;
            double orangeSum = quantity * orangePr;
            double grapefruitSum = quantity * grapefruitPr;
            double kiwiSum = quantity * kiwiPr;
            double pineappleSum = quantity * pineapplePr;
            double grapesSum = quantity * grapesPr;

            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                case "Saturday":
                case "Sunday":
                    switch (fruit)
                    {
                        case "banana":
                            Console.WriteLine($"{bananaSum:f2}");
                            break;
                        case "apple":
                            Console.WriteLine($"{appleSum:f2}");
                            break;
                        case "orange":
                            Console.WriteLine($"{orangeSum:f}");
                            break;
                        case "grapefruit":
                            Console.WriteLine($"{grapefruitSum:f2}");
                            break;
                        case "kiwi":
                            Console.WriteLine($"{kiwiSum:f2}");
                            break;
                        case "pineapple":
                            Console.WriteLine($"{pineappleSum:f2}");
                            break;
                        case "grapes":
                            Console.WriteLine($"{grapesSum:f2}");
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
