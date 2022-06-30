using Quarantine;
using System;
using Xunit;

namespace TestQuarantine
{
    public class HolidayFactoryTests
    {
        [Fact]
        public void ItComputes2021Holidays()
        {
            var hf = new HolidayFactory();

            var list = hf.GetHolidayList(2021);

            Assert.NotNull(list);
            Assert.Equal(8, list.Count);

            var i = 0;
            Assert.Equal(1, list[i].Month);
            Assert.Equal(1, list[i].Day);

            i++;
            Assert.Equal(1, list[i].Month);
            Assert.Equal(18, list[i].Day);

            i++;
            Assert.Equal(2, list[i].Month);
            Assert.Equal(15, list[i].Day);

            i++;
            Assert.Equal(5, list[i].Month);
            Assert.Equal(31, list[i].Day);

            i++;
            Assert.Equal(7, list[i].Month);
            Assert.Equal(5, list[i].Day);

            i++;
            Assert.Equal(9, list[i].Month);
            Assert.Equal(6, list[i].Day);

            i++;
            Assert.Equal(11, list[i].Month);
            Assert.Equal(25, list[i].Day);

            i++;
            Assert.Equal(12, list[i].Month);
            Assert.Equal(24, list[i].Day);
        }

        [Fact]
        public void ItComputes2022Holidays()
        {
            var hf = new HolidayFactory();

            var list = hf.GetHolidayList(2022);

            Assert.NotNull(list);
            Assert.Equal(9, list.Count);

            var i = 0;
            Assert.Equal(12, list[i].Month);
            Assert.Equal(31, list[i].Day);

            i++;
            Assert.Equal(1, list[i].Month);
            Assert.Equal(17, list[i].Day);

            i++;
            Assert.Equal(2, list[i].Month);
            Assert.Equal(21, list[i].Day);

            i++;
            Assert.Equal(5, list[i].Month);
            Assert.Equal(30, list[i].Day);

            i++;
            Assert.Equal(7, list[i].Month);
            Assert.Equal(4, list[i].Day);

            i++;
            Assert.Equal(9, list[i].Month);
            Assert.Equal(5, list[i].Day);

            i++;
            Assert.Equal(11, list[i].Month);
            Assert.Equal(24, list[i].Day);

            i++;
            Assert.Equal(11, list[i].Month);
            Assert.Equal(25, list[i].Day);

            i++;
            Assert.Equal(12, list[i].Month);
            Assert.Equal(26, list[i].Day);
        }

        [Fact]
        public void ItComputes2023Holidays()
        {
            var hf = new HolidayFactory();

            var list = hf.GetHolidayList(2023);

            Assert.NotNull(list);
            Assert.Equal(11, list.Count);

            var i = 0;
            Assert.Equal(1, list[i].Month);
            Assert.Equal(2, list[i].Day);

            i++;
            Assert.Equal(1, list[i].Month);
            Assert.Equal(16, list[i].Day);

            i++;
            Assert.Equal(2, list[i].Month);
            Assert.Equal(20, list[i].Day);

            i++;
            Assert.Equal(3, list[i].Month);
            Assert.Equal(1, list[i].Day);

            i++;
            Assert.Equal(5, list[i].Month);
            Assert.Equal(29, list[i].Day);

            i++;
            Assert.Equal(6, list[i].Month);
            Assert.Equal(19, list[i].Day);

            i++;
            Assert.Equal(7, list[i].Month);
            Assert.Equal(4, list[i].Day);

            i++;
            Assert.Equal(9, list[i].Month);
            Assert.Equal(4, list[i].Day);

            i++;
            Assert.Equal(11, list[i].Month);
            Assert.Equal(23, list[i].Day);

            i++;
            Assert.Equal(11, list[i].Month);
            Assert.Equal(24, list[i].Day);

            i++;
            Assert.Equal(12, list[i].Month);
            Assert.Equal(25, list[i].Day);
        }

    }
}
