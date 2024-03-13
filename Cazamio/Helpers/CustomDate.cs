using CazamioProject.Helpers.CustomEnums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.Helpers
{
    public class CustomDate
    {
        private static string GetDateFormat(DateFormat dateFormat)
        {
            string format = string.Empty;
            switch (dateFormat)
            {
                case DateFormat.Short: format = "M'/'d'/'yy"; break;
                case DateFormat.Full: format = "MM'/'dd'/'yyyy"; break;
                case DateFormat.Initials: format = "MMMM dd, yyyy"; break;
            }
            return format;
        }

        public static DateTime GetDate(When when) => DateTime.Today.AddDays((int)when);

        public static string GetDateString(When when, DateFormat dateFormat) =>
            DateTime.Today
            .AddDays((int)when)
            .ToString(GetDateFormat(dateFormat), new CultureInfo("en-US"));


        public static string GetDateString(int when, DateFormat dateFormat) =>
            DateTime.Today
            .AddDays((int)when)
            .ToString(GetDateFormat(dateFormat), new CultureInfo("en-US"));

        public static string GetDateString(When when, PassYear amount, DateFormat dateFormat) =>
            DateTime.Today
            .AddYears((int)amount)
            .AddDays((int)when)
            .ToString(GetDateFormat(dateFormat), new CultureInfo("en-US"));





        public static DateTime Tomorrow()
        {
            DateTime tomorrow = DateTime.Today.AddDays(1);
            return tomorrow;
        }

        public static DateTime DayAfterTomorrow()
        {
            DateTime tomorrow = DateTime.Today.AddDays(2);
            return tomorrow;
        }

        public static DateTime Today()
        {
            DateTime tomorrow = DateTime.Today;
            return tomorrow;
        }

        public static string GetTodayFullFormat()
        {
            string today = DateTime.Today.ToString("MM'/'dd'/'yyyy");
            return today;
        }



        public static string FormatToString(DateTime date)
        {
            return date.ToString("M'/'d'/'yyyy", new CultureInfo("en-US"));
        }

        public static string FormatToFullString(DateTime date)
        {
            return date.ToString("MMMM dd, yyyy", new CultureInfo("en-US"));
        }

        public static string FormatToInitialsString(DateTime date)
        {
            return date.ToString("MMM d, yyyy", new CultureInfo("en-US"));
        }
    }
}
