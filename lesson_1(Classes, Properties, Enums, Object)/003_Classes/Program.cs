using System;

namespace _003_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Пример создания класса, используя конструктор без параметров.
            Man person = new Man();

            // Пример создания класса, используя конструктор с параметрами.
            Man person2 = new Man("Оби-Ван ", "Кеноби", 57);

            Console.WriteLine(person.ManInfo());
            Console.WriteLine(person2.ManInfo());
            Console.Read();
        }
    }
}
