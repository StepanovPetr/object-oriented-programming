namespace _002_Classes
{
    /// <summary> Класс Man (человек). </summary>
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

        #region public metods

        /// <summary> Пример метода. </summary>
        /// <remarks> Получение информации об экземпляре класса. </remarks>
        /// <returns> Информация об экземпляре класса. </returns>
        public string ManInfo()
        {
            return $"FirstName - {FirstName} " 
                   + $"SecondName - {SecondName} " 
                   + $"Age - {Age}";
        }
        #endregion
    }
}
