using System;
using System.Collections.Generic;
using System.Linq;

namespace _021_LINQ
{
    class Program
    {
        //Примеры сортировок по нескольким полям
        static void Main(string[] args)
        {
            List<Man> persons = new List<Man>() { Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan() };
            foreach (var i in persons)
            {
                Console.WriteLine(i.ManInfo());
            }

            // Определите выражение запроса.
            var personQuery = persons.OrderBy(p => p.FirstName).ThenBy(p => p.Age);

                //from person in persons
                //orderby person.FirstName
                //orderby person.Age
                //select person;

            Console.WriteLine("Отсортированная коллекция по возрастанию.");
            foreach (var i in personQuery)
            {
                Console.WriteLine(i.ManInfo());
            }

            // Определите выражение запроса.
            personQuery = persons.OrderByDescending(p => p.FirstName).ThenByDescending(p => p.Age);
            //from person in persons
            //orderby person.FirstName descending
            //orderby person.Age descending
            //select person;

            Console.WriteLine("Отсортированная коллекция по убыванию.");
            foreach (var i in personQuery)
            {
                Console.WriteLine(i.ManInfo());
            }
            Console.ReadLine();
        }
    }
}
