using System;

namespace _001_Classes
{
    /// <summary> Класс Man (человек). </summary>
    class Man
    {
        /// <summary> Возраст. </summary>
        public int Age;

        /// <summary> Имя. </summary>
        public string FirstName;

        /// <summary> Фамилия. </summary>
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
            Console.WriteLine($"FirstName - {person.FirstName} " +
                              $"SecondName - {person.SecondName} " +
                              $"Age - {person.Age}");
            Console.Read();
        }
    }
}
