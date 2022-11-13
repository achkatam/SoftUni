namespace DependancyInjection
{
    using System;

    public class Store
    {
        private DateTime dateToday;

        public Store(DateTime dateToday)
        {
            this.dateToday = dateToday;
        }

        public void Buy(Product product)
        {
            decimal discount = 0;

            //dependency if the DateTime 
            if (dateToday.DayOfWeek == DayOfWeek.Tuesday)
            {
                discount += 20;
            }

            Console.WriteLine($"Discount is {discount}lv ");
        }
    }
}
