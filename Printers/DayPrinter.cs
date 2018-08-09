using System;
using RangePrinter.Interfaces;

namespace RangePrinter.Printers
{
    public class DayPrinter: IPrinter
    {
        public string Print(DateTime startTime, DateTime finishTime)
        {
            return startTime.ToShortDateString().Substring(0, 2) + " - " + finishTime.ToShortDateString();
        }
    }
}
