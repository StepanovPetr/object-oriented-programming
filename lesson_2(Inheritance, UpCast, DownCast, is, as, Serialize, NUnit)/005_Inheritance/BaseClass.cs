using System;

namespace _005_Inheritance
{
    sealed class BaseClass
    {
        #region filds
        
        // Закрытое поле.
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
            Console.WriteLine("BaseClass constractor");
            Console.WriteLine(this._privateField);
            Console.WriteLine(this.protectedField);
            Console.WriteLine(this.publicField);
        }
    }
}