using System;

namespace Inheritance_1
{
    class DerivedClass : BaseClass
    {
        public DerivedClass()
        {
            // Изменяем все доступные поля унаследованные от базового класса.
            protectedField = "New protected  Field";
            publicField = "New public Field";

        }

        public void ShowFilds()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(this.publicField);
            //Console.WriteLine(this.privateField);
            Console.WriteLine(this.protectedField);
        }
    }
}
