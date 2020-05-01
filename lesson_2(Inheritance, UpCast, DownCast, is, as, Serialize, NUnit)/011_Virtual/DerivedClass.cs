using System;

namespace _011_Virtual
{
    public class DerivedClass : BaseClass
    {
        // Откртое свойтво.
        public new string NormalProperty => "Normal Property from derived class";

        // Виртуальный свойство.
        public override string VirtualProperty => "Virtual Property from derived class";
    }
}