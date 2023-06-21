namespace _003_Classes
{
    class Man
    {
        #region public fields
        public string FirstName;
        public string SecondName;
        public int Age;
        #endregion

        #region Constructors
        // Конструктор без параметров.
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

        #region public metods
        public string ManInfo()
        {
            return $"FirstName - {FirstName} SecondName - {SecondName} Age - {Age}";
        }

        // Значение переменной по умолчанию.
        public string ManInfoWithPlanet(string planet = "Татуин")
        {
            return $"FirstName - {FirstName} SecondName - {SecondName} Age - {Age} Planet - {planet}";
        }
        #endregion
    }
}
