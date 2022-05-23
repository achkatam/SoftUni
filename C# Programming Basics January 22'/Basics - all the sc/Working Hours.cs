using System;

namespace Working_Hours
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            int hours = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();

            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                case "Saturday":
                    if( hours >=10 && hours <= 18)
                    {
                        Console.WriteLine("open");
                    }                    
                    else
                    {
                        Console.WriteLine("closed");
                    }
                    break;
                case "Sunday":
                    Console.WriteLine("closed");
                    break;
            }
        
        }
    }
}
