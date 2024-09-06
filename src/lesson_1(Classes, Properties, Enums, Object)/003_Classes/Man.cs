namespace _003_Classes
{
    class Man
    {
        #region public fields
        /// <summary> Возраст. </summary>
        public int Age;

        /// <summary> Имя. </summary>
        public string FirstName;

        /// <summary> Фамилия. </summary>
        public string SecondName;
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

        /// <summary> Пример метода. </summary>
        /// <remarks> Получение информации об экземпляре класса. </remarks>
        /// <returns> Информация об экземпляре класса. </returns>
        public string ManInfo()
        {
            return $"FirstName - {FirstName} SecondName - {SecondName} Age - {Age}";
        }

        /// <summary> Пример метода. </summary>
        /// <param name="planet"> Параметр метода. Может принимать значение по-умолчанию. </param>
        /// <returns> Информация об экземпляре класса. </returns>
        public string ManInfoWithPlanet(string planet = "Татуин")
        {
            return $"FirstName - {FirstName} SecondName - {SecondName} Age - {Age} Planet - {planet}";
        }
        #endregion
    }
}
