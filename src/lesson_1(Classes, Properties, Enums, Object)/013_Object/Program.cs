using System;
using LibExample;

namespace _013_Object
{
    class Program
    {
        static void Main(string[] args)
        {
            Man man = new Man();
            Man man2 = new Man();
            Man man3 = man;

            // Экземпляры ссылаются на разные участки в оперативной памяти.
            Console.WriteLine(Object.ReferenceEquals(man, man2));

            // Экземпляры ссылаются на один и тотже участок в оперативной памяти.
            Console.WriteLine(Object.ReferenceEquals(man, man3));
            Console.ReadLine();
        }
    }
}
