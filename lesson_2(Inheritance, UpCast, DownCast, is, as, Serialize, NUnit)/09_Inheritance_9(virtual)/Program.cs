using System;

namespace Inheritance_9
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass derivedClass = new DerivedClass();
            derivedClass.ShowFileds();

            // UpCast
            BaseClass baseClass = (BaseClass)derivedClass;
            baseClass.ShowFileds();

            Console.ReadLine();
        }
    }
}
