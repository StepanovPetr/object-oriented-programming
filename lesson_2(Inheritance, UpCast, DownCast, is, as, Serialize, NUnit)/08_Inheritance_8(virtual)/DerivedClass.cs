using System;

namespace Inheritance_8
{
    class DerivedClass : BaseClass
    {
        // Открытые поле.
        public string publicField4 = "public Field4";
        public string publicField5 = "public Field5";

        //Открытый метод
        public override void ShowFileds()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(this.publicField1);
            Console.WriteLine(this.publicField2);
            Console.WriteLine(this.publicField3);
            Console.WriteLine(this.publicField4);
            Console.WriteLine(this.publicField5);
            Console.WriteLine(this.GetHashCode());
            Console.WriteLine("************************************************************************************************************************");
        }
    }
}
