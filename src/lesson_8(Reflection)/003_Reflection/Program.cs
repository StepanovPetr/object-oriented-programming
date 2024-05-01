using System;
using LibExample;

// https://docs.microsoft.com/en-us/dotnet/api/system.type.gettype?view=netframework-4.5#System_Type_GetType_System_String_
namespace _003_Reflection
{
    class Program
    {
        // Третий способ создания обьекта класса type.
        static void Main(string[] args)
        {
            string myString = "Example string";
            // Вызов метода GetType() класса Type (Нужно передать полное имя класса включая namespace).
            var type = Type.GetType("System.String");
            Console.WriteLine("Class name: " + type.FullName);
            Console.WriteLine("Class name: " + type.Name);

            Man man = new Man();
            // Вызов метода GetType() класса Type (Нужно передать полное имя класса включая namespace).
            type = Type.GetType("LibExample.Man,LibExample");
            Console.WriteLine("Class name: " + type);
            Console.WriteLine("Class name: " + type.Name);

            Console.ReadLine();           
        }
    }
}
