using System;
using LibExample;

// Абстрактный класс может содержать не абстрактныечлены и методы.
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
