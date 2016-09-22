using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProblems
{
    class Program
    {
        /// <summary>
        /// Main entry point of C Sharp Problems
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            System.Diagnostics.Debug.WriteLine("\nRunning Trading Stocks Problem");
            TradingStocks ts = new TradingStocks();
            ts.RunTradingStocks();
            System.Diagnostics.Debug.WriteLine("Finished Trading Stocks Problem\n");

            System.Diagnostics.Debug.WriteLine("\nRunning Multiply Int Array Problem");
            MultiplyIntArray mia = new MultiplyIntArray();
            mia.RunMultiplyIntArray();
            System.Diagnostics.Debug.WriteLine("Finished Multiply Int Array Problem\n");
        }
    }

    class HelperFunctions
    {
        /// <summary>
        /// Turn any double array into a comma separated string
        /// </summary>
        /// <param name="array"></param>
        /// <returns>string representing the array</returns>
        public string ArrayToString(double[] array)
        {
            if (array is Array)
                return string.Join(",", array.Select(p => p.ToString()).ToArray());
            else
                return "";
        }

        /// <summary>
        /// Turn any int array into a comma separated string
        /// </summary>
        /// <param name="array"></param>
        /// <returns>string representing the array</returns>
        public string ArrayToString(int[] array)
        {
            if (array is Array)
                return string.Join(",", array.Select(p => p.ToString()).ToArray());
            else
                return "";
        }
    }
}
