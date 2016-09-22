using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Diagnostics.Debug.WriteLine("\nRunning Trading Stocks Problem");
            TradingStocks ts = new TradingStocks();
            ts.RunTradingStocks();
            System.Diagnostics.Debug.WriteLine("Finished Trading Stocks Problem\n");


        }
    }
}
