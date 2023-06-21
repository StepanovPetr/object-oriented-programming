using System;
using LibExample;

namespace _020_Serialize
{
    class Program
    {
        static void Main(string[] args)
        {
            Man man = new Man("Вася", "Пупкин", 65);
            man.BinarySerialization();
            Man manFromFile = Man.StaticBinaryDeserialization();

            Console.WriteLine(man.ManInfo());
            Console.WriteLine(manFromFile.ManInfo());

            Console.ReadLine();
        }
    }
}
