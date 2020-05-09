using System;

namespace LibExample
{
    public class Man
    {
        #region static fields
        private static readonly string[] _firstNames = new string[] 
            { "Вова", "Алексей", "Егор", 
                "Дима", "Николай", "Петр", "Максим", "Иван" };
        private static readonly string[] _secondNames = new string[] 
            { "Мусихин", "Цыганок", "Чердынцев", 
                "Степанов", "Куянов", "Атинк", "Максим", "Блинов" };
        private static readonly Random _rand = new Random();
        #endregion

        #region public fields
        public string FirstName;
        public string SecondName;
        public int Age;
        #endregion

        #region   Constructors
        // Конструктор по умолчанию
        public Man()
        {
            this.FirstName = "Энакин";
            this.SecondName = "Скайуокер";
            this.Age = 33;
        }

        // Конструктор с параметрами
        public Man(string firstName, string secondName, int age)
        {
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.Age = age;
        }
        #endregion

        #region public metods
        public string ManInfo() => $"FirstName - {this.FirstName} SecondName - {this.SecondName} Age - {this.Age} Hash - {this.GetHashCode()}";

        // значение переменной по умолчанию.
        public string ManInfoWithPlanet(string planet = "Татуин")
        {
            return $"FirstName - {this.FirstName} SecondName - {this.SecondName} Age - {this.Age} Planet - {planet}";
        }
        #endregion

        #region static metods
        public static Man GetMan()
        {
            return new Man()
            {
                FirstName = _firstNames[_rand.Next(0, _firstNames.Length)],
                SecondName = _secondNames[_rand.Next(0, _secondNames.Length)],
                Age = _rand.Next(1, 101)
            };
        }
        #endregion

        #region Indexers
        // Индексатор принимающий цело число.
        public string this[int i] => "Целочисленный индексатор";

        // Индексатор принимающий строку.
        public string this[string i] => "Строковой индексатор";

        #endregion
    }
}