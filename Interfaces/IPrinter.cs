using System;

namespace RangePrinter.Interfaces
{
    interface IPrinter
    {
        string Print(DateTime startTime, DateTime finishTime);
    }
}
