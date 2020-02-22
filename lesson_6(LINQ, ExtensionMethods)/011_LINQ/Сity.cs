namespace _011_LINQ
{
    class Сity
    {
        public string ManInfo()
        {
            return string.Format("Название города - {0} Население - {1} Мэр - {2} ", this.Name, this.Population, this.Mayor);
            //https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/interpolated Стандарт C# 6
            //return string.Format($"FirstName - {this.FirstName} SecondName - {this.SecondName} Age - {this.Age}");
        }

        public string Name { get; set;}
        public int Population { get; set; }
        public string Mayor { get; set; }
    }
}
