using System;

namespace _002_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Man person = new Man();
            person.FirstName = "Энакин";
            person.SecondName = "Скайуокер";
            person.Age = 33;
            Console.WriteLine(person.ManInfo());
            Console.Read();
        }
    }
}
