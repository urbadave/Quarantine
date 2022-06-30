using Quarantine;
using System;
using Xunit;

namespace TestQuarantine
{
    public class RelativeHolidayTests
    {
        [Fact]
        public void ItComputesMLKDay2022()
        {
            IHoliday rh = new RelativeHoliday(HolidayRank.third, DayOfWeek.Monday, 1);

            var date = rh.GetDateForYear(2022);
            Assert.Equal(17, date.Day);
        }

        [Fact]
        public void ItComputesMemorialDay2022()
        {
            IHoliday rh = new RelativeHoliday(HolidayRank.last, DayOfWeek.Monday, 5);

            var date = rh.GetDateForYear(2022);
            Assert.Equal(30, date.Day);
        }

        [Fact]
        public void ItComputesThanksgiving2022()
        {
            IHoliday rh = new RelativeHoliday(HolidayRank.fourth, DayOfWeek.Thursday, 11);

            var date = rh.GetDateForYear(2022);
            Assert.Equal(24, date.Day);
        }

        [Fact]
        public void ItComputesDayAfterThanksGiving2022()
        {
            IHoliday rh = new RelativeHoliday(HolidayRank.fourth, DayOfWeek.Thursday, 11, true);

            var date = rh.GetDateForYear(2022);
            Assert.Equal(25, date.Day);
        }
    }
}
