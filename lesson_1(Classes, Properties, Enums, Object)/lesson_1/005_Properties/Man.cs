using System;

namespace _005_Properties
{
    class Man
    {
        #region private fields
        private string _firstName;
        private string _secondName;
        private int _age;
        #endregion

        #region   Constructors
        //Конструктор по умолчанию
        public Man()
        {
            this._firstName = "";
            this._secondName = "";
            this._age = 0;
        }

        //Конструктор с параметрами
        public Man(string firstName, string secondName, int age)
        {
            this._firstName = firstName;
            this._secondName = secondName;
            this._age = age;
        }
        #endregion

        #region public properties
        //Примеры использования Свойств
        public string FirstName
        {
            set { _firstName = value; }
            get
            {
                if (_firstName == "")
                    return "В поле отсутствуют данные.";
                else
                    return _firstName;
            }
        }

        public string SecondName
        {
            set { _secondName = value; }
            get
            {
                if (_secondName == "")
                    return "В поле отсутствуют данные.";
                else
                    return _secondName;
            }
        }

        public int Age
        {
            set
            {
                if (value <= 0 || value >= 120)
                    Console.WriteLine("Вы ввели недопустимое значение. Повторите попытку.");
                else
                    _age = value;
            }
            get
            {
                return _age;
            }
        }
        #endregion

        #region public metods
        public string ManInfo()
        {
            return string.Format("FirstName - {0} SecondName - {1} Age - {2}", this.FirstName, this.SecondName, this.Age);
        https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/interpolated Стандарт C# 6
            return string.Format($"FirstName - {this.FirstName} SecondName - {this.SecondName} Age - {this.Age}");
        }
        #endregion
    }
}
