using System;

namespace _003_Inheritance
{
    public class BaseClass
    {
        #region fields
        /// <summary> Закрытое поле. </summary>
        private string _privateField = "private Field";

        // Защищенное поле.
        protected string protectedField = "protected Field";
        // Открытое поле.
        public string publicField = "public Field";
        #endregion

        public BaseClass()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("BaseClass constructor");
            Console.WriteLine(_privateField);
            Console.WriteLine(protectedField);
            Console.WriteLine(publicField);
        }

        public BaseClass(string protectedField, string publicField)
        {
            this.protectedField = protectedField;
            this.publicField = protectedField;
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("BaseClass constructor with params");
            Console.WriteLine(_privateField);
            Console.WriteLine(protectedField);
            Console.WriteLine(publicField);
        }
    }
}