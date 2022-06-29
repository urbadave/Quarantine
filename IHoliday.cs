using System;

namespace Quarantine
{
    public interface IHoliday
    {
        DateTime GetDateForYear(int year);
    }
}