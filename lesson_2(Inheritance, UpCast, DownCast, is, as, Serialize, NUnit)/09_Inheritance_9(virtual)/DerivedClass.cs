using System;

namespace Inheritance_9
{
    class DerivedClass : BaseClass
    {
        // Открытые поле.
        public string publicField4 = "public Field4";
        public string publicField5 = "public Field5";

        // Переопределение метода базового класса.
        public override void ShowFileds()
        {
            // вызов ShowFileds() базового метода
            base.ShowFileds();
            //base.base.publicField10;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(this.publicField4);
            Console.WriteLine(this.publicField5);
            Console.WriteLine(this.GetHashCode());
            Console.WriteLine("************************************************************************************************************************");
        }
    }
}
