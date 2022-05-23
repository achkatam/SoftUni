using System;

namespace Commission_Rate_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            double commissionFee = 0.0;


            switch (city)
            {
                case "Sofia":
                    if (sales >= 0 && sales <= 500)
                    {
                        commissionFee = 5;

                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        commissionFee = 7;
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        commissionFee = 8;
                    }
                    else if (sales > 10000)
                    {
                        commissionFee = 12;
                    }

                    break;
                case "Varna":
                    if (sales >= 0 && sales <= 500)
                    {
                        commissionFee = 4.5;
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        commissionFee = 7.5;
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        commissionFee = 10;
                    }
                    else if (sales > 10000)
                    {
                        commissionFee = 13;
                    }
                    break;
                case "Plovdiv":
                    if (sales >= 0 && sales <= 500)
                    {
                        commissionFee = 5.5;
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        commissionFee = 8;
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        commissionFee = 12;
                    }
                    else if (sales > 10000)
                    {
                        commissionFee = 14.5;
                    }
                    break;
            }
            if (sales < 0)
            {
                Console.WriteLine("error");
            }
            else if (city != "Sofia" && city != "Varna" && city != "Plovdiv")
            {
                Console.WriteLine("error");
            }
            else
            {
                double finalSum = commissionFee * sales / 100;
                Console.WriteLine($"{finalSum:f2}");
            }
        }
    }
}
