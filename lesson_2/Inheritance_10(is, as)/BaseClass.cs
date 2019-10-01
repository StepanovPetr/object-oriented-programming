using System;

namespace Inheritance_10
{
    public class BaseClass
    {
        // Открытые поле.
        public string publicField1 = "public Field1";
        public string publicField2 = "public Field2";
        public string publicField3 = "public Field3";

        //Открытый виртуальный метод
        public virtual void ShowFileds()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;        
            Console.WriteLine(this.publicField1);
            Console.WriteLine(this.publicField2);
            Console.WriteLine(this.publicField3);
            Console.WriteLine(this.GetHashCode());
            Console.WriteLine("************************************************************************************************************************");
        }
    }
}
