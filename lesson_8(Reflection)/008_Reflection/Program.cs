using System;
using System.Reflection;

// https://docs.microsoft.com/en-us/dotnet/api/system.type.getproperty?view=netframework-4.5
namespace _008_Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Man man = new Man();
            // Вызов метода GetType() (Метод базового класса object).
            var type = man.GetType();

            // Получение всех свойтв из класса.
            PropertyInfo[] propertiesInfo = type.GetProperties(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);

            foreach (var propertyInfo in propertiesInfo)
                GetMainInfoAboutProperty(propertyInfo);

            Console.ReadLine();
        }

        static void GetMainInfoAboutProperty(PropertyInfo propertyInfo)
        {
            Console.WriteLine(propertyInfo.Name);
            Console.WriteLine($"Есть ли в свойстве Get? {propertyInfo.CanRead}");
            Console.WriteLine($"Есть ли в свойстве Set? {propertyInfo.CanWrite}");
            Console.WriteLine();
        }
    }
}
