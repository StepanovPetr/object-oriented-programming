using System;

namespace _005_Inheritance
{
    // Пример наследования от запечатанного класса 
    class DerivedClass : BaseClass
    {
        public DerivedClass()
        { 
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Derived Class constructor with params");
        }
    }
}