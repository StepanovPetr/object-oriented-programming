using System;

namespace LibExample.DependencyInjection2
{
    public interface IDateTimeManager
    {
        /// <summary>
        /// Получить текущие время.
        /// </summary>
        public DateTime GetDateTimeNow();

    }
}
