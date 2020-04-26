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
            return string.Format("FirstName - {0} " +
                                 "SecondName - {1} " +
                                 "Age - {2}",
                FirstName, SecondName, Age);
        }
        #endregion
    }
}