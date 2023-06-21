using System;

namespace Inheritance_2
{
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
