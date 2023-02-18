using System;
using System.Collections.Generic;
using System.Linq;
using LibExample;

namespace _008_LINQ
{
    class Program
    {
        // Пример группировки.
        static void Main(string[] args)
        {
            List<Man> persons = new List<Man>() { Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan() };

            foreach (var person in persons)
            {
                Console.WriteLine(person.ManInfo());
            }

            var queryMenByFirstName =
            from person in persons
            // Группировка по полю FirstName.
            // И вополенение действий с результатом группировки.
            group person by person.FirstName into count
            where count.Count() > 1
            orderby count.Key
            select count;

            // customerGroup is an IGrouping<string, Customer>
            foreach (var manGroup in queryMenByFirstName)
            {
                Console.WriteLine(manGroup.Key);
                foreach (var person in manGroup)
                {
                    Console.WriteLine(person.ManInfo());
                }
            }
            Console.ReadLine();
        }
    }
}
