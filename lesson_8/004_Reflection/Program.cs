using System;

// https://docs.microsoft.com/en-us/dotnet/api/system.type.isenum?view=netframework-4.5
// https://docs.microsoft.com/en-us/dotnet/api/system.type.isinterface?view=netframework-4.5
namespace _004_Reflection
{

    // Получение  данных о классе.
    class Program
    {
        static void Main(string[] args)
        {
            Man man = new Man();
            // Вызов метода GetType() (Метод базового класса object).
            var type = man.GetType();
            Console.WriteLine("Информация о классе");
            GetMainInfoAboutClass(type);
            Console.WriteLine();

            type = typeof(EnumExample);
            Console.WriteLine("Информация о перечислении");
            GetMainInfoAboutClass(type);
            Console.WriteLine();

            StructExample structExample = new StructExample();
            type = structExample.GetType();
            Console.WriteLine("Информация о структуре");
            GetMainInfoAboutClass(type);
            Console.WriteLine("");

            Console.ReadLine();
        }

        static void GetMainInfoAboutClass(Type type)
        {
            Console.WriteLine($"Это класс? {type.IsClass}");
            Console.WriteLine($"Это перечисление? {type.IsEnum}");
            bool isStuct = type.IsValueType && !type.IsEnum;
            Console.WriteLine($"Это структура? {isStuct}");
            Console.WriteLine($"Это интерфейс? {type.IsInterface}");
            Console.WriteLine($"Невозможность наследования  {type.IsSealed}");
            Console.WriteLine($"Public ?  {type.IsPublic}");
            Console.WriteLine($"Not Public ?  {type.IsNotPublic}");
        }
    }
}
