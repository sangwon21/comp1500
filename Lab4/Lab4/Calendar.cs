﻿namespace Lab4
{
    public static class Calendar
    {
        public static bool IsLeapYear(uint year)
        {
            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            {
                return true;
            }

            return false;
        }

        public static int GetDaysInMonth(uint year, uint month)
        {
            if (year > 9999)
            {
                return -1;
            }

            if (IsLeapYear(year) && month == 2)
            {
                return 29;
            }
            else if (IsLeapYear(year) == false && month == 2)
            {
                return 28;
            }
                      
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;
                default:
                    return -1;
            }
        }
    }
}