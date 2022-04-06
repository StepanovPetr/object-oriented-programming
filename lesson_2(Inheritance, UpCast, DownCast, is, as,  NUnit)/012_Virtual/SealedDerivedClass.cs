using System;

namespace _010_Virtual
{
    public class SealedDerivedClass : BaseClass
    {
        // Пример замещения метода в дочернем классе.
        public new void NormalMethod()
        {
            Console.WriteLine("Normal method from derived class");
        }

        // Пример переопределения виртуального метода в дочернем классе.
        public sealed override void VirtualMethod()
        {
            Console.WriteLine("Virtual method from derived class");
        }
    }
}