using System;
using LibExample.FactoryMethod2;

namespace _002_Factory_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICreator creator = null;
            IProduct product = null;
            IProduct productSecond = null;

            creator = new ConcreteCreator();
            product = creator.FactoryMethod();
            productSecond = creator.FactoryMethod();

            Console.WriteLine(product.GetHashCode());
            Console.WriteLine(productSecond.GetHashCode());
        }
    }
}
