using System;
using LibExample.Abstract;

// Абстрактный класс может содержать не абстрактные члены и методы.
// Абстрактный класс может иметь конструктор.
namespace _002_Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Flat flat = new Flat();
            Console.WriteLine(flat.GetOwner());
            Console.ReadLine();
        }
    }
}
