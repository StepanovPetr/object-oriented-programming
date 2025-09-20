using System;

namespace _006_UpCast
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass derivedClass = new DerivedClass();

            // Пример явного приведения типа.
            BaseClass baseClass = (BaseClass) derivedClass;
            //Console.WriteLine(baseClass.PublicField4);

            // Пример неявного приведения типа.
            BaseClass baseClass2 = derivedClass;

            Console.WriteLine(derivedClass.GetHashCode());
            Console.WriteLine(baseClass.GetHashCode());
            Console.WriteLine(baseClass2.GetHashCode());
            Console.ReadLine();
        }
    }
}
