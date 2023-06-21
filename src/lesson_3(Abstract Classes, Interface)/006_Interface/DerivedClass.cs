using System;

namespace _006_Interface
{
    class DerivedClass : BaseClass, IInterface1, IInterface2
    {
        public void Method1()
        {
            Console.WriteLine("Реализация метода " +
                "Method1() из IInterface1");
        }
    }
}