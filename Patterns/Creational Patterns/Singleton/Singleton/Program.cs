using System;

#region Links
// https://www.dofactory.com/net/singleton-design-pattern
// https://refactoring.guru/ru/design-patterns/singleton
#endregion
namespace Singleton
{
    class Program
    {
        // Пример патерна Singleton
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.Instance();
            Singleton s2 = Singleton.Instance();
            Singleton s3 = Singleton.Instance();

            Console.WriteLine(s1.GetHashCode());
            Console.WriteLine(s2.GetHashCode());
            Console.WriteLine(s3.GetHashCode());

            Console.ReadLine();
        }  
    }
}
