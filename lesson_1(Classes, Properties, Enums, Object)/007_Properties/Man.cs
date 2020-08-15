namespace _007_Properties
{
    internal class Man
    {
        #region public metods

        public string ManInfo()
        {
            return $"FirstName - {FirstName} SecondName - {SecondName} Age - {Age}";
        }

        #endregion

        #region public properties

        // Автоматически реализуемые свойства. 
        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public int Age { get; set; }

        #endregion
    }
}