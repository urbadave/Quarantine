using Quarantine;
using System;
using Xunit;

namespace TestQuarantine
{
    public class DateHolidayTests
    {
        [Fact]
        public void ItComputesNewYears2022()
        {
            IHoliday dh = new DateHoliday(1, 1);

            var date = dh.GetDateForYear(2022);
            Assert.Equal(12, date.Month);
            Assert.Equal(31, date.Day);
        }

        [Fact]
        public void ItComutesBirthday()
        {
            IHoliday dh = new DateHoliday(3, 1);

            var date = dh.GetDateForYear(2022);
            Assert.Equal(1, date.Day);

            date = dh.GetDateForYear(2020);
            Assert.Equal(2, date.Day);
        }
    }
}
