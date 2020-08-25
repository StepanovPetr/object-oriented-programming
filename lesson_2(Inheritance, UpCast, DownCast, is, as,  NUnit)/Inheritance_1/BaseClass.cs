using System;

namespace Inheritance_1
{
    // Базовый класс.
    class BaseClass
    {
        // Закрытое поле.
        private string _privateField = "private Field";
        // Защищенное поле.
        protected string protectedField = "protected Field";
        // Открытое поле.
        public string publicField = "public Field";

        public void ShowFields()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(_privateField);
            Console.WriteLine(protectedField);
            Console.WriteLine(publicField);
        }
    }
}