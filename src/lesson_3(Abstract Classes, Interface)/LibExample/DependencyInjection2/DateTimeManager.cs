using System;

namespace LibExample.DependencyInjection2
{
    public class DateTimeManager : IDateTimeManager
    {
        public DateTime GetDateTimeNow()
        {
            return DateTime.Now;
        }
    }
}
