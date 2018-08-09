using System;
using RangePrinter.Interfaces;

namespace RangePrinter.Printers
{
    public class YearPrinter: IPrinter
    {
        public string Print(DateTime startTime, DateTime finishTime)
        {
            return startTime.ToShortDateString() + " - " + finishTime.ToShortDateString();
        }
    }
}
