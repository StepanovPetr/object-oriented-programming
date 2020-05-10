using System;

namespace _007_UpCast
{
    public class DerivedClass : BaseClass
    {
        // Открытые поля.
        public string PublicField4 = "public Field4";
        public string PublicField5 = "public Field5";

        // Открытый метод.
        public void ShowFileds()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(this.PublicField3);
            Console.WriteLine(this.PublicField4);
            Console.WriteLine(this.PublicField5);
            Console.WriteLine("******************");
        }
    }
}