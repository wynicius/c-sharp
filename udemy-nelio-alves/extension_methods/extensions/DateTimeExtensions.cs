using System;
using System.Globalization;
static class DateTimeExtensions
{
    public static string ElapsedTime(this DateTime value)
    {
        TimeSpan span = DateTime.Now.Subtract(value);

        // Years
        if (span.TotalDays > 365.0)
        {
            double years = span.TotalDays / 365.0;
            return years.ToString("F1", CultureInfo.InvariantCulture)
            + " years";
        }
        // Hours
        else if (span.TotalHours < 24.0)
        {
            return span.TotalHours.ToString("F1", CultureInfo.InvariantCulture)
            + " hours";
        }
        // Days
        else
        {
            return span.TotalDays.ToString("F1", CultureInfo.InvariantCulture)
            + " days";
        }
    }
}