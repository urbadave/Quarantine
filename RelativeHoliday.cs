using System;
using System.Collections.Generic;
using System.Text;

namespace Quarantine
{
    public enum HolidayRank { first, second, third, fourth, last}

    public class RelativeHoliday: IHoliday
    {
        public HolidayRank Rank { get; set; }
        public DayOfWeek Day { get; set; }
        public int Month { get; set; }
        public bool DayAfter { get; set; }

        public RelativeHoliday() { }

        public RelativeHoliday(HolidayRank rank, DayOfWeek day, int month, bool dayAfter = false)
        {
            Rank = rank;
            Day = day;
            Month = month;
            DayAfter = dayAfter;
        }

        public DateTime GetDateForYear(int year)
        {
            DateTime retVal = DateTime.MinValue;

            if (Rank == HolidayRank.last)
                retVal = FromEnd(year);
            else
                retVal = FromStart(year);

            return (DayAfter) ? retVal.AddDays(1) : retVal;
        }

        private DateTime FromStart(int year)
        {
            var retVal = new DateTime(year, Month, 1);

            while (retVal.DayOfWeek != Day)
                retVal = retVal.AddDays(1);

            switch (Rank)
            {
                case HolidayRank.first:
                    //already there. do nothing
                    break;
                case HolidayRank.second:
                    retVal = retVal.AddDays(7);
                    break;
                case HolidayRank.third:
                    retVal = retVal.AddDays(14);
                    break;
                case HolidayRank.fourth:
                    retVal = retVal.AddDays(21);
                    break;
                case HolidayRank.last:
                    throw new Exception("For last, use FromEnd");
            }

            return retVal;
        }

        private DateTime FromEnd(int year)
        {
            var retVal = new DateTime(year, Month, DateTime.DaysInMonth(year, Month));

            while (retVal.DayOfWeek != Day)
                retVal = retVal.AddDays(-1);

            if (Rank != HolidayRank.last)
                throw new Exception("For anything except last, use FromStart");

            return retVal;
        }
    }
}
