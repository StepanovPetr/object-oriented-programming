using System;
using System.Collections.Generic;
using System.Linq;
using LibExample;

namespace _006_LINQ
{
    class Program
    {
        //Примеры сортировок по нескольким полям.
        static void Main(string[] args)
        {
            List<Man> persons = new List<Man>() { Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan() };
            foreach (var i in persons)
            {
                Console.WriteLine(i.ManInfo());
            }

            // Определите выражение запроса.
            var personQuery =
                from person in persons
                    //where (person.FirstName != "Петр" && person.Age <= 40)
                orderby person.FirstName, person.Age
                select person;

            Console.WriteLine("Отсортированная коллекция по возрастанию.");
            foreach (var i in personQuery)
            {
                Console.WriteLine(i.ManInfo());
            }

            // Определите выражение запроса.
            personQuery =
                from person in persons
                    //where (person.FirstName != "Петр" && person.Age <= 40)
                orderby person.FirstName descending, person.Age descending
                select person;

            Console.WriteLine("Отсортированная коллекция по убыванию.");
            foreach (var i in personQuery)
            {
                Console.WriteLine(i.ManInfo());
            }

            Console.ReadLine();
        }
    }
}
