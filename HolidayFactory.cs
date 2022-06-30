using System;
using System.Collections.Generic;
using System.Text;

namespace Quarantine
{
    public class HolidayFactory
    {
        private List<IHoliday> Pre2022Holidays;
        private List<IHoliday> On2022Holidays;
        private List<IHoliday> Post2022Holidays;

        public HolidayFactory()
        {
            Pre2022Holidays = new List<IHoliday>();
            On2022Holidays = new List<IHoliday>();
            Post2022Holidays = new List<IHoliday>();

            var NewYears = new DateHoliday(1, 1);
            var MartinLutherKing = new RelativeHoliday(HolidayRank.third, DayOfWeek.Monday, 1);
            var Presidents = new RelativeHoliday(HolidayRank.third, DayOfWeek.Monday, 2);
            var Birthday = new DateHoliday(3, 1);
            var Memorial = new RelativeHoliday(HolidayRank.last, DayOfWeek.Monday, 5);
            var Juneteenth = new DateHoliday(6, 19);
            var Independence = new DateHoliday(7, 4);
            var Labor = new RelativeHoliday(HolidayRank.first, DayOfWeek.Monday, 9);
            var Thanksgiving = new RelativeHoliday(HolidayRank.fourth, DayOfWeek.Thursday, 11);
            var AfterThanksgiving = new RelativeHoliday(HolidayRank.fourth, DayOfWeek.Thursday, 11, true);
            var Christmas = new DateHoliday(12, 25);

            Pre2022Holidays.Add(NewYears);
            On2022Holidays.Add(NewYears);
            Post2022Holidays.Add(NewYears);

            Pre2022Holidays.Add(MartinLutherKing);
            On2022Holidays.Add(MartinLutherKing);
            Post2022Holidays.Add(MartinLutherKing);

            Pre2022Holidays.Add(Presidents);
            On2022Holidays.Add(Presidents);
            Post2022Holidays.Add(Presidents);

            Post2022Holidays.Add(Birthday);

            Pre2022Holidays.Add(Memorial);
            On2022Holidays.Add(Memorial);
            Post2022Holidays.Add(Memorial);

            Post2022Holidays.Add(Juneteenth);

            Pre2022Holidays.Add(Independence);
            On2022Holidays.Add(Independence);
            Post2022Holidays.Add(Independence);

            Pre2022Holidays.Add(Labor);
            On2022Holidays.Add(Labor);
            Post2022Holidays.Add(Labor);

            Pre2022Holidays.Add(Thanksgiving);
            On2022Holidays.Add(Thanksgiving);
            Post2022Holidays.Add(Thanksgiving);

            On2022Holidays.Add(AfterThanksgiving);
            Post2022Holidays.Add(AfterThanksgiving);

            Pre2022Holidays.Add(Christmas);
            On2022Holidays.Add(Christmas);
            Post2022Holidays.Add(Christmas);
        }

        public List<DateTime> GetHolidayList(int year)
        {
            var retVal = new List<DateTime>();

            if(year < 2022)
            {
                Pre2022Holidays.ForEach(h => retVal.Add(h.GetDateForYear(year)));
            }
            else if (year == 2022)
            {
                On2022Holidays.ForEach(h => retVal.Add(h.GetDateForYear(year)));
            }
            else
            {
                Post2022Holidays.ForEach(h => retVal.Add(h.GetDateForYear(year)));
            }

            return retVal;
        }
    }
}
