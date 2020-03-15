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
            return string.Format("FirstName - {0} SecondName - {1} Age - {2}", this.FirstName, this.SecondName, this.Age);
            //https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/interpolated Стандарт C# 6
            //return string.Format($"FirstName - {this.FirstName} SecondName - {this.SecondName} Age - {this.Age}");
        }
        #endregion
    }
}
