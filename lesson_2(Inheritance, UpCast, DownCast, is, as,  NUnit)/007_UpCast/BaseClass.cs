using System;

namespace _007_UpCast
{
    public class BaseClass
    {
        // Открытые поля.
        private string _privateField1 = "private Field1";
        private string _privateField2 = "private Field2";
        public string PublicField3 = "public Field3";

        // Открытый метод.
        public void ShowFileds()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(this._privateField1);
            Console.WriteLine(this._privateField2);
            Console.WriteLine(this.PublicField3);
            Console.WriteLine("*************************");
        }
    }
}