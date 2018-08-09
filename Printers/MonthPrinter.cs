using System;
using myapp.Interfaces;

namespace myapp.Printers
{
    public class MonthPrinter: IPrinter
    {
        public string Print(DateTime startTime, DateTime finishTime)
        {
            return startTime.ToShortDateString().Substring(0, 5) + " - " + finishTime.ToShortDateString();
        }
    }
}
