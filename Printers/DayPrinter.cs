using System;
using myapp.Interfaces;

namespace myapp.Printers
{
    public class DayPrinter: IPrinter
    {
        public string Print(DateTime startTime, DateTime finishTime)
        {
            return startTime.Day + " - " + finishTime.ToShortDateString();
        }
    }
}
