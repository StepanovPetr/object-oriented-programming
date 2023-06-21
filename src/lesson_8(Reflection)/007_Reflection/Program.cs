using System;
using System.Reflection;
using LibExample;

// https://docs.microsoft.com/en-us/dotnet/api/system.type.getfields?view=netframework-4.5
namespace _007_Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Man man = new Man();
            // Вызов метода GetType() (Метод базового класса object).
            var type = man.GetType();
            
            // Получение всех переменных из класса.
            FieldInfo[] fieldsInfo = type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);

            foreach(var fieldInfo in fieldsInfo)
                GetMainInfoAboutField(fieldInfo);
           
            Console.ReadLine();
        }

        static void GetMainInfoAboutField(FieldInfo fieldInfo)
        {
            Console.WriteLine(fieldInfo.Name);
            Console.WriteLine($"Статический член? {fieldInfo.IsStatic}");
            Console.WriteLine($"Приватный член? {fieldInfo.IsPrivate}");
            Console.WriteLine($"Открытый член? {fieldInfo.IsPublic}");
            Console.WriteLine();
        }
    }
}
