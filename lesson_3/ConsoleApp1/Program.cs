using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_3
{
    class Program
    {

        // Абстрактный класс может содержать не абстрактныечлены и методы.
        // Абстрактный класс может иметь конструктор.
        static void Main(string[] args)
        {
            Flat flat = new Flat();
            Console.WriteLine(flat.GetOwner());
            Console.ReadLine();
        }
    }
}
