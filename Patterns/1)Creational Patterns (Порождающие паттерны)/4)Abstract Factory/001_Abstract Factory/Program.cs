using System;
using LibExample.AbstractFactory1;

namespace _001_Abstract_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AbstractFactory factory = new ConcreteFactory1();
            var productA = factory.GreateProductA();
            var productB = factory.GreateProducB();

            Console.WriteLine($"productA.name - {productA.Name}");
            Console.WriteLine($"productB.name - {productB.Name}");
            
            factory = new ConcreteFactory2();
            productA = factory.GreateProductA();
            productB = factory.GreateProducB();

            Console.WriteLine($"productA.name - {productA.Name}");
            Console.WriteLine($"productB.name - {productB.Name}");

            Console.ReadLine();
        }
    }
}
