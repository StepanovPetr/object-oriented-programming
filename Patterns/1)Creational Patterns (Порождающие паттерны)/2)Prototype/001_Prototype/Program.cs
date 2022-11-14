using System;
using LibExample.Prototype2;

namespace _001_Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPrototype prototype = null;
            IPrototype clone = null;

            prototype = new ConcretePrototype1(1);
            clone = prototype.Clone();
            Console.WriteLine($"prototype - {prototype.GetHashCode()}  clone - {clone.GetHashCode()}");

            prototype = new ConcretePrototype2(2);
            clone = prototype.Clone();
            Console.WriteLine($"prototype - {prototype.GetHashCode()}  clone - {clone.GetHashCode()}");
        }
    }
}
