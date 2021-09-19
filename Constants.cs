using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mobile_bill
{
    public static class Constants
    {
        public static int Pulse { get; private set; } = 20;

        private static DateTime PeekHourStartTime => Convert.ToDateTime("9.00.00 am");
        private static DateTime PeekHourEndTime => Convert.ToDateTime("10.59.59 pm");

        public static bool IsPeekHour(this DateTime dateTime)
        {
            return dateTime.TimeOfDay >= PeekHourStartTime.TimeOfDay && dateTime.TimeOfDay <= PeekHourEndTime.TimeOfDay;
        }

        public static decimal ConvertToTaka(this decimal paisa)
        {
            return paisa / 100;
        }
    }
}
