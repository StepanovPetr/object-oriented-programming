namespace _004_Properties
{
    internal class Man
    {
        #region public metods

        public string ManInfo()
        {
            return $"FirstName - {FirstName} SecondName - {SecondName} Age - {Age}";
        }

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
        public string FirstName { set; get; }

        public string SecondName { set; get; }

        public int Age { set; get; }

        #endregion
    }
}