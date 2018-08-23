using System;
using System.Collections.Generic;

namespace stockPurchaseDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> stocks = new Dictionary<string, string>(){
                {"GM", "General Motors"},
                {"CAT", "Caterpillar"},
                {"APL", "Apple Computer"},
                {"GOOG", "Alphabet"},
                {"COK", "Coca-Cola"}
            };

            List<(string ticker, int shares, double price)> purchases = new List<(string, int, double)>()
            {
                {("GM", 50, 49.99)},
                {("APL", 100, 3000.00)},
                {("COK", 49, 30.04)},
                {("CAT", 25, 29.65)},
                {("GOOG", 5000, 800.94)}
            };

            Dictionary<string, double> stockValues = new Dictionary<string, double>();

            foreach ((string ticker, int shares, double price) stock in purchases)
            {
                if (stockValues.ContainsKey(stock.ticker))
                {
                    double stockValuation = (stock.shares * stock.price);
                    stockValues[stock.ticker] = stockValuation;
                }
                else 
                {
                    double stockValuation = (stock.shares * stock.price);
                    string stockName = (stocks[stock.ticker]);
                    stockValues.Add(stockName, stockValuation);
                }
            }

            foreach (KeyValuePair<string, double> stockThing in stockValues)
            {
                System.Console.WriteLine($"{stockThing.Key} is currently worth: ${stockThing.Value}");
            }

        }
    }
}
