using System;

namespace _001_Classes
{
    class Man
    {
        public int Age;
        public string FirstName;
        public string SecondName;
    }

    class Program
    {
        private static void Main(string[] args)
        {
            // Создание экземпляра класса Man с именем person.
            var person = new Man();
            person.FirstName = "Ivan";
            person.SecondName = "Ivanov";
            person.Age = 33;
            Console.WriteLine("FirstName - {0} " +
                              "SecondName - {1} " +
                              "Age - {2}",
                person.FirstName, person.SecondName,
                person.Age);
            Console.Read();
        }
    }
}
