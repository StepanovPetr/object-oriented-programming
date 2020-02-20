using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_LINQ
{
    class Program
    {
        //Пример группировки
        static void Main(string[] args)
        {
            List<Man> persons = new List<Man>() { Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan() };

            var queryMenByFirstName =
            from person in persons
            // Группировка по полю FirstName.
            // И вополенение действий с результатом группировки.
            group person by person.FirstName into cout
            where cout.Count() > 1
            orderby cout.Key
            select cout;

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
