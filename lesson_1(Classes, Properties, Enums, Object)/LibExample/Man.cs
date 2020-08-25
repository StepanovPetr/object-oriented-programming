namespace LibExample
{
    public class Man
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
        // Примеры использования Свойств.
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

        public int Age
        {
            get
            {
                return _age;
            }
        }
        #endregion

        #region public metods
        public string ManInfo()
        {
            return $"FirstName - {_firstName} " +
                $"SecondName - {SecondName} " +
                $"Age - {Age}";
        }

        // Пример неглубокого копирования.
        public Man Clone()
        {
           return (Man) base.MemberwiseClone();
        }
        #endregion

        #region operators
        public static bool operator ==(Man firstMan, Man secondMan)
        {
            if (firstMan == null || secondMan == null)
                return false;

            return ((firstMan.Age == secondMan.Age)
                    && (firstMan.FirstName == secondMan.FirstName)
                    && (firstMan._secondName == secondMan._secondName))
                ? true
                : false;
        }

        public static bool operator !=(Man firstMan, Man secondMan)
        {
            if (firstMan == null || secondMan == null)
                return true;

            return ((firstMan.Age == secondMan.Age)
                    && (firstMan.FirstName == secondMan.FirstName)
                    && (firstMan._secondName == secondMan._secondName))
                ? false
                : true;
        }
        #endregion
    }
}