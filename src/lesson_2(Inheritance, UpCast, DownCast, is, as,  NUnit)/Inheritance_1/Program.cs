﻿using System;

namespace Inheritance_1
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass baseClass = new BaseClass();

            Console.WriteLine(baseClass.PublicField);
            //Console.WriteLine(baseClass.);
            baseClass.ShowFields();

            DerivedClass derivedClass = new DerivedClass();
            derivedClass.ShowFields();

            Console.WriteLine($"PublicField {derivedClass.PublicField}");
            //Console.WriteLine(derivedClass.protectedField);
            Console.ReadLine();
        }
    }
}
