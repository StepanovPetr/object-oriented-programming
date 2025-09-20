using System;

namespace Inheritance_1
{
    /// <summary> Базовый класс. </summary>
    class BaseClass
    {
        /// <summary> Закрытое поле. </summary>
        private string _privateField = "private Field";

        /// <summary> Защищенное поле. </summary>
        protected string ProtectedField = "protected Field";

        /// <summary> Открытое поле. </summary>
        public string PublicField = "public Field";

        /// <summary> Вывести значение полей на экран (BaseClass).  </summary>
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