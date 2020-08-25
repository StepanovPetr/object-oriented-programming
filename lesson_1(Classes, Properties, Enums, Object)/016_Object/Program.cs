using System;
using LibExample;

namespace _016_Object
{
    class Program
    {
        static void Main(string[] args)
        {
            Man man = new Man();
            Type type = man.GetType();
            Console.WriteLine(type);

            Console.ReadLine();
        }
    }
}
