
using System;

namespace myapp2.Validation
{
    public static class Validation
    {
        public static bool IsValid(string startDate, string finishDate)
        {   
            DateTime startDateTime;
            DateTime finishDateTime;
            if(!DateTime.TryParse(startDate, out startDateTime) || !DateTime.TryParse(finishDate, out finishDateTime))
            {
                return false;
            }
            if(startDateTime > finishDateTime)
            {
                return false;
            }

            return true;
        }
    }
}