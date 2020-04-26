using System;

namespace _007_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Man person = new Man();
            person.FirstName = "dsfsdfsdf";
            Console.WriteLine(person.ManInfo());
            Console.ReadKey();
        }
    }
}
