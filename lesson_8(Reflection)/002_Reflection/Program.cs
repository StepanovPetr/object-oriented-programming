using System;

// https://docs.microsoft.com/en-us/dotnet/api/system.type.gettype?view=netframework-4.5#System_Type_GetType_System_String
namespace _002_Reflection
{
    class Program
    {
        // Второй способ создания обьекта класса type.
        static void Main(string[] args)

        { 
            Man man = new Man();
            // Оператор typeof  возвращает экземпляр класса Type.
            var type = Type.GetType("Man");
            Console.WriteLine("Class name: " + type);
            Console.WriteLine("Class name: " + type.Name);

            Console.ReadLine();
        }
    }
}
