using System;
using LibExample;

#region Links
// https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/abstract
// 1)Нельзя создавать экземпляры абстрактного класса.
// 2)Абстрактный класс может содержать абстрактные методы и свойства.
// 3)Абстрактный класс не может быть декарирован атрибутом sealed или static.
// 4)Неабстрактный класс, производный от абстрактного класса, должен включать фактические реализации всех унаследованных абстрактных методов.
// 5)Абстрактные методы являются вирутуальными (virual) и должны быть переопледелены (override)
// 6 Абстрактный класс может быть декарирован модификаторм доступа.
#endregion

namespace _001_Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Flat flat = new Flat();
            Building building = flat;

            Console.ReadLine();
        }
    }
}