namespace _004_Properties
{
    internal class Man
    {
        #region private fields
        private string _firstName;
        private string _secondName;
        private int _age;
        #endregion

        #region Constructors
        // Конструктор по умолчанию.
        public Man()
        {
            FirstName = "Энакин";
            SecondName = "Скайуокер";
            Age = 33;
        }

        // Конструктор с параметрами.
        public Man(string firstName, string secondName, int age)
        {
            FirstName = firstName;
            SecondName = secondName;
            Age = age;
        }
        #endregion

        #region public properties
        // Примеры использования cвойств.
        public string FirstName 
        {
            set { _firstName = value; }
            get { return _firstName; }
        }

        public string SecondName 
        {
            set { _secondName = value; }
            get { return _secondName; } 
        }

        public int Age 
        {
            set { _age = value; }
            get { return _age; } 
        }
        #endregion

        #region public metods
        public string ManInfo()
        {
            return $"FirstName - {FirstName} " +
                   $"SecondName - {SecondName} " +
                   $"Age - {Age}";
        }
        #endregion
    }
}