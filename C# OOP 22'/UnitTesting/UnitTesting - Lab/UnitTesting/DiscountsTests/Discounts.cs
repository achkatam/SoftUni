namespace DiscountsTests
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Discounts
    {
        public decimal GetDiscount(DateTime date)
        {
            if (DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
                return 50;
            else if (DateTime.Now.DayOfWeek == DayOfWeek.Saturday)
                return 40;
            else if (DateTime.Now.DayOfWeek == DayOfWeek.Friday)
                return 10;

            return 0;
        }
    }
}
