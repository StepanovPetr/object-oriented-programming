using System;

namespace LibExample.DependencyInjection2
{
    public class OmGTUFix
    {
        private IDateTimeManager _timeManager;

        public OmGTUFix(IDateTimeManager dateTimeManager)
        { 
            _timeManager = dateTimeManager;
        }
 
        /// <summary>
        /// Проверям открыт ли политех.
        /// </summary>
        /// <returns> Открыт ли политех. </returns>
        public bool IsOpen()
        { 
            DateTime dateTime = _timeManager.GetDateTimeNow();

            return dateTime.Hour >= 8 
                ? true
                : false;
        }
    }
}
