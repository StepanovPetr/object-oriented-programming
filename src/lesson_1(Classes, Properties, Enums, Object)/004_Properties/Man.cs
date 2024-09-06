namespace _004_Properties
{
    internal class Man
    {
        #region private fields
        /// <summary> Имя. </summary>
        private string _firstName;

        /// <summary> Фамилия. </summary>
        private string _secondName;

        /// <summary> Возраст. </summary>
        private int _age;
        #endregion

        #region Constructors
        
        /// <summary> Конструктор по умолчанию. </summary>
        public Man()
        {
            FirstName = "Энакин";
            SecondName = "Скайуокер";
            Age = 33;
        }

        /// <summary> Конструктор с параметрами. </summary>
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
        /// <summary> Пример метода. </summary>
        /// <remarks> Получение информации об экземпляре класса. </remarks>
        /// <returns> Информация об экземпляре класса. </returns>
        public string ManInfo()
        {
            return $"FirstName - {FirstName} " +
                   $"SecondName - {SecondName} " +
                   $"Age - {Age}";
        }
        #endregion
    }
}