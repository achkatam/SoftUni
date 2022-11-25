namespace Promotions
{
    using Promotions.Contracts;
    using System;

    public class PromotionService : IPromotionService
    {
        private DateTime dateToday;

        public PromotionService(DateTime dateToday)
        {
            this.dateToday = dateToday;
        }

        public decimal GetPromotion(Product product )
        {
            decimal percentage = 0;
            if (dateToday.DayOfWeek == DayOfWeek.Thursday)
            {
                percentage = 20;
            }
            if (dateToday.DayOfWeek == DayOfWeek.Wednesday)
            {
                percentage =  30;
            }
            if (dateToday.DayOfWeek == DayOfWeek.Friday)
            {
                percentage = 80;
            }

            return product.Price - (percentage / 100 * product.Price);
        }
    }
}
