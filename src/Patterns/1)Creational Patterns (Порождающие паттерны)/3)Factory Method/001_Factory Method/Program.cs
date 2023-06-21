using System;
using LibExample.FactoryMethod1;

namespace _001_Factory_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Creator creator = null;
            Product product = null;
            Product productSecond = null;

            creator = new ConcreteCreator();
            product = creator.FactoryMethod();
            productSecond = creator.FactoryMethod();

            Console.WriteLine(product.GetHashCode());
            Console.WriteLine(productSecond.GetHashCode());
        }
    }
}
