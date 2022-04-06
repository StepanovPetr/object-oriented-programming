namespace _011_Virtual
{
    public class DerivedClass : BaseClass
    {
        // Открытое свойство.
        public new string NormalProperty => "Normal Property from derived class";

        // Виртуальное свойство.
        public override string VirtualProperty => "Virtual Property from derived class";
    }
}