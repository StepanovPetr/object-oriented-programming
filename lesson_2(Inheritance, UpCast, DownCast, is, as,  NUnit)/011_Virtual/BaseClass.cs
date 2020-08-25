using System;

namespace _011_Virtual
{
    public class BaseClass
    {
        // Открытое свойтво.
        public string NormalProperty => "Normal Property from base class";

        // Виртуальное свойство.
        public virtual string VirtualProperty => "Virtual Property from base class";
    }
}