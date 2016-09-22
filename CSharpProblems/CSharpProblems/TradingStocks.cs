using System;

/*
Writing programming interview questions hasn't made me rich. Maybe trading Apple stocks will.
Suppose we could access yesterday's stock prices as an array, where:

The indices are the time in minutes past trade opening time, which was 9:30am local time.
The values are the price in dollars of Apple stock at that time.
So if the stock cost $500 at 10:30am, stockPricesYesterday[60] = 500.

Write an efficient function that takes stockPricesYesterday and returns the best profit I could have made from 1 purchase and 1 sale of 1 Apple stock yesterday.

For example:

    var stockPricesYesterday = [10, 7, 5, 8, 11, 9];
    getMaxProfit(stockPricesYesterday);
// returns 6 (buying for $5 and selling for $11)

No "shorting"—you must buy before you sell. You may not buy and sell in the same time step (at least 1 minute must pass).
*/

namespace CSharpProblems
{
    class TradingStocks
    {
        /// <summary>
        /// Retrieve the max profit from an array of stock prices
        /// Can't short a stock by selling at a price that came
        ///  before it was able to be bought
        ///  A stock can't have a value of 0
        /// </summary>
        /// <param name="stockPricesYesterday"></param>
        /// <returns>maxProfit</returns>
        private double GetMaxProfit(double[] stockPricesYesterday)
        {
            // Throw error if < 2 stocks. Can't trade.
            if (stockPricesYesterday.Length < 2)
            {
                throw new Exception("Need 2 or more stocks to get a margin!");
            }

            // Initial buy price will always be the first stock
            double buyPrice = stockPricesYesterday[0];
            // Initial max profit will always be second stock - first (might be negative also)
            double maxProfit = stockPricesYesterday[1] - stockPricesYesterday[0];

            // Loop through stocks starting from stock #2
            //  (if we start at first stock we might incorrectly set profit to 0
            for (int i = 1; i < stockPricesYesterday.Length; i++)
            {
                // Get current stock price
                double currentPrice = stockPricesYesterday[i];

                // Get potential profit if sold right now
                double potentialProfit = currentPrice - buyPrice;

                // Check if potential profit > current max profit
                maxProfit = Math.Max(potentialProfit, maxProfit);

                // Update buy price if current is lower
                buyPrice = Math.Min(currentPrice, buyPrice);
            }

            return maxProfit;
        }

        /// <summary>
        /// Run the Trading Stock Problem
        /// </summary>
        /// <param name="helper"></param>
        public void RunTradingStocks(HelperFunctions helper)
        {
            Random rnd = new Random();
            double[] stockPricesYesterday =
                new double[] {
                    rnd.Next(1,100),
                    rnd.Next(1,100),
                    rnd.Next(1,100),
                    rnd.Next(1,100),
                    rnd.Next(1,100),
                    rnd.Next(1,100),
                    rnd.Next(1,100),
                    rnd.Next(1,100),
                    rnd.Next(1,100),
                    rnd.Next(1,100)
                };

            // Updated code takes care of issue of consistently decreasing stock
            //stockPricesYesterday = new double[] { 10, 8, 5, 2, 1};

            System.Diagnostics.Debug.WriteLine("Stocks: " + helper.ArrayToString(stockPricesYesterday) + "\nMax Profit: " + GetMaxProfit(stockPricesYesterday));
        }
    }
}