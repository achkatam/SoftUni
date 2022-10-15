using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;

namespace StockMarket
{
    public class Investor
    {
        public List<Stock> Portfolio { get; set; }

        public string FullName { get; set; }
        public string EmailAddress { get; set; }
        public decimal MoneyToInvest { get; set; }
        public string BrokerName { get; set; }

        public int Count { get { return Portfolio.Count; } }

        public Investor(string fullName, string emailAddress, decimal moneyToInvest, string brokerName)
        {
            this.Portfolio = new List<Stock>();
            this.FullName = fullName;
            this.EmailAddress = emailAddress;
            this.MoneyToInvest = moneyToInvest;
            this.BrokerName = brokerName;
        }

        public void BuyStock(Stock stock)
        {
            if (stock.MarketCapitalization > 10000 && this.MoneyToInvest >= stock.PricePerShare)
            {
                this.MoneyToInvest -= stock.PricePerShare;
                Portfolio.Add(stock);
            }
        }

        public string SellStock(string companyName, decimal sellPrice)
        {
            //•	If the company does not exist return: "{companyName} does not exist."
            //•	If the selling price is smaller than the price per share return: "Cannot sell {companyName}."
            //•	Upon successful sell, you should remove the company from the portfolio, increase Money to Invest with the selling price, and return: "{companyName} was sold."
            Stock company = Portfolio.FirstOrDefault(x => x.CompanyName == companyName);

            if (company == null)
            {
                return $"{companyName} does not exist.";
            }

            if (company.PricePerShare > sellPrice)
            {
                return $"Cannot sell {companyName}.";
            }

            this.MoneyToInvest += sellPrice;
            Portfolio.Remove(company);
            return $"{companyName} was sold.";
        }

        public Stock FindStock(string companyName) => this.Portfolio.Find(x => x.CompanyName == companyName);

        public Stock FindBiggestCompany() => Portfolio.OrderByDescending(x => x.MarketCapitalization).FirstOrDefault();
        

        public string InvestorInformation()
        {
            return
                $"The investor {FullName} with a broker {BrokerName} has stocks:" + Environment.NewLine +
                $"{string.Join(Environment.NewLine, Portfolio)}";

            //"The investor {fullName} with a broker {brokerName} has stocks: 
            //{ Stock1}
            //{ Stock2}

        }

        //•	FullName: string
        //•	EmailAddress: string
        //•	MoneyToInvest: decimal
        //•	BrokerName: string

    }
}
