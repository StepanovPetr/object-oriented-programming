using System;

namespace LibExample.DependencyInjection2
{
    public class OmGTU
    {
        /// <summary>
        /// Проверям открыт ли политех.
        /// </summary>
        /// <returns> Открыт ли политех. </returns>
        public bool IsOpen()
        { 
            DateTime dateTime = DateTime.Now;

            return dateTime.Hour >= 8 
                ? true
                : false;
        }
    }
}
