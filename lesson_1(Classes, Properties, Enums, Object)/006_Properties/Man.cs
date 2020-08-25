namespace _006_Properties
{
    class Man
    {
        #region private fields
        private string _firstName;
        private readonly string _secondName;
        private readonly int _age;
        #endregion

        #region   Constructors
        // Конструктор без параметров.
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
        // Примеры использования cвойств.
        public string FirstName
        {
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
        }

        public int Age
        {
            get { return _age; }
        }
        #endregion

        #region public metods
        public string ManInfo()
        {
            return $"FirstName - {this._firstName} " +
                   $"SecondName - {this.SecondName} " +
                   $"Age - {this.Age}";
        }
        #endregion
    }
}