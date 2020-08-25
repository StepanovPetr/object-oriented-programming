using System;

namespace _003_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass derivedClass = new DerivedClass("New protected Field", "New public Field");
            Console.ReadLine();
        }
    }
}
