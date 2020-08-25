namespace _002_Classes
{
    class Man
    {
        #region public fields
        public string FirstName;
        public string SecondName;
        public int Age;
        #endregion

        #region public metods
        public string ManInfo()
        {
            return $"FirstName - {FirstName} " 
                   + $"SecondName - {SecondName} " 
                   + $"Age - {Age}";
        }
        #endregion
    }
}
