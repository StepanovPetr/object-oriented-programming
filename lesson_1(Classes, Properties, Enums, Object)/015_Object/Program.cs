using System;
using LibExample;

namespace _015_Object
{
    class Program
    {
        static void Main(string[] args)
        {
            Man man = new Man();
            Man man2 = man;
            Man man3 = new Man();

            // Проверка на то, что экземпляры равны.
            Console.WriteLine(man.Equals(man2));

            // Проверка на то, что экземпляры равны.
            Console.WriteLine(man.Equals(man3));

            Console.ReadLine();
        }
    }
}
