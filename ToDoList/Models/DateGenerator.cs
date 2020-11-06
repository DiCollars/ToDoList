using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace ToDoList.Models
{
    public static class DateGenerator
    {
        public static List<KeyValuePair<int, string>> allMonths = GetAllMonths().ToList();
        public static List<DateTime> GetDates(int year, int month)
        {
            return Enumerable.Range(1, DateTime.DaysInMonth(year, month))
                             .Select(day => new DateTime(year, month, day)) 
                             .ToList();
        }

        public static IEnumerable<KeyValuePair<int, string>> GetAllMonths()
        {
            for (int i = 1; i <= 12; i++)
            {
                yield return new KeyValuePair<int, string>(i, DateTimeFormatInfo.CurrentInfo.GetMonthName(i));
            }
        }
    }
}
