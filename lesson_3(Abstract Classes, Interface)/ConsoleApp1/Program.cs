using System;

// Абстрактный класс может содержать не абстрактныечлены и методы.
// Абстрактный класс может иметь конструктор.
namespace lesson_3
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
