using System;
using LibExample;

namespace _012_is
{
    class Program
    {
        // Пример использования оператора is
        static void Main(string[] args)
        {
            DerivedClass derivedClass = new DerivedClass();
            BaseClass baseClass = null;

            if (derivedClass is BaseClass)
            {
                // Приведение типов возможно.
                baseClass = (BaseClass)derivedClass;
            }
            else
            {
                // Приведение типов невозможно.
                baseClass = null;
            }

            baseClass.VirtualMethod();
            Console.ReadLine();
        }
    }
}
