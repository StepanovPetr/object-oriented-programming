using System;
using LibExample;

namespace _001_Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var instance1 = SingletonSimple.Instance();
            var instance2 = SingletonSimple.Instance();

            Console.WriteLine($"instance1 - {instance1.GetHashCode()}");
            Console.WriteLine($"instance2 - {instance2.GetHashCode()}");

            Console.ReadLine();
        }
    }
}
