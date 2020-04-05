using System;
using System.Reflection;

// https://docs.microsoft.com/en-us/dotnet/api/system.reflection.methodinfo.invoke?view=netframework-1.1&viewFallbackFrom=netframework-4.5
namespace _011_Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Man man = Man.GetMan();
            // Вызов метода GetType() (Метод базового класса object).
            var type = man.GetType();

            // Получение всех методов из класса.
            MethodInfo methodInfo = type.GetMethod("ExamplePrivateMethod", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);

            // Вызов приватного метода с параметрами!!!
            string result =  methodInfo.Invoke(man, new object[] {"StrginParam", 666, true}).ToString();
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
