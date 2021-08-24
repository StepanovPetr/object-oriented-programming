using System;

namespace _003_Inheritance
{
    // Класс-наследник.
    class DerivedClass : BaseClass
    {   
        // Вызов нужного конструктора базового класса 
        public DerivedClass(string protectedField, string publicField)
            : base(protectedField, publicField)
        {
            //publicField = "New public Field";
            //protectedField = "New protected  Field";           
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Derived Class constructor with params");
            Console.WriteLine(publicField);
            //Console.WriteLine(_privateField);
            Console.WriteLine(protectedField);
        }
    }
}