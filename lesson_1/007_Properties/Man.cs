using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_Properties
{
    class Man
    {
        #region   Constructors
        //Конструктор по умолчанию
        public Man()
        {
            
        }
        #endregion

        #region public properties
        // Автоматически реализуемые свойства. 
        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public int Age { get; set; }
        #endregion

        #region public metods
        public string ManInfo()
        {
            return string.Format("FirstName - {0} SecondName - {1} Age - {2}", this.FirstName, this.SecondName, this.Age);
            //https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/interpolated Стандарт C# 6
            //return string.Format($"FirstName - {this.FirstName} SecondName - {this.SecondName} Age - {this.Age}");
        }
        #endregion
    }
}
