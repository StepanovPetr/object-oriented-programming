using System;

namespace _010_Virtual
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass derivedClass = new DerivedClass();
            derivedClass.NormalMethod();
            derivedClass.VirtualMethod();

            // Up Cast.
            BaseClass baseClass = derivedClass;
            baseClass.NormalMethod();
            baseClass.VirtualMethod();

            Console.ReadLine();
        }
    }
}
