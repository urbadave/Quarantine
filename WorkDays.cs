using System;
using System.Collections.Generic;

namespace Quarantine
{
    public class WorkDays
    {
        public List<DateTime> holidayList {get; set;}

        public WorkDays()
        {
            holidayList = new List<DateTime>(){
                new DateTime(2020,7,3),
                new DateTime(2020,11,26),
                new DateTime(2020,12,24),
                new DateTime(2020,12,31),
                new DateTime(2021,1,18),
                new DateTime(2021,2,15),
                new DateTime(2021,5,31),
                new DateTime(2021,7,5),
                new DateTime(2021,9,6),
                new DateTime(2021,11,25),
                new DateTime(2021,12,24),
                new DateTime(2021,12,31),
                new DateTime(2022,1,17),
                new DateTime(2022,2,21),
                new DateTime(2022,5,30),
                new DateTime(2022,7,4),
                new DateTime(2022,9,5),
                new DateTime(2022,11,24),
                new DateTime(2022,11,25),
                new DateTime(2022,12,26),
                new DateTime(2023,1,2),
                new DateTime(2023,1,16),
                new DateTime(2023,2,20),
                new DateTime(2023,3,1),
                new DateTime(2023,5,29),
                new DateTime(2023,6,19),
                new DateTime(2023,7,4),
                new DateTime(2023,9,3),
                new DateTime(2023,11,23),
                new DateTime(2023,11,24),
                new DateTime(2023,12,25),
                new DateTime(2024,1,1),
                new DateTime(2024,1,15),
                new DateTime(2024,2,19),
                new DateTime(2024,3,1),
                new DateTime(2024,5,27),
                new DateTime(2024,6,19),
                new DateTime(2024,7,4),
                new DateTime(2024,9,2),
                new DateTime(2024,11,28),
                new DateTime(2024,11,29),
                new DateTime(2024,12,25),
                new DateTime(2025,1,1),
                new DateTime(2025,1,20),
                new DateTime(2025,2,17),
                new DateTime(2025,3,3),
                new DateTime(2025,5,25),
                new DateTime(2025,6,19),
                new DateTime(2025,7,5),
                new DateTime(2025,9,1),
                new DateTime(2025,11,27),
                new DateTime(2025,11,28),
                new DateTime(2025,12,25)
            };
        }

        public bool isHoliday(DateTime check){
            var index = holidayList.FindIndex(h => h.Year == check.Year && h.Month == check.Month && h.Day == check.Day);
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