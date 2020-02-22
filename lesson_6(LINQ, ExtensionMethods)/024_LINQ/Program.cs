using System;
using System.Collections.Generic;
using System.Linq;

namespace _024_LINQ
{
    // Выборка значений.
    class Program
    {
        static void Main(string[] args)
        {
            List<Man> persons = new List<Man>() { Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan() };

            var queryMenByFirstName = persons.Select(p => p.FirstName);
            //from person in persons
            //select person.FirstName;

            foreach (var person in queryMenByFirstName)
            {
                Console.WriteLine(person);
            }
            Console.ReadLine();
        }
    }
}
