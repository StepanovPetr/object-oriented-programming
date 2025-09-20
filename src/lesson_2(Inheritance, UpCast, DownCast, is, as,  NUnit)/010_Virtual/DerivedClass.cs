using System;

namespace _010_Virtual
{
    public class DerivedClass : BaseClass
    {
        // Пример замещения метода в дочернем классе.
        public void NormalMethod()
        {
            Console.WriteLine("Normal method from derived class");
        }

        // Пример переопределения виртуального метода в дочернем классе.
        public override void VirtualMethod()
        {
            Console.WriteLine("Virtual method from derived class");
        }
    }
}