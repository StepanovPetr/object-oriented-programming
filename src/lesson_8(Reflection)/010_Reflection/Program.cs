using System;
using System.Reflection;
using LibExample;

// https://docs.microsoft.com/en-us/dotnet/api/system.type.getmethods?view=netframework-4.5
namespace _010_Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Man man = Man.GetMan();
            Console.WriteLine(man.ManInfo());
            // Вызов метода GetType() (Метод базового класса object).
            var type = man.GetType();

            // Получение всех методов из класса.
            MethodInfo[] methodsInfo = type.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);

            foreach (var methodInfo in methodsInfo)
            {
                GetMainInfoAboutMethod(methodInfo);
            }

            Console.ReadLine();
        }

        // Вывод на экран информации о методе.
        static void GetMainInfoAboutMethod(MethodInfo methodInfo)
        {
            Console.WriteLine(methodInfo.Name);
            Console.WriteLine($"Тип возвращаемого значения {methodInfo.ReturnType.Name}");
            var parameters = methodInfo.GetParameters();
            Console.WriteLine("Принимаемые параметры");
            foreach(var parameter in parameters)
                Console.WriteLine($"{parameter.Name} - {parameter.ParameterType.Name}");

            Console.WriteLine();
        }
    }
}
