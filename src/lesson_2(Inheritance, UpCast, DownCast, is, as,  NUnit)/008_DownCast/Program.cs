using System;
using _007_UpCast;

namespace _008_DownCast
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass derivedClass = new DerivedClass();
            // Вызов метода ShowFileds() до приведения к базовому типу.
            derivedClass.ShowFileds();

            // Пример неявного приведения типа.
            BaseClass baseClass = derivedClass;
            //BaseClass baseClass = new BaseClass();
            // Вызов метода ShowFileds() после приведения к базовому типу.
            baseClass.ShowFileds();

            // Пример Down Cast (Приведение базового класса к классу-потомку).
            // Доступен только после выполнить Up Cast
            var downCast = (DerivedClass)baseClass;
            downCast.ShowFileds();

            Console.WriteLine(derivedClass.GetHashCode());
            Console.WriteLine(baseClass.GetHashCode());
            Console.ReadLine();
        }
    }
}
