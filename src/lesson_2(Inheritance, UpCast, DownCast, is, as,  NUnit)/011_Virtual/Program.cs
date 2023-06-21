using System;

namespace _011_Virtual
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass derivedClass = new DerivedClass();

            Console.WriteLine(derivedClass.NormalProperty);
            Console.WriteLine(derivedClass.VirtualProperty);

            // Up Cast.
            BaseClass baseClass = derivedClass;
            Console.WriteLine(baseClass.NormalProperty);
            Console.WriteLine(baseClass.VirtualProperty);

            Console.ReadLine();
        }
    }
}
