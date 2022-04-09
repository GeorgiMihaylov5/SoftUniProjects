using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockMarket
{
    public class Investor
    {
        public Investor(string fullName, string emailAddress, decimal moneyToInvest, string brokerName)
        {
            this.FullName = fullName;
            this.EmailAddress = emailAddress;
            this.MoneyToInvest = moneyToInvest;
            this.BrokerName = brokerName;
            this.Portfolio = new Dictionary<string, Stock>();
        }
        public string FullName { get; set; }
        public string EmailAddress { get; set; }
        public decimal MoneyToInvest { get; set; }
        public string BrokerName { get; set; }
        public Dictionary<string, Stock> Portfolio { get; set; }

        public int Count => Portfolio.Count;

        public void BuyStock(Stock stock)
        {
            if (stock.MarketCapitalization > 10000)
            {
                if (this.MoneyToInvest >= stock.PricePerShare)
                {
                    Portfolio.Add(stock.CompanyName, stock);
                    this.MoneyToInvest-=stock.PricePerShare;
                }
            }
        }
        public string SellStock(string companyName, decimal sellPrice)
        {
            if (!Portfolio.ContainsKey(companyName))
            {
                return $"{companyName} does not exist.";
            }
            foreach (var item in Portfolio)
            {
                if (item.Value.PricePerShare > sellPrice)
                {
                    return $"Cannot sell {companyName}.";
                }
            }
            Portfolio.Remove(companyName);
            this.MoneyToInvest += sellPrice;

            return $"{companyName} was sold.";
        }
        public Stock FindStock(string companyName)
        {
            return Portfolio.FirstOrDefault(x => x.Key == companyName).Value;
        }
        public Stock FindBiggestCompany()
        {
            if (Portfolio.Count == 0)
            {
                return null;
            }
            string key = string.Empty;
            decimal max = 0;
            foreach (var item in Portfolio)
            {
                if (item.Value.MarketCapitalization > max)
                {
                    max = item.Value.MarketCapitalization;
                    key = item.Key;
                }
            }
            return Portfolio[key];
        }
        public string InvestorInformation()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"The investor {this.FullName} with a broker {this.BrokerName} has stocks: ");

            foreach (var item in Portfolio)
            {
                sb.AppendLine(item.Value.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
