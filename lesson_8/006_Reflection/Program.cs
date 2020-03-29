using System;
// Пространство имен для работы с рефлексией.
using System.Reflection;

namespace _006_Reflection
{
    // Пример чтения и записи значений в члены класса.
    class Program
    {
        static void Main(string[] args)
        {

            Man man = Man.GetMan();
            Console.WriteLine(man.ManInfo());

            // Вызов метода GetType() (Метод базового класса object).
            var type = man.GetType();
            FieldInfo fieldInfo = type.GetField("FirstName",
            BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);

            // Получения значения переменной.
            string firstName = (string)fieldInfo.GetValue(man);
            Console.WriteLine($"First Name {firstName}");

            // Установка значения переменной.
            fieldInfo.SetValue(man,"Энакин");
            Console.WriteLine(man.ManInfo());

            fieldInfo = type.GetField("_age",
            BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);

            // Получения значения переменной Private!!!.
            int age = (int)fieldInfo.GetValue(man);
            Console.WriteLine($"age {age}");

            // Установка значения переменной Private!!!.
            fieldInfo.SetValue(man, 999);
            Console.WriteLine(man.ManInfo());

            Console.ReadLine();
        }
    }
}
