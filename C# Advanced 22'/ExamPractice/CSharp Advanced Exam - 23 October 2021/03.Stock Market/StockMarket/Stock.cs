using System;
using System.Diagnostics;

namespace StockMarket
{
    public class Stock
    {
        //•	CompanyName: string
        //•	Director: string
        //•	PricePerShare: decimal
        //•	TotalNumberOfShares: int
        //•	MarketCapitalization: decimal


        public string CompanyName { get; set; }
        public string Director { get; set; }
        public decimal PricePerShare { get; set; }
        public int TotalNumberOfShares { get; set; }
        public decimal MarketCapitalization { get; set; }

        public Stock(string companyName, string director, decimal pricePerShare, int totalNumbersOfShares)
        {
            CompanyName = companyName;
            Director = director;
            PricePerShare = pricePerShare;
            TotalNumberOfShares = totalNumbersOfShares;
            MarketCapitalization = PricePerShare * TotalNumberOfShares;
        }

        public override string ToString()
        {
            //"Company: {CompanyName}
            //Director: { Director}
            //Price per share: ${ PricePerShare}
            //Market capitalization: ${ MarketCapitalization}"

            return
                $"Company: {CompanyName}" + Environment.NewLine +
                $"Director: {Director}" + Environment.NewLine +
                $"Price per share: ${PricePerShare}" + Environment.NewLine +
                $"Market capitalization: ${MarketCapitalization}";

        }
    }
}
