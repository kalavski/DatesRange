using System;
using myapp2.Interfaces;

namespace myapp2.Printers
{
    public class MonthPrinter: IPrinter
    {
        public string Print(DateTime startTime, DateTime finishTime)
        {
            return startTime.ToShortDateString().Substring(0, 5) + " - " + finishTime.ToShortDateString();
        }
    }
}
