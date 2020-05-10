using System;
using LibExample;

namespace _014_As
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass derivedClass = new DerivedClass();
            BaseClass baseClass = null;

            baseClass = derivedClass as BaseClass;
            baseClass.NormalMethod();
            
            Console.ReadLine();
        }
    }
}
