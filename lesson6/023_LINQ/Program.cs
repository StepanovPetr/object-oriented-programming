using System;
using System.Collections.Generic;
using System.Linq;

namespace _023_LINQ
{
    class Program
    {
        //Пример группировки
        static void Main(string[] args)
        {
            List<Man> persons = new List<Man>() { Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan() };
            foreach (var person in persons)
            {
                Console.WriteLine(person.ManInfo());
            }
            // Группировка по полю FirstName.
            // И вополенение действий с результатом группировки
            var queryMenByFirstName = persons.GroupBy(p => p.FirstName).Where(p => p.Count() > 1).OrderBy(p => p.Key);

            //from person in persons
            //group person by person.FirstName into cout
            //where cout.Count() > 1
            //orderby cout.Key
            //select cout;

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
