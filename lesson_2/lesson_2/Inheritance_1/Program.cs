﻿using System;

namespace Inheritance_1
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass baseClass = new BaseClass();
            
            Console.WriteLine(baseClass.publicField);
            //Console.WriteLine(baseClass.);
            baseClass.ShowFilds();

            DerivedClass derivedClass = new DerivedClass();
            derivedClass.ShowFilds();
            Console.ReadLine();
        }
    }
}
