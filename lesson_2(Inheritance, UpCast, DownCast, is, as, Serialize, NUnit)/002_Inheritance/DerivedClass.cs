using System;

namespace _002_Inheritance
{
    // Класс наследник.
    class DerivedClass : BaseClass
    {
        public DerivedClass()
        {
            // Изменяем все доступные поля унаследованные от базового класса.
            publicField = "New public Field";
            protectedField = "New protected  Field";
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Derived Class constractor");
            Console.WriteLine(this.publicField);
            Console.WriteLine(this.protectedField);
        }
    }
}