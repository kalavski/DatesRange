using System;
using myapp.Interfaces;
using myapp.Printers;

namespace myapp
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
                case 0:
                    message = new YearPrinter().Print(startTime, finishTime);
                    break;
                case 1:
                    message = new MonthPrinter().Print(startTime, finishTime);
                    break;
                case 2:
                    message = new DayPrinter().Print(startTime, finishTime);
                    break;
            }

            return message;
        }

        private int CheckRange(DateTime startTime, DateTime finishTime )
        {
            var checker = 0;

            if(startTime.Month == finishTime.Month && startTime.Year == finishTime.Year)
            {
                checker = 2;
            }
            else if(startTime.Year == finishTime.Year)
            { 
                checker = 1;
            }
            return checker;
        }
    }
}
