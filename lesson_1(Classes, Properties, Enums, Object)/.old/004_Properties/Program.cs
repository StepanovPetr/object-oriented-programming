using System;

namespace _004_Properties
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var person = new Man();
            Console.WriteLine($"{person.FirstName}, {person.SecondName}, {person.Age}");
            person.FirstName = "Ivan";
            Console.WriteLine($"{person.FirstName}, {person.SecondName}, {person.Age}");
            Console.ReadKey();
        }
    }
}