using System;

namespace _011_Virtual
{
    public class BaseClass
    {
        // Откртое свойтво.
        public string NormalProperty => "Normal Property from base class";

        // Виртуальный свойство.
        public virtual string VirtualProperty => "Virtual Property from base class";
    }
}