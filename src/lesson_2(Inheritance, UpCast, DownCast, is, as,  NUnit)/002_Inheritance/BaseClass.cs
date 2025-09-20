using System;

namespace _002_Inheritance
{
    public class BaseClass
    {
        #region fields
        /// <summary> Закрытое поле. </summary>
        private string _privateField = "private Field";

        //  Защищенное поле.
        protected string ProtectedField = "protected Field";
        // Открытое поле.
        public string PublicField = "public Field";
        #endregion

        public BaseClass()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("BaseClass constructor");
            Console.WriteLine(_privateField);
            Console.WriteLine(ProtectedField);
            Console.WriteLine(PublicField);
        }
    }
}