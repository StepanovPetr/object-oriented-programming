using System;
// Пространство имен для работы с рефлексией.
using System.Reflection;
using LibExample;

// https://docs.microsoft.com/en-us/dotnet/api/system.type.getfield?view=netframework-4.8
// https://docs.microsoft.com/en-us/dotnet/api/system.reflection.fieldinfo.setvalue?view=netframework-4.8
namespace _005_Reflection
{
    // Пример получения информации о членах калсса.
    class Program
    {
        static void Main(string[] args)
        {

            Man man = new Man();
            // Вызов метода GetType() (Метод базового класса object).
            var type = man.GetType();
            FieldInfo fieldInfo = type.GetField("FirstName",
            BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
            GetMainInfoAboutField(fieldInfo);
            Console.WriteLine();

            fieldInfo = type.GetField("_firstNames",
            BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
            GetMainInfoAboutField(fieldInfo);
            Console.ReadLine();
        }

        static void GetMainInfoAboutField(FieldInfo fieldInfo)
        {
            Console.WriteLine($"Статический член? {fieldInfo.IsStatic}");
            Console.WriteLine($"Приватный член? {fieldInfo.IsPrivate}");
            Console.WriteLine($"Открытый член? {fieldInfo.IsPublic}");
        }
    }
}
