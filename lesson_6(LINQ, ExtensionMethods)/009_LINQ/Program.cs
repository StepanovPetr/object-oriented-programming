using System;
using System.Collections.Generic;
using System.Linq;

// https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/basic-linq-query-operations#selecting-projections
namespace _009_LINQ
{
    class Program
    {
        // Выборка значений.
        static void Main(string[] args)
        {
            List<Man> persons = new List<Man>() { Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan() };

            var queryMenByFirstName =
            from person in persons
            select person.FirstName;

            foreach (var person in queryMenByFirstName)
            {
                Console.WriteLine(person);
            }
            Console.ReadLine();
        }
    }
}
