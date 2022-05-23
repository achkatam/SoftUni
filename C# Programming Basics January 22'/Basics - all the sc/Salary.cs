using System;

namespace _05._Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int facebook = 150;
            int instagram = 100;
            int reddit = 50;

            //input
            int openedTabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());


            for (int i = 1; i <= openedTabs; i++)
            {
                string website = Console.ReadLine();

                if (website == "Facebook")
                {
                    salary -= facebook;
                }
                else if (website == "Instagram")
                {
                    salary -= instagram;
                }
                else if (website == "Reddit")
                {
                    salary -= reddit;
                }
                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }
                
            }
            if (salary > 0)
            {
                Console.WriteLine(salary);

            }
        }
    }
}
