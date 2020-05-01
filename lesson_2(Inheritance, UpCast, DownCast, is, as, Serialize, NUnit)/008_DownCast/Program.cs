using System;
using _007_UpCast;

namespace _008_DownCast
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass derivedClass = new DerivedClass();
            // Вызов метода ShowFileds() до приведения с базому типу.
            derivedClass.ShowFileds();

            // Пример не явного приведения типа.
            BaseClass baseClass = derivedClass;
            // Вызов метода ShowFileds() после приведения к базовому типу.
            baseClass.ShowFileds();

            // Пример Down Cast (Привдение базового класса к классу потомка).
            // Доступен только после выполнить Up Cast
            var downCast = (DerivedClass)baseClass;
            downCast.ShowFileds();

            Console.WriteLine(derivedClass.GetHashCode());
            Console.WriteLine(baseClass.GetHashCode());
            Console.ReadLine();
        }
    }
}
