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

        public void ShowFilds()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(this._privateField);
            Console.WriteLine(this.protectedField);
            Console.WriteLine(this.publicField);
        }
    }
}