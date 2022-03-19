using System;
using System.Reflection;
using LibExample;

namespace _009_Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Man man = Man.GetMan();
            Console.WriteLine(man.ManInfo());
            // Вызов метода GetType() (Метод базового класса object).
            var type = man.GetType();

            // Получение всех свойтв из класса.
            PropertyInfo[] propertiesInfo = type.GetProperties(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);

            foreach (var propertyInfo in propertiesInfo)
            {
               string value = propertyInfo.GetValue(man).ToString();
               Console.WriteLine($"Текущие значение свойтва {propertyInfo.Name}  - {value}");
               propertyInfo.SetValue(man, "Мордор");
            }

            Console.WriteLine(man.ManInfo()); ;
            Console.ReadLine();
        }
    }
}
