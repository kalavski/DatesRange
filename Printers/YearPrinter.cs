using System;
using myapp.Interfaces;

namespace myapp.Printers
{
    public class YearPrinter: IPrinter
    {
        public string Print(DateTime startTime, DateTime finishTime)
        {
            return startTime.ToShortDateString() + " - " + finishTime.ToShortDateString();
        }
    }
}
