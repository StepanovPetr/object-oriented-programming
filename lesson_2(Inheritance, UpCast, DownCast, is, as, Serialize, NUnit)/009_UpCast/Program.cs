using System;
using _007_UpCast;

namespace _009_UpCast
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass derivedClass = new DerivedClass();
            MethodExample(derivedClass);  

            Console.ReadLine();
        }

        // Пример неявного Up Cast параметра метода
        static void MethodExample(BaseClass baseClass)
        {
            baseClass.ShowFileds();
        }
    }
}
