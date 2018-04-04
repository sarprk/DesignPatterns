using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Observer.EventAndDelegate;
using static System.Console;

namespace Observer.EventAndDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            // Monitor a stock ticker, when particular events occur, react
            StockTicker st = new StockTicker();

            // Create New observers to listen to the stock ticker
            GoogleMonitor gf = new GoogleMonitor(st);
            MicrosoftMonitor mf = new MicrosoftMonitor(st);

            // Load the Sample Stock Data
            foreach (var s in SampleData.getNext())
                st.Stock = s;

            ReadLine();
        }
    }
}
