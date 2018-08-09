using System;
using myapp2.Interfaces;

namespace myapp2.Printers
{
    public class DayPrinter: IPrinter
    {
        public string Print(DateTime startTime, DateTime finishTime)
        {
            return startTime.ToShortDateString().Substring(0, 2) + " - " + finishTime.ToShortDateString();
        }
    }
}
