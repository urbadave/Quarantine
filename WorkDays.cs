using System;
using System.Collections.Generic;

namespace Quarantine
{
    public class WorkDays
    {
        public List<DateTime> HolidayList {get; set;}

        public WorkDays()
        {
            HolidayList = new List<DateTime>();
        }

        public WorkDays(List<DateTime> holidayList)
        {
            HolidayList = holidayList;
        }

        public bool isHoliday(DateTime check){
            var index = HolidayList.FindIndex(h => h.Year == check.Year && h.Month == check.Month && h.Day == check.Day);
            return (index != -1);
        }

        public bool isWorkDay(DateTime check){             
            var isWeekend = (check.DayOfWeek == DayOfWeek.Saturday || check.DayOfWeek == DayOfWeek.Sunday);
            if(isWeekend) return false;

            if(isHoliday(check)) return false;

            return true;
        }
    }    
}