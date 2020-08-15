using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace LibExample 
{
    [Serializable]
    public class Man : IBinarySerialization 
    {
        #region static metods

        public static Man GetMan()
        {
            return new Man
            {
                FirstName = _firstNames[_rand.Next(0, _firstNames.Length)],
                SecondName = _secondNames[_rand.Next(0, _secondNames.Length)],
                Age = _rand.Next(1, 101)
            };
        }

        #endregion

        #region static fields

        private static readonly string[] _firstNames =
        {
            "Вова", "Алексей", "Егор",
            "Дима", "Николай", "Петр", "Максим", "Иван"
        };

        private static readonly string[] _secondNames =
        {
            "Мусихин", "Цыганок", "Чердынцев",
            "Степанов", "Куянов", "Атинк", "Максим", "Блинов"
        };

        private static readonly Random _rand = new Random();

        #endregion

        #region public fields

        public string FirstName;
        public string SecondName;
        public int Age;

        #endregion

        #region Constructors

        // Конструктор по умолчанию.
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
            return $"FirstName - {FirstName} SecondName - {SecondName} Age - {Age} Hash - {GetHashCode()}";
        }

        // Значение переменной по умолчанию.
        public string ManInfoWithPlanet(string planet = "Татуин")
        {
            return $"FirstName - {FirstName} SecondName - {SecondName} Age - {Age} Planet - {planet}";
        }

        #endregion

        #region Indexers

        // Индексатор принимающий цело число.
        public string this[int i] => "Целочисленный индексатор";

        // Индексатор принимающий строку.
        public string this[string i] => "Строковой индексатор";

        #endregion

        #region static deserialize

        // Метод для бинарной десерилизации.
        public static Man StaticBinaryDeserialization(string fileName = "Man.bin")
        {
            Man result = null;
            using (var stream = new FileStream(fileName, FileMode.Open))
            {
                var binaryFormatter = new BinaryFormatter();
                result = binaryFormatter.Deserialize(stream) as Man;
            }

            return result;
        }

        #endregion

        #region binary serialize and deserialize

        // Метод для бинарной серилизации.
        public bool BinarySerialization(string fileName = "Man.bin")
        {
            var result = false;
            using (var stream = new FileStream(fileName, FileMode.Create))
            {
                var binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(stream, this);
                result = true;
            }

            return result;
        }

        // Метод для бинарной десерилизации.
        public  Man BinaryDeserialization(string fileName = "Man.bin")
        {
            Man result = null;
            using (var stream = new FileStream(fileName, FileMode.Open))
            {
                var binaryFormatter = new BinaryFormatter();
                result = (Man)binaryFormatter.Deserialize(stream);
            }

            return result;
        }

        #endregion
    }
}