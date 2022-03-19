using System;

namespace _007_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Man person = new Man();
            person.FirstName = "Vasy";
            person.SecondName = "Pupkin";
            Console.WriteLine(person.ManInfo());
            Console.WriteLine(person.Fio);
            Console.ReadKey();
        }
    }
}
