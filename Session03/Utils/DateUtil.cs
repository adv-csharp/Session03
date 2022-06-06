using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session03.Utils
{
    public static class DateUtil
    {
        public static string ToJalali(this DateTime date)
        {
            var pc = new PersianCalendar();
            var result = $"{pc.GetYear(date)}/{pc.GetMonth(date)}/{pc.GetDayOfMonth(date)}";
            return result;
        }
    }
}
