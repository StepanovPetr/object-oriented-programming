using System;

// https://docs.microsoft.com/en-us/dotnet/api/system.type?view=netframework-4.8
namespace _001_Reflection
{
    class Program
    {
        // Первый способ создания обьекта класса type.
        static void Main(string[] args)
        {
            string myString = "Example string";
            // Вызов метода GetType() (Метод базового класса object).
            var type = myString.GetType();
            Console.WriteLine("Class name: " + type.FullName);
            Console.WriteLine("Class name: " + type.Name);

            Man man = new Man();
            // Вызов метода GetType() (Метод базового класса object).
            type = man.GetType();
            Console.WriteLine("Class name: " + type);
            Console.WriteLine("Class name: " + type.Name);

            Console.ReadLine();
        }
    }
}
