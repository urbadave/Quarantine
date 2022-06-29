using System;
using System.Collections.Generic;
using System.Text;

namespace Quarantine
{
    public class DateHoliday: IHoliday
    {
        public int Month { get; set; }
        public int Day { get; set; }

        public DateHoliday() { }
        public DateHoliday(int month, int day)
        {
            Month = month;
            Day = day;
        }

        public DateTime GetDateForYear(int year)
        {
            var retVal = new DateTime(year, Month, Day);
            if (retVal.DayOfWeek == DayOfWeek.Saturday)
                retVal = retVal.AddDays(-1);
            else if (retVal.DayOfWeek == DayOfWeek.Sunday)
                retVal = retVal.AddDays(1);
            return retVal;
        }
    }
}
