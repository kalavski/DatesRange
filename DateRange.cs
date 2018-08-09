using System;
using myapp2.Interfaces;
using myapp2.Printers;

namespace myapp2
{
    public class DateRange : IDateRange
    {
        public string ShowRange(string start, string finish)
        {
            var startTime = DateTime.Parse(start);
            var finishTime = DateTime.Parse(finish);

            var checker = CheckRange(startTime, finishTime);
            var message = "";
            switch(checker)
            {
                case DateEnum.Years:
                    message = new YearPrinter().Print(startTime, finishTime);
                    break;
                case DateEnum.Months:
                    message = new MonthPrinter().Print(startTime, finishTime);
                    break;
                case DateEnum.Days:
                    message = new DayPrinter().Print(startTime, finishTime);
                    break;
            }

            return message;
        }

        private DateEnum CheckRange(DateTime startTime, DateTime finishTime )
        {
            var checker = DateEnum.Years;

            if(startTime.Month == finishTime.Month && startTime.Year == finishTime.Year)
            {
                checker = DateEnum.Days;
            }
            else if(startTime.Year == finishTime.Year)
            { 
                checker = DateEnum.Months;
            }
            return checker;
        }
    }

    enum DateEnum
    {
        Days, Months, Years
    }
}
