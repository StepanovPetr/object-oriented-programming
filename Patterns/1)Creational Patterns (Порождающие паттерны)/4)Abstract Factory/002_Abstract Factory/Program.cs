using System;
using LibExample.AbstractFactory2;

namespace _002_Abstract_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFactory factory = new ConcreteFactory1();
            IProductA productA = factory.CreateProductA();
            IProductB productB = factory.CreateProductB();

            Console.WriteLine($"productA.name - {productA.Name}");
            Console.WriteLine($"productB.name - {productB.Name}");

            factory = new ConcreteFactory2();
            productA = factory.CreateProductA();
            productB = factory.CreateProductB();

            Console.WriteLine($"productA.name - {productA.Name}");
            Console.WriteLine($"productB.name - {productB.Name}");

            Console.ReadLine();
        }
    }
}
