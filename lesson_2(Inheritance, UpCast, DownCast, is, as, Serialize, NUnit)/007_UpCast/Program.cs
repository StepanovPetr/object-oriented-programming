using System;

namespace _007_UpCast
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass derivedClass = new DerivedClass();
            // Вызов метода ShowFileds() до приведения с базому типу.
            derivedClass.ShowFileds();

            // Пример не явного приведения типа.
            BaseClass baseClass = derivedClass;
            // Вызов метода ShowFileds() после приведения к базовому типу.
            baseClass.ShowFileds();

            Console.WriteLine(derivedClass.GetHashCode());
            Console.WriteLine(baseClass.GetHashCode());
            Console.ReadLine();
        }
    }
}
