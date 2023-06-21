using System;

namespace _010_Virtual
{
    public class BaseClass
    {
        #region Поля метода

        private string _privateField1 = "private Field1";
        private string _privateField2 = "private Field2";
        public string PublicField3 = "public Field3";

        #endregion
        // Открытый метод.
        public void NormalMethod()
        {
            Console.WriteLine("Normal method from base class");
        }

        // Виртуальный метод.
        public virtual void VirtualMethod()
        {
            Console.WriteLine("Virtual method from base class");
        }
    }
}