using System;

namespace Inheritance_1
{
    // Класс-наследник.
    class DerivedClass : BaseClass
    {
        public DerivedClass()
        {
            // Изменяем все доступные поля, унаследованные от базового класса.
            ProtectedField = "New protected  Field";
            PublicField = "New public Field";
        }

        public void ShowFields()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(PublicField);
            //Console.WriteLine(privateField);
            Console.WriteLine(ProtectedField);
        }
    }
}