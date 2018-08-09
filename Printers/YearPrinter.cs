using System;
using myapp2.Interfaces;

namespace myapp2.Printers
{
    public class YearPrinter: IPrinter
    {
        public string Print(DateTime startTime, DateTime finishTime)
        {
            return startTime.ToShortDateString() + " - " + finishTime.ToShortDateString();
        }
    }
}
