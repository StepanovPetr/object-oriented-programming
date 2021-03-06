﻿using System;

namespace Inheritance_7
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass derivedClass = new DerivedClass();
            derivedClass.ShowFileds();

            // UpCast
            BaseClass baseClass = (BaseClass) derivedClass;
            baseClass.ShowFileds();

            BaseClass baseClassForDownCast = new BaseClass();
           //baseClass.ShowFileds();

            // DownCast возможен только после после UpCast
            DerivedClass derivedClasForDownCast = (DerivedClass)baseClass; //baseClassForDownCast
            derivedClasForDownCast.ShowFileds();

            Console.ReadLine();
        }
    }
}
