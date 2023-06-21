using System;
using LibExample;

// Пример использования расширяющих методов.
namespace _014_ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string myStrint = "Hello Word";
            // Пример использования метода.
            Console.WriteLine(myStrint.AddSomething());

            var man = Man.GetMan();
            // Пример использования метода.
            Console.WriteLine(man.AddSomething());

            Console.ReadLine();
        }
    }
}
