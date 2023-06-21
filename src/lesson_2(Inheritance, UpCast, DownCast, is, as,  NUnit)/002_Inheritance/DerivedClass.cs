using System;

namespace _002_Inheritance
{
    // Класс-наследник.
    class DerivedClass : BaseClass
    {
        public DerivedClass()
        {
            // Изменяем все доступные поля, унаследованные от базового класса.
            PublicField = "New public Field";
            ProtectedField = "New protected  Field";
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Derived Class constructor");
            Console.WriteLine(PublicField);
            Console.WriteLine(ProtectedField);
        }
    }
}