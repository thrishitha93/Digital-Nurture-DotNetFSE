using System;

namespace LeapYearCalculatorLib
{
    public class LeapYearCalculator
    {
        public int CheckLeapYear(int year)
        {
            // Invalid range
            if (year < 1753 || year > 9999)
                return -1;

            // Leap year logic
            if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
                return 1;

            // Not a leap year
            return 0;
        }
    }
}