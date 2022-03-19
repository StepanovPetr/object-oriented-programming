namespace _008_Operators
{
    class Man
    {
        #region private fields
        private string _firstName;
        private string _secondName;
        private int _age;
        #endregion

        #region   Constructors
        // Конструктор по умолчанию.
        public Man()
        {
            _firstName = "Валерий";
            _secondName = "Кипелов ";
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
            get
            {
                if (_firstName == "")
                    return "В поле отсутствуют данные.";
                else
                    return _firstName;
            }
            set { _firstName = value; }
        }

        public string SecondName
        {
            get
            {
                if (_secondName == "")
                    return "В поле отсутствуют данные.";
                else
                    return _secondName;
            }
            set { _secondName = value; }
        }

        public int Age { get; set; }
        #endregion

        #region public metods
        public string ManInfo()
        {
            return $"FirstName - {_firstName} " +
                $"SecondName - {SecondName} " +
                $"Age - {Age}";
        }
        #endregion


        public static Man operator +(Man firstMan, int age)
        {
             firstMan.Age += age;
             return firstMan;
        }

        public static bool operator ==(Man firstMan, Man secondMan)
        {
            return ((firstMan.Age == secondMan.Age)
                    && (firstMan.FirstName == secondMan.FirstName)
                    && (firstMan._secondName == secondMan._secondName));
        }

        public static bool operator !=(Man firstMan, Man secondMan)
        {
            return ((firstMan.Age != secondMan.Age)
                    || (firstMan.FirstName != secondMan.FirstName)
                    || (firstMan._secondName != secondMan._secondName));
        }
    }
}