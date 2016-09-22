using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

namespace TradingStocks
{
    class Program
    {
        // Assume a stock can never be < 0
        static double GetMaxProfit(double[] stockPricesYesterday)
        {
            double maxProfit = 0;
            double buyPrice = 0;
            double sellPrice = 0;

            foreach (var stockPrice in stockPricesYesterday)
            {
                if ((buyPrice == 0 || stockPrice < buyPrice))
                {
                    buyPrice = stockPrice;
                    sellPrice = 0;
                } else if (buyPrice != 0 && stockPrice > sellPrice && stockPrice > buyPrice)
                {
                    sellPrice = stockPrice;
                }

                // If current upper value price - lowest found price > current max profit
                //  set the max profit
                if ((sellPrice - buyPrice) > maxProfit)
                {
                    maxProfit = sellPrice - buyPrice;
                }
            }

            return maxProfit;
        }

        static void Main(string[] args)
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

            System.Diagnostics.Debug.WriteLine("Stocks: " + String.Join(",", stockPricesYesterday.Select(p => p.ToString()).ToArray()) + "\nMax Profit: " + GetMaxProfit(stockPricesYesterday));
        }
    }
}
