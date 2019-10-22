using System;
using System.Collections.Generic;
using System.Text;

namespace day07
{


    // Vinicio - in CS, we say that enums facilitate type safety, and value safety
    public enum DayOfWeek : byte
    {
        Sunday = 100,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

    public enum Month
    {
        January = 1, 
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }

    class Date
    {

        public Month Month { get; set; }
        public DayOfWeek DayOfWeek { get; set; }
    }
}
