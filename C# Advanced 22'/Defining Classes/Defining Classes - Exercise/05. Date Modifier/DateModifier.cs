using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class DateModifier
    {
        public static int DateTimeDifference(string startDate, string endDate)
        {
            DateTime firstDate = DateTime.Parse(startDate);
            DateTime secDate = DateTime.Parse(endDate);

            TimeSpan diff = firstDate - secDate;

            return Math.Abs(diff.Days);
        }
    }
}
