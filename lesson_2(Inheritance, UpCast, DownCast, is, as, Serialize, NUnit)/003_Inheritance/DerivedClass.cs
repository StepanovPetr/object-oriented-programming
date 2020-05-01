using System;

namespace _003_Inheritance
{
    // Класс наследник.
    class DerivedClass : BaseClass
    {   
        // Вызов нужного конструктора базового класса 
        public DerivedClass(string publicField, string publicFild)
            : base(publicField, publicFild)
        {
            //publicField = "New public Field";
            //protectedField = "New protected  Field";           
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Derived Class constractor with params");
            Console.WriteLine(this.publicField);
            //Console.WriteLine(this.privateField);
            Console.WriteLine(this.protectedField);
        }
    }
}