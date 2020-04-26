namespace _007_Properties
{
    internal class Man
    {
        #region public metods

        public string ManInfo()
        {
            return string.Format("FirstName - {0} SecondName - {1} Age - {2}", FirstName, SecondName, Age);
            //https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/interpolated Стандарт C# 6
            //return string.Format($"FirstName - {this.FirstName} SecondName - {this.SecondName} Age - {this.Age}");
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