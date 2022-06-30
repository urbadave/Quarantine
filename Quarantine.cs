using System;
using System.Collections.Generic;

namespace Quarantine
{
    class Program
    {
        static void Main(string[] args)
        {
            var start = new DateTime(2020, 3, 16);

            var today = DateTime.Now;
            var span = today.Subtract(start);
            var days = span.Days;
            var weeks = days/7;

            var factory = new HolidayFactory();
            var holidayList = new List<DateTime>();
            for(var y = start.Year; y <= today.Year; y++)
            {
                holidayList.AddRange(factory.GetHolidayList(y));
            }

            var workDays = new WorkDays(holidayList);
            var totalWorkDays = 0;
            var checkDay = start;
            while(checkDay < today){
                if(workDays.isWorkDay(checkDay)) totalWorkDays++;
                checkDay = checkDay.AddDays(1);
            }

            Console.WriteLine($"Been working from home for {days} total days");
            Console.WriteLine($"or {totalWorkDays} work days");
            Console.WriteLine($"or {weeks} weeks");
            Console.WriteLine($"starting from {start.ToString("MM/dd/yyyy")}");
            Console.WriteLine("Holidays are dynamicaly calculated.");

            var nothing = Console.ReadLine();
        }
    }

}
