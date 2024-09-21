using System;

namespace Inheritance_1
{
    /// <summary> Класс-наследник. </summary>
    class DerivedClass : BaseClass
    {
        public DerivedClass()
        {
            // Изменяем все доступные поля, унаследованные от базового класса.
            ProtectedField = "New protected  Field";
            PublicField = "New public Field";
        }

        /// <summary> Вывести значение полей на экран (DerivedClass).  </summary>
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