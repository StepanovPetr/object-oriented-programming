using System;

namespace _005_Properties
{
    internal class Man
    {
        #region public metods
        public string ManInfo()
        {
            return $"FirstName - {FirstName} " +
                $"SecondName - {SecondName} " +
                $"Age - {Age}";
        }
        #endregion

        #region private fields
        private string _firstName;
        private string _secondName;
        private int _age;
        #endregion

        #region Constructors
        // Конструктор по умолчанию.
        public Man()
        {
            _firstName = "";
            _secondName = "";
            _age = 0;
        }

        // Конструктор с параметрами.
        public Man(string firstName, string secondName, int age)
        {
            _firstName = firstName;
            _secondName = secondName;
            _age = age;
        }
        #endregion

        #region public properties
        // Примеры использования свойств.
        public string FirstName
        {
            set { _firstName = value; }
            get
            {
                if (_firstName == "")
                    return "В поле отсутствуют данные.";
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
                return _secondName;
            }
        }

        public int Age
        {
            set
            {
                if (value <= 0 || value >= 120)
                    Console.WriteLine("Вы ввели недопустимое значение." +
                        " Повторите попытку.");
                else
                    _age = value;
            }
            get { return _age; }
        }
        #endregion
    }
}