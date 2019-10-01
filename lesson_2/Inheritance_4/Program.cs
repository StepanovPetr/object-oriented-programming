using System;
using internal_Library;

namespace Inheritance_4
{
    class Program
    {
        static void Main(string[] args)
        {
            NormalClass normalClass = new NormalClass();
            InternalFild internalFild = new InternalFild();
            //internalFild.intM = 100;
            InternalClassInThisAssebly internalClassInThisAssebly = new InternalClassInThisAssebly();
            internalClassInThisAssebly.intM = 100;
            Console.WriteLine(internalClassInThisAssebly.intM);
            Console.ReadLine();
        }
    }
}
