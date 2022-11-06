using System;
    
#region Links
// https://www.dofactory.com/net/prototype-design-pattern
// https://docs.microsoft.com/en-us/dotnet/api/system.icloneable.clone?view=netframework-4.8
#endregion
namespace Prototype
{
    class Program
    {
        // Пример патерна Prototype через реализацию интерфейса ICloneable.
        static void Main(string[] args)
        {
            Man man = new Man();
            // Создание нового экземпляра класса вызовом метода Clone().
            Man cloneMan = (Man)man.Clone();

            Console.WriteLine(man.ManInfo());
            Console.WriteLine(cloneMan.ManInfo());

            Console.ReadLine();
        }
    }
}
