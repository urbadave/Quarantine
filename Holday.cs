using System;
using System.Collections.Generic;
using System.Text;

namespace Quarantine
{
    public class Holday : IHoliday
    {
        public DateTime GetDateForYear(int year)
        {
            return DateTime.Now;
        }
    }
}
