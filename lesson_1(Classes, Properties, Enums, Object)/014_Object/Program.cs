using System;
using LibExample;

namespace _014_Object
{
    class Program
    {
        static void Main(string[] args)
        {
            Man man = new Man();
            Man man2 = man.MemberwiseClone();

            Console.WriteLine(man.GetHashCode());
            Console.WriteLine(man2.GetHashCode());
            Console.ReadLine();
        }
    }
}
