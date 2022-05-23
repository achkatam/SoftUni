using System;

namespace Cinema_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            //price M-Tue-Fr = 12 
            //W-Thu- = 14
            //Sat - Sun = 16
            double price = 0;
            //input
            string day = Console.ReadLine();

            //
            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Friday":
                    price = 12;
                    break;
                case "Wednesday":
                case "Thursday":
                    price = 14;
                    break;
                case "Saturday":
                case "Sunday":
                    price = 16;
                    break;
            }
            Console.WriteLine(price);
            
        }
    }
}
