using System.Runtime.Serialization.Formatters.Binary;

namespace LibExample.Single_responsibility_principle.Before
{
    [System.Serializable()]
    public class Man
    {

        #region static fields
        static string[] _firstNames = new string[] { "Вова", "Алексей", "Егор", "Дима", "Николай", "Петр", "Максим", "Иван" };
        static string[] _secondNames = new string[] { "Мусихин", "Цыганок", "Чердынцев", "Степанов", "Куянов", "Атинк", "Максим", "Блинов" };
        static string[] _cities = new string[] { "Омск", "Москва", "Хацупетовка", "Исилькуль", "Магадан" };
        static Random _rand = new Random();
        #endregion

        #region public fields
        public string FirstName;
        public string SecondName;
        public int Age;
        #endregion

        #region   Constructors
        // Конструктор по умолчанию.
        public Man()
        {
            this.FirstName = "Энакин";
            this.SecondName = "Скайуокер";
            this.Age = 33;
        }

        // Конструктор с параметрами.
        public Man(string firstName, string secondName, int age)
        {
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.Age = age;
        }
        #endregion

        #region public metods
        public static Man GetMan()
        {
            return new Man()
            {
                FirstName = _firstNames[_rand.Next(0, _firstNames.Length)],
                SecondName = _secondNames[_rand.Next(0, _secondNames.Length)],
                City = _cities[_rand.Next(0, _cities.Length)],
                Age = _rand.Next(1, 101)
            };
        }

        public bool BinarySerialization(string fileName = "Man.bin")
        {
            bool result = false;
            using (FileStream stream = new FileStream(fileName, FileMode.Create))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(stream, this);
                result = true;
            }
            return result;
        }

        public static Man BinaryDeserialization(string fileName = "Man.bin")
        {
            Man result = null;
            using (FileStream stream = new FileStream(fileName, FileMode.Open))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                result = binaryFormatter.Deserialize(stream) as Man;
            }
            return result;
        }

        public string ManInfo()
        {
            return $"FirstName - {this.FirstName} SecondName - {this.SecondName} Age - {this.Age} City - {this.City} Hash - {this.GetHashCode()}";
            // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/interpolated Стандарт C# 6
        }

        // значение переменной по умолчанию.
        public string ManInfoWithPlanet(string planet = "Татуин")
        {
            return $"FirstName - {this.FirstName} SecondName - {this.SecondName} Age - {this.Age} Planet - {planet}";
            // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/interpolated Стандарт C# 6
        }
        #endregion

        #region public property
        public string City { get; set; }
        #endregion
    }
}
