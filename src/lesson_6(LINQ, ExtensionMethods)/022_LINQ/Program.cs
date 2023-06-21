using System;
using System.Collections.Generic;
using System.Linq;
using LibExample;

namespace _022_LINQ
{
    class Program
    {
        //Пример группировки
        static void Main(string[] args)
        {
            List<Man> persons = new List<Man>() { Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan() };

            // Группировка по полю FirstName;
            var queryMenByFirstName = persons.GroupBy(p => p.FirstName);
            
            //from person in persons           
            //group person by person.FirstName;

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
