using System;

namespace Inheritance_1
{
    // Класс-наследник.
    class DerivedClass : BaseClass
    {
        public DerivedClass()
        {
            // Изменяем все доступные поля, унаследованные от базового класса.
            protectedField = "New protected  Field";
            publicField = "New public Field";
        }

        public void ShowFields()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(publicField);
            //Console.WriteLine(privateField);
            Console.WriteLine(protectedField);
        }
    }
}