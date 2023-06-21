using System;

namespace Inheritance_1
{
    // Базовый класс.
    class BaseClass
    {
        // Закрытое поле.
        private string _privateField = "private Field";
        // Защищенное поле.
        protected string ProtectedField = "protected Field";
        // Открытое поле.
        public string PublicField = "public Field";

        public void ShowFields()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(_privateField);
            Console.WriteLine(ProtectedField);
            Console.WriteLine(PublicField);
        }
    }
}