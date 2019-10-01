using System;

namespace Inheritance_6
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass derivedClass = new DerivedClass();

            Console.WriteLine(derivedClass.publicField1);
            Console.WriteLine(derivedClass.publicField2);
            Console.WriteLine(derivedClass.publicField3);
            Console.WriteLine(derivedClass.publicField4);
            Console.WriteLine(derivedClass.publicField5);
            Console.WriteLine(derivedClass.GetHashCode());
            Console.WriteLine("************************************************************************************************************************");
            
            // UpCast
            BaseClass baseClass = (BaseClass) derivedClass;
            Console.WriteLine(baseClass.publicField1);
            Console.WriteLine(baseClass.publicField2);
            Console.WriteLine(baseClass.publicField3);
            //Console.WriteLine(baseClass.publicField4);
            //Console.WriteLine(baseClass.publicField5);
            Console.WriteLine(derivedClass.GetHashCode());
            Console.ReadLine();
        }
    }
}
