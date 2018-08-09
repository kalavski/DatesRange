using System;
using myapp.Interfaces;
using myapp.Printers;

namespace myapp
{
    public class MainClass : IMainClass
    {
        public string ShowRange(string start, string finish)
        {
            DateTime startTime = DateTime.Parse(start);
            DateTime finishTime = DateTime.Parse(finish);

            int checker = CheckRange(startTime, finishTime);
            string message = "";
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
            int checker = 0;

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
