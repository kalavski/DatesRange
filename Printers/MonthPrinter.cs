using System;
using RangePrinter.Interfaces;

namespace RangePrinter.Printers
{
    public class MonthPrinter: IPrinter
    {
        public string Print(DateTime startTime, DateTime finishTime)
        {
            return startTime.ToShortDateString().Substring(0, 5) + " - " + finishTime.ToShortDateString();
        }
    }
}
