using System;

namespace _003_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Man person = new Man();
            Man person = new Man("Оби-Ван ", "Кеноби", 57);

            Console.WriteLine(person.ManInfo());
            Console.Read();
        }
    }
}
