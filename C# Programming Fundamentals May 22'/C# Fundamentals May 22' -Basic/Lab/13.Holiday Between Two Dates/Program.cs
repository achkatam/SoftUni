using System;
using System.Globalization;

namespace _13.Holiday_Between_Two_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            //The following code needs to be debugged and FIXED !!

            //var startDate = DateTime.ParseExact(Console.ReadLine(),
            //"dd.m.yyyy", CultureInfo.InvariantCulture);
            //var endDate = DateTime.ParseExact(Console.ReadLine(),
            //    "dd.m.yyyy", CultureInfo.InvariantCulture);
            //var holidaysCount = 0;
            //for (var date = startDate; date <= endDate; date.AddDays(1))
            //    if (date.DayOfWeek == DayOfWeek.Saturday &&
            //        date.DayOfWeek == DayOfWeek.Sunday) holidaysCount++;
            //Console.WriteLine(holidaysCount);

            var startDate = DateTime.ParseExact(Console.ReadLine(),
    "d.M.yyyy", CultureInfo.InvariantCulture);//dd.mm.yyyy changed to d.M.yyyy

            var endDate = DateTime.ParseExact(Console.ReadLine(),
                "d.M.yyyy", CultureInfo.InvariantCulture);//dd.mm.yyyy changed to d.M.yyyy

            var holidaysCount = 0;

            for (var date = startDate; date <= endDate; date = date.AddDays(1))// date= was missing
            {

                if (date.DayOfWeek == DayOfWeek.Saturday || // && was changed to || One date cannot be 2 days
                    date.DayOfWeek == DayOfWeek.Sunday) holidaysCount++;
            }
            Console.WriteLine(holidaysCount);

        }
    }
}
