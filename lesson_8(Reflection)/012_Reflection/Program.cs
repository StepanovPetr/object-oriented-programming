using System;
using System.Reflection;
using System.Collections.Generic;
using LibExample;

// https://docs.microsoft.com/en-us/dotnet/api/system.type.getconstructors?view=netframework-4.5
namespace _012_Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Man man = Man.GetMan();
            // Вызов метода GetType() (Метод базового класса object).
            var type = man.GetType();

            // Получение всех конструкторов  из класса.
            ConstructorInfo[] constructorInfo = type.GetConstructors();
            
            List<Man> men = new List<Man>();
            // Создание экземпляров класса через вызов конструкторов.
            foreach (var constructor in constructorInfo)
            {
                var person =
                (constructor.GetParameters().Length == 0)
                ? constructor.Invoke(new object[0]{})
                : constructor.Invoke(new object[3] {"Обиван", "Кеноби", 33});

                men.Add((Man)person);
            }

            foreach (var person in men)
                Console.WriteLine(person.ManInfo());

            Console.ReadLine();
        }
    }
}
